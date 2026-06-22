#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnalyticsDimensionSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.AnalyticsDimensionSource>
    {
        /// <inheritdoc />
        public override global::Speechify.AnalyticsDimensionSource Read(
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
                        return global::Speechify.AnalyticsDimensionSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.AnalyticsDimensionSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.AnalyticsDimensionSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.AnalyticsDimensionSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Speechify.AnalyticsDimensionSourceExtensions.ToValueString(value));
        }
    }
}
