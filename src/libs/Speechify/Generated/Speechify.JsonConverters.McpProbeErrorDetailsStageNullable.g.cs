#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class McpProbeErrorDetailsStageNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.McpProbeErrorDetailsStage?>
    {
        /// <inheritdoc />
        public override global::Speechify.McpProbeErrorDetailsStage? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Speechify.McpProbeErrorDetailsStageExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.McpProbeErrorDetailsStage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.McpProbeErrorDetailsStage?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.McpProbeErrorDetailsStage? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Speechify.McpProbeErrorDetailsStageExtensions.ToValueString(value.Value));
            }
        }
    }
}
