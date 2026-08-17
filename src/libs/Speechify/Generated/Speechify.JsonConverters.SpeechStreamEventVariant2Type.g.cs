#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpeechStreamEventVariant2TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.SpeechStreamEventVariant2Type>
    {
        /// <inheritdoc />
        public override global::Speechify.SpeechStreamEventVariant2Type Read(
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
                        return global::Speechify.SpeechStreamEventVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.SpeechStreamEventVariant2Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.SpeechStreamEventVariant2Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.SpeechStreamEventVariant2Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Speechify.SpeechStreamEventVariant2TypeExtensions.ToValueString(value));
        }
    }
}
