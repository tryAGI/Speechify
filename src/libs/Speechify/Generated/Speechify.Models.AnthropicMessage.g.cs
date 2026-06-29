
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Anthropic-compatible Messages response. Carries the standard Anthropic<br/>
    /// fields (`id`, `type`, `role`, `content`, `usage`, …) plus a `waymark`<br/>
    /// object describing the upstream models that ran. Standard Anthropic<br/>
    /// clients ignore the extra field.
    /// </summary>
    public sealed partial class AnthropicMessage
    {
        /// <summary>
        /// Unique identifier for the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, always `message`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The conversational role of the generated message, always `assistant`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The route that served the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The generated content blocks, in Anthropic format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Content { get; set; }

        /// <summary>
        /// The reason generation stopped (e.g. `end_turn`, `max_tokens`,<br/>
        /// `stop_sequence`); null while a streamed message is still in flight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        public string? StopReason { get; set; }

        /// <summary>
        /// The custom stop sequence that was generated, if any; otherwise null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Anthropic token-usage totals for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Speechify.AnthropicMessageUsage? Usage { get; set; }

        /// <summary>
        /// Per-request routing and token breakdown. Reports the route taken,<br/>
        /// whether it escalated, and the input, output, and cached-input token counts for each<br/>
        /// upstream model that ran. Token counts only — no pricing or cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("waymark")]
        public global::Speechify.WaymarkUsage? Waymark { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the message.
        /// </param>
        /// <param name="type">
        /// The object type, always `message`.
        /// </param>
        /// <param name="role">
        /// The conversational role of the generated message, always `assistant`.
        /// </param>
        /// <param name="content">
        /// The generated content blocks, in Anthropic format.
        /// </param>
        /// <param name="model">
        /// The route that served the request.
        /// </param>
        /// <param name="stopReason">
        /// The reason generation stopped (e.g. `end_turn`, `max_tokens`,<br/>
        /// `stop_sequence`); null while a streamed message is still in flight.
        /// </param>
        /// <param name="stopSequence">
        /// The custom stop sequence that was generated, if any; otherwise null.
        /// </param>
        /// <param name="usage">
        /// Anthropic token-usage totals for the request.
        /// </param>
        /// <param name="waymark">
        /// Per-request routing and token breakdown. Reports the route taken,<br/>
        /// whether it escalated, and the input, output, and cached-input token counts for each<br/>
        /// upstream model that ran. Token counts only — no pricing or cost.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessage(
            string id,
            string type,
            string role,
            global::System.Collections.Generic.IList<object> content,
            string? model,
            string? stopReason,
            string? stopSequence,
            global::Speechify.AnthropicMessageUsage? usage,
            global::Speechify.WaymarkUsage? waymark)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Model = model;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage;
            this.Waymark = waymark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        public AnthropicMessage()
        {
        }

    }
}