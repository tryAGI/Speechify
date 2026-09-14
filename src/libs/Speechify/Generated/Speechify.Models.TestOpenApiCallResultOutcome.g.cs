
#nullable enable

namespace Speechify
{
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
    public enum TestOpenApiCallResultOutcome
    {
        /// <summary>
        /// the arguments did not fit the operation (a
        /// </summary>
        InvalidArguments,
        /// <summary>
        /// the vendor answered with a success status. The only
        /// </summary>
        Ok,
        /// <summary>
        /// the vendor answered 429. `observation` carries
        /// </summary>
        RateLimited,
        /// <summary>
        /// the vendor could not be reached, or its answer
        /// </summary>
        Unreachable,
        /// <summary>
        /// the vendor answered a media type the
        /// </summary>
        UnsupportedResponse,
        /// <summary>
        /// the vendor answered 4xx or 5xx. `status` is the
        /// </summary>
        UpstreamError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestOpenApiCallResultOutcomeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestOpenApiCallResultOutcome value)
        {
            return value switch
            {
                TestOpenApiCallResultOutcome.InvalidArguments => "invalid_arguments",
                TestOpenApiCallResultOutcome.Ok => "ok",
                TestOpenApiCallResultOutcome.RateLimited => "rate_limited",
                TestOpenApiCallResultOutcome.Unreachable => "unreachable",
                TestOpenApiCallResultOutcome.UnsupportedResponse => "unsupported_response",
                TestOpenApiCallResultOutcome.UpstreamError => "upstream_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestOpenApiCallResultOutcome? ToEnum(string value)
        {
            return value switch
            {
                "invalid_arguments" => TestOpenApiCallResultOutcome.InvalidArguments,
                "ok" => TestOpenApiCallResultOutcome.Ok,
                "rate_limited" => TestOpenApiCallResultOutcome.RateLimited,
                "unreachable" => TestOpenApiCallResultOutcome.Unreachable,
                "unsupported_response" => TestOpenApiCallResultOutcome.UnsupportedResponse,
                "upstream_error" => TestOpenApiCallResultOutcome.UpstreamError,
                _ => null,
            };
        }
    }
}