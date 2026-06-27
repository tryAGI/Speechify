
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
            typeof(global::Speechify.JsonConverters.GetSpeechRequestAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechResponseAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ErrorCodeJsonConverter),

            typeof(global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptJsonConverter),

            typeof(global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.GetStreamRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoicesModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentLlmConfigProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSttConfigOverrideJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSttConfigOverrideNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigStyleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigThemeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigAvatarTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnVoicemailActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnVoicemailActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnIvrActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnIvrActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnUnavailableActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnUnavailableActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataCollectionFieldTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataCollectionFieldTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DynamicVariableTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DynamicVariableTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationEndReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationEndReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationIvrSurrenderReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationIvrSurrenderReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationKindJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookDeliveryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.RefreshHistoryEntryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolParamTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolParamTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookToolConfigMethodJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookToolConfigMethodNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant1TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant1TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant2TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant2TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TestTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ParameterCheckModeJsonConverter),

            typeof(global::Speechify.JsonConverters.ParameterCheckModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionModeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::Speechify.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.NoMatchBehaviorJsonConverter),

            typeof(global::Speechify.JsonConverters.NoMatchBehaviorNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationResultSentimentJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationResultSentimentNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationCriterionResultStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationCriterionResultStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionResultModeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionResultModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SuiteRunTriggerJsonConverter),

            typeof(global::Speechify.JsonConverters.SuiteRunTriggerNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchRecipientStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchRecipientStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberCapabilityJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberCapabilityNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkDirectionJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkDirectionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPMediaEncryptionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter),

            typeof(global::Speechify.JsonConverters.McpProbeErrorDetailsStageNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTraceEventKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTraceEventKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionSourceJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionSourceNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsMetricAggJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsMetricAggNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsFilterOpJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsFilterOpNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeFieldJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeFieldNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeBucketJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeBucketNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsQueryResultBucketJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsQueryResultBucketNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DashboardWidgetChartTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DashboardWidgetChartTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CredentialKindJsonConverter),

            typeof(global::Speechify.JsonConverters.CredentialKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentTestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateAgentToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.EvaluationStatus?, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ReplyResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ToolCallResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.SimulationResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestAudioFormat), TypeInfoPropertyName = "GetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestModel), TypeInfoPropertyName = "GetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponseAudioFormat), TypeInfoPropertyName = "GetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NestedChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechMarks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.NestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamPostParametersAccept), TypeInfoPropertyName = "V1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequestModel), TypeInfoPropertyName = "GetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceGender), TypeInfoPropertyName = "GetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModelName), TypeInfoPropertyName = "GetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceType), TypeInfoPropertyName = "GetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.GetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender), TypeInfoPropertyName = "V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreatedVoiceGender), TypeInfoPropertyName = "CreatedVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateVoiceModelName), TypeInfoPropertyName = "CreateVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.CreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreatedVoiceType), TypeInfoPropertyName = "CreatedVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreatedVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.CreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigProvider), TypeInfoPropertyName = "AgentLlmConfigProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTTSConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSttConfigOverride), TypeInfoPropertyName = "AgentSttConfigOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSTTConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTurnHandlingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentMemoryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentNavigatorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentBackgroundNoiseConfigPreset), TypeInfoPropertyName = "AgentBackgroundNoiseConfigPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentBackgroundNoiseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigStyle), TypeInfoPropertyName = "WidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTheme), TypeInfoPropertyName = "WidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatarType), TypeInfoPropertyName = "WidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemailAction), TypeInfoPropertyName = "AmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvrAction), TypeInfoPropertyName = "AmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailableAction), TypeInfoPropertyName = "AmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigTuning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AMDConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceType), TypeInfoPropertyName = "AgentVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceModelName), TypeInfoPropertyName = "AgentVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceGender), TypeInfoPropertyName = "AgentVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentFlowGetSchemaResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListFlowTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInputVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowGraphInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CloneFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionFieldType), TypeInfoPropertyName = "DataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateEvaluationConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RollbackFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListFlowVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetFlowVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariableType), TypeInfoPropertyName = "DynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemVariableDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListDynamicVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDynamicVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus), TypeInfoPropertyName = "ConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport), TypeInfoPropertyName = "ConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason), TypeInfoPropertyName = "ConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset), TypeInfoPropertyName = "AgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason), TypeInfoPropertyName = "ConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RecentCallee))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRecentCalleesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationKind), TypeInfoPropertyName = "EvaluationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationStatus), TypeInfoPropertyName = "EvaluationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Evaluation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.EvaluationStatus?, object>), TypeInfoPropertyName = "OneOfEvaluationStatusObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListEvaluationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Memory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageRole), TypeInfoPropertyName = "MessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Message))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListMessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRetrievalLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShadowConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDeliveryStatus), TypeInfoPropertyName = "WebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListWebhookDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.WebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchKnowledgeBasesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseSearchHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentSourceKind), TypeInfoPropertyName = "KnowledgeBaseDocumentSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentStatus), TypeInfoPropertyName = "KnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchDeleteDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchMoveDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateCrawlImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobKind), TypeInfoPropertyName = "ImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobStatus), TypeInfoPropertyName = "ImportJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSitemapImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateTextDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLBatchImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DependentAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateRefreshConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntryStatus), TypeInfoPropertyName = "RefreshHistoryEntryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRefreshHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListImportJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AttachedKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolKind), TypeInfoPropertyName = "ToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolParamType), TypeInfoPropertyName = "ToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BuiltinToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookToolConfigMethod), TypeInfoPropertyName = "WebhookToolConfigMethod2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentToolConfig), TypeInfoPropertyName = "AgentToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTool>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestConfig), TypeInfoPropertyName = "AgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MockingStrategy), TypeInfoPropertyName = "MockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NoMatchBehavior), TypeInfoPropertyName = "NoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunStatus), TypeInfoPropertyName = "TestRunStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.ReplyResult, object>), TypeInfoPropertyName = "OneOfReplyResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.ToolCallResult, object>), TypeInfoPropertyName = "OneOfToolCallResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.SimulationResult, object>), TypeInfoPropertyName = "OneOfSimulationResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TestRunResult, object>), TypeInfoPropertyName = "OneOfTestRunResultObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestWithLastRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.AgentTestRun, object>), TypeInfoPropertyName = "OneOfAgentTestRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRunEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger), TypeInfoPropertyName = "SuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TestRunConfigOverride, object>), TypeInfoPropertyName = "OneOfTestRunConfigOverrideObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.AgentTestSuiteRun, object>), TypeInfoPropertyName = "OneOfAgentTestSuiteRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStatsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSuiteRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteChildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequestConfig), TypeInfoPropertyName = "UpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequestConfig), TypeInfoPropertyName = "CreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAllTestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchCallStatus), TypeInfoPropertyName = "BatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListBatchCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipientStatus), TypeInfoPropertyName = "BatchRecipientStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IvrMenuListEntryMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IVRMenuListEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListIVRMenusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.IVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IvrMenuMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IVRMenu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateIVRMenuLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.InvalidateIVRMenuRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateOutboundCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberProvider), TypeInfoPropertyName = "PhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberCapability), TypeInfoPropertyName = "PhoneNumberCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PhoneNumberCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TwilioImportSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TelnyxImportSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PurchasedPhoneNumberProvider), TypeInfoPropertyName = "PurchasedPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AvailablePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SearchAvailablePhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PurchasePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTrunkProvider), TypeInfoPropertyName = "SIPTrunkProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTrunkDirection), TypeInfoPropertyName = "SIPTrunkDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTransport), TypeInfoPropertyName = "SIPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPMediaEncryption), TypeInfoPropertyName = "SIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTrunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSIPTrunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SIPTrunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSipTrunkRequestCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSIPTrunkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Caller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCallersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Caller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCallerConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CallerMemoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCallerMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.CallerMemoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteMemoriesByCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteMemoriesByCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAudioAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadAudioAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LLMModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LLMPlatformDefault))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.LLMModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.LLMModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequestConfig), TypeInfoPropertyName = "CreateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequestConfig), TypeInfoPropertyName = "UpdateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemBuiltinInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSystemBuiltinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SystemBuiltinInfo>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTraceEventKind), TypeInfoPropertyName = "ConversationTraceEventKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTraceTurn))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ConversationTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ConversationTraceTurn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsDimensionType), TypeInfoPropertyName = "AnalyticsDimensionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsDimensionSource), TypeInfoPropertyName = "AnalyticsDimensionSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsDimension))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsDimensionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AnalyticsDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsMetricAgg), TypeInfoPropertyName = "AnalyticsMetricAgg2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsFilterOp), TypeInfoPropertyName = "AnalyticsFilterOp2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsTimeField), TypeInfoPropertyName = "AnalyticsTimeField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsTimeBucket), TypeInfoPropertyName = "AnalyticsTimeBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsQueryRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AnalyticsFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsQueryResultBucket), TypeInfoPropertyName = "AnalyticsQueryResultBucket2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsPoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsSeries))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AnalyticsPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsPreviousResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AnalyticsSeries>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsQueryMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AnalyticsQueryResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DashboardWidgetChartType), TypeInfoPropertyName = "DashboardWidgetChartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DashboardPosition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DashboardWidget))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DashboardLayout))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Dashboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListDashboardsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Dashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDashboardRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TakeOverConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialKind), TypeInfoPropertyName = "CredentialKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewOauth2ClientCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewOauth2Jwt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewBasic))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewBearer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigViewCustomHeaders))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfigView))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Credential))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCredentialsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Credential>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2ClientCredentialsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OAuth2JWTConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BasicAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BearerAuthConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CustomHeadersConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CredentialConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateCredentialRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.NestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.CreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.CreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestNodesItems>))]
    internal sealed partial class SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }

    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Speechify.JsonConverters.GetSpeechRequestAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter),

            typeof(global::Speechify.JsonConverters.GetSpeechResponseAudioFormatNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ErrorCodeJsonConverter),

            typeof(global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptJsonConverter),

            typeof(global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.GetStreamRequestModelNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoicesModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.GetVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.CreatedVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentLlmConfigProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSttConfigOverrideJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSttConfigOverrideNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigStyleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigThemeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.WidgetConfigAvatarTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnVoicemailActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnVoicemailActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnIvrActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnIvrActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnUnavailableActionJsonConverter),

            typeof(global::Speechify.JsonConverters.AmdConfigOnUnavailableActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataCollectionFieldTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataCollectionFieldTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DynamicVariableTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DynamicVariableTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationEndReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationEndReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationIvrSurrenderReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationIvrSurrenderReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationKindJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.EvaluationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.MessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookDeliveryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.ImportJobStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.RefreshHistoryEntryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolParamTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolParamTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookToolConfigMethodJsonConverter),

            typeof(global::Speechify.JsonConverters.WebhookToolConfigMethodNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant1TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant1TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant2TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant2TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthVariant3TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TestTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TestTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ParameterCheckModeJsonConverter),

            typeof(global::Speechify.JsonConverters.ParameterCheckModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionModeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MockingStrategyJsonConverter),

            typeof(global::Speechify.JsonConverters.MockingStrategyNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.NoMatchBehaviorJsonConverter),

            typeof(global::Speechify.JsonConverters.NoMatchBehaviorNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TestRunStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TestRunStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationResultSentimentJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationResultSentimentNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationCriterionResultStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.SimulationCriterionResultStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionResultModeJsonConverter),

            typeof(global::Speechify.JsonConverters.DataAssertionResultModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SuiteRunTriggerJsonConverter),

            typeof(global::Speechify.JsonConverters.SuiteRunTriggerNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchCallStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchCallStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchRecipientStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.BatchRecipientStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberCapabilityJsonConverter),

            typeof(global::Speechify.JsonConverters.PhoneNumberCapabilityNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.PurchasedPhoneNumberProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkDirectionJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTrunkDirectionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter),

            typeof(global::Speechify.JsonConverters.SIPMediaEncryptionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter),

            typeof(global::Speechify.JsonConverters.McpProbeErrorDetailsStageNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTraceEventKindJsonConverter),

            typeof(global::Speechify.JsonConverters.ConversationTraceEventKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionSourceJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsDimensionSourceNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsMetricAggJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsMetricAggNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsFilterOpJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsFilterOpNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeFieldJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeFieldNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeBucketJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsTimeBucketNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsQueryResultBucketJsonConverter),

            typeof(global::Speechify.JsonConverters.AnalyticsQueryResultBucketNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.DashboardWidgetChartTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.DashboardWidgetChartTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.CredentialKindJsonConverter),

            typeof(global::Speechify.JsonConverters.CredentialKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.MCPAuthJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.AgentTestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateAgentToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.ToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.CreateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.EvaluationStatus?, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ReplyResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ToolCallResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.SimulationResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.WebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTool>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.IVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PhoneNumberCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SIPTrunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Caller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.CallerMemoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.LLMModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemBuiltinInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.MCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ConversationTraceEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ConversationTraceTurn>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AnalyticsDimension>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AnalyticsFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AnalyticsPoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AnalyticsSeries>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DashboardWidget>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Dashboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Credential>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = global::System.Text.Json.Serialization.Metadata.JsonTypeInfoResolver.Combine(
            SourceGenerationContextChunk0.Default,

            SourceGenerationContextChunk1.Default
            );

        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        /// 
        /// </summary>
        public static SourceGenerationContext Default { get; } = new(DefaultOptions);

        private SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechRequestModelJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ErrorCodeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetStreamRequestModelNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoiceGenderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoiceGenderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoicesModelNameNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoiceTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.GetVoiceTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreatedVoiceGenderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreatedVoiceGenderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateVoiceModelNameJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateVoiceModelNameNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreatedVoiceTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreatedVoiceTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentLlmConfigProviderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentSttConfigOverrideJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentSttConfigOverrideNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigStyleNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigThemeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WidgetConfigAvatarTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnVoicemailActionJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnVoicemailActionNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnIvrActionJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnIvrActionNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnUnavailableActionJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AmdConfigOnUnavailableActionNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceModelNameJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceModelNameNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceGenderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentVoiceGenderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataCollectionFieldTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataCollectionFieldTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DynamicVariableTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DynamicVariableTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationTransportJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationTransportNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationEndReasonJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationEndReasonNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentSnapshotBackgroundNoisePresetNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationIvrSurrenderReasonJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationIvrSurrenderReasonNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.EvaluationKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.EvaluationKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.EvaluationStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.EvaluationStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MessageRoleJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WebhookDeliveryStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ImportJobKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ImportJobKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ImportJobStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ImportJobStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.RefreshHistoryEntryStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolParamTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolParamTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WebhookToolConfigMethodJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.WebhookToolConfigMethodNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPTransportJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPTransportNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant1TypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant1TypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant2TypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant2TypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant3TypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthVariant3TypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthDiscriminatorTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.TestTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.TestTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationMessageRoleJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationMessageRoleNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ParameterCheckModeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ParameterCheckModeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataAssertionModeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataAssertionModeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MockingStrategyJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MockingStrategyNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.NoMatchBehaviorJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.NoMatchBehaviorNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.TestRunStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.TestRunStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationResultSentimentJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationResultSentimentNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationCriterionResultStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SimulationCriterionResultStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataAssertionResultModeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DataAssertionResultModeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SuiteRunTriggerJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SuiteRunTriggerNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.BatchCallStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.BatchCallStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.BatchRecipientStatusJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.BatchRecipientStatusNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PhoneNumberProviderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PhoneNumberCapabilityJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PhoneNumberCapabilityNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.PurchasedPhoneNumberProviderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTrunkProviderJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTrunkProviderNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTrunkDirectionJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTrunkDirectionNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTransportJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPTransportNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.SIPMediaEncryptionNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.McpProbeErrorDetailsStageNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationTraceEventKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ConversationTraceEventKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsDimensionTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsDimensionTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsDimensionSourceJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsDimensionSourceNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsMetricAggJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsMetricAggNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsFilterOpJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsFilterOpNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsTimeFieldJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsTimeFieldNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsTimeBucketJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsTimeBucketNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsQueryResultBucketJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AnalyticsQueryResultBucketNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DashboardWidgetChartTypeJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.DashboardWidgetChartTypeNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CredentialKindJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CredentialKindNullableJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentTestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.EvaluationStatus?, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ReplyResult, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.ToolCallResult, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.SimulationResult, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestRun, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunResult, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TestRunConfigOverride, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.AgentTestSuiteRun, object>());
            options.Converters.Add(new global::Speechify.JsonConverters.UnixTimestampJsonConverter());

            return options;
        }
    }
}