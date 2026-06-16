#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class MCPAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.MCPAuth>
    {
        /// <inheritdoc />
        public override global::Speechify.MCPAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.MCPAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Speechify.MCPAuthVariant1? none = default;
            if (discriminator?.Type == global::Speechify.MCPAuthDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.MCPAuthVariant1)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.MCPAuthVariant2? bearer = default;
            if (discriminator?.Type == global::Speechify.MCPAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.MCPAuthVariant2)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.MCPAuthVariant3? oauth2ClientCredentials = default;
            if (discriminator?.Type == global::Speechify.MCPAuthDiscriminatorType.Oauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.MCPAuthVariant3)}");
                oauth2ClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Speechify.MCPAuth(
                discriminator?.Type,
                none,

                bearer,

                oauth2ClientCredentials
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Speechify.MCPAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPAuthVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPAuthVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
            else if (value.IsOauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.MCPAuthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.MCPAuthVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.MCPAuthVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2ClientCredentials!, typeInfo);
            }
        }
    }
}