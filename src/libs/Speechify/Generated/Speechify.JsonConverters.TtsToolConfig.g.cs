#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class TtsToolConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.TtsToolConfig>
    {
        /// <inheritdoc />
        public override global::Speechify.TtsToolConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("builtin")) __score0++;
            if (__jsonProps.Contains("builtin_config")) __score0++;
            if (__jsonProps.Contains("params")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("headers")) __score1++;
            if (__jsonProps.Contains("method")) __score1++;
            if (__jsonProps.Contains("params")) __score1++;
            if (__jsonProps.Contains("timeout_ms")) __score1++;
            if (__jsonProps.Contains("url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("params")) __score2++;
            if (__jsonProps.Contains("timeout_ms")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Speechify.TtsSystemToolConfig? systemToolConfig = default;
            global::Speechify.TtsWebhookToolConfig? webhookToolConfig = default;
            global::Speechify.TtsClientToolConfig? clientToolConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSystemToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSystemToolConfig).Name}");
                        systemToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsWebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsWebhookToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsWebhookToolConfig).Name}");
                        webhookToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsClientToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsClientToolConfig).Name}");
                        clientToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (systemToolConfig == null && webhookToolConfig == null && clientToolConfig == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSystemToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSystemToolConfig).Name}");
                    systemToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsWebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsWebhookToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsWebhookToolConfig).Name}");
                    webhookToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsClientToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsClientToolConfig).Name}");
                    clientToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Speechify.TtsToolConfig(
                systemToolConfig,

                webhookToolConfig,

                clientToolConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.TtsToolConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSystemToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSystemToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSystemToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSystemToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SystemToolConfig!, typeInfo);
            }
            else if (value.IsWebhookToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsWebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsWebhookToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsWebhookToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookToolConfig!, typeInfo);
            }
            else if (value.IsClientToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsClientToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsClientToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientToolConfig!, typeInfo);
            }
        }
    }
}