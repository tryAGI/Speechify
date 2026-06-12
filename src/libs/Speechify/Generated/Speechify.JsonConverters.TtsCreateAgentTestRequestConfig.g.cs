#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class TtsCreateAgentTestRequestConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.TtsCreateAgentTestRequestConfig>
    {
        /// <inheritdoc />
        public override global::Speechify.TtsCreateAgentTestRequestConfig Read(
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
            if (__jsonProps.Contains("context")) __score0++;
            if (__jsonProps.Contains("failure_examples")) __score0++;
            if (__jsonProps.Contains("first_message_override")) __score0++;
            if (__jsonProps.Contains("initial_chat_history")) __score0++;
            if (__jsonProps.Contains("model_override")) __score0++;
            if (__jsonProps.Contains("success_criteria")) __score0++;
            if (__jsonProps.Contains("success_examples")) __score0++;
            if (__jsonProps.Contains("system_prompt_override")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("context")) __score1++;
            if (__jsonProps.Contains("expected_tool")) __score1++;
            if (__jsonProps.Contains("initial_chat_history")) __score1++;
            if (__jsonProps.Contains("model_override")) __score1++;
            if (__jsonProps.Contains("parameter_checks")) __score1++;
            if (__jsonProps.Contains("system_prompt_override")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data_assertions")) __score2++;
            if (__jsonProps.Contains("initial_chat_history")) __score2++;
            if (__jsonProps.Contains("max_turns")) __score2++;
            if (__jsonProps.Contains("model_override")) __score2++;
            if (__jsonProps.Contains("scenario")) __score2++;
            if (__jsonProps.Contains("system_prompt_override")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::Speechify.TtsReplyConfig? replyConfig = default;
            global::Speechify.TtsToolCallConfig? toolCallConfig = default;
            global::Speechify.TtsSimulationConfig? simulationConfig = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsReplyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsReplyConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsReplyConfig).Name}");
                        replyConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsToolCallConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsToolCallConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsToolCallConfig).Name}");
                        toolCallConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSimulationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSimulationConfig> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSimulationConfig).Name}");
                        simulationConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (replyConfig == null && toolCallConfig == null && simulationConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsReplyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsReplyConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsReplyConfig).Name}");
                    replyConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (replyConfig == null && toolCallConfig == null && simulationConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsToolCallConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsToolCallConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsToolCallConfig).Name}");
                    toolCallConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (replyConfig == null && toolCallConfig == null && simulationConfig == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSimulationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSimulationConfig> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSimulationConfig).Name}");
                    simulationConfig = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Speechify.TtsCreateAgentTestRequestConfig(
                replyConfig,

                toolCallConfig,

                simulationConfig
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.TtsCreateAgentTestRequestConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReplyConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsReplyConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsReplyConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsReplyConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReplyConfig!, typeInfo);
            }
            else if (value.IsToolCallConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsToolCallConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsToolCallConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsToolCallConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCallConfig!, typeInfo);
            }
            else if (value.IsSimulationConfig)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsSimulationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsSimulationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsSimulationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SimulationConfig!, typeInfo);
            }
        }
    }
}