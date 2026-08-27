
#nullable enable

namespace Speechify
{
    /// <summary>
    /// Metadata for a pre-recorded WAV clip stored in the workspace's<br/>
    /// audio-asset bucket. Bytes are immutable once uploaded — to<br/>
    /// replace a clip, upload a new asset and update any references.
    /// </summary>
    public sealed partial class AudioAsset
    {
        /// <summary>
        /// Prefixed wire identifier (`audio_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The filename supplied at upload time, kept for display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalFilename { get; set; }

        /// <summary>
        /// Always `audio/wav`. Pinned server-side after WAV validation<br/>
        /// rather than trusting the upload's multipart Content-Type<br/>
        /// header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Stored byte length. Capped at 4 MiB at upload time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Clip duration in milliseconds. Capped at 30000 (30s) at upload time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// WAV sample rate. Always 48000 (the rate voice agents play back natively).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_rate_hz")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SampleRateHz { get; set; }

        /// <summary>
        /// Channel count. Always 1 (mono).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Channels { get; set; }

        /// <summary>
        /// PCM sample bit depth. Always 16.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bit_depth")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BitDepth { get; set; }

        /// <summary>
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        /// <param name="id">
        /// Prefixed wire identifier (`audio_&lt;26 char Crockford base32&gt;`).<br/>
        /// URL paths accept only this<br/>
        /// prefixed form; legacy UUID path parameters are rejected with<br/>
        /// 404.
        /// </param>
        /// <param name="originalFilename">
        /// The filename supplied at upload time, kept for display.
        /// </param>
        /// <param name="contentType">
        /// Always `audio/wav`. Pinned server-side after WAV validation<br/>
        /// rather than trusting the upload's multipart Content-Type<br/>
        /// header.
        /// </param>
        /// <param name="sizeBytes">
        /// Stored byte length. Capped at 4 MiB at upload time.
        /// </param>
        /// <param name="durationMs">
        /// Clip duration in milliseconds. Capped at 30000 (30s) at upload time.
        /// </param>
        /// <param name="sampleRateHz">
        /// WAV sample rate. Always 48000 (the rate voice agents play back natively).
        /// </param>
        /// <param name="channels">
        /// Channel count. Always 1 (mono).
        /// </param>
        /// <param name="bitDepth">
        /// PCM sample bit depth. Always 16.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="projectId">
        /// Workspace project this resource lives in (prefixed external<br/>
        /// id). Null means the implicit Default project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioAsset(
            string id,
            string originalFilename,
            string contentType,
            long sizeBytes,
            int durationMs,
            int sampleRateHz,
            int channels,
            int bitDepth,
            global::System.DateTime createdAt,
            string? projectId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OriginalFilename = originalFilename ?? throw new global::System.ArgumentNullException(nameof(originalFilename));
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.SizeBytes = sizeBytes;
            this.DurationMs = durationMs;
            this.SampleRateHz = sampleRateHz;
            this.Channels = channels;
            this.BitDepth = bitDepth;
            this.ProjectId = projectId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioAsset" /> class.
        /// </summary>
        public AudioAsset()
        {
        }

    }
}