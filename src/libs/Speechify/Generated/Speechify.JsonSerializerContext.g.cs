
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestAudioFormat), TypeInfoPropertyName = "GetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestModel), TypeInfoPropertyName = "GetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioOutputFormat), TypeInfoPropertyName = "AudioOutputFormat2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamPostParametersAccept), TypeInfoPropertyName = "V1AudioStreamPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequestModel), TypeInfoPropertyName = "GetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioStreamOutputFormat), TypeInfoPropertyName = "AudioStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept), TypeInfoPropertyName = "V1AudioStreamWithTimestampsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEvent), TypeInfoPropertyName = "SpeechStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1Type), TypeInfoPropertyName = "SpeechStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2Type), TypeInfoPropertyName = "SpeechStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3Type), TypeInfoPropertyName = "SpeechStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminatorType), TypeInfoPropertyName = "SpeechStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersType), TypeInfoPropertyName = "V1VoicesGetParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersGender), TypeInfoPropertyName = "V1VoicesGetParametersGender2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConsentChallengeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConsentChallenge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Model))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WatermarkDetectionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentAdditionalLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigProvider), TypeInfoPropertyName = "AgentLlmConfigProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLLMConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTTSConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity), TypeInfoPropertyName = "AgentTurnHandlingConfigInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTurnHandlingConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentMemoryConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentNavigatorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentGuardrailsConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentBackgroundNoiseConfigPreset), TypeInfoPropertyName = "AgentBackgroundNoiseConfigPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentBackgroundNoiseConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigStyle), TypeInfoPropertyName = "WidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTheme), TypeInfoPropertyName = "WidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatarType), TypeInfoPropertyName = "WidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatar))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigText))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTerms))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTelemetry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemailAction), TypeInfoPropertyName = "AmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvrAction), TypeInfoPropertyName = "AmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvr))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailableAction), TypeInfoPropertyName = "AmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigTuning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AMDConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AIDisclosure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Agent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentAdditionalLanguage>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MultilingualLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentVoicesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.MultilingualLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTTSModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTTSModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTTSModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentPhoneNumberReferenceResourceType), TypeInfoPropertyName = "AgentPhoneNumberReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentPhoneNumberReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentPhoneNumberUsedBy))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentPhoneNumberReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentInUseErrorDetailDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentInUseErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentInUseError))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetFlowResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestNodesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestEdgesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequestVariablesItems))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PutFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationIssue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.FlowValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RollbackFlowRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListFlowVersionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.FlowVersion>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CloneFlowTemplateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterion))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionFieldType), TypeInfoPropertyName = "DataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionField))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateEvaluationConfigRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariableType), TypeInfoPropertyName = "DynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariable))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemVariableDoc))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListDynamicVariablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDynamicVariablesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationOverrides))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus), TypeInfoPropertyName = "ConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport), TypeInfoPropertyName = "ConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason), TypeInfoPropertyName = "ConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotInterruptionSensitivity), TypeInfoPropertyName = "AgentSnapshotInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset), TypeInfoPropertyName = "AgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshot))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason), TypeInfoPropertyName = "ConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Conversation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RecentCallee))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRecentCalleesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageRole), TypeInfoPropertyName = "MessageRole2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RetrievalLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListRetrievalLogsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDeliveryStatus), TypeInfoPropertyName = "WebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDelivery))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListWebhookDeliveriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.WebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShadowConversationResponse))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DependentAgent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListKnowledgeBaseChunksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateCrawlImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobKind), TypeInfoPropertyName = "ImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJob))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSitemapImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateTextDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateURLBatchImportRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchDeleteDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchMoveDocumentsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchMoveDocumentsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBaseDocumentDetail>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentToolConfig), TypeInfoPropertyName = "AgentToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequestConfig), TypeInfoPropertyName = "CreateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequestConfig), TypeInfoPropertyName = "UpdateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemBuiltinInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSystemBuiltinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SystemBuiltinInfo>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequestConfig), TypeInfoPropertyName = "UpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestFolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestFoldersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestFolderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentTestRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRunEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunBatchRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRunEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger), TypeInfoPropertyName = "SuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSuiteRunsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestSuiteRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunWithRunsResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteChildRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunWithRuns))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SuiteChildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequestConfig), TypeInfoPropertyName = "CreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAllTestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStatsBucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.TestStatsBucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkStatus), TypeInfoPropertyName = "ShareLinkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLink))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListShareLinksResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ShareLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponseStatus), TypeInfoPropertyName = "CreateShareLinkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RevealShareLinkTokenResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkPreview))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkSession))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberProvider), TypeInfoPropertyName = "PhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberRelayHealth), TypeInfoPropertyName = "PhoneNumberRelayHealth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberRelay))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberCapability), TypeInfoPropertyName = "PhoneNumberCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberReputationRisk), TypeInfoPropertyName = "PhoneNumberReputationRisk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberReputation))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IntendedUseMarketingOrInformational), TypeInfoPropertyName = "IntendedUseMarketingOrInformational2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IntendedUse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PurchasePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RelayBinding))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdatePhoneNumberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateOutboundCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateOutboundCallResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListBatchCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipientRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateBatchCallRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipientStatus), TypeInfoPropertyName = "BatchRecipientStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipient))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListBatchRecipientsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.BatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IvrMenuListEntryMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IVRMenuListEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListIVRMenusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.IVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IvrMenuMenuTree))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IVRMenu))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateIVRMenuLabelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.InvalidateIVRMenuRequest))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateCallerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteCallerResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCallerConversationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListCallerMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioAsset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAudioAssetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Project))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListProjectsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequestMode), TypeInfoPropertyName = "DeleteProjectRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectRestoredCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectStillRevokedCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectRestore))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerKind), TypeInfoPropertyName = "ProjectTeardownBlockerKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerBlocksItems), TypeInfoPropertyName = "ProjectTeardownBlockerBlocksItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlocker))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlockerBlocksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownGroup))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardown))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownBlocker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectTeardownGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectResourceCounts))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectStats))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteProjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteCreated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteReused))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionKind), TypeInfoPropertyName = "PromoteAttentionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionReason), TypeInfoPropertyName = "PromoteAttentionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttention))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.PromoteAttention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEventType), TypeInfoPropertyName = "ProjectAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectAuditEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMember))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectMembersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ProjectMember>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GrantProjectMemberRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DetectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateDocumentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunTestRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UploadRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestAudioFormat?), TypeInfoPropertyName = "NullableGetSpeechRequestAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechRequestModel?), TypeInfoPropertyName = "NullableGetSpeechRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioOutputFormat?), TypeInfoPropertyName = "NullableAudioOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetSpeechResponseAudioFormat?), TypeInfoPropertyName = "NullableGetSpeechResponseAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamPostParametersAccept?), TypeInfoPropertyName = "NullableV1AudioStreamPostParametersAccept2")]
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
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetStreamRequestModel?), TypeInfoPropertyName = "NullableGetStreamRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AudioStreamOutputFormat?), TypeInfoPropertyName = "NullableAudioStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?), TypeInfoPropertyName = "NullableV1AudioStreamWithTimestampsPostParametersAccept2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEvent?), TypeInfoPropertyName = "NullableSpeechStreamEvent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant1Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant1Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant2Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant2Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventVariant3Type?), TypeInfoPropertyName = "NullableSpeechStreamEventVariant3Type2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SpeechStreamEventDiscriminatorType?), TypeInfoPropertyName = "NullableSpeechStreamEventDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersType?), TypeInfoPropertyName = "NullableV1VoicesGetParametersType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesGetParametersGender?), TypeInfoPropertyName = "NullableV1VoicesGetParametersGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceGender?), TypeInfoPropertyName = "NullableGetVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoicesModelName?), TypeInfoPropertyName = "NullableGetVoicesModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.GetVoiceType?), TypeInfoPropertyName = "NullableGetVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?), TypeInfoPropertyName = "NullableV1VoicesPostRequestBodyContentMultipartFormDataSchemaGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigProvider?), TypeInfoPropertyName = "NullableAgentLlmConfigProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentTurnHandlingConfigInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentBackgroundNoiseConfigPreset?), TypeInfoPropertyName = "NullableAgentBackgroundNoiseConfigPreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigStyle?), TypeInfoPropertyName = "NullableWidgetConfigStyle2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigTheme?), TypeInfoPropertyName = "NullableWidgetConfigTheme2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WidgetConfigAvatarType?), TypeInfoPropertyName = "NullableWidgetConfigAvatarType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnVoicemailAction?), TypeInfoPropertyName = "NullableAmdConfigOnVoicemailAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnIvrAction?), TypeInfoPropertyName = "NullableAmdConfigOnIvrAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AmdConfigOnUnavailableAction?), TypeInfoPropertyName = "NullableAmdConfigOnUnavailableAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceType?), TypeInfoPropertyName = "NullableAgentVoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceModelName?), TypeInfoPropertyName = "NullableAgentVoiceModelName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentVoiceGender?), TypeInfoPropertyName = "NullableAgentVoiceGender2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentPhoneNumberReferenceResourceType?), TypeInfoPropertyName = "NullableAgentPhoneNumberReferenceResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionFieldType?), TypeInfoPropertyName = "NullableDataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariableType?), TypeInfoPropertyName = "NullableDynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus?), TypeInfoPropertyName = "NullableConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport?), TypeInfoPropertyName = "NullableConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason?), TypeInfoPropertyName = "NullableConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentSnapshotInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?), TypeInfoPropertyName = "NullableAgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason?), TypeInfoPropertyName = "NullableConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MessageRole?), TypeInfoPropertyName = "NullableMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationKind?), TypeInfoPropertyName = "NullableEvaluationKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationStatus?), TypeInfoPropertyName = "NullableEvaluationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.WebhookDeliveryStatus?), TypeInfoPropertyName = "NullableWebhookDeliveryStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentSourceKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseDocumentStatus?), TypeInfoPropertyName = "NullableKnowledgeBaseDocumentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ImportJobKind?), TypeInfoPropertyName = "NullableImportJobKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RefreshHistoryEntryStatus?), TypeInfoPropertyName = "NullableRefreshHistoryEntryStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentToolConfig?), TypeInfoPropertyName = "NullableAgentToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequestConfig?), TypeInfoPropertyName = "NullableCreateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequestConfig?), TypeInfoPropertyName = "NullableUpdateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolConfig?), TypeInfoPropertyName = "NullableToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateToolRequestConfig?), TypeInfoPropertyName = "NullableCreateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateToolRequestConfig?), TypeInfoPropertyName = "NullableUpdateToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.McpProbeErrorDetailsStage?), TypeInfoPropertyName = "NullableMcpProbeErrorDetailsStage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestType?), TypeInfoPropertyName = "NullableTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessageRole?), TypeInfoPropertyName = "NullableSimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckMode?), TypeInfoPropertyName = "NullableParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionMode?), TypeInfoPropertyName = "NullableDataAssertionMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestConfig?), TypeInfoPropertyName = "NullableAgentTestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MockingStrategy?), TypeInfoPropertyName = "NullableMockingStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.NoMatchBehavior?), TypeInfoPropertyName = "NullableNoMatchBehavior2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestVerdict?), TypeInfoPropertyName = "NullableTestVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationResultSentiment?), TypeInfoPropertyName = "NullableSimulationResultSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationCriterionResultStatus?), TypeInfoPropertyName = "NullableSimulationCriterionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionResultMode?), TypeInfoPropertyName = "NullableDataAssertionResultMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentTestRequestConfig?), TypeInfoPropertyName = "NullableUpdateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger?), TypeInfoPropertyName = "NullableSuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentTestRequestConfig?), TypeInfoPropertyName = "NullableCreateAgentTestRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ShareLinkStatus?), TypeInfoPropertyName = "NullableShareLinkStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateShareLinkResponseStatus?), TypeInfoPropertyName = "NullableCreateShareLinkResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberProvider?), TypeInfoPropertyName = "NullablePhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberRelayHealth?), TypeInfoPropertyName = "NullablePhoneNumberRelayHealth2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberCapability?), TypeInfoPropertyName = "NullablePhoneNumberCapability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PhoneNumberReputationRisk?), TypeInfoPropertyName = "NullablePhoneNumberReputationRisk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PurchasedPhoneNumberProvider?), TypeInfoPropertyName = "NullablePurchasedPhoneNumberProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.IntendedUseMarketingOrInformational?), TypeInfoPropertyName = "NullableIntendedUseMarketingOrInformational2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.BatchRecipientStatus?), TypeInfoPropertyName = "NullableBatchRecipientStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTrunkProvider?), TypeInfoPropertyName = "NullableSIPTrunkProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTrunkDirection?), TypeInfoPropertyName = "NullableSIPTrunkDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPTransport?), TypeInfoPropertyName = "NullableSIPTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SIPMediaEncryption?), TypeInfoPropertyName = "NullableSIPMediaEncryption2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DeleteProjectRequestMode?), TypeInfoPropertyName = "NullableDeleteProjectRequestMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerKind?), TypeInfoPropertyName = "NullableProjectTeardownBlockerKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?), TypeInfoPropertyName = "NullableProjectTeardownBlockerBlocksItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionKind?), TypeInfoPropertyName = "NullablePromoteAttentionKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PromoteAttentionReason?), TypeInfoPropertyName = "NullablePromoteAttentionReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ProjectAuditEventType?), TypeInfoPropertyName = "NullableProjectAuditEventType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.NestedChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoicesModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.GetVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Model>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentAdditionalLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.MultilingualLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTTSModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentPhoneNumberReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PutFlowRequestVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowValidationIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowVersion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowTemplate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputNodesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputEdgesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.FlowGraphInputVariablesItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Conversation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RecentCallee>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Message>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Evaluation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RetrievalLogEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.WebhookDelivery>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseSearchHit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseDocument>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DependentAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseDocumentDetail>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.RefreshHistoryEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBaseFolder>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ImportJob>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolAttachedAgent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.MCPProbeTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemBuiltinInfo>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ShareLink>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PhoneNumberCapability>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AvailablePhoneNumber>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRecipientRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.BatchRecipient>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.IVRMenuListEntry>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SIPTrunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Caller>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AudioAsset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Project>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownBlockerBlocksItems>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownBlocker>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectTeardownGroup>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.PromoteAttention>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectAuditEvent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ProjectMember>))]
    internal sealed partial class SourceGenerationContextChunk1 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

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
            options.Converters.Add(new global::Speechify.JsonConverters.SpeechStreamEventJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.MCPAuthJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.ToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.AgentTestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentTestRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentTestRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UnixTimestampJsonConverter());

            options.Converters.Add(new LazyEnumJsonConverterFactory());

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat?)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestModel)

                    || typeToConvert == typeof(global::Speechify.GetSpeechRequestModel?)

                    || typeToConvert == typeof(global::Speechify.AudioOutputFormat)

                    || typeToConvert == typeof(global::Speechify.AudioOutputFormat?)

                    || typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat)

                    || typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat?)

                    || typeToConvert == typeof(global::Speechify.ErrorCode)

                    || typeToConvert == typeof(global::Speechify.ErrorCode?)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept?)

                    || typeToConvert == typeof(global::Speechify.GetStreamRequestModel)

                    || typeToConvert == typeof(global::Speechify.GetStreamRequestModel?)

                    || typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat)

                    || typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat?)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept)

                    || typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type?)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType)

                    || typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender)

                    || typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender?)

                    || typeToConvert == typeof(global::Speechify.GetVoiceGender)

                    || typeToConvert == typeof(global::Speechify.GetVoiceGender?)

                    || typeToConvert == typeof(global::Speechify.GetVoicesModelName)

                    || typeToConvert == typeof(global::Speechify.GetVoicesModelName?)

                    || typeToConvert == typeof(global::Speechify.GetVoiceType)

                    || typeToConvert == typeof(global::Speechify.GetVoiceType?)

                    || typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender)

                    || typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?)

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider)

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider?)

                    || typeToConvert == typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity)

                    || typeToConvert == typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity?)

                    || typeToConvert == typeof(global::Speechify.AgentBackgroundNoiseConfigPreset)

                    || typeToConvert == typeof(global::Speechify.AgentBackgroundNoiseConfigPreset?)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigStyle)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigStyle?)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigTheme)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigTheme?)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType)

                    || typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnVoicemailAction?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnIvrAction?)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction)

                    || typeToConvert == typeof(global::Speechify.AmdConfigOnUnavailableAction?)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceType)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceType?)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceModelName)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceModelName?)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceGender)

                    || typeToConvert == typeof(global::Speechify.AgentVoiceGender?)

                    || typeToConvert == typeof(global::Speechify.AgentPhoneNumberReferenceResourceType)

                    || typeToConvert == typeof(global::Speechify.AgentPhoneNumberReferenceResourceType?)

                    || typeToConvert == typeof(global::Speechify.DataCollectionFieldType)

                    || typeToConvert == typeof(global::Speechify.DataCollectionFieldType?)

                    || typeToConvert == typeof(global::Speechify.DynamicVariableType)

                    || typeToConvert == typeof(global::Speechify.DynamicVariableType?)

                    || typeToConvert == typeof(global::Speechify.ConversationStatus)

                    || typeToConvert == typeof(global::Speechify.ConversationStatus?)

                    || typeToConvert == typeof(global::Speechify.ConversationTransport)

                    || typeToConvert == typeof(global::Speechify.ConversationTransport?)

                    || typeToConvert == typeof(global::Speechify.ConversationEndReason)

                    || typeToConvert == typeof(global::Speechify.ConversationEndReason?)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset)

                    || typeToConvert == typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?)

                    || typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason)

                    || typeToConvert == typeof(global::Speechify.ConversationIvrSurrenderReason?)

                    || typeToConvert == typeof(global::Speechify.MessageRole)

                    || typeToConvert == typeof(global::Speechify.MessageRole?)

                    || typeToConvert == typeof(global::Speechify.EvaluationKind)

                    || typeToConvert == typeof(global::Speechify.EvaluationKind?)

                    || typeToConvert == typeof(global::Speechify.EvaluationStatus)

                    || typeToConvert == typeof(global::Speechify.EvaluationStatus?)

                    || typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus)

                    || typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus)

                    || typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus?)

                    || typeToConvert == typeof(global::Speechify.ImportJobKind)

                    || typeToConvert == typeof(global::Speechify.ImportJobKind?)

                    || typeToConvert == typeof(global::Speechify.JobStatus)

                    || typeToConvert == typeof(global::Speechify.JobStatus?)

                    || typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus)

                    || typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus?)

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

                    || typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage)

                    || typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage?)

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

                    || typeToConvert == typeof(global::Speechify.SuiteRunTrigger?)

                    || typeToConvert == typeof(global::Speechify.ShareLinkStatus)

                    || typeToConvert == typeof(global::Speechify.ShareLinkStatus?)

                    || typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus)

                    || typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus?)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberProvider)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberProvider?)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberRelayHealth)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberRelayHealth?)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberCapability)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberCapability?)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberReputationRisk)

                    || typeToConvert == typeof(global::Speechify.PhoneNumberReputationRisk?)

                    || typeToConvert == typeof(global::Speechify.PurchasedPhoneNumberProvider)

                    || typeToConvert == typeof(global::Speechify.PurchasedPhoneNumberProvider?)

                    || typeToConvert == typeof(global::Speechify.IntendedUseMarketingOrInformational)

                    || typeToConvert == typeof(global::Speechify.IntendedUseMarketingOrInformational?)

                    || typeToConvert == typeof(global::Speechify.BatchRecipientStatus)

                    || typeToConvert == typeof(global::Speechify.BatchRecipientStatus?)

                    || typeToConvert == typeof(global::Speechify.SIPTrunkProvider)

                    || typeToConvert == typeof(global::Speechify.SIPTrunkProvider?)

                    || typeToConvert == typeof(global::Speechify.SIPTrunkDirection)

                    || typeToConvert == typeof(global::Speechify.SIPTrunkDirection?)

                    || typeToConvert == typeof(global::Speechify.SIPTransport)

                    || typeToConvert == typeof(global::Speechify.SIPTransport?)

                    || typeToConvert == typeof(global::Speechify.SIPMediaEncryption)

                    || typeToConvert == typeof(global::Speechify.SIPMediaEncryption?)

                    || typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode)

                    || typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode?)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind?)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems)

                    || typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionKind)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionKind?)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionReason)

                    || typeToConvert == typeof(global::Speechify.PromoteAttentionReason?)

                    || typeToConvert == typeof(global::Speechify.ProjectAuditEventType)

                    || typeToConvert == typeof(global::Speechify.ProjectAuditEventType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestAudioFormat?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestModel))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechRequestModel?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioOutputFormat))
                {
                    return new global::Speechify.JsonConverters.AudioOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioOutputFormat?))
                {
                    return new global::Speechify.JsonConverters.AudioOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat))
                {
                    return new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetSpeechResponseAudioFormat?))
                {
                    return new global::Speechify.JsonConverters.GetSpeechResponseAudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ErrorCode?))
                {
                    return new global::Speechify.JsonConverters.ErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamPostParametersAccept?))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamPostParametersAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetStreamRequestModel))
                {
                    return new global::Speechify.JsonConverters.GetStreamRequestModelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetStreamRequestModel?))
                {
                    return new global::Speechify.JsonConverters.GetStreamRequestModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat))
                {
                    return new global::Speechify.JsonConverters.AudioStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AudioStreamOutputFormat?))
                {
                    return new global::Speechify.JsonConverters.AudioStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamWithTimestampsPostParametersAcceptJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1AudioStreamWithTimestampsPostParametersAccept?))
                {
                    return new global::Speechify.JsonConverters.V1AudioStreamWithTimestampsPostParametersAcceptNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant1TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant1Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant1TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant2TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant2Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant2TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant3TypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventVariant3Type?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventVariant3TypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SpeechStreamEventDiscriminatorType?))
                {
                    return new global::Speechify.JsonConverters.SpeechStreamEventDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersType?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesGetParametersGender?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesGetParametersGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceGender))
                {
                    return new global::Speechify.JsonConverters.GetVoiceGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceGender?))
                {
                    return new global::Speechify.JsonConverters.GetVoiceGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoicesModelName))
                {
                    return new global::Speechify.JsonConverters.GetVoicesModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoicesModelName?))
                {
                    return new global::Speechify.JsonConverters.GetVoicesModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceType))
                {
                    return new global::Speechify.JsonConverters.GetVoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.GetVoiceType?))
                {
                    return new global::Speechify.JsonConverters.GetVoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender))
                {
                    return new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGender?))
                {
                    return new global::Speechify.JsonConverters.V1VoicesPostRequestBodyContentMultipartFormDataSchemaGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider?))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity))
                {
                    return new global::Speechify.JsonConverters.AgentTurnHandlingConfigInterruptionSensitivityJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentTurnHandlingConfigInterruptionSensitivity?))
                {
                    return new global::Speechify.JsonConverters.AgentTurnHandlingConfigInterruptionSensitivityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentBackgroundNoiseConfigPreset))
                {
                    return new global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentBackgroundNoiseConfigPreset?))
                {
                    return new global::Speechify.JsonConverters.AgentBackgroundNoiseConfigPresetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigStyle))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigStyleJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigStyle?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigStyleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigTheme))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigThemeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigTheme?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigThemeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigAvatarTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WidgetConfigAvatarType?))
                {
                    return new global::Speechify.JsonConverters.WidgetConfigAvatarTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.AgentVoiceType))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentVoiceType?))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentVoiceModelName))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceModelNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentVoiceModelName?))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceModelNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentVoiceGender))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceGenderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentVoiceGender?))
                {
                    return new global::Speechify.JsonConverters.AgentVoiceGenderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentPhoneNumberReferenceResourceType))
                {
                    return new global::Speechify.JsonConverters.AgentPhoneNumberReferenceResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentPhoneNumberReferenceResourceType?))
                {
                    return new global::Speechify.JsonConverters.AgentPhoneNumberReferenceResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataCollectionFieldType))
                {
                    return new global::Speechify.JsonConverters.DataCollectionFieldTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DataCollectionFieldType?))
                {
                    return new global::Speechify.JsonConverters.DataCollectionFieldTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DynamicVariableType))
                {
                    return new global::Speechify.JsonConverters.DynamicVariableTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DynamicVariableType?))
                {
                    return new global::Speechify.JsonConverters.DynamicVariableTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.ConversationEndReason))
                {
                    return new global::Speechify.JsonConverters.ConversationEndReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ConversationEndReason?))
                {
                    return new global::Speechify.JsonConverters.ConversationEndReasonNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus))
                {
                    return new global::Speechify.JsonConverters.WebhookDeliveryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.WebhookDeliveryStatus?))
                {
                    return new global::Speechify.JsonConverters.WebhookDeliveryStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentSourceKind?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentSourceKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.KnowledgeBaseDocumentStatus?))
                {
                    return new global::Speechify.JsonConverters.KnowledgeBaseDocumentStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ImportJobKind))
                {
                    return new global::Speechify.JsonConverters.ImportJobKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ImportJobKind?))
                {
                    return new global::Speechify.JsonConverters.ImportJobKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus))
                {
                    return new global::Speechify.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus?))
                {
                    return new global::Speechify.JsonConverters.JobStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus))
                {
                    return new global::Speechify.JsonConverters.RefreshHistoryEntryStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.RefreshHistoryEntryStatus?))
                {
                    return new global::Speechify.JsonConverters.RefreshHistoryEntryStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage))
                {
                    return new global::Speechify.JsonConverters.McpProbeErrorDetailsStageJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.McpProbeErrorDetailsStage?))
                {
                    return new global::Speechify.JsonConverters.McpProbeErrorDetailsStageNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.ShareLinkStatus))
                {
                    return new global::Speechify.JsonConverters.ShareLinkStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ShareLinkStatus?))
                {
                    return new global::Speechify.JsonConverters.ShareLinkStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus))
                {
                    return new global::Speechify.JsonConverters.CreateShareLinkResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.CreateShareLinkResponseStatus?))
                {
                    return new global::Speechify.JsonConverters.CreateShareLinkResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberProvider))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberProvider?))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberRelayHealth))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberRelayHealthJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberRelayHealth?))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberRelayHealthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberCapability))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberCapabilityJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberCapability?))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberCapabilityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberReputationRisk))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberReputationRiskJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PhoneNumberReputationRisk?))
                {
                    return new global::Speechify.JsonConverters.PhoneNumberReputationRiskNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PurchasedPhoneNumberProvider))
                {
                    return new global::Speechify.JsonConverters.PurchasedPhoneNumberProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PurchasedPhoneNumberProvider?))
                {
                    return new global::Speechify.JsonConverters.PurchasedPhoneNumberProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.IntendedUseMarketingOrInformational))
                {
                    return new global::Speechify.JsonConverters.IntendedUseMarketingOrInformationalJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.IntendedUseMarketingOrInformational?))
                {
                    return new global::Speechify.JsonConverters.IntendedUseMarketingOrInformationalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.BatchRecipientStatus))
                {
                    return new global::Speechify.JsonConverters.BatchRecipientStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.BatchRecipientStatus?))
                {
                    return new global::Speechify.JsonConverters.BatchRecipientStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTrunkProvider))
                {
                    return new global::Speechify.JsonConverters.SIPTrunkProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTrunkProvider?))
                {
                    return new global::Speechify.JsonConverters.SIPTrunkProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTrunkDirection))
                {
                    return new global::Speechify.JsonConverters.SIPTrunkDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTrunkDirection?))
                {
                    return new global::Speechify.JsonConverters.SIPTrunkDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTransport))
                {
                    return new global::Speechify.JsonConverters.SIPTransportJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPTransport?))
                {
                    return new global::Speechify.JsonConverters.SIPTransportNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPMediaEncryption))
                {
                    return new global::Speechify.JsonConverters.SIPMediaEncryptionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SIPMediaEncryption?))
                {
                    return new global::Speechify.JsonConverters.SIPMediaEncryptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode))
                {
                    return new global::Speechify.JsonConverters.DeleteProjectRequestModeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.DeleteProjectRequestMode?))
                {
                    return new global::Speechify.JsonConverters.DeleteProjectRequestModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerKind?))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerBlocksItemsJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectTeardownBlockerBlocksItems?))
                {
                    return new global::Speechify.JsonConverters.ProjectTeardownBlockerBlocksItemsNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionKind))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionKindJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionKind?))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionReason))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionReasonJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PromoteAttentionReason?))
                {
                    return new global::Speechify.JsonConverters.PromoteAttentionReasonNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectAuditEventType))
                {
                    return new global::Speechify.JsonConverters.ProjectAuditEventTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.ProjectAuditEventType?))
                {
                    return new global::Speechify.JsonConverters.ProjectAuditEventTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => new SourceGenerationContextChunk1(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}