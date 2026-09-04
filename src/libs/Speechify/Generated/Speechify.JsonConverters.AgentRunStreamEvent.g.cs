#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class AgentRunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.AgentRunStreamEvent>
    {
        /// <inheritdoc />
        public override global::Speechify.AgentRunStreamEvent Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.AgentRunStreamEventDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Speechify.AgentRunStreamEventVariant1? runStepAdded = default;
            if (discriminator?.Type == global::Speechify.AgentRunStreamEventDiscriminatorType.RunStepAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.AgentRunStreamEventVariant1)}");
                runStepAdded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.AgentRunStreamEventVariant2? runStatusChanged = default;
            if (discriminator?.Type == global::Speechify.AgentRunStreamEventDiscriminatorType.RunStatusChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.AgentRunStreamEventVariant2)}");
                runStatusChanged = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.AgentRunStreamEventVariant3? runEnded = default;
            if (discriminator?.Type == global::Speechify.AgentRunStreamEventDiscriminatorType.RunEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.AgentRunStreamEventVariant3)}");
                runEnded = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Speechify.AgentRunStreamEvent(
                discriminator?.Type,
                runStepAdded,

                runStatusChanged,

                runEnded
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.AgentRunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStepAdded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.AgentRunStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepAdded!, typeInfo);
            }
            else if (value.IsRunStatusChanged)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.AgentRunStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStatusChanged!, typeInfo);
            }
            else if (value.IsRunEnded)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.AgentRunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.AgentRunStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.AgentRunStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunEnded!, typeInfo);
            }
        }
    }
}