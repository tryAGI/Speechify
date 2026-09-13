
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStatus), TypeInfoPropertyName = "AgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunInputDelegationTargetsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRunInputDelegationTargetsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunOutputTranscriptItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRunOutputTranscriptItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunIncompleteReason), TypeInfoPropertyName = "AgentRunIncompleteReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunUsageModelsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunUsageToolsItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRunUsageModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRunUsageToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PendingActionDefaultDecision), TypeInfoPropertyName = "PendingActionDefaultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PendingAction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus), TypeInfoPropertyName = "V1AgentsAgentIdRunsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsRunsGetParametersStatus), TypeInfoPropertyName = "V1AgentsRunsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SubmitAgentRunRequestDecision), TypeInfoPropertyName = "SubmitAgentRunRequestDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SubmitAgentRunRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStepKind), TypeInfoPropertyName = "AgentRunStepKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunStepDelegationChildStatus), TypeInfoPropertyName = "RunStepDelegationChildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunStepDelegation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStep))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentRunStepsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentRunStep>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStepAddedEventKind), TypeInfoPropertyName = "AgentRunStepAddedEventKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStatusChangedEventStatus), TypeInfoPropertyName = "AgentRunStatusChangedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunEndedEventStatus), TypeInfoPropertyName = "AgentRunEndedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunEndedEventOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEvent), TypeInfoPropertyName = "AgentRunStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant1Type), TypeInfoPropertyName = "AgentRunStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant2Type), TypeInfoPropertyName = "AgentRunStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant3Type), TypeInfoPropertyName = "AgentRunStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventDiscriminatorType), TypeInfoPropertyName = "AgentRunStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStatus?), TypeInfoPropertyName = "NullableAgentRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunIncompleteReason?), TypeInfoPropertyName = "NullableAgentRunIncompleteReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PendingActionDefaultDecision?), TypeInfoPropertyName = "NullablePendingActionDefaultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus?), TypeInfoPropertyName = "NullableV1AgentsAgentIdRunsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AgentsRunsGetParametersStatus?), TypeInfoPropertyName = "NullableV1AgentsRunsGetParametersStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SubmitAgentRunRequestDecision?), TypeInfoPropertyName = "NullableSubmitAgentRunRequestDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStepKind?), TypeInfoPropertyName = "NullableAgentRunStepKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunStepDelegationChildStatus?), TypeInfoPropertyName = "NullableRunStepDelegationChildStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStepAddedEventKind?), TypeInfoPropertyName = "NullableAgentRunStepAddedEventKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStatusChangedEventStatus?), TypeInfoPropertyName = "NullableAgentRunStatusChangedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunEndedEventStatus?), TypeInfoPropertyName = "NullableAgentRunEndedEventStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEvent?), TypeInfoPropertyName = "NullableAgentRunStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant1Type?), TypeInfoPropertyName = "NullableAgentRunStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant2Type?), TypeInfoPropertyName = "NullableAgentRunStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventVariant3Type?), TypeInfoPropertyName = "NullableAgentRunStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentRunStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableAgentRunStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRunInputDelegationTargetsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRunOutputTranscriptItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRunUsageModelsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRunUsageToolsItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentRunStep>))]
    internal sealed partial class RunsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RunsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Speechify.JsonConverters.AgentRunStreamEventJsonConverter());
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

                    || typeToConvert == typeof(global::Speechify.AgentRunStatus)

                    || typeToConvert == typeof(global::Speechify.AgentRunStatus?)

                    || typeToConvert == typeof(global::Speechify.AgentRunIncompleteReason)

                    || typeToConvert == typeof(global::Speechify.AgentRunIncompleteReason?)

                    || typeToConvert == typeof(global::Speechify.PendingActionDefaultDecision)

                    || typeToConvert == typeof(global::Speechify.PendingActionDefaultDecision?)

                    || typeToConvert == typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus)

                    || typeToConvert == typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus?)

                    || typeToConvert == typeof(global::Speechify.V1AgentsRunsGetParametersStatus)

                    || typeToConvert == typeof(global::Speechify.V1AgentsRunsGetParametersStatus?)

                    || typeToConvert == typeof(global::Speechify.SubmitAgentRunRequestDecision)

                    || typeToConvert == typeof(global::Speechify.SubmitAgentRunRequestDecision?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStepKind)

                    || typeToConvert == typeof(global::Speechify.AgentRunStepKind?)

                    || typeToConvert == typeof(global::Speechify.RunStepDelegationChildStatus)

                    || typeToConvert == typeof(global::Speechify.RunStepDelegationChildStatus?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStepAddedEventKind)

                    || typeToConvert == typeof(global::Speechify.AgentRunStepAddedEventKind?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStatusChangedEventStatus)

                    || typeToConvert == typeof(global::Speechify.AgentRunStatusChangedEventStatus?)

                    || typeToConvert == typeof(global::Speechify.AgentRunEndedEventStatus)

                    || typeToConvert == typeof(global::Speechify.AgentRunEndedEventStatus?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant1Type)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant1Type?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant2Type)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant2Type?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant3Type)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant3Type?)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::Speechify.AgentRunStreamEventDiscriminatorType?);
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

                if (typeToConvert == typeof(global::Speechify.AgentRunStatus))
                {
                    return new global::Speechify.JsonConverters.AgentRunStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStatus?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunIncompleteReason))
                {
                    return new global::Speechify.JsonConverters.AgentRunIncompleteReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunIncompleteReason?))
                {
                    return new global::Speechify.JsonConverters.AgentRunIncompleteReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PendingActionDefaultDecision))
                {
                    return new global::Speechify.JsonConverters.PendingActionDefaultDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PendingActionDefaultDecision?))
                {
                    return new global::Speechify.JsonConverters.PendingActionDefaultDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus))
                {
                    return new global::Speechify.JsonConverters.V1AgentsAgentIdRunsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsAgentIdRunsGetParametersStatus?))
                {
                    return new global::Speechify.JsonConverters.V1AgentsAgentIdRunsGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsRunsGetParametersStatus))
                {
                    return new global::Speechify.JsonConverters.V1AgentsRunsGetParametersStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AgentsRunsGetParametersStatus?))
                {
                    return new global::Speechify.JsonConverters.V1AgentsRunsGetParametersStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SubmitAgentRunRequestDecision))
                {
                    return new global::Speechify.JsonConverters.SubmitAgentRunRequestDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SubmitAgentRunRequestDecision?))
                {
                    return new global::Speechify.JsonConverters.SubmitAgentRunRequestDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStepKind))
                {
                    return new global::Speechify.JsonConverters.AgentRunStepKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStepKind?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStepKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RunStepDelegationChildStatus))
                {
                    return new global::Speechify.JsonConverters.RunStepDelegationChildStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RunStepDelegationChildStatus?))
                {
                    return new global::Speechify.JsonConverters.RunStepDelegationChildStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStepAddedEventKind))
                {
                    return new global::Speechify.JsonConverters.AgentRunStepAddedEventKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStepAddedEventKind?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStepAddedEventKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStatusChangedEventStatus))
                {
                    return new global::Speechify.JsonConverters.AgentRunStatusChangedEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStatusChangedEventStatus?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStatusChangedEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunEndedEventStatus))
                {
                    return new global::Speechify.JsonConverters.AgentRunEndedEventStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunEndedEventStatus?))
                {
                    return new global::Speechify.JsonConverters.AgentRunEndedEventStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant1Type))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant1Type?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant2Type))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant2Type?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant3Type))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventVariant3Type?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventDiscriminatorType))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentRunStreamEventDiscriminatorType?))
                {
                    return new global::Speechify.JsonConverters.AgentRunStreamEventDiscriminatorTypeNullableJsonConverter();
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
                    0 => new RunsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}