
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolKind), TypeInfoPropertyName = "ToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolParamType), TypeInfoPropertyName = "ToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookToolConfigMethod), TypeInfoPropertyName = "WebhookToolConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset), TypeInfoPropertyName = "LongRunningToolConfigWaitAudioPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfigWaitAudio))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfigOnDuplicate), TypeInfoPropertyName = "LongRunningToolConfigOnDuplicate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ClientToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPTransport), TypeInfoPropertyName = "MCPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuth), TypeInfoPropertyName = "MCPAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant1Type), TypeInfoPropertyName = "MCPAuthVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant2Type), TypeInfoPropertyName = "MCPAuthVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant3Type), TypeInfoPropertyName = "MCPAuthVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthDiscriminatorType), TypeInfoPropertyName = "MCPAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolActionClass), TypeInfoPropertyName = "ToolActionClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolResponseMapping))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Speechify.ToolActionClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Speechify.ToolResponseMapping>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiOperationMethod), TypeInfoPropertyName = "OpenApiOperationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiParamIn), TypeInfoPropertyName = "OpenApiParamIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenAPIParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiBodyContentType), TypeInfoPropertyName = "OpenApiBodyContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenAPIBody))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenAPIOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.OpenAPIParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenAPIToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.OpenAPIOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolApprovalClass), TypeInfoPropertyName = "ToolApprovalClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolReach), TypeInfoPropertyName = "ToolReach2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolReach>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolderKind), TypeInfoPropertyName = "ToolNameHolderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenErrorDetailDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolConfig), TypeInfoPropertyName = "ToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateToolRequestConfig), TypeInfoPropertyName = "CreateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateToolRequestConfig), TypeInfoPropertyName = "UpdateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolAttachedAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListToolAttachedAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestMCPConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPProbeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.McpProbeErrorDetailsStage), TypeInfoPropertyName = "McpProbeErrorDetailsStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPProbeErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPProbeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.MCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestWebhookConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookProbeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportOpenApiRequestSpec), TypeInfoPropertyName = "ImportOpenApiRequestSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportOpenAPIRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportedOpenAPIDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SkippedOpenAPIOperation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportOpenAPIResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SkippedOpenAPIOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestOpenAPICallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestOpenApiCallResultOutcome), TypeInfoPropertyName = "TestOpenApiCallResultOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestOpenAPICallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolKind?), TypeInfoPropertyName = "NullableToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolParamType?), TypeInfoPropertyName = "NullableToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookToolConfigMethod?), TypeInfoPropertyName = "NullableWebhookToolConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset?), TypeInfoPropertyName = "NullableLongRunningToolConfigWaitAudioPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LongRunningToolConfigOnDuplicate?), TypeInfoPropertyName = "NullableLongRunningToolConfigOnDuplicate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPTransport?), TypeInfoPropertyName = "NullableMCPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuth?), TypeInfoPropertyName = "NullableMCPAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant1Type?), TypeInfoPropertyName = "NullableMCPAuthVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant2Type?), TypeInfoPropertyName = "NullableMCPAuthVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthVariant3Type?), TypeInfoPropertyName = "NullableMCPAuthVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPAuthDiscriminatorType?), TypeInfoPropertyName = "NullableMCPAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolActionClass?), TypeInfoPropertyName = "NullableToolActionClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiOperationMethod?), TypeInfoPropertyName = "NullableOpenApiOperationMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiParamIn?), TypeInfoPropertyName = "NullableOpenApiParamIn2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OpenApiBodyContentType?), TypeInfoPropertyName = "NullableOpenApiBodyContentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolApprovalClass?), TypeInfoPropertyName = "NullableToolApprovalClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolReach?), TypeInfoPropertyName = "NullableToolReach2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolderKind?), TypeInfoPropertyName = "NullableToolNameHolderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolConfig?), TypeInfoPropertyName = "NullableToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateToolRequestConfig?), TypeInfoPropertyName = "NullableCreateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateToolRequestConfig?), TypeInfoPropertyName = "NullableUpdateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.McpProbeErrorDetailsStage?), TypeInfoPropertyName = "NullableMcpProbeErrorDetailsStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportOpenApiRequestSpec?), TypeInfoPropertyName = "NullableImportOpenApiRequestSpec2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestOpenApiCallResultOutcome?), TypeInfoPropertyName = "NullableTestOpenApiCallResultOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.OpenAPIParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.OpenAPIOperation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolReach>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.MCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SkippedOpenAPIOperation>))]
    internal sealed partial class ToolDefinitionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolDefinitionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ToolDefinitionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ToolDefinitionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ImportOpenApiRequestSpecJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Speechify.ErrorCode)

                    || typeToConvert == typeof(global::Speechify.ErrorCode?)

                    || typeToConvert == typeof(global::Speechify.ToolKind)

                    || typeToConvert == typeof(global::Speechify.ToolKind?)

                    || typeToConvert == typeof(global::Speechify.ToolParamType)

                    || typeToConvert == typeof(global::Speechify.ToolParamType?)

                    || typeToConvert == typeof(global::Speechify.WebhookToolConfigMethod)

                    || typeToConvert == typeof(global::Speechify.WebhookToolConfigMethod?)

                    || typeToConvert == typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset)

                    || typeToConvert == typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset?)

                    || typeToConvert == typeof(global::Speechify.LongRunningToolConfigOnDuplicate)

                    || typeToConvert == typeof(global::Speechify.LongRunningToolConfigOnDuplicate?)

                    || typeToConvert == typeof(global::Speechify.MCPTransport)

                    || typeToConvert == typeof(global::Speechify.MCPTransport?)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant1Type)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant1Type?)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant2Type)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant2Type?)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant3Type)

                    || typeToConvert == typeof(global::Speechify.MCPAuthVariant3Type?)

                    || typeToConvert == typeof(global::Speechify.MCPAuthDiscriminatorType)

                    || typeToConvert == typeof(global::Speechify.MCPAuthDiscriminatorType?)

                    || typeToConvert == typeof(global::Speechify.ToolActionClass)

                    || typeToConvert == typeof(global::Speechify.ToolActionClass?)

                    || typeToConvert == typeof(global::Speechify.OpenApiOperationMethod)

                    || typeToConvert == typeof(global::Speechify.OpenApiOperationMethod?)

                    || typeToConvert == typeof(global::Speechify.OpenApiParamIn)

                    || typeToConvert == typeof(global::Speechify.OpenApiParamIn?)

                    || typeToConvert == typeof(global::Speechify.OpenApiBodyContentType)

                    || typeToConvert == typeof(global::Speechify.OpenApiBodyContentType?)

                    || typeToConvert == typeof(global::Speechify.ToolApprovalClass)

                    || typeToConvert == typeof(global::Speechify.ToolApprovalClass?)

                    || typeToConvert == typeof(global::Speechify.ToolReach)

                    || typeToConvert == typeof(global::Speechify.ToolReach?)

                    || typeToConvert == typeof(global::Speechify.ToolNameHolderKind)

                    || typeToConvert == typeof(global::Speechify.ToolNameHolderKind?)

                    || typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage)

                    || typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage?)

                    || typeToConvert == typeof(global::Speechify.TestOpenApiCallResultOutcome)

                    || typeToConvert == typeof(global::Speechify.TestOpenApiCallResultOutcome?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Speechify.ErrorCode))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode?))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolKind))
                {
                    return new global::Speechify.JsonConverters.ToolKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolKind?))
                {
                    return new global::Speechify.JsonConverters.ToolKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolParamType))
                {
                    return new global::Speechify.JsonConverters.ToolParamTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolParamType?))
                {
                    return new global::Speechify.JsonConverters.ToolParamTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WebhookToolConfigMethod))
                {
                    return new global::Speechify.JsonConverters.WebhookToolConfigMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WebhookToolConfigMethod?))
                {
                    return new global::Speechify.JsonConverters.WebhookToolConfigMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset))
                {
                    return new global::Speechify.JsonConverters.LongRunningToolConfigWaitAudioPresetJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.LongRunningToolConfigWaitAudioPreset?))
                {
                    return new global::Speechify.JsonConverters.LongRunningToolConfigWaitAudioPresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.LongRunningToolConfigOnDuplicate))
                {
                    return new global::Speechify.JsonConverters.LongRunningToolConfigOnDuplicateJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.LongRunningToolConfigOnDuplicate?))
                {
                    return new global::Speechify.JsonConverters.LongRunningToolConfigOnDuplicateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPTransport))
                {
                    return new global::Speechify.JsonConverters.MCPTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPTransport?))
                {
                    return new global::Speechify.JsonConverters.MCPTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant1Type))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant1Type?))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant2Type))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant2Type?))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant3Type))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthVariant3Type?))
                {
                    return new global::Speechify.JsonConverters.MCPAuthVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthDiscriminatorType))
                {
                    return new global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MCPAuthDiscriminatorType?))
                {
                    return new global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolActionClass))
                {
                    return new global::Speechify.JsonConverters.ToolActionClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolActionClass?))
                {
                    return new global::Speechify.JsonConverters.ToolActionClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiOperationMethod))
                {
                    return new global::Speechify.JsonConverters.OpenApiOperationMethodJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiOperationMethod?))
                {
                    return new global::Speechify.JsonConverters.OpenApiOperationMethodNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiParamIn))
                {
                    return new global::Speechify.JsonConverters.OpenApiParamInJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiParamIn?))
                {
                    return new global::Speechify.JsonConverters.OpenApiParamInNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiBodyContentType))
                {
                    return new global::Speechify.JsonConverters.OpenApiBodyContentTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.OpenApiBodyContentType?))
                {
                    return new global::Speechify.JsonConverters.OpenApiBodyContentTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolApprovalClass))
                {
                    return new global::Speechify.JsonConverters.ToolApprovalClassJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolApprovalClass?))
                {
                    return new global::Speechify.JsonConverters.ToolApprovalClassNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolReach))
                {
                    return new global::Speechify.JsonConverters.ToolReachJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolReach?))
                {
                    return new global::Speechify.JsonConverters.ToolReachNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolNameHolderKind))
                {
                    return new global::Speechify.JsonConverters.ToolNameHolderKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ToolNameHolderKind?))
                {
                    return new global::Speechify.JsonConverters.ToolNameHolderKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage))
                {
                    return new global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage?))
                {
                    return new global::Speechify.JsonConverters.McpProbeErrorDetailsStageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestOpenApiCallResultOutcome))
                {
                    return new global::Speechify.JsonConverters.TestOpenApiCallResultOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestOpenApiCallResultOutcome?))
                {
                    return new global::Speechify.JsonConverters.TestOpenApiCallResultOutcomeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new ToolDefinitionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}