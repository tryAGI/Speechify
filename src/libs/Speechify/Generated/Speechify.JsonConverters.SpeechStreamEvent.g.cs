#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class SpeechStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.SpeechStreamEvent>
    {
        /// <inheritdoc />
        public override global::Speechify.SpeechStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.SpeechStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Speechify.SpeechStreamEventVariant1? speechChunk = default;
            if (discriminator?.Type == global::Speechify.SpeechStreamEventDiscriminatorType.SpeechChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.SpeechStreamEventVariant1)}");
                speechChunk = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.SpeechStreamEventVariant2? speechDone = default;
            if (discriminator?.Type == global::Speechify.SpeechStreamEventDiscriminatorType.SpeechDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.SpeechStreamEventVariant2)}");
                speechDone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.SpeechStreamEventVariant3? speechError = default;
            if (discriminator?.Type == global::Speechify.SpeechStreamEventDiscriminatorType.SpeechError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.SpeechStreamEventVariant3)}");
                speechError = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Speechify.SpeechStreamEvent(
                discriminator?.Type,
                speechChunk,

                speechDone,

                speechError
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.SpeechStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSpeechChunk)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.SpeechStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechChunk!, typeInfo);
            }
            else if (value.IsSpeechDone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.SpeechStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechDone!, typeInfo);
            }
            else if (value.IsSpeechError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.SpeechStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.SpeechStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.SpeechStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechError!, typeInfo);
            }
        }
    }
}