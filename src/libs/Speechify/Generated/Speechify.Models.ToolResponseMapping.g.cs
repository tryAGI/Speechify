
#nullable enable

namespace Speechify
{
    /// <summary>
    /// What a tool's JSON result passes through before the agent reads it,<br/>
    /// applied in the order `max_items`, `pick`, `derive`, on the platform<br/>
    /// and before the result is trimmed to the observation window. One path<br/>
    /// grammar serves `pick` and the keys of `derive`: dot-separated names of<br/>
    /// letters, digits, `_` and `-`, each optionally followed by `[]` for<br/>
    /// every element (`issues[].id`; `[].id` for a root array). A `derive`<br/>
    /// value is free text with `{{path}}` placeholders resolved relative to<br/>
    /// the object its key's scope selects, and nothing else: there is no<br/>
    /// expression language (no filters, conditionals, arithmetic, JSONata or<br/>
    /// jq); anything richer belongs in your own connector. A result that is<br/>
    /// not JSON passes through untouched.
    /// </summary>
    public sealed partial class ToolResponseMapping
    {
        /// <summary>
        /// The paths to keep, structure-preserving: `issues[].id` keeps<br/>
        /// `issues` as an array whose objects hold only `id`. A path the<br/>
        /// result does not have leaves nothing, silently; an empty list keeps<br/>
        /// everything. Preview with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` and read<br/>
        /// `mapped`, since a `pick` whose every path missed still changes the<br/>
        /// answer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pick")]
        public global::System.Collections.Generic.IList<string>? Pick { get; set; }

        /// <summary>
        /// Fields to add, keyed by where they land: the last segment is the<br/>
        /// field name, the segments before it the scope, so `issues[].url`<br/>
        /// adds `url` to every issue and `summary_url` adds it at the root.<br/>
        /// The value is a template whose `{{path}}` placeholders resolve<br/>
        /// relative to that scope; a missing value renders empty. A field the<br/>
        /// result already has is never overwritten.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("derive")]
        public global::System.Collections.Generic.Dictionary<string, string>? Derive { get; set; }

        /// <summary>
        /// Keep only the first N elements of a root array, or of every<br/>
        /// top-level array of a root object. Applied before `pick`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_items")]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseMapping" /> class.
        /// </summary>
        /// <param name="pick">
        /// The paths to keep, structure-preserving: `issues[].id` keeps<br/>
        /// `issues` as an array whose objects hold only `id`. A path the<br/>
        /// result does not have leaves nothing, silently; an empty list keeps<br/>
        /// everything. Preview with<br/>
        /// `POST /v1/agents/tool-definitions/test-openapi-call` and read<br/>
        /// `mapped`, since a `pick` whose every path missed still changes the<br/>
        /// answer.
        /// </param>
        /// <param name="derive">
        /// Fields to add, keyed by where they land: the last segment is the<br/>
        /// field name, the segments before it the scope, so `issues[].url`<br/>
        /// adds `url` to every issue and `summary_url` adds it at the root.<br/>
        /// The value is a template whose `{{path}}` placeholders resolve<br/>
        /// relative to that scope; a missing value renders empty. A field the<br/>
        /// result already has is never overwritten.
        /// </param>
        /// <param name="maxItems">
        /// Keep only the first N elements of a root array, or of every<br/>
        /// top-level array of a root object. Applied before `pick`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolResponseMapping(
            global::System.Collections.Generic.IList<string>? pick,
            global::System.Collections.Generic.Dictionary<string, string>? derive,
            int? maxItems)
        {
            this.Pick = pick;
            this.Derive = derive;
            this.MaxItems = maxItems;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolResponseMapping" /> class.
        /// </summary>
        public ToolResponseMapping()
        {
        }

    }
}