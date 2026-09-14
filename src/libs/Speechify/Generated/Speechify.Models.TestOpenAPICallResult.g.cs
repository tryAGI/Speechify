
#nullable enable

namespace Speechify
{
    /// <summary>
    /// One test call's result. `error` is set only when no call was made, and<br/>
    /// then every other field but `applied` is absent. Otherwise `outcome`<br/>
    /// says how the call ended, and only `ok` is a preview that worked; `raw`<br/>
    /// and `mapped` are present only on `ok` when the vendor answered JSON.
    /// </summary>
    public sealed partial class TestOpenAPICallResult
    {
        /// <summary>
        /// Exactly what the agent would read. On `ok` it is the mapped answer<br/>
        /// trimmed to the observation window; on any other outcome it is the<br/>
        /// account the agent gets instead (the vendor's status and an excerpt<br/>
        /// of its error body, the wait to observe, the argument that was<br/>
        /// missing). Absent when `error` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("observation")]
        public string? Observation { get; set; }

        /// <summary>
        /// The vendor's JSON answer as it came, before the operation's<br/>
        /// `response` mapping. Present only when `outcome` is `ok` and the<br/>
        /// vendor answered JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw")]
        public object? Raw { get; set; }

        /// <summary>
        /// The same answer after the operation's `response` mapping and<br/>
        /// before trimming: what a hosted API `tool` route would respond with.<br/>
        /// Identical to `raw` when the operation has no mapping or the mapping<br/>
        /// changed nothing. Present only when `outcome` is `ok` and the vendor<br/>
        /// answered JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mapped")]
        public object? Mapped { get; set; }

        /// <summary>
        /// Whether the `response` mapping changed the answer. It is also true<br/>
        /// when every `pick` path missed and the answer became empty, so read<br/>
        /// `mapped` to see what survives. Always false when `error` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Applied { get; set; }

        /// <summary>
        /// The vendor's HTTP status, the value a hosted API `tool` route<br/>
        /// reports as `error.details.upstream_status`. Absent when the call<br/>
        /// never reached the vendor (`invalid_arguments`, `unreachable`) and<br/>
        /// when `error` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// How a call that was made ended. Absent when `error` is set.<br/>
        /// - `ok`: the vendor answered with a success status. The only<br/>
        ///   outcome that previews a working call.<br/>
        /// - `invalid_arguments`: the arguments did not fit the operation (a<br/>
        ///   required param or body missing, a value that cannot be placed on<br/>
        ///   the request), so nothing was sent. Fix `arguments`, or the<br/>
        ///   operation's `params`.<br/>
        /// - `rate_limited`: the vendor answered 429. `observation` carries<br/>
        ///   the wait it asked for.<br/>
        /// - `upstream_error`: the vendor answered 4xx or 5xx. `status` is the<br/>
        ///   code and `observation` carries an excerpt of the body; a 401 or<br/>
        ///   403 usually means the credential or its scopes, a 404 the path or<br/>
        ///   `base_url`.<br/>
        /// - `unreachable`: the vendor could not be reached, or its answer<br/>
        ///   could not be read (DNS, TLS, timeout, an address the platform<br/>
        ///   refuses to call).<br/>
        /// - `unsupported_response`: the vendor answered a media type the<br/>
        ///   agent cannot read (not JSON or text). `status` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.TestOpenApiCallResultOutcomeJsonConverter))]
        public global::Speechify.TestOpenApiCallResultOutcome? Outcome { get; set; }

        /// <summary>
        /// Why no call was made: a config the create endpoint would refuse, an<br/>
        /// operation the config does not have, a write operation, or a<br/>
        /// credential that does not resolve or cannot mint a token. The<br/>
        /// message names what to fix. Absent when a call was made.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOpenAPICallResult" /> class.
        /// </summary>
        /// <param name="applied">
        /// Whether the `response` mapping changed the answer. It is also true<br/>
        /// when every `pick` path missed and the answer became empty, so read<br/>
        /// `mapped` to see what survives. Always false when `error` is set.
        /// </param>
        /// <param name="observation">
        /// Exactly what the agent would read. On `ok` it is the mapped answer<br/>
        /// trimmed to the observation window; on any other outcome it is the<br/>
        /// account the agent gets instead (the vendor's status and an excerpt<br/>
        /// of its error body, the wait to observe, the argument that was<br/>
        /// missing). Absent when `error` is set.
        /// </param>
        /// <param name="raw">
        /// The vendor's JSON answer as it came, before the operation's<br/>
        /// `response` mapping. Present only when `outcome` is `ok` and the<br/>
        /// vendor answered JSON.
        /// </param>
        /// <param name="mapped">
        /// The same answer after the operation's `response` mapping and<br/>
        /// before trimming: what a hosted API `tool` route would respond with.<br/>
        /// Identical to `raw` when the operation has no mapping or the mapping<br/>
        /// changed nothing. Present only when `outcome` is `ok` and the vendor<br/>
        /// answered JSON.
        /// </param>
        /// <param name="status">
        /// The vendor's HTTP status, the value a hosted API `tool` route<br/>
        /// reports as `error.details.upstream_status`. Absent when the call<br/>
        /// never reached the vendor (`invalid_arguments`, `unreachable`) and<br/>
        /// when `error` is set.
        /// </param>
        /// <param name="outcome">
        /// How a call that was made ended. Absent when `error` is set.<br/>
        /// - `ok`: the vendor answered with a success status. The only<br/>
        ///   outcome that previews a working call.<br/>
        /// - `invalid_arguments`: the arguments did not fit the operation (a<br/>
        ///   required param or body missing, a value that cannot be placed on<br/>
        ///   the request), so nothing was sent. Fix `arguments`, or the<br/>
        ///   operation's `params`.<br/>
        /// - `rate_limited`: the vendor answered 429. `observation` carries<br/>
        ///   the wait it asked for.<br/>
        /// - `upstream_error`: the vendor answered 4xx or 5xx. `status` is the<br/>
        ///   code and `observation` carries an excerpt of the body; a 401 or<br/>
        ///   403 usually means the credential or its scopes, a 404 the path or<br/>
        ///   `base_url`.<br/>
        /// - `unreachable`: the vendor could not be reached, or its answer<br/>
        ///   could not be read (DNS, TLS, timeout, an address the platform<br/>
        ///   refuses to call).<br/>
        /// - `unsupported_response`: the vendor answered a media type the<br/>
        ///   agent cannot read (not JSON or text). `status` is set.
        /// </param>
        /// <param name="error">
        /// Why no call was made: a config the create endpoint would refuse, an<br/>
        /// operation the config does not have, a write operation, or a<br/>
        /// credential that does not resolve or cannot mint a token. The<br/>
        /// message names what to fix. Absent when a call was made.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestOpenAPICallResult(
            bool applied,
            string? observation,
            object? raw,
            object? mapped,
            int? status,
            global::Speechify.TestOpenApiCallResultOutcome? outcome,
            string? error)
        {
            this.Observation = observation;
            this.Raw = raw;
            this.Mapped = mapped;
            this.Applied = applied;
            this.Status = status;
            this.Outcome = outcome;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestOpenAPICallResult" /> class.
        /// </summary>
        public TestOpenAPICallResult()
        {
        }

    }
}