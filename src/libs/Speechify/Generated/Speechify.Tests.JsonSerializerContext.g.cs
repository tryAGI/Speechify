
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestType), TypeInfoPropertyName = "TestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessageRole), TypeInfoPropertyName = "SimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ReplyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckMode), TypeInfoPropertyName = "ParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionMode), TypeInfoPropertyName = "DataAssertionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DataAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequestConfig), TypeInfoPropertyName = "CreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MockingStrategy), TypeInfoPropertyName = "MockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NoMatchBehavior), TypeInfoPropertyName = "NoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestConfig), TypeInfoPropertyName = "AgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestVerdict), TypeInfoPropertyName = "TestVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ReplyResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationResultSentiment), TypeInfoPropertyName = "SimulationResultSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationCriterionResultStatus), TypeInfoPropertyName = "SimulationCriterionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationCriterionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionResultMode), TypeInfoPropertyName = "DataAssertionResultMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SimulationCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DataAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestWithLastRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequestConfig), TypeInfoPropertyName = "UpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTarget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTargetedTestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger), TypeInfoPropertyName = "SuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRunEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSuiteRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunWithRunsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteChildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStatsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestType?), TypeInfoPropertyName = "NullableTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessageRole?), TypeInfoPropertyName = "NullableSimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckMode?), TypeInfoPropertyName = "NullableParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionMode?), TypeInfoPropertyName = "NullableDataAssertionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequestConfig?), TypeInfoPropertyName = "NullableCreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MockingStrategy?), TypeInfoPropertyName = "NullableMockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NoMatchBehavior?), TypeInfoPropertyName = "NullableNoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestConfig?), TypeInfoPropertyName = "NullableAgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestVerdict?), TypeInfoPropertyName = "NullableTestVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationResultSentiment?), TypeInfoPropertyName = "NullableSimulationResultSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationCriterionResultStatus?), TypeInfoPropertyName = "NullableSimulationCriterionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionResultMode?), TypeInfoPropertyName = "NullableDataAssertionResultMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequestConfig?), TypeInfoPropertyName = "NullableUpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger?), TypeInfoPropertyName = "NullableSuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TestStatsBucket>))]
    internal sealed partial class TestsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TestsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static TestsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private TestsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentTestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter());
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

                    || typeToConvert == typeof(global::Speechify.JobStatus)

                    || typeToConvert == typeof(global::Speechify.JobStatus?)

                    || typeToConvert == typeof(global::Speechify.TestType)

                    || typeToConvert == typeof(global::Speechify.TestType?)

                    || typeToConvert == typeof(global::Speechify.SimulationMessageRole)

                    || typeToConvert == typeof(global::Speechify.SimulationMessageRole?)

                    || typeToConvert == typeof(global::Speechify.ParameterCheckMode)

                    || typeToConvert == typeof(global::Speechify.ParameterCheckMode?)

                    || typeToConvert == typeof(global::Speechify.DataAssertionMode)

                    || typeToConvert == typeof(global::Speechify.DataAssertionMode?)

                    || typeToConvert == typeof(global::Speechify.MockingStrategy)

                    || typeToConvert == typeof(global::Speechify.MockingStrategy?)

                    || typeToConvert == typeof(global::Speechify.NoMatchBehavior)

                    || typeToConvert == typeof(global::Speechify.NoMatchBehavior?)

                    || typeToConvert == typeof(global::Speechify.TestVerdict)

                    || typeToConvert == typeof(global::Speechify.TestVerdict?)

                    || typeToConvert == typeof(global::Speechify.SimulationResultSentiment)

                    || typeToConvert == typeof(global::Speechify.SimulationResultSentiment?)

                    || typeToConvert == typeof(global::Speechify.SimulationCriterionResultStatus)

                    || typeToConvert == typeof(global::Speechify.SimulationCriterionResultStatus?)

                    || typeToConvert == typeof(global::Speechify.DataAssertionResultMode)

                    || typeToConvert == typeof(global::Speechify.DataAssertionResultMode?)

                    || typeToConvert == typeof(global::Speechify.SuiteRunTrigger)

                    || typeToConvert == typeof(global::Speechify.SuiteRunTrigger?);
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

                if (typeToConvert == typeof(global::Speechify.JobStatus))
                {
                    return new global::Speechify.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus?))
                {
                    return new global::Speechify.JsonConverters.JobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestType))
                {
                    return new global::Speechify.JsonConverters.TestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestType?))
                {
                    return new global::Speechify.JsonConverters.TestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationMessageRole))
                {
                    return new global::Speechify.JsonConverters.SimulationMessageRoleJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationMessageRole?))
                {
                    return new global::Speechify.JsonConverters.SimulationMessageRoleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ParameterCheckMode))
                {
                    return new global::Speechify.JsonConverters.ParameterCheckModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ParameterCheckMode?))
                {
                    return new global::Speechify.JsonConverters.ParameterCheckModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataAssertionMode))
                {
                    return new global::Speechify.JsonConverters.DataAssertionModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataAssertionMode?))
                {
                    return new global::Speechify.JsonConverters.DataAssertionModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MockingStrategy))
                {
                    return new global::Speechify.JsonConverters.MockingStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.MockingStrategy?))
                {
                    return new global::Speechify.JsonConverters.MockingStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.NoMatchBehavior))
                {
                    return new global::Speechify.JsonConverters.NoMatchBehaviorJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.NoMatchBehavior?))
                {
                    return new global::Speechify.JsonConverters.NoMatchBehaviorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestVerdict))
                {
                    return new global::Speechify.JsonConverters.TestVerdictJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.TestVerdict?))
                {
                    return new global::Speechify.JsonConverters.TestVerdictNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationResultSentiment))
                {
                    return new global::Speechify.JsonConverters.SimulationResultSentimentJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationResultSentiment?))
                {
                    return new global::Speechify.JsonConverters.SimulationResultSentimentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationCriterionResultStatus))
                {
                    return new global::Speechify.JsonConverters.SimulationCriterionResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SimulationCriterionResultStatus?))
                {
                    return new global::Speechify.JsonConverters.SimulationCriterionResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataAssertionResultMode))
                {
                    return new global::Speechify.JsonConverters.DataAssertionResultModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataAssertionResultMode?))
                {
                    return new global::Speechify.JsonConverters.DataAssertionResultModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SuiteRunTrigger))
                {
                    return new global::Speechify.JsonConverters.SuiteRunTriggerJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SuiteRunTrigger?))
                {
                    return new global::Speechify.JsonConverters.SuiteRunTriggerNullableJsonConverter();
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
                    0 => new TestsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}