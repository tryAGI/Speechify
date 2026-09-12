#nullable enable

namespace Speechify
{
    public partial interface IWatermarkClient
    {
        /// <summary>
        /// Detect Watermark<br/>
        /// Check whether a clip carries the watermark Speechify seals into audio it<br/>
        /// generates. Upload the audio as `audio`; nothing about it is stored, and<br/>
        /// no voice is read or written.<br/>
        /// Read the answer carefully in one direction. A `watermarked: true` is<br/>
        /// positive evidence that the audio came from Speechify synthesis. A<br/>
        /// `watermarked: false` is NOT proof that it did not: only models<br/>
        /// redeployed since the watermark shipped mark their output, the detector<br/>
        /// needs at least three seconds of clear speech to judge, and re-encoding<br/>
        /// or changing the speed of a clip degrades the mark. Treat a negative as<br/>
        /// the absence of evidence rather than as evidence of absence.<br/>
        /// Checks are rate-limited well below the synthesis budget: this is a<br/>
        /// forensic question, not a data-plane call.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkDetectionResponse> DetectAsync(

            global::Speechify.DetectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect Watermark<br/>
        /// Check whether a clip carries the watermark Speechify seals into audio it<br/>
        /// generates. Upload the audio as `audio`; nothing about it is stored, and<br/>
        /// no voice is read or written.<br/>
        /// Read the answer carefully in one direction. A `watermarked: true` is<br/>
        /// positive evidence that the audio came from Speechify synthesis. A<br/>
        /// `watermarked: false` is NOT proof that it did not: only models<br/>
        /// redeployed since the watermark shipped mark their output, the detector<br/>
        /// needs at least three seconds of clear speech to judge, and re-encoding<br/>
        /// or changing the speed of a clip degrades the mark. Treat a negative as<br/>
        /// the absence of evidence rather than as evidence of absence.<br/>
        /// Checks are rate-limited well below the synthesis budget: this is a<br/>
        /// forensic question, not a data-plane call.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WatermarkDetectionResponse>> DetectAsResponseAsync(

            global::Speechify.DetectRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect Watermark<br/>
        /// Check whether a clip carries the watermark Speechify seals into audio it<br/>
        /// generates. Upload the audio as `audio`; nothing about it is stored, and<br/>
        /// no voice is read or written.<br/>
        /// Read the answer carefully in one direction. A `watermarked: true` is<br/>
        /// positive evidence that the audio came from Speechify synthesis. A<br/>
        /// `watermarked: false` is NOT proof that it did not: only models<br/>
        /// redeployed since the watermark shipped mark their output, the detector<br/>
        /// needs at least three seconds of clear speech to judge, and re-encoding<br/>
        /// or changing the speed of a clip degrades the mark. Treat a negative as<br/>
        /// the absence of evidence rather than as evidence of absence.<br/>
        /// Checks are rate-limited well below the synthesis budget: this is a<br/>
        /// forensic question, not a data-plane call.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkDetectionResponse> DetectAsync(
            byte[] audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detect Watermark<br/>
        /// Check whether a clip carries the watermark Speechify seals into audio it<br/>
        /// generates. Upload the audio as `audio`; nothing about it is stored, and<br/>
        /// no voice is read or written.<br/>
        /// Read the answer carefully in one direction. A `watermarked: true` is<br/>
        /// positive evidence that the audio came from Speechify synthesis. A<br/>
        /// `watermarked: false` is NOT proof that it did not: only models<br/>
        /// redeployed since the watermark shipped mark their output, the detector<br/>
        /// needs at least three seconds of clear speech to judge, and re-encoding<br/>
        /// or changing the speed of a clip degrades the mark. Treat a negative as<br/>
        /// the absence of evidence rather than as evidence of absence.<br/>
        /// Checks are rate-limited well below the synthesis budget: this is a<br/>
        /// forensic question, not a data-plane call.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkDetectionResponse> DetectAsync(
            global::System.IO.Stream audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detect Watermark<br/>
        /// Check whether a clip carries the watermark Speechify seals into audio it<br/>
        /// generates. Upload the audio as `audio`; nothing about it is stored, and<br/>
        /// no voice is read or written.<br/>
        /// Read the answer carefully in one direction. A `watermarked: true` is<br/>
        /// positive evidence that the audio came from Speechify synthesis. A<br/>
        /// `watermarked: false` is NOT proof that it did not: only models<br/>
        /// redeployed since the watermark shipped mark their output, the detector<br/>
        /// needs at least three seconds of clear speech to judge, and re-encoding<br/>
        /// or changing the speed of a clip degrades the mark. Treat a negative as<br/>
        /// the absence of evidence rather than as evidence of absence.<br/>
        /// Checks are rate-limited well below the synthesis budget: this is a<br/>
        /// forensic question, not a data-plane call.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its confidence is<br/>
        /// not worth acting on, and below half a second it always<br/>
        /// reports zero.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WatermarkDetectionResponse>> DetectAsResponseAsync(
            global::System.IO.Stream audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}