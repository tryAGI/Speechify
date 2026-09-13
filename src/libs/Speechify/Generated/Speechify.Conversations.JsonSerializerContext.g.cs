
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentChannel), TypeInfoPropertyName = "AgentChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentAdditionalLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemailAction), TypeInfoPropertyName = "AmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvrAction), TypeInfoPropertyName = "AmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailableAction), TypeInfoPropertyName = "AmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigTuning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AMDConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus), TypeInfoPropertyName = "ConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport), TypeInfoPropertyName = "ConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationChannel), TypeInfoPropertyName = "ConversationChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason), TypeInfoPropertyName = "ConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SkillPin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotReasoningEffort), TypeInfoPropertyName = "AgentSnapshotReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotInterruptionSensitivity), TypeInfoPropertyName = "AgentSnapshotInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset), TypeInfoPropertyName = "AgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SkillPin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason), TypeInfoPropertyName = "ConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RecentCallee))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRecentCalleesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageInitiatedBy), TypeInfoPropertyName = "MessageInitiatedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationKind), TypeInfoPropertyName = "EvaluationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationStatus), TypeInfoPropertyName = "EvaluationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Evaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Memory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchHitRanking))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalCoverage), TypeInfoPropertyName = "RetrievalCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRetrievalLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDeliveryStatus), TypeInfoPropertyName = "WebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListWebhookDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.WebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentChannel?), TypeInfoPropertyName = "NullableAgentChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemailAction?), TypeInfoPropertyName = "NullableAmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvrAction?), TypeInfoPropertyName = "NullableAmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailableAction?), TypeInfoPropertyName = "NullableAmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus?), TypeInfoPropertyName = "NullableConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport?), TypeInfoPropertyName = "NullableConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationChannel?), TypeInfoPropertyName = "NullableConversationChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason?), TypeInfoPropertyName = "NullableConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotReasoningEffort?), TypeInfoPropertyName = "NullableAgentSnapshotReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentSnapshotInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?), TypeInfoPropertyName = "NullableAgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason?), TypeInfoPropertyName = "NullableConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageInitiatedBy?), TypeInfoPropertyName = "NullableMessageInitiatedBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationKind?), TypeInfoPropertyName = "NullableEvaluationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationStatus?), TypeInfoPropertyName = "NullableEvaluationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalCoverage?), TypeInfoPropertyName = "NullableRetrievalCoverage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDeliveryStatus?), TypeInfoPropertyName = "NullableWebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentAdditionalLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SkillPin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.WebhookDelivery>))]
    internal sealed partial class ConversationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConversationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ConversationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ConversationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

                    || typeToConvert == typeof(global::Speechify.AgentChannel)

                    || typeToConvert == typeof(global::Speechify.AgentChannel?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction?)

                    || typeToConvert == typeof(global::Speechify.ConversationStatus)

                    || typeToConvert == typeof(global::Speechify.ConversationStatus?)

                    || typeToConvert == typeof(global::Speechify.ConversationTransport)

                    || typeToConvert == typeof(global::Speechify.ConversationTransport?)

                    || typeToConvert == typeof(global::Speechify.ConversationChannel)

                    || typeToConvert == typeof(global::Speechify.ConversationChannel?)

                    || typeToConvert == typeof(global::Speechify.ConversationEndReason)

                    || typeToConvert == typeof(global::Speechify.ConversationEndReason?)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotReasoningEffort)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotReasoningEffort?)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?)

                    || typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason)

                    || typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason?)

                    || typeToConvert == typeof(global::Speechify.MessageRole)

                    || typeToConvert == typeof(global::Speechify.MessageRole?)

                    || typeToConvert == typeof(global::Speechify.MessageInitiatedBy)

                    || typeToConvert == typeof(global::Speechify.MessageInitiatedBy?)

                    || typeToConvert == typeof(global::Speechify.EvaluationKind)

                    || typeToConvert == typeof(global::Speechify.EvaluationKind?)

                    || typeToConvert == typeof(global::Speechify.EvaluationStatus)

                    || typeToConvert == typeof(global::Speechify.EvaluationStatus?)

                    || typeToConvert == typeof(global::Speechify.RetrievalCoverage)

                    || typeToConvert == typeof(global::Speechify.RetrievalCoverage?)

                    || typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus)

                    || typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus?)

                    || typeToConvert == typeof(global::Speechify.JobStatus)

                    || typeToConvert == typeof(global::Speechify.JobStatus?);
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

                if (typeToConvert == typeof(global::Speechify.AgentChannel))
                {
                    return new global::Speechify.JsonConverters.AgentChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentChannel?))
                {
                    return new global::Speechify.JsonConverters.AgentChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnVoicemailActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction?))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnVoicemailActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnIvrActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction?))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnIvrActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnUnavailableActionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction?))
                {
                    return new global::Speechify.JsonConverters.AmdConfigOnUnavailableActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationStatus))
                {
                    return new global::Speechify.JsonConverters.ConversationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationStatus?))
                {
                    return new global::Speechify.JsonConverters.ConversationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationTransport))
                {
                    return new global::Speechify.JsonConverters.ConversationTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationTransport?))
                {
                    return new global::Speechify.JsonConverters.ConversationTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationChannel))
                {
                    return new global::Speechify.JsonConverters.ConversationChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationChannel?))
                {
                    return new global::Speechify.JsonConverters.ConversationChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationEndReason))
                {
                    return new global::Speechify.JsonConverters.ConversationEndReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationEndReason?))
                {
                    return new global::Speechify.JsonConverters.ConversationEndReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotReasoningEffort))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotReasoningEffort?))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotReasoningEffortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotInterruptionSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotInterruptionSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?))
                {
                    return new global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason))
                {
                    return new global::Speechify.JsonConverters.ConversationIvrSurrenderReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason?))
                {
                    return new global::Speechify.JsonConverters.ConversationIvrSurrenderReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MessageRole))
                {
                    return new global::Speechify.JsonConverters.MessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MessageRole?))
                {
                    return new global::Speechify.JsonConverters.MessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MessageInitiatedBy))
                {
                    return new global::Speechify.JsonConverters.MessageInitiatedByJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MessageInitiatedBy?))
                {
                    return new global::Speechify.JsonConverters.MessageInitiatedByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationKind))
                {
                    return new global::Speechify.JsonConverters.EvaluationKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationKind?))
                {
                    return new global::Speechify.JsonConverters.EvaluationKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationStatus))
                {
                    return new global::Speechify.JsonConverters.EvaluationStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationStatus?))
                {
                    return new global::Speechify.JsonConverters.EvaluationStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RetrievalCoverage))
                {
                    return new global::Speechify.JsonConverters.RetrievalCoverageJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RetrievalCoverage?))
                {
                    return new global::Speechify.JsonConverters.RetrievalCoverageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus))
                {
                    return new global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus?))
                {
                    return new global::Speechify.JsonConverters.WebhookDeliveryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus))
                {
                    return new global::Speechify.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus?))
                {
                    return new global::Speechify.JsonConverters.JobStatusNullableJsonConverter();
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
                    0 => new ConversationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}