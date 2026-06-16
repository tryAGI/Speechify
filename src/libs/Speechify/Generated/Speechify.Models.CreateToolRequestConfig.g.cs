#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreateToolRequestConfig : global::System.IEquatable<CreateToolRequestConfig>
    {
        /// <summary>
        /// Config shape for `kind=system`. The `builtin` value names the<br/>
        /// worker-resident capability; the catalogue served by<br/>
        /// `GET /v1/agents/tools/system-builtins` is the runtime source of truth<br/>
        /// for valid names plus their console-facing labels.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.SystemToolConfig? SystemToolConfig { get; init; }
#else
        public global::Speechify.SystemToolConfig? SystemToolConfig { get; }
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
            out global::Speechify.SystemToolConfig? value)
        {
            value = SystemToolConfig;
            return IsSystemToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.SystemToolConfig PickSystemToolConfig() => IsSystemToolConfig
            ? SystemToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemToolConfig' but the value was {ToString()}.");

        /// <summary>
        /// Config shape for `kind=webhook`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.WebhookToolConfig? WebhookToolConfig { get; init; }
#else
        public global::Speechify.WebhookToolConfig? WebhookToolConfig { get; }
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
            out global::Speechify.WebhookToolConfig? value)
        {
            value = WebhookToolConfig;
            return IsWebhookToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.WebhookToolConfig PickWebhookToolConfig() => IsWebhookToolConfig
            ? WebhookToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebhookToolConfig' but the value was {ToString()}.");

        /// <summary>
        /// Config shape for `kind=client`. Execution happens in the caller's browser / SDK.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.ClientToolConfig? ClientToolConfig { get; init; }
#else
        public global::Speechify.ClientToolConfig? ClientToolConfig { get; }
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
            out global::Speechify.ClientToolConfig? value)
        {
            value = ClientToolConfig;
            return IsClientToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.ClientToolConfig PickClientToolConfig() => IsClientToolConfig
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
        public global::Speechify.MCPToolConfig? MCPToolConfig { get; init; }
#else
        public global::Speechify.MCPToolConfig? MCPToolConfig { get; }
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
            out global::Speechify.MCPToolConfig? value)
        {
            value = MCPToolConfig;
            return IsMCPToolConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Speechify.MCPToolConfig PickMCPToolConfig() => IsMCPToolConfig
            ? MCPToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPToolConfig' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequestConfig(global::Speechify.SystemToolConfig value) => new CreateToolRequestConfig((global::Speechify.SystemToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.SystemToolConfig?(CreateToolRequestConfig @this) => @this.SystemToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequestConfig(global::Speechify.SystemToolConfig? value)
        {
            SystemToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequestConfig FromSystemToolConfig(global::Speechify.SystemToolConfig? value) => new CreateToolRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequestConfig(global::Speechify.WebhookToolConfig value) => new CreateToolRequestConfig((global::Speechify.WebhookToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.WebhookToolConfig?(CreateToolRequestConfig @this) => @this.WebhookToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequestConfig(global::Speechify.WebhookToolConfig? value)
        {
            WebhookToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequestConfig FromWebhookToolConfig(global::Speechify.WebhookToolConfig? value) => new CreateToolRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequestConfig(global::Speechify.ClientToolConfig value) => new CreateToolRequestConfig((global::Speechify.ClientToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.ClientToolConfig?(CreateToolRequestConfig @this) => @this.ClientToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequestConfig(global::Speechify.ClientToolConfig? value)
        {
            ClientToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequestConfig FromClientToolConfig(global::Speechify.ClientToolConfig? value) => new CreateToolRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreateToolRequestConfig(global::Speechify.MCPToolConfig value) => new CreateToolRequestConfig((global::Speechify.MCPToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Speechify.MCPToolConfig?(CreateToolRequestConfig @this) => @this.MCPToolConfig;

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequestConfig(global::Speechify.MCPToolConfig? value)
        {
            MCPToolConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CreateToolRequestConfig FromMCPToolConfig(global::Speechify.MCPToolConfig? value) => new CreateToolRequestConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public CreateToolRequestConfig(
            global::Speechify.SystemToolConfig? systemToolConfig,
            global::Speechify.WebhookToolConfig? webhookToolConfig,
            global::Speechify.ClientToolConfig? clientToolConfig,
            global::Speechify.MCPToolConfig? mCPToolConfig
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
            global::System.Func<global::Speechify.SystemToolConfig, TResult>? systemToolConfig = null,
            global::System.Func<global::Speechify.WebhookToolConfig, TResult>? webhookToolConfig = null,
            global::System.Func<global::Speechify.ClientToolConfig, TResult>? clientToolConfig = null,
            global::System.Func<global::Speechify.MCPToolConfig, TResult>? mCPToolConfig = null,
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
            global::System.Action<global::Speechify.SystemToolConfig>? systemToolConfig = null,

            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,

            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,

            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
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
            global::System.Action<global::Speechify.SystemToolConfig>? systemToolConfig = null,
            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,
            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,
            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
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
                typeof(global::Speechify.SystemToolConfig),
                WebhookToolConfig,
                typeof(global::Speechify.WebhookToolConfig),
                ClientToolConfig,
                typeof(global::Speechify.ClientToolConfig),
                MCPToolConfig,
                typeof(global::Speechify.MCPToolConfig),
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
        public bool Equals(CreateToolRequestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.SystemToolConfig?>.Default.Equals(SystemToolConfig, other.SystemToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.WebhookToolConfig?>.Default.Equals(WebhookToolConfig, other.WebhookToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ClientToolConfig?>.Default.Equals(ClientToolConfig, other.ClientToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPToolConfig?>.Default.Equals(MCPToolConfig, other.MCPToolConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreateToolRequestConfig obj1, CreateToolRequestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreateToolRequestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreateToolRequestConfig obj1, CreateToolRequestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreateToolRequestConfig o && Equals(o);
        }
    }
}
