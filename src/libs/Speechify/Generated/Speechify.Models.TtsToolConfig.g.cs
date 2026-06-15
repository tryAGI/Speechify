#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// One of `SystemToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
    /// </summary>
    public readonly partial struct TtsToolConfig : global::System.IEquatable<TtsToolConfig>
    {
        /// <summary>
        /// Config shape for `kind=system`. The `builtin` value names the<br/>
        /// worker-resident capability; the catalogue served by<br/>
        /// `GET /v1/agents/tools/system-builtins` is the runtime source of truth<br/>
        /// for valid names plus their console-facing labels.
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
        /// 
        /// </summary>
        public bool TryPickSystemToolConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsSystemToolConfig? value)
        {
            value = SystemToolConfig;
            return IsSystemToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsSystemToolConfig PickSystemToolConfig() => IsSystemToolConfig
            ? SystemToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemToolConfig' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickWebhookToolConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsWebhookToolConfig? value)
        {
            value = WebhookToolConfig;
            return IsWebhookToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsWebhookToolConfig PickWebhookToolConfig() => IsWebhookToolConfig
            ? WebhookToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookToolConfig' but the value was {ToString()}.");

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
        public bool TryPickClientToolConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsClientToolConfig? value)
        {
            value = ClientToolConfig;
            return IsClientToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsClientToolConfig PickClientToolConfig() => IsClientToolConfig
            ? ClientToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolConfig' but the value was {ToString()}.");

        /// <summary>
        /// Config shape for `kind=mcp`. The worker opens the<br/>
        /// configured transport at session start, runs `initialize` +<br/>
        /// `list_tools`, and registers each discovered remote tool as a<br/>
        /// livekit-agents function_tool proxying through the long-lived<br/>
        /// ClientSession.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.TtsMCPToolConfig? MCPToolConfig { get; init; }
#else
        public global::Speechify.TtsMCPToolConfig? MCPToolConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolConfig))]
#endif
        public bool IsMCPToolConfig => MCPToolConfig != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMCPToolConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.TtsMCPToolConfig? value)
        {
            value = MCPToolConfig;
            return IsMCPToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.TtsMCPToolConfig PickMCPToolConfig() => IsMCPToolConfig
            ? MCPToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPToolConfig' but the value was {ToString()}.");
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
        public static TtsToolConfig FromSystemToolConfig(global::Speechify.TtsSystemToolConfig? value) => new TtsToolConfig(value);

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
        public static TtsToolConfig FromWebhookToolConfig(global::Speechify.TtsWebhookToolConfig? value) => new TtsToolConfig(value);

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
        public static TtsToolConfig FromClientToolConfig(global::Speechify.TtsClientToolConfig? value) => new TtsToolConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TtsToolConfig(global::Speechify.TtsMCPToolConfig value) => new TtsToolConfig((global::Speechify.TtsMCPToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.TtsMCPToolConfig?(TtsToolConfig @this) => @this.MCPToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(global::Speechify.TtsMCPToolConfig? value)
        {
            MCPToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TtsToolConfig FromMCPToolConfig(global::Speechify.TtsMCPToolConfig? value) => new TtsToolConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public TtsToolConfig(
            global::Speechify.TtsSystemToolConfig? systemToolConfig,
            global::Speechify.TtsWebhookToolConfig? webhookToolConfig,
            global::Speechify.TtsClientToolConfig? clientToolConfig,
            global::Speechify.TtsMCPToolConfig? mCPToolConfig
            )
        {
            SystemToolConfig = systemToolConfig;
            WebhookToolConfig = webhookToolConfig;
            ClientToolConfig = clientToolConfig;
            MCPToolConfig = mCPToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MCPToolConfig as object ??
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
            ClientToolConfig?.ToString() ??
            MCPToolConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSystemToolConfig && !IsWebhookToolConfig && !IsClientToolConfig && !IsMCPToolConfig || !IsSystemToolConfig && IsWebhookToolConfig && !IsClientToolConfig && !IsMCPToolConfig || !IsSystemToolConfig && !IsWebhookToolConfig && IsClientToolConfig && !IsMCPToolConfig || !IsSystemToolConfig && !IsWebhookToolConfig && !IsClientToolConfig && IsMCPToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.TtsSystemToolConfig, TResult>? systemToolConfig = null,
            global::System.Func<global::Speechify.TtsWebhookToolConfig, TResult>? webhookToolConfig = null,
            global::System.Func<global::Speechify.TtsClientToolConfig, TResult>? clientToolConfig = null,
            global::System.Func<global::Speechify.TtsMCPToolConfig, TResult>? mCPToolConfig = null,
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
            else if (IsMCPToolConfig && mCPToolConfig != null)
            {
                return mCPToolConfig(MCPToolConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.TtsSystemToolConfig>? systemToolConfig = null,

            global::System.Action<global::Speechify.TtsWebhookToolConfig>? webhookToolConfig = null,

            global::System.Action<global::Speechify.TtsClientToolConfig>? clientToolConfig = null,

            global::System.Action<global::Speechify.TtsMCPToolConfig>? mCPToolConfig = null,
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
            else if (IsMCPToolConfig)
            {
                mCPToolConfig?.Invoke(MCPToolConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.TtsSystemToolConfig>? systemToolConfig = null,
            global::System.Action<global::Speechify.TtsWebhookToolConfig>? webhookToolConfig = null,
            global::System.Action<global::Speechify.TtsClientToolConfig>? clientToolConfig = null,
            global::System.Action<global::Speechify.TtsMCPToolConfig>? mCPToolConfig = null,
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
            else if (IsMCPToolConfig)
            {
                mCPToolConfig?.Invoke(MCPToolConfig!);
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
                MCPToolConfig,
                typeof(global::Speechify.TtsMCPToolConfig),
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
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsClientToolConfig?>.Default.Equals(ClientToolConfig, other.ClientToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.TtsMCPToolConfig?>.Default.Equals(MCPToolConfig, other.MCPToolConfig) 
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
