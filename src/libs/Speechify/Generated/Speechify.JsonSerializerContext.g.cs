
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

            typeof(global::Speechify.JsonConverters.TtsErrorCodeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsErrorCodeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsV1AudioStreamPostParametersAcceptNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsGetStreamRequestModelNullableJsonConverter),

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

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestLlmProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestLlmProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigStyleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigStyleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigThemeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigThemeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigAvatarTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWidgetConfigAvatarTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnVoicemailActionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnVoicemailActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnIvrActionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnIvrActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnUnavailableActionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAmdConfigOnUnavailableActionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestSttOverrideJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentRequestSttOverrideNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentLlmProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentLlmProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentSttOverrideJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentSttOverrideNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestLlmProviderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestLlmProviderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestSttOverrideJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentRequestSttOverrideNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationEndReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationEndReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentSnapshotBackgroundNoisePresetJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentSnapshotBackgroundNoisePresetNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationIvrSurrenderReasonJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsConversationIvrSurrenderReasonNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceModelNameJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceModelNameNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceGenderJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentVoiceGenderNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDynamicVariableTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDynamicVariableTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataCollectionFieldTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataCollectionFieldTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsParameterCheckModeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsParameterCheckModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataAssertionModeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataAssertionModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMockingStrategyJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMockingStrategyNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsNoMatchBehaviorJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsNoMatchBehaviorNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestRunStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsTestRunStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationResultSentimentJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationResultSentimentNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationCriterionResultStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSimulationCriterionResultStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataAssertionResultModeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsDataAssertionResultModeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSuiteRunTriggerJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSuiteRunTriggerNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolParamTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolParamTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookToolConfigMethodJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookToolConfigMethodNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant1TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant1TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant2TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant2TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant3TypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthVariant3TypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthDiscriminatorTypeJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthDiscriminatorTypeNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMessageRoleJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMessageRoleNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsEvaluationStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookDeliveryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsWebhookDeliveryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentSourceKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentSourceKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsKnowledgeBaseDocumentStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsImportJobKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsImportJobKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsImportJobStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsImportJobStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsRefreshHistoryEntryStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsRefreshHistoryEntryStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMcpProbeErrorDetailsStageJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMcpProbeErrorDetailsStageNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsBatchCallStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsBatchCallStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsBatchRecipientStatusJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsBatchRecipientStatusNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsPhoneNumberSourceJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsPhoneNumberSourceNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsPhoneNumberCapabilityJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsPhoneNumberCapabilityNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTrunkKindJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTrunkKindNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTrunkDirectionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTrunkDirectionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTransportJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPTransportNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPMediaEncryptionJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsSIPMediaEncryptionNullableJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsAgentTestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsMCPAuthJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsToolConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateAgentTestRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsCreateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.TtsUpdateToolRequestConfigJsonConverter),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsReplyResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsToolCallResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsSimulationResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunConfigOverride, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsEvaluationStatus?, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsAgentTestSuiteRun, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunResult, object>),

            typeof(global::Speechify.JsonConverters.OneOfJsonConverter<global::Speechify.TtsTestRunConfigOverride, object>),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsErrorCode), TypeInfoPropertyName = "TtsErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsV1AudioStreamPostParametersAccept), TypeInfoPropertyName = "TtsV1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequestModel), TypeInfoPropertyName = "TtsGetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetStreamRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentRequestLlmProvider), TypeInfoPropertyName = "TtsCreateAgentRequestLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigStyle), TypeInfoPropertyName = "TtsWidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigTheme), TypeInfoPropertyName = "TtsWidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigAvatarType), TypeInfoPropertyName = "TtsWidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfigTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWidgetConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnVoicemailAction), TypeInfoPropertyName = "TtsAmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnVoicemail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnIvrAction), TypeInfoPropertyName = "TtsAmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnIvr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnUnavailableAction), TypeInfoPropertyName = "TtsAmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigOnUnavailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAmdConfigTuning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAMDConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentRequestBackgroundNoisePreset), TypeInfoPropertyName = "TtsCreateAgentRequestBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentRequestSttOverride), TypeInfoPropertyName = "TtsCreateAgentRequestSttOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentLlmProvider), TypeInfoPropertyName = "TtsAgentLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentBackgroundNoisePreset), TypeInfoPropertyName = "TtsAgentBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentSttOverride), TypeInfoPropertyName = "TtsAgentSttOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentRequestLlmProvider), TypeInfoPropertyName = "TtsUpdateAgentRequestLlmProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentRequestBackgroundNoisePreset), TypeInfoPropertyName = "TtsUpdateAgentRequestBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentRequestSttOverride), TypeInfoPropertyName = "TtsUpdateAgentRequestSttOverride2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationStatus), TypeInfoPropertyName = "TtsConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationTransport), TypeInfoPropertyName = "TtsConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationEndReason), TypeInfoPropertyName = "TtsConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentSnapshotBackgroundNoisePreset), TypeInfoPropertyName = "TtsAgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationIvrSurrenderReason), TypeInfoPropertyName = "TtsConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoiceType), TypeInfoPropertyName = "TtsAgentVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoiceModelName), TypeInfoPropertyName = "TtsAgentVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoiceLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoiceModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoiceGender), TypeInfoPropertyName = "TtsAgentVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentVoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentBuiltinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentBuiltin))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentBuiltinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentBuiltin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentBuiltinRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDynamicVariableType), TypeInfoPropertyName = "TtsDynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemVariableDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListDynamicVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateDynamicVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataCollectionFieldType), TypeInfoPropertyName = "TtsDataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataCollectionField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsEvaluationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsEvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateEvaluationConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAttachedKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMemory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDeleteMemoriesByCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDeleteMemoriesByCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestType), TypeInfoPropertyName = "TtsTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationMessageRole), TypeInfoPropertyName = "TtsSimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsReplyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheckMode), TypeInfoPropertyName = "TtsParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheck))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolCallConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataAssertionMode), TypeInfoPropertyName = "TtsDataAssertionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataAssertion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDataAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestConfig), TypeInfoPropertyName = "TtsAgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMockingStrategy), TypeInfoPropertyName = "TtsMockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolMock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsNoMatchBehavior), TypeInfoPropertyName = "TtsNoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolMockConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestRunStatus), TypeInfoPropertyName = "TtsTestRunStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsReplyResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsParameterCheckResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolCallResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationResultSentiment), TypeInfoPropertyName = "TtsSimulationResultSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationCriterionResultStatus), TypeInfoPropertyName = "TtsSimulationCriterionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationCriterionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataAssertionResultMode), TypeInfoPropertyName = "TtsDataAssertionResultMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDataAssertionResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSimulationResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSimulationCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDataAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestRunResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsReplyResult, object>), TypeInfoPropertyName = "OneOfTtsReplyResultObject2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestRunConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunAllTestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSuiteRunTrigger), TypeInfoPropertyName = "TtsSuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsTestRunConfigOverride, object>), TypeInfoPropertyName = "OneOfTtsTestRunConfigOverrideObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.OneOf<global::Speechify.TtsAgentTestSuiteRun, object>), TypeInfoPropertyName = "OneOfTtsAgentTestSuiteRunObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolKind), TypeInfoPropertyName = "TtsToolKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolParamType), TypeInfoPropertyName = "TtsToolParamType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookToolConfigMethod), TypeInfoPropertyName = "TtsWebhookToolConfigMethod2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsClientToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPTransport), TypeInfoPropertyName = "TtsMCPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuth), TypeInfoPropertyName = "TtsMCPAuth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant1Type), TypeInfoPropertyName = "TtsMCPAuthVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant2Type), TypeInfoPropertyName = "TtsMCPAuthVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthVariant3Type), TypeInfoPropertyName = "TtsMCPAuthVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPAuthDiscriminatorType), TypeInfoPropertyName = "TtsMCPAuthDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolConfig), TypeInfoPropertyName = "TtsToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAttachedToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsTool>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsConversationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRecentCallee))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListRecentCalleesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsRecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookDeliveryStatus), TypeInfoPropertyName = "TtsWebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListWebhookDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsWebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRetrievalLogResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRetrievalLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsRetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListRetrievalLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsRetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateKnowledgeBaseRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocumentSourceKind), TypeInfoPropertyName = "TtsKnowledgeBaseDocumentSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocumentStatus), TypeInfoPropertyName = "TtsKnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocument))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBaseDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDependentAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRefreshConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseDocumentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsDependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBaseChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSearchKnowledgeBasesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseSearchHit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSearchKnowledgeBasesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateTextDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateURLDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateSitemapImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsImportJobKind), TypeInfoPropertyName = "TtsImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsImportJobStatus), TypeInfoPropertyName = "TtsImportJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsImportJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsImportJobResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateCrawlImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateURLBatchImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListImportJobsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchDeleteDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchMoveDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateRefreshConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRefreshHistoryEntryStatus), TypeInfoPropertyName = "TtsRefreshHistoryEntryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRefreshHistoryEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListRefreshHistoryResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsRefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsKnowledgeBaseFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListKnowledgeBaseFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsKnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestStatsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsTestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestRequestConfig), TypeInfoPropertyName = "TtsUpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestAttachment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestAttachmentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchRunEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsBatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRunBatchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListSuiteRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSuiteChildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAgentTestSuiteRunWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateToolRequestConfig), TypeInfoPropertyName = "TtsCreateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateToolRequestConfig), TypeInfoPropertyName = "TtsUpdateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSystemBuiltinInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListSystemBuiltinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSystemBuiltinInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsToolAttachedAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListToolAttachedAgentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestMCPConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPProbeTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMcpProbeErrorDetailsStage), TypeInfoPropertyName = "TtsMcpProbeErrorDetailsStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPProbeErrorDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsMCPProbeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsMCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTestWebhookConnectionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsWebhookProbeResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCaller))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListCallersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsDeleteCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCallerMemoryItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListCallerMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsCallerMemoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListCallerConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAudioAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListAudioAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUploadAudioAssetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowVersion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraph))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPutFlowRequestNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPutFlowRequestEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPutFlowRequestVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPutFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsPutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPublishFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsRollbackFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListFlowVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetFlowVersionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGetSchemaResponse200))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowTemplate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListFlowTemplatesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphInputNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphInputEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphInputVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsFlowGraphInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsFlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCloneFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsShadowConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchRecipientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchCallStatus), TypeInfoPropertyName = "TtsBatchCallStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListBatchCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsBatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchRecipientStatus), TypeInfoPropertyName = "TtsBatchRecipientStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsBatchRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsGetBatchCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateOutboundCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPhoneNumberSource), TypeInfoPropertyName = "TtsPhoneNumberSource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsTwilioImportSpec))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsImportPhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPhoneNumberCapability), TypeInfoPropertyName = "TtsPhoneNumberCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumberCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListPhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsPhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsAvailablePhoneNumber))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSearchAvailablePhoneNumbersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsPurchasePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSIPTrunkKind), TypeInfoPropertyName = "TtsSIPTrunkKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSIPTrunkDirection), TypeInfoPropertyName = "TtsSIPTrunkDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSIPTransport), TypeInfoPropertyName = "TtsSIPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSIPMediaEncryption), TypeInfoPropertyName = "TtsSIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateSipTrunkRequestCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsCreateSIPTrunkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsSIPTrunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListSIPTrunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsSIPTrunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsIvrMenuListEntryMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsIVRMenuListEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsListIVRMenusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsIVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsIvrMenuMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsIVRMenu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsUpdateIVRMenuLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TtsInvalidateIVRMenuRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsGetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TtsAgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsNestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCreateVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentBuiltin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsEvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMemory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsParameterCheck>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDataAssertion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsToolMock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSimulationCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDataAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestWithLastRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsConversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsEvaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsRecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsWebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsRetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsRetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsDependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsRefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsKnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsTestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestAttachment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsBatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSystemBuiltinInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsMCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCaller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsCallerMemoryItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsPutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsPutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsPutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsFlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsBatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsBatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsBatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsPhoneNumberCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsPhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsSIPTrunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsIVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsGetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.TtsAgentVoice>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}