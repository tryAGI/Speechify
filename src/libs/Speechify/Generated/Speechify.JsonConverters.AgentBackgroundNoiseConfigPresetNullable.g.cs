#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentBackgroundNoiseConfigPresetNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.AgentBackgroundNoiseConfigPreset?>
    {
        /// <inheritdoc />
        public override global::Speechify.AgentBackgroundNoiseConfigPreset? Read(
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
                        return global::Speechify.AgentBackgroundNoiseConfigPresetExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.AgentBackgroundNoiseConfigPreset)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.AgentBackgroundNoiseConfigPreset?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.AgentBackgroundNoiseConfigPreset? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Speechify.AgentBackgroundNoiseConfigPresetExtensions.ToValueString(value.Value));
            }
        }
    }
}
