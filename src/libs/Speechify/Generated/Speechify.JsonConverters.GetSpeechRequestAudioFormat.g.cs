#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetSpeechRequestAudioFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.GetSpeechRequestAudioFormat>
    {
        /// <inheritdoc />
        public override global::Speechify.GetSpeechRequestAudioFormat Read(
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
                        return global::Speechify.GetSpeechRequestAudioFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.GetSpeechRequestAudioFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.GetSpeechRequestAudioFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.GetSpeechRequestAudioFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Speechify.GetSpeechRequestAudioFormatExtensions.ToValueString(value));
        }
    }
}
