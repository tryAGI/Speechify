
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
            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechResponseAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetSpeechResponseAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestGrantTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestGrantTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestScopeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAccessTokenRequestScopeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAccessTokenScopeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAccessTokenScopeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAccessTokenTokenTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAccessTokenTokenTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsOAuthErrorErrorJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsOAuthErrorErrorNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoicesModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoicesModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreatedVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSystemToolConfigBuiltinJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSystemToolConfigBuiltinNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolParamTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolParamTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookToolConfigMethodJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookToolConfigMethodNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataCollectionFieldTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataCollectionFieldTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDynamicVariableTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDynamicVariableTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsParameterCheckModeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsParameterCheckModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMockingStrategyJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMockingStrategyNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsNoMatchBehaviorJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsNoMatchBehaviorNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestRunStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestRunStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTenantPlanJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTenantPlanNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTenantDataRegionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTenantDataRegionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMemberRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMemberRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentTestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsScenarioResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsToolCallResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsSimulationResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsEvaluationStatus?, object>),

            typeof(global::Speechify.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequestAudioFormat), TypeInfoPropertyName = "TtsGetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequestModel), TypeInfoPropertyName = "TtsGetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechResponseAudioFormat), TypeInfoPropertyName = "TtsGetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsNestedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSpeechMarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsNestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsV1AudioStreamPostParametersAccept), TypeInfoPropertyName = "TtsV1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequestModel), TypeInfoPropertyName = "TtsGetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAudioStreamResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAccessTokenRequestGrantType), TypeInfoPropertyName = "TtsCreateAccessTokenRequestGrantType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAccessTokenRequestScope), TypeInfoPropertyName = "TtsCreateAccessTokenRequestScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAccessTokenRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAccessTokenScope), TypeInfoPropertyName = "TtsAccessTokenScope2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAccessTokenTokenType), TypeInfoPropertyName = "TtsAccessTokenTokenType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAccessToken))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsOAuthErrorError), TypeInfoPropertyName = "TtsOAuthErrorError2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsOAuthError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceGender), TypeInfoPropertyName = "TtsGetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoicesModelName), TypeInfoPropertyName = "TtsGetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoicesModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoiceType), TypeInfoPropertyName = "TtsGetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender), TypeInfoPropertyName = "TtsV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoiceGender), TypeInfoPropertyName = "TtsCreatedVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceModelName), TypeInfoPropertyName = "TtsCreateVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoiceType), TypeInfoPropertyName = "TtsCreatedVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreatedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolKind), TypeInfoPropertyName = "TtsToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemToolConfigBuiltin), TypeInfoPropertyName = "TtsSystemToolConfigBuiltin2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolParamType), TypeInfoPropertyName = "TtsToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookToolConfigMethod), TypeInfoPropertyName = "TtsWebhookToolConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsClientToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolConfig), TypeInfoPropertyName = "TtsToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataCollectionFieldType), TypeInfoPropertyName = "TtsDataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataCollectionField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsEvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateEvaluationConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDynamicVariableType), TypeInfoPropertyName = "TtsDynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemVariableDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListDynamicVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateDynamicVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationStatus), TypeInfoPropertyName = "TtsConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationTransport), TypeInfoPropertyName = "TtsConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDeleteMemoriesByCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDeleteMemoriesByCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestType), TypeInfoPropertyName = "TtsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationMessageRole), TypeInfoPropertyName = "TtsSimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsScenarioConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheckMode), TypeInfoPropertyName = "TtsParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestConfig), TypeInfoPropertyName = "TtsAgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMockingStrategy), TypeInfoPropertyName = "TtsMockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsNoMatchBehavior), TypeInfoPropertyName = "TtsNoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestRunStatus), TypeInfoPropertyName = "TtsTestRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsScenarioResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheckResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsScenarioResult, object>), TypeInfoPropertyName = "OneOfTtsScenarioResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsToolCallResult, object>), TypeInfoPropertyName = "OneOfTtsToolCallResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsSimulationResult, object>), TypeInfoPropertyName = "OneOfTtsSimulationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsTestRunResult, object>), TypeInfoPropertyName = "OneOfTtsTestRunResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestWithLastRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsAgentTestRun, object>), TypeInfoPropertyName = "OneOfTtsAgentTestRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentTestRequestConfig), TypeInfoPropertyName = "TtsCreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestRequestConfig), TypeInfoPropertyName = "TtsUpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestStatsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsTestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchRunEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsBatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestAttachmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMoveAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateToolRequestConfig), TypeInfoPropertyName = "TtsCreateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateToolRequestConfig), TypeInfoPropertyName = "TtsUpdateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMessageRole), TypeInfoPropertyName = "TtsMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationKind), TypeInfoPropertyName = "TtsEvaluationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationStatus), TypeInfoPropertyName = "TtsEvaluationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsEvaluationStatus?, object>), TypeInfoPropertyName = "OneOfTtsEvaluationStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocumentStatus), TypeInfoPropertyName = "TtsKnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBaseDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBaseChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSearchKnowledgeBasesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseSearchHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSearchKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTenantPlan), TypeInfoPropertyName = "TtsTenantPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTenantDataRegion), TypeInfoPropertyName = "TtsTenantDataRegion2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTenantsListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateWorkspaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMemberRole), TypeInfoPropertyName = "TtsMemberRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMembersListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateMemberRoleRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsInvite))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsInvitesListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateInviteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsInvitePreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTransferOwnershipRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsNestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsEvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsTestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsBatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsTenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsInvite>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}