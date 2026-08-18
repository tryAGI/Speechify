#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentSnapshotInterruptionSensitivityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.AgentSnapshotInterruptionSensitivity?>
    {
        /// <inheritdoc />
        public override global::Speechify.AgentSnapshotInterruptionSensitivity? Read(
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
                        return global::Speechify.AgentSnapshotInterruptionSensitivityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.AgentSnapshotInterruptionSensitivity)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.AgentSnapshotInterruptionSensitivity?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.AgentSnapshotInterruptionSensitivity? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Speechify.AgentSnapshotInterruptionSensitivityExtensions.ToValueString(value.Value));
            }
        }
    }
}
