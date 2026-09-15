#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class ProjectRunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.ProjectRunStreamEvent>
    {
        /// <inheritdoc />
        public override global::Speechify.ProjectRunStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.ProjectRunStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Speechify.ProjectRunStreamEventVariant1? runUpdated = default;
            if (discriminator?.Type == global::Speechify.ProjectRunStreamEventDiscriminatorType.RunUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.ProjectRunStreamEventVariant1)}");
                runUpdated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.ProjectRunStreamEventVariant2? runEnded = default;
            if (discriminator?.Type == global::Speechify.ProjectRunStreamEventDiscriminatorType.RunEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.ProjectRunStreamEventVariant2)}");
                runEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.ProjectRunStreamEventVariant3? runsSynced = default;
            if (discriminator?.Type == global::Speechify.ProjectRunStreamEventDiscriminatorType.RunsSynced)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.ProjectRunStreamEventVariant3)}");
                runsSynced = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Speechify.ProjectRunStreamEvent(
                discriminator?.Type,
                runUpdated,

                runEnded,

                runsSynced
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.ProjectRunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunUpdated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ProjectRunStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunUpdated!, typeInfo);
            }
            else if (value.IsRunEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ProjectRunStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunEnded!, typeInfo);
            }
            else if (value.IsRunsSynced)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.ProjectRunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.ProjectRunStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.ProjectRunStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunsSynced!, typeInfo);
            }
        }
    }
}