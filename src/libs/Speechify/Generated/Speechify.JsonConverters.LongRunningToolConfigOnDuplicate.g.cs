#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class LongRunningToolConfigOnDuplicateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.LongRunningToolConfigOnDuplicate>
    {
        /// <inheritdoc />
        public override global::Speechify.LongRunningToolConfigOnDuplicate Read(
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
                        return global::Speechify.LongRunningToolConfigOnDuplicateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.LongRunningToolConfigOnDuplicate)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.LongRunningToolConfigOnDuplicate);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.LongRunningToolConfigOnDuplicate value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Speechify.LongRunningToolConfigOnDuplicateExtensions.ToValueString(value));
        }
    }
}
