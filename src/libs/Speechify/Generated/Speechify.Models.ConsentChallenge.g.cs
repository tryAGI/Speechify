
#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConsentChallenge
    {
        /// <summary>
        /// Identifier for this challenge, sent back as `consent_challenge_id`<br/>
        /// on the create. Treat it as an opaque string - the format is not part<br/>
        /// of the contract and will not stay stable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The sentence the speaker must read aloud. Show it exactly as<br/>
        /// returned - the recording is transcribed and matched against this<br/>
        /// text, so re-wording, re-casing or re-punctuating it will fail the<br/>
        /// check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phrase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Phrase { get; set; }

        /// <summary>
        /// When the challenge stops being usable. This is the only authority on<br/>
        /// the window - do not hard-code a duration. Past it, create a new<br/>
        /// challenge and record the new phrase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentChallenge" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for this challenge, sent back as `consent_challenge_id`<br/>
        /// on the create. Treat it as an opaque string - the format is not part<br/>
        /// of the contract and will not stay stable.
        /// </param>
        /// <param name="phrase">
        /// The sentence the speaker must read aloud. Show it exactly as<br/>
        /// returned - the recording is transcribed and matched against this<br/>
        /// text, so re-wording, re-casing or re-punctuating it will fail the<br/>
        /// check.
        /// </param>
        /// <param name="expiresAt">
        /// When the challenge stops being usable. This is the only authority on<br/>
        /// the window - do not hard-code a duration. Past it, create a new<br/>
        /// challenge and record the new phrase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConsentChallenge(
            string id,
            string phrase,
            global::System.DateTime expiresAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Phrase = phrase ?? throw new global::System.ArgumentNullException(nameof(phrase));
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsentChallenge" /> class.
        /// </summary>
        public ConsentChallenge()
        {
        }

    }
}