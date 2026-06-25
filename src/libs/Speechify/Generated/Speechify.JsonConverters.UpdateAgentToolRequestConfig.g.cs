#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class UpdateAgentToolRequestConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.UpdateAgentToolRequestConfig>
    {
        /// <inheritdoc />
        public override global::Speechify.UpdateAgentToolRequestConfig Read(
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
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::Speechify.BuiltinToolConfig? builtinToolConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.BuiltinToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.BuiltinToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.BuiltinToolConfig).Name}");
                        builtinToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (builtinToolConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.BuiltinToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.BuiltinToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.BuiltinToolConfig).Name}");
                    builtinToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Speechify.UpdateAgentToolRequestConfig(
                builtinToolConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.UpdateAgentToolRequestConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBuiltinToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.BuiltinToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.BuiltinToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.BuiltinToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BuiltinToolConfig!, typeInfo);
            }
        }
    }
}