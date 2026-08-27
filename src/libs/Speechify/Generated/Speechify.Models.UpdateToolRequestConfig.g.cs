#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct UpdateToolRequestConfig : global::System.IEquatable<UpdateToolRequestConfig>
    {
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
        public static implicit operator UpdateToolRequestConfig(global::Speechify.WebhookToolConfig value) => new UpdateToolRequestConfig((global::Speechify.WebhookToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.WebhookToolConfig?(UpdateToolRequestConfig @this) => @this.WebhookToolConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateToolRequestConfig(global::Speechify.WebhookToolConfig? value)
        {
            WebhookToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateToolRequestConfig FromWebhookToolConfig(global::Speechify.WebhookToolConfig? value) => new UpdateToolRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateToolRequestConfig(global::Speechify.ClientToolConfig value) => new UpdateToolRequestConfig((global::Speechify.ClientToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ClientToolConfig?(UpdateToolRequestConfig @this) => @this.ClientToolConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateToolRequestConfig(global::Speechify.ClientToolConfig? value)
        {
            ClientToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateToolRequestConfig FromClientToolConfig(global::Speechify.ClientToolConfig? value) => new UpdateToolRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UpdateToolRequestConfig(global::Speechify.MCPToolConfig value) => new UpdateToolRequestConfig((global::Speechify.MCPToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.MCPToolConfig?(UpdateToolRequestConfig @this) => @this.MCPToolConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateToolRequestConfig(global::Speechify.MCPToolConfig? value)
        {
            MCPToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateToolRequestConfig FromMCPToolConfig(global::Speechify.MCPToolConfig? value) => new UpdateToolRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public UpdateToolRequestConfig(
            global::Speechify.WebhookToolConfig? webhookToolConfig,
            global::Speechify.ClientToolConfig? clientToolConfig,
            global::Speechify.MCPToolConfig? mCPToolConfig
            )
        {
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
            WebhookToolConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            WebhookToolConfig?.ToString() ??
            ClientToolConfig?.ToString() ??
            MCPToolConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsWebhookToolConfig && !IsClientToolConfig && !IsMCPToolConfig || !IsWebhookToolConfig && IsClientToolConfig && !IsMCPToolConfig || !IsWebhookToolConfig && !IsClientToolConfig && IsMCPToolConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.WebhookToolConfig, TResult>? webhookToolConfig = null,
            global::System.Func<global::Speechify.ClientToolConfig, TResult>? clientToolConfig = null,
            global::System.Func<global::Speechify.MCPToolConfig, TResult>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfig && webhookToolConfig != null)
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
            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,

            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,

            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfig)
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
            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,
            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,
            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhookToolConfig)
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
        public bool Equals(UpdateToolRequestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.WebhookToolConfig?>.Default.Equals(WebhookToolConfig, other.WebhookToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ClientToolConfig?>.Default.Equals(ClientToolConfig, other.ClientToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPToolConfig?>.Default.Equals(MCPToolConfig, other.MCPToolConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateToolRequestConfig obj1, UpdateToolRequestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateToolRequestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateToolRequestConfig obj1, UpdateToolRequestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateToolRequestConfig o && Equals(o);
        }
    }
}
