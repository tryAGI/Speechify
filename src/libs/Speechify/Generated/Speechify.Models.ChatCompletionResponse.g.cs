
#nullable enable

namespace Speechify
{
    /// <summary>
    /// OpenAI-compatible chat completion. Carries the standard OpenAI fields<br/>
    /// (`id`, `choices`, `usage`, …) plus a `waymark` object describing the<br/>
    /// upstream models that ran. Standard OpenAI clients ignore the extra<br/>
    /// field.
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// Unique identifier for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, always `chat.completion`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Unix timestamp (seconds) of when the completion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The route that served the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The list of completion choices, in OpenAI format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Choices { get; set; }

        /// <summary>
        /// Standard OpenAI token-usage totals for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public object? Usage { get; set; }

        /// <summary>
        /// Per-request routing and token breakdown. Reports the route taken,<br/>
        /// whether it escalated, and the input/output token counts for each<br/>
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
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the chat completion.
        /// </param>
        /// <param name="choices">
        /// The list of completion choices, in OpenAI format.
        /// </param>
        /// <param name="object">
        /// The object type, always `chat.completion`.
        /// </param>
        /// <param name="created">
        /// Unix timestamp (seconds) of when the completion was created.
        /// </param>
        /// <param name="model">
        /// The route that served the request.
        /// </param>
        /// <param name="usage">
        /// Standard OpenAI token-usage totals for the request.
        /// </param>
        /// <param name="waymark">
        /// Per-request routing and token breakdown. Reports the route taken,<br/>
        /// whether it escalated, and the input/output token counts for each<br/>
        /// upstream model that ran. Token counts only — no pricing or cost.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string id,
            global::System.Collections.Generic.IList<object> choices,
            string? @object,
            global::System.DateTimeOffset? created,
            string? model,
            object? usage,
            global::Speechify.WaymarkUsage? waymark)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices ?? throw new global::System.ArgumentNullException(nameof(choices));
            this.Usage = usage;
            this.Waymark = waymark;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }

    }
}