#nullable enable

namespace Speechify
{
    public partial interface IWatermarkClient
    {
        /// <summary>
        /// Verify Watermark<br/>
        /// The public AI detection tool. Ask whether a clip carries the watermark<br/>
        /// Speechify seals into audio it generates, with no account, no API key and<br/>
        /// no credential of any kind.<br/>
        /// `verify` answers; `detect` measures. This route returns a bare yes or no,<br/>
        /// the way verifying a signature does. Its sibling<br/>
        /// `POST /v1/audio/watermark/detect` takes an API key and returns the<br/>
        /// detector's confidence alongside the verdict.<br/>
        /// This is the programmatic half of the tool published at<br/>
        /// &lt;https://speechify.ai/detect&gt;, and it exists so the tool can be invoked<br/>
        /// without visiting our website, as California's AI Transparency Act<br/>
        /// (BPC 22757.2) requires. Nothing about the clip is stored, and nothing<br/>
        /// identifying about you is collected or retained.<br/>
        /// The answer is a bare verdict. `watermarked: true` is positive evidence<br/>
        /// that the audio came from Speechify synthesis. `watermarked: false` is<br/>
        /// NOT proof that it did not: only models redeployed since the watermark<br/>
        /// shipped mark their output, the detector needs at least three seconds of<br/>
        /// clear speech to judge, and re-encoding or changing the speed of a clip<br/>
        /// degrades the mark. Treat a negative as the absence of evidence rather<br/>
        /// than as evidence of absence.<br/>
        /// Because the tool takes no credential, it is rate-limited per client<br/>
        /// address and shares a platform-wide budget: expect a 429 under sustained<br/>
        /// automated use, and retry after the interval the response advertises.<br/>
        /// Use `POST /v1/audio/watermark/detect` with an API key for the detector's<br/>
        /// confidence score and a per-workspace allowance of its own.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkVerificationResponse> VerifyAsync(

            global::Speechify.VerifyRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Watermark<br/>
        /// The public AI detection tool. Ask whether a clip carries the watermark<br/>
        /// Speechify seals into audio it generates, with no account, no API key and<br/>
        /// no credential of any kind.<br/>
        /// `verify` answers; `detect` measures. This route returns a bare yes or no,<br/>
        /// the way verifying a signature does. Its sibling<br/>
        /// `POST /v1/audio/watermark/detect` takes an API key and returns the<br/>
        /// detector's confidence alongside the verdict.<br/>
        /// This is the programmatic half of the tool published at<br/>
        /// &lt;https://speechify.ai/detect&gt;, and it exists so the tool can be invoked<br/>
        /// without visiting our website, as California's AI Transparency Act<br/>
        /// (BPC 22757.2) requires. Nothing about the clip is stored, and nothing<br/>
        /// identifying about you is collected or retained.<br/>
        /// The answer is a bare verdict. `watermarked: true` is positive evidence<br/>
        /// that the audio came from Speechify synthesis. `watermarked: false` is<br/>
        /// NOT proof that it did not: only models redeployed since the watermark<br/>
        /// shipped mark their output, the detector needs at least three seconds of<br/>
        /// clear speech to judge, and re-encoding or changing the speed of a clip<br/>
        /// degrades the mark. Treat a negative as the absence of evidence rather<br/>
        /// than as evidence of absence.<br/>
        /// Because the tool takes no credential, it is rate-limited per client<br/>
        /// address and shares a platform-wide budget: expect a 429 under sustained<br/>
        /// automated use, and retry after the interval the response advertises.<br/>
        /// Use `POST /v1/audio/watermark/detect` with an API key for the detector's<br/>
        /// confidence score and a per-workspace allowance of its own.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WatermarkVerificationResponse>> VerifyAsResponseAsync(

            global::Speechify.VerifyRequest request,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Watermark<br/>
        /// The public AI detection tool. Ask whether a clip carries the watermark<br/>
        /// Speechify seals into audio it generates, with no account, no API key and<br/>
        /// no credential of any kind.<br/>
        /// `verify` answers; `detect` measures. This route returns a bare yes or no,<br/>
        /// the way verifying a signature does. Its sibling<br/>
        /// `POST /v1/audio/watermark/detect` takes an API key and returns the<br/>
        /// detector's confidence alongside the verdict.<br/>
        /// This is the programmatic half of the tool published at<br/>
        /// &lt;https://speechify.ai/detect&gt;, and it exists so the tool can be invoked<br/>
        /// without visiting our website, as California's AI Transparency Act<br/>
        /// (BPC 22757.2) requires. Nothing about the clip is stored, and nothing<br/>
        /// identifying about you is collected or retained.<br/>
        /// The answer is a bare verdict. `watermarked: true` is positive evidence<br/>
        /// that the audio came from Speechify synthesis. `watermarked: false` is<br/>
        /// NOT proof that it did not: only models redeployed since the watermark<br/>
        /// shipped mark their output, the detector needs at least three seconds of<br/>
        /// clear speech to judge, and re-encoding or changing the speed of a clip<br/>
        /// degrades the mark. Treat a negative as the absence of evidence rather<br/>
        /// than as evidence of absence.<br/>
        /// Because the tool takes no credential, it is rate-limited per client<br/>
        /// address and shares a platform-wide budget: expect a 429 under sustained<br/>
        /// automated use, and retry after the interval the response advertises.<br/>
        /// Use `POST /v1/audio/watermark/detect` with an API key for the detector's<br/>
        /// confidence score and a per-workspace allowance of its own.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkVerificationResponse> VerifyAsync(
            byte[] audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Verify Watermark<br/>
        /// The public AI detection tool. Ask whether a clip carries the watermark<br/>
        /// Speechify seals into audio it generates, with no account, no API key and<br/>
        /// no credential of any kind.<br/>
        /// `verify` answers; `detect` measures. This route returns a bare yes or no,<br/>
        /// the way verifying a signature does. Its sibling<br/>
        /// `POST /v1/audio/watermark/detect` takes an API key and returns the<br/>
        /// detector's confidence alongside the verdict.<br/>
        /// This is the programmatic half of the tool published at<br/>
        /// &lt;https://speechify.ai/detect&gt;, and it exists so the tool can be invoked<br/>
        /// without visiting our website, as California's AI Transparency Act<br/>
        /// (BPC 22757.2) requires. Nothing about the clip is stored, and nothing<br/>
        /// identifying about you is collected or retained.<br/>
        /// The answer is a bare verdict. `watermarked: true` is positive evidence<br/>
        /// that the audio came from Speechify synthesis. `watermarked: false` is<br/>
        /// NOT proof that it did not: only models redeployed since the watermark<br/>
        /// shipped mark their output, the detector needs at least three seconds of<br/>
        /// clear speech to judge, and re-encoding or changing the speed of a clip<br/>
        /// degrades the mark. Treat a negative as the absence of evidence rather<br/>
        /// than as evidence of absence.<br/>
        /// Because the tool takes no credential, it is rate-limited per client<br/>
        /// address and shares a platform-wide budget: expect a 429 under sustained<br/>
        /// automated use, and retry after the interval the response advertises.<br/>
        /// Use `POST /v1/audio/watermark/detect` with an API key for the detector's<br/>
        /// confidence score and a per-workspace allowance of its own.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.WatermarkVerificationResponse> VerifyAsync(
            global::System.IO.Stream audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Watermark<br/>
        /// The public AI detection tool. Ask whether a clip carries the watermark<br/>
        /// Speechify seals into audio it generates, with no account, no API key and<br/>
        /// no credential of any kind.<br/>
        /// `verify` answers; `detect` measures. This route returns a bare yes or no,<br/>
        /// the way verifying a signature does. Its sibling<br/>
        /// `POST /v1/audio/watermark/detect` takes an API key and returns the<br/>
        /// detector's confidence alongside the verdict.<br/>
        /// This is the programmatic half of the tool published at<br/>
        /// &lt;https://speechify.ai/detect&gt;, and it exists so the tool can be invoked<br/>
        /// without visiting our website, as California's AI Transparency Act<br/>
        /// (BPC 22757.2) requires. Nothing about the clip is stored, and nothing<br/>
        /// identifying about you is collected or retained.<br/>
        /// The answer is a bare verdict. `watermarked: true` is positive evidence<br/>
        /// that the audio came from Speechify synthesis. `watermarked: false` is<br/>
        /// NOT proof that it did not: only models redeployed since the watermark<br/>
        /// shipped mark their output, the detector needs at least three seconds of<br/>
        /// clear speech to judge, and re-encoding or changing the speed of a clip<br/>
        /// degrades the mark. Treat a negative as the absence of evidence rather<br/>
        /// than as evidence of absence.<br/>
        /// Because the tool takes no credential, it is rate-limited per client<br/>
        /// address and shares a platform-wide budget: expect a 429 under sustained<br/>
        /// automated use, and retry after the interval the response advertises.<br/>
        /// Use `POST /v1/audio/watermark/detect` with an API key for the detector's<br/>
        /// confidence score and a per-workspace allowance of its own.
        /// </summary>
        /// <param name="speechifyVersion"></param>
        /// <param name="audio">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="audioname">
        /// The clip to check, at most 25MB. Give the detector at least<br/>
        /// three seconds of clear speech; below that its answer is not<br/>
        /// worth acting on.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Speechify.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Speechify.AutoSDKHttpResponse<global::Speechify.WatermarkVerificationResponse>> VerifyAsResponseAsync(
            global::System.IO.Stream audio,
            string audioname,
            string? speechifyVersion = default,
            global::Speechify.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}