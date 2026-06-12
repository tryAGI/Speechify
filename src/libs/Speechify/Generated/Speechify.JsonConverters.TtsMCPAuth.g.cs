#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Speechify.JsonConverters
{
    /// <inheritdoc />
    public class TtsMCPAuthJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Speechify.TtsMCPAuth>
    {
        /// <inheritdoc />
        public override global::Speechify.TtsMCPAuth Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.TtsMCPAuthDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Speechify.TtsMCPAuthVariant1? none = default;
            if (discriminator?.Type == global::Speechify.TtsMCPAuthDiscriminatorType.None)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.TtsMCPAuthVariant1)}");
                none = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.TtsMCPAuthVariant2? bearer = default;
            if (discriminator?.Type == global::Speechify.TtsMCPAuthDiscriminatorType.Bearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.TtsMCPAuthVariant2)}");
                bearer = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Speechify.TtsMCPAuthVariant3? oauth2ClientCredentials = default;
            if (discriminator?.Type == global::Speechify.TtsMCPAuthDiscriminatorType.Oauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Speechify.TtsMCPAuthVariant3)}");
                oauth2ClientCredentials = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Speechify.TtsMCPAuth(
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
            global::Speechify.TtsMCPAuth value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsMCPAuthVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.None!, typeInfo);
            }
            else if (value.IsBearer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsMCPAuthVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Bearer!, typeInfo);
            }
            else if (value.IsOauth2ClientCredentials)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Speechify.TtsMCPAuthVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Speechify.TtsMCPAuthVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Speechify.TtsMCPAuthVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2ClientCredentials!, typeInfo);
            }
        }
    }
}