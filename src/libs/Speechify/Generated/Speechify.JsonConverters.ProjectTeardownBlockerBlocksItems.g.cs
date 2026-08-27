#nullable enable

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectTeardownBlockerBlocksItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.ProjectTeardownBlockerBlocksItems>
    {
        /// <inheritdoc />
        public override global::Speechify.ProjectTeardownBlockerBlocksItems Read(
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
                        return global::Speechify.ProjectTeardownBlockerBlocksItemsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Speechify.ProjectTeardownBlockerBlocksItems)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Speechify.ProjectTeardownBlockerBlocksItems);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.ProjectTeardownBlockerBlocksItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Speechify.ProjectTeardownBlockerBlocksItemsExtensions.ToValueString(value));
        }
    }
}
