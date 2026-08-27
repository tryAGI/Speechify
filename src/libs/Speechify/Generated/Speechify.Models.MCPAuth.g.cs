#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// Discriminated union over `type`.
    /// </summary>
    public readonly partial struct MCPAuth : global::System.IEquatable<MCPAuth>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Speechify.MCPAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// none variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.MCPAuthVariant1? None { get; init; }
#else
        public global::Speechify.MCPAuthVariant1? None { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.MCPAuthVariant1? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.MCPAuthVariant1 PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Bearer auth for an MCP server. References a workspace credential of<br/>
        /// kind `bearer` by id; the secret lives in the credentials vault and is<br/>
        /// resolved server-side at dispatch, never inlined on the tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.MCPAuthVariant2? Bearer { get; init; }
#else
        public global::Speechify.MCPAuthVariant2? Bearer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bearer))]
#endif
        public bool IsBearer => Bearer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBearer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.MCPAuthVariant2? value)
        {
            value = Bearer;
            return IsBearer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.MCPAuthVariant2 PickBearer() => IsBearer
            ? Bearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bearer' but the value was {ToString()}.");

        /// <summary>
        /// OAuth2 client-credentials auth for an MCP server. References a<br/>
        /// workspace credential of kind `oauth2_client_credentials` by id; the<br/>
        /// token_url / client_id / client_secret / scopes all live in the vault<br/>
        /// credential and are resolved server-side at dispatch.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.MCPAuthVariant3? Oauth2ClientCredentials { get; init; }
#else
        public global::Speechify.MCPAuthVariant3? Oauth2ClientCredentials { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Oauth2ClientCredentials))]
#endif
        public bool IsOauth2ClientCredentials => Oauth2ClientCredentials != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOauth2ClientCredentials(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.MCPAuthVariant3? value)
        {
            value = Oauth2ClientCredentials;
            return IsOauth2ClientCredentials;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.MCPAuthVariant3 PickOauth2ClientCredentials() => IsOauth2ClientCredentials
            ? Oauth2ClientCredentials!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Oauth2ClientCredentials' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPAuth(global::Speechify.MCPAuthVariant1 value) => new MCPAuth((global::Speechify.MCPAuthVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.MCPAuthVariant1?(MCPAuth @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public MCPAuth(global::Speechify.MCPAuthVariant1? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPAuth FromNone(global::Speechify.MCPAuthVariant1? value) => new MCPAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPAuth(global::Speechify.MCPAuthVariant2 value) => new MCPAuth((global::Speechify.MCPAuthVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.MCPAuthVariant2?(MCPAuth @this) => @this.Bearer;

        /// <summary>
        ///
        /// </summary>
        public MCPAuth(global::Speechify.MCPAuthVariant2? value)
        {
            Bearer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPAuth FromBearer(global::Speechify.MCPAuthVariant2? value) => new MCPAuth(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator MCPAuth(global::Speechify.MCPAuthVariant3 value) => new MCPAuth((global::Speechify.MCPAuthVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.MCPAuthVariant3?(MCPAuth @this) => @this.Oauth2ClientCredentials;

        /// <summary>
        ///
        /// </summary>
        public MCPAuth(global::Speechify.MCPAuthVariant3? value)
        {
            Oauth2ClientCredentials = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static MCPAuth FromOauth2ClientCredentials(global::Speechify.MCPAuthVariant3? value) => new MCPAuth(value);

        /// <summary>
        ///
        /// </summary>
        public MCPAuth(
            global::Speechify.MCPAuthDiscriminatorType? type,
            global::Speechify.MCPAuthVariant1? none,
            global::Speechify.MCPAuthVariant2? bearer,
            global::Speechify.MCPAuthVariant3? oauth2ClientCredentials
            )
        {
            Type = type;

            None = none;
            Bearer = bearer;
            Oauth2ClientCredentials = oauth2ClientCredentials;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Oauth2ClientCredentials as object ??
            Bearer as object ??
            None as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            Bearer?.ToString() ??
            Oauth2ClientCredentials?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsBearer && !IsOauth2ClientCredentials || !IsNone && IsBearer && !IsOauth2ClientCredentials || !IsNone && !IsBearer && IsOauth2ClientCredentials;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.MCPAuthVariant1, TResult>? none = null,
            global::System.Func<global::Speechify.MCPAuthVariant2, TResult>? bearer = null,
            global::System.Func<global::Speechify.MCPAuthVariant3, TResult>? oauth2ClientCredentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsBearer && bearer != null)
            {
                return bearer(Bearer!);
            }
            else if (IsOauth2ClientCredentials && oauth2ClientCredentials != null)
            {
                return oauth2ClientCredentials(Oauth2ClientCredentials!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.MCPAuthVariant1>? none = null,

            global::System.Action<global::Speechify.MCPAuthVariant2>? bearer = null,

            global::System.Action<global::Speechify.MCPAuthVariant3>? oauth2ClientCredentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsBearer)
            {
                bearer?.Invoke(Bearer!);
            }
            else if (IsOauth2ClientCredentials)
            {
                oauth2ClientCredentials?.Invoke(Oauth2ClientCredentials!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.MCPAuthVariant1>? none = null,
            global::System.Action<global::Speechify.MCPAuthVariant2>? bearer = null,
            global::System.Action<global::Speechify.MCPAuthVariant3>? oauth2ClientCredentials = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsBearer)
            {
                bearer?.Invoke(Bearer!);
            }
            else if (IsOauth2ClientCredentials)
            {
                oauth2ClientCredentials?.Invoke(Oauth2ClientCredentials!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::Speechify.MCPAuthVariant1),
                Bearer,
                typeof(global::Speechify.MCPAuthVariant2),
                Oauth2ClientCredentials,
                typeof(global::Speechify.MCPAuthVariant3),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(MCPAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPAuthVariant1?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPAuthVariant2?>.Default.Equals(Bearer, other.Bearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPAuthVariant3?>.Default.Equals(Oauth2ClientCredentials, other.Oauth2ClientCredentials)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(MCPAuth obj1, MCPAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MCPAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(MCPAuth obj1, MCPAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MCPAuth o && Equals(o);
        }
    }
}
