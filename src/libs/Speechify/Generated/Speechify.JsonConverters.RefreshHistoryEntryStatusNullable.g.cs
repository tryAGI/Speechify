#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class RefreshHistoryEntryStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.RefreshHistoryEntryStatus?>
    {
        /// <inheritdoc />
        public override global::Speechify.RefreshHistoryEntryStatus? Read(
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
                        return global::Speechify.RefreshHistoryEntryStatusExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.RefreshHistoryEntryStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.RefreshHistoryEntryStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.RefreshHistoryEntryStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Speechify.RefreshHistoryEntryStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
