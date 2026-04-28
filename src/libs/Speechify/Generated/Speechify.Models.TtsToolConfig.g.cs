#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One of `SystemToolConfig`, `WebhookToolConfig`, or `ClientToolConfig` depending on `kind`.
    /// </summary>
    public readonly partial struct TtsToolConfig : global::System.IEquatable<TtsToolConfig>
    {
        /// <summary>
        /// Config shape for `kind=system`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsSystemToolConfig? SystemToolConfig { get; init; }
#else
        public global::Speechify.TtsSystemToolConfig? SystemToolConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemToolConfig))]
#endif
        public bool IsSystemToolConfig => SystemToolConfig != null;

        /// <summary>
        /// Config shape for `kind=webhook`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsWebhookToolConfig? WebhookToolConfig { get; init; }
#else
        public global::Speechify.TtsWebhookToolConfig? WebhookToolConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebhookToolConfig))]
#endif
        public bool IsWebhookToolConfig => WebhookToolConfig != null;

        /// <summary>
        /// Config shape for `kind=client`. Execution happens in the caller's browser / SDK.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsClientToolConfig? ClientToolConfig { get; init; }
#else
        public global::Speechify.TtsClientToolConfig? ClientToolConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolConfig))]
#endif
        public bool IsClientToolConfig => ClientToolConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsToolConfig(global::Speechify.TtsSystemToolConfig value) => new TtsToolConfig((global::Speechify.TtsSystemToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsSystemToolConfig?(TtsToolConfig @this) => @this.SystemToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(global::Speechify.TtsSystemToolConfig? value)
        {
            SystemToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsToolConfig(global::Speechify.TtsWebhookToolConfig value) => new TtsToolConfig((global::Speechify.TtsWebhookToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsWebhookToolConfig?(TtsToolConfig @this) => @this.WebhookToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(global::Speechify.TtsWebhookToolConfig? value)
        {
            WebhookToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsToolConfig(global::Speechify.TtsClientToolConfig value) => new TtsToolConfig((global::Speechify.TtsClientToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsClientToolConfig?(TtsToolConfig @this) => @this.ClientToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(global::Speechify.TtsClientToolConfig? value)
        {
            ClientToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(
            global::Speechify.TtsSystemToolConfig? systemToolConfig,
            global::Speechify.TtsWebhookToolConfig? webhookToolConfig,
            global::Speechify.TtsClientToolConfig? clientToolConfig
            )
        {
            SystemToolConfig = systemToolConfig;
            WebhookToolConfig = webhookToolConfig;
            ClientToolConfig = clientToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientToolConfig as object ??
            WebhookToolConfig as object ??
            SystemToolConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SystemToolConfig?.ToString() ??
            WebhookToolConfig?.ToString() ??
            ClientToolConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemToolConfig && !IsWebhookToolConfig && !IsClientToolConfig || !IsSystemToolConfig && IsWebhookToolConfig && !IsClientToolConfig || !IsSystemToolConfig && !IsWebhookToolConfig && IsClientToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.TtsSystemToolConfig?, TResult>? systemToolConfig = null,
            global::System.Func<global::Speechify.TtsWebhookToolConfig?, TResult>? webhookToolConfig = null,
            global::System.Func<global::Speechify.TtsClientToolConfig?, TResult>? clientToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemToolConfig && systemToolConfig != null)
            {
                return systemToolConfig(SystemToolConfig!);
            }
            else if (IsWebhookToolConfig && webhookToolConfig != null)
            {
                return webhookToolConfig(WebhookToolConfig!);
            }
            else if (IsClientToolConfig && clientToolConfig != null)
            {
                return clientToolConfig(ClientToolConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.TtsSystemToolConfig?>? systemToolConfig = null,
            global::System.Action<global::Speechify.TtsWebhookToolConfig?>? webhookToolConfig = null,
            global::System.Action<global::Speechify.TtsClientToolConfig?>? clientToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSystemToolConfig)
            {
                systemToolConfig?.Invoke(SystemToolConfig!);
            }
            else if (IsWebhookToolConfig)
            {
                webhookToolConfig?.Invoke(WebhookToolConfig!);
            }
            else if (IsClientToolConfig)
            {
                clientToolConfig?.Invoke(ClientToolConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SystemToolConfig,
                typeof(global::Speechify.TtsSystemToolConfig),
                WebhookToolConfig,
                typeof(global::Speechify.TtsWebhookToolConfig),
                ClientToolConfig,
                typeof(global::Speechify.TtsClientToolConfig),
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
        public bool Equals(TtsToolConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsSystemToolConfig?>.Default.Equals(SystemToolConfig, other.SystemToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsWebhookToolConfig?>.Default.Equals(WebhookToolConfig, other.WebhookToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsClientToolConfig?>.Default.Equals(ClientToolConfig, other.ClientToolConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TtsToolConfig obj1, TtsToolConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TtsToolConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TtsToolConfig obj1, TtsToolConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TtsToolConfig o && Equals(o);
        }
    }
}
