#!/usr/bin/env bash
set -euo pipefail
install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli

tmp_dir="$(mktemp -d)"
trap 'rm -rf "$tmp_dir"' EXIT

fetch_spec -fsSL -o "$tmp_dir/api-reference.json" https://docs.speechify.ai/openapi/api-reference.json
fetch_spec -fsSL -o "$tmp_dir/api-reference-2.json" https://docs.speechify.ai/openapi/api-reference-2.json

python3 - "$tmp_dir/api-reference.json" "$tmp_dir/api-reference-2.json" openapi.yaml <<'PY'
import json
import sys

left_path, right_path, output_path = sys.argv[1:]
with open(left_path, encoding="utf-8") as file:
    left = json.load(file)
with open(right_path, encoding="utf-8") as file:
    right = json.load(file)

merged = left
for path, value in right.get("paths", {}).items():
    if path in merged.get("paths", {}) and merged["paths"][path] != value:
        raise SystemExit(f"Conflicting path in Speechify specs: {path}")
    merged.setdefault("paths", {})[path] = value

for component_name, components in right.get("components", {}).items():
    target = merged.setdefault("components", {}).setdefault(component_name, {})
    for key, value in components.items():
        if key in target and target[key] != value:
            raise SystemExit(f"Conflicting component in Speechify specs: {component_name}.{key}")
        target[key] = value

with open(output_path, "w", encoding="utf-8") as file:
    json.dump(merged, file, separators=(",", ":"))
    file.write("\n")
PY

rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Speechify \
  --clientClassName SpeechifyClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
