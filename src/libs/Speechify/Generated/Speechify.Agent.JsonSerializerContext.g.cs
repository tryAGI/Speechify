
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode), TypeInfoPropertyName = "ErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentChannel), TypeInfoPropertyName = "AgentChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentAdditionalLanguage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigProvider), TypeInfoPropertyName = "AgentLlmConfigProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigReasoningEffort), TypeInfoPropertyName = "AgentLlmConfigReasoningEffort2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentChannel>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResultDecision), TypeInfoPropertyName = "PublishGateResultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictOutcome), TypeInfoPropertyName = "EvaluationCaseVerdictOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictFault), TypeInfoPropertyName = "EvaluationCaseVerdictFault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdictStatus), TypeInfoPropertyName = "EvaluationCriterionVerdictStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCriterionVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationVerdict))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.EvaluationCaseVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResult))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateConversationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.Memory))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListMemoriesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus), TypeInfoPropertyName = "JobStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBaseInjection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.KnowledgeBase))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AttachedKnowledgeBasesResponseInjection))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolActionClass), TypeInfoPropertyName = "ToolActionClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.MCPToolConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Speechify.ToolActionClass>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentToolConfig), TypeInfoPropertyName = "AgentToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolApprovalClass), TypeInfoPropertyName = "ToolApprovalClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolReach), TypeInfoPropertyName = "ToolReach2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.ToolReach>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListAgentToolsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequestConfig), TypeInfoPropertyName = "CreateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolderKind), TypeInfoPropertyName = "ToolNameHolderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolder))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenErrorDetailDetails))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenErrorDetail))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameTakenError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequestConfig), TypeInfoPropertyName = "UpdateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemBuiltinInfoExecution), TypeInfoPropertyName = "SystemBuiltinInfoExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemBuiltinInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ListSystemBuiltinsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SystemBuiltinInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestType), TypeInfoPropertyName = "TestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessageRole), TypeInfoPropertyName = "SimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.SimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckMode), TypeInfoPropertyName = "ParameterCheckMode2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Speechify.AgentTestRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestRunConfigOverride))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger), TypeInfoPropertyName = "SuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRunResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentTestSuiteRun))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAgentTestsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.RunAllTestsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ErrorCode?), TypeInfoPropertyName = "NullableErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentChannel?), TypeInfoPropertyName = "NullableAgentChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigProvider?), TypeInfoPropertyName = "NullableAgentLlmConfigProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentLlmConfigReasoningEffort?), TypeInfoPropertyName = "NullableAgentLlmConfigReasoningEffort2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.PublishGateResultDecision?), TypeInfoPropertyName = "NullablePublishGateResultDecision2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictOutcome?), TypeInfoPropertyName = "NullableEvaluationCaseVerdictOutcome2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCaseVerdictFault?), TypeInfoPropertyName = "NullableEvaluationCaseVerdictFault2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.EvaluationCriterionVerdictStatus?), TypeInfoPropertyName = "NullableEvaluationCriterionVerdictStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataCollectionFieldType?), TypeInfoPropertyName = "NullableDataCollectionFieldType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DynamicVariableType?), TypeInfoPropertyName = "NullableDynamicVariableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationStatus?), TypeInfoPropertyName = "NullableConversationStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationTransport?), TypeInfoPropertyName = "NullableConversationTransport2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationChannel?), TypeInfoPropertyName = "NullableConversationChannel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationEndReason?), TypeInfoPropertyName = "NullableConversationEndReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotReasoningEffort?), TypeInfoPropertyName = "NullableAgentSnapshotReasoningEffort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotInterruptionSensitivity?), TypeInfoPropertyName = "NullableAgentSnapshotInterruptionSensitivity2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentSnapshotBackgroundNoisePreset?), TypeInfoPropertyName = "NullableAgentSnapshotBackgroundNoisePreset2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ConversationIvrSurrenderReason?), TypeInfoPropertyName = "NullableConversationIvrSurrenderReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.JobStatus?), TypeInfoPropertyName = "NullableJobStatus2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.AgentToolConfig?), TypeInfoPropertyName = "NullableAgentToolConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolApprovalClass?), TypeInfoPropertyName = "NullableToolApprovalClass2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolReach?), TypeInfoPropertyName = "NullableToolReach2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.CreateAgentToolRequestConfig?), TypeInfoPropertyName = "NullableCreateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ToolNameHolderKind?), TypeInfoPropertyName = "NullableToolNameHolderKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.UpdateAgentToolRequestConfig?), TypeInfoPropertyName = "NullableUpdateAgentToolRequestConfig2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SystemBuiltinInfoExecution?), TypeInfoPropertyName = "NullableSystemBuiltinInfoExecution2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestType?), TypeInfoPropertyName = "NullableTestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationMessageRole?), TypeInfoPropertyName = "NullableSimulationMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.ParameterCheckMode?), TypeInfoPropertyName = "NullableParameterCheckMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.TestVerdict?), TypeInfoPropertyName = "NullableTestVerdict2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationResultSentiment?), TypeInfoPropertyName = "NullableSimulationResultSentiment2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SimulationCriterionResultStatus?), TypeInfoPropertyName = "NullableSimulationCriterionResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.DataAssertionResultMode?), TypeInfoPropertyName = "NullableDataAssertionResultMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Speechify.SuiteRunTrigger?), TypeInfoPropertyName = "NullableSuiteRunTrigger2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentChannel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentAdditionalLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Agent>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoiceModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentVoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.MultilingualLanguage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTTSModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentPhoneNumberReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCriterionVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCaseVerdict>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.EvaluationCriterion>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataCollectionField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DynamicVariable>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemVariableDoc>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SkillPin>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.Memory>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.KnowledgeBase>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolParam>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ToolReach>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SystemBuiltinInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.ParameterCheckResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.SimulationCriterionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.DataAssertionResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Speechify.AgentTestRun>))]
    internal sealed partial class AgentSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AgentSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AgentSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Speechify.JsonConverters.AgentToolConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.CreateAgentToolRequestConfigJsonConverter());
            options.Converters.Add(new global::Speechify.JsonConverters.UpdateAgentToolRequestConfigJsonConverter());
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

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider)

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider?)

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigReasoningEffort)

                    || typeToConvert == typeof(global::Speechify.AgentLlmConfigReasoningEffort?)

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

                    || typeToConvert == typeof(global::Speechify.PublishGateResultDecision)

                    || typeToConvert == typeof(global::Speechify.PublishGateResultDecision?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault)

                    || typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault?)

                    || typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus)

                    || typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus?)

                    || typeToConvert == typeof(global::Speechify.DataCollectionFieldType)

                    || typeToConvert == typeof(global::Speechify.DataCollectionFieldType?)

                    || typeToConvert == typeof(global::Speechify.DynamicVariableType)

                    || typeToConvert == typeof(global::Speechify.DynamicVariableType?)

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

                    || typeToConvert == typeof(global::Speechify.JobStatus)

                    || typeToConvert == typeof(global::Speechify.JobStatus?)

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

                    || typeToConvert == typeof(global::Speechify.ToolApprovalClass)

                    || typeToConvert == typeof(global::Speechify.ToolApprovalClass?)

                    || typeToConvert == typeof(global::Speechify.ToolReach)

                    || typeToConvert == typeof(global::Speechify.ToolReach?)

                    || typeToConvert == typeof(global::Speechify.ToolNameHolderKind)

                    || typeToConvert == typeof(global::Speechify.ToolNameHolderKind?)

                    || typeToConvert == typeof(global::Speechify.SystemBuiltinInfoExecution)

                    || typeToConvert == typeof(global::Speechify.SystemBuiltinInfoExecution?)

                    || typeToConvert == typeof(global::Speechify.TestType)

                    || typeToConvert == typeof(global::Speechify.TestType?)

                    || typeToConvert == typeof(global::Speechify.SimulationMessageRole)

                    || typeToConvert == typeof(global::Speechify.SimulationMessageRole?)

                    || typeToConvert == typeof(global::Speechify.ParameterCheckMode)

                    || typeToConvert == typeof(global::Speechify.ParameterCheckMode?)

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

                if (typeToConvert == typeof(global::Speechify.AgentChannel))
                {
                    return new global::Speechify.JsonConverters.AgentChannelJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentChannel?))
                {
                    return new global::Speechify.JsonConverters.AgentChannelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigProvider?))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigReasoningEffort))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigReasoningEffortJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.AgentLlmConfigReasoningEffort?))
                {
                    return new global::Speechify.JsonConverters.AgentLlmConfigReasoningEffortNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.PublishGateResultDecision))
                {
                    return new global::Speechify.JsonConverters.PublishGateResultDecisionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.PublishGateResultDecision?))
                {
                    return new global::Speechify.JsonConverters.PublishGateResultDecisionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictOutcomeJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictOutcome?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictOutcomeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictFaultJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCaseVerdictFault?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCaseVerdictFaultNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus))
                {
                    return new global::Speechify.JsonConverters.EvaluationCriterionVerdictStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.EvaluationCriterionVerdictStatus?))
                {
                    return new global::Speechify.JsonConverters.EvaluationCriterionVerdictStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.JobStatus))
                {
                    return new global::Speechify.JsonConverters.JobStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.JobStatus?))
                {
                    return new global::Speechify.JsonConverters.JobStatusNullableJsonConverter();
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

                if (typeToConvert == typeof(global::Speechify.SystemBuiltinInfoExecution))
                {
                    return new global::Speechify.JsonConverters.SystemBuiltinInfoExecutionJsonConverter();
                }

                if (typeToConvert == typeof(global::Speechify.SystemBuiltinInfoExecution?))
                {
                    return new global::Speechify.JsonConverters.SystemBuiltinInfoExecutionNullableJsonConverter();
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
                    0 => new AgentSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}