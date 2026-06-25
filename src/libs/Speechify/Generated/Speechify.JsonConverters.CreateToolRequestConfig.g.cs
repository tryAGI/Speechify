#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class CreateToolRequestConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.CreateToolRequestConfig>
    {
        /// <inheritdoc />
        public override global::Speechify.CreateToolRequestConfig Read(
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
            if (__jsonProps.Contains("fire_and_forget")) __score0++;
            if (__jsonProps.Contains("headers")) __score0++;
            if (__jsonProps.Contains("method")) __score0++;
            if (__jsonProps.Contains("params")) __score0++;
            if (__jsonProps.Contains("timeout_ms")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("params")) __score1++;
            if (__jsonProps.Contains("timeout_ms")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("auth")) __score2++;
            if (__jsonProps.Contains("endpoint")) __score2++;
            if (__jsonProps.Contains("transport")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Speechify.WebhookToolConfig? webhookToolConfig = default;
            global::Speechify.ClientToolConfig? clientToolConfig = default;
            global::Speechify.MCPToolConfig? mCPToolConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.WebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.WebhookToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.WebhookToolConfig).Name}");
                        webhookToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ClientToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ClientToolConfig).Name}");
                        clientToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPToolConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPToolConfig).Name}");
                        mCPToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (webhookToolConfig == null && clientToolConfig == null && mCPToolConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.WebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.WebhookToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.WebhookToolConfig).Name}");
                    webhookToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (webhookToolConfig == null && clientToolConfig == null && mCPToolConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ClientToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ClientToolConfig).Name}");
                    clientToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (webhookToolConfig == null && clientToolConfig == null && mCPToolConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPToolConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPToolConfig).Name}");
                    mCPToolConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Speechify.CreateToolRequestConfig(
                webhookToolConfig,

                clientToolConfig,

                mCPToolConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.CreateToolRequestConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhookToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.WebhookToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.WebhookToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.WebhookToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookToolConfig!, typeInfo);
            }
            else if (value.IsClientToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ClientToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ClientToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ClientToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClientToolConfig!, typeInfo);
            }
            else if (value.IsMCPToolConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPToolConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPToolConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPToolConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MCPToolConfig!, typeInfo);
            }
        }
    }
}