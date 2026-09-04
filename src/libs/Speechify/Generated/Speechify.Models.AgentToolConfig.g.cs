#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// Resolved config - `BuiltinToolConfig`, `WebhookToolConfig`, `ClientToolConfig`, or `MCPToolConfig` depending on `kind`.
    /// </summary>
    public readonly partial struct AgentToolConfig : global::System.IEquatable<AgentToolConfig>
    {
        /// <summary>
        /// Config shape for `kind=builtin`. The `builtin` value names the<br/>
        /// worker-resident capability; the catalogue served by<br/>
        /// `GET /v1/agents/tool-capabilities` is the runtime source of truth<br/>
        /// for valid names plus their human-readable labels. `builtin_config`<br/>
        /// carries per-instance extras (e.g. mode + hold_message +<br/>
        /// allowed_numbers for transfer_to_number, audio_asset_id for<br/>
        /// play_audio).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Speechify.BuiltinToolConfig? BuiltinToolConfig { get; init; }
#else
        public global::Speechify.BuiltinToolConfig? BuiltinToolConfig { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuiltinToolConfig))]
#endif
        public bool IsBuiltinToolConfig => BuiltinToolConfig != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuiltinToolConfig(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Speechify.BuiltinToolConfig? value)
        {
            value = BuiltinToolConfig;
            return IsBuiltinToolConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Speechify.BuiltinToolConfig PickBuiltinToolConfig() => IsBuiltinToolConfig
            ? BuiltinToolConfig!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuiltinToolConfig' but the value was {ToString()}.");

        /// <summary>
        /// Config shape for `kind=webhook`.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) your endpoint is<br/>
        /// told `user_identity`: the person the agent is acting for, exactly as<br/>
        /// your application supplied it when it started the run. The field is<br/>
        /// absent when the run is acting for nobody in particular, so treat an<br/>
        /// absent value as "no person", never as a default one. Voice<br/>
        /// conversations and sessions do not carry it yet.<br/>
        /// On `method: POST` it rides inside the **signed** JSON body rather than<br/>
        /// a header, so an endpoint deciding whose data to touch can verify the<br/>
        /// answer with the same HMAC it already checks. On `method: GET` there is<br/>
        /// no body to sign, so it arrives as a **`user_identity` query<br/>
        /// parameter**, unverifiable exactly as the arguments beside it are: a<br/>
        /// GET's signature covers an envelope that is not on the wire. Use POST<br/>
        /// for any endpoint that authorizes on who the call is for. A tool<br/>
        /// argument of the same name never overrides it.
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
        /// ClientSession.<br/>
        /// On a durable run (`POST /v1/agents/{agent_id}/runs`) every request to<br/>
        /// your server carries a `Speechify-User-Identity` header holding the<br/>
        /// person the agent is acting for, exactly as your application supplied<br/>
        /// it when it started the run. This is what lets a server you wrote hold<br/>
        /// your users' third-party credentials and act for the right one; the<br/>
        /// header is absent when the run is acting for nobody. It is a header<br/>
        /// rather than a body field because MCP owns its own JSON-RPC envelope,<br/>
        /// so trust it exactly as far as you trust the connection your server<br/>
        /// already authenticated. Voice conversations and sessions do not carry<br/>
        /// it yet.
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
        public static implicit operator AgentToolConfig(global::Speechify.BuiltinToolConfig value) => new AgentToolConfig((global::Speechify.BuiltinToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.BuiltinToolConfig?(AgentToolConfig @this) => @this.BuiltinToolConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfig(global::Speechify.BuiltinToolConfig? value)
        {
            BuiltinToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfig FromBuiltinToolConfig(global::Speechify.BuiltinToolConfig? value) => new AgentToolConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfig(global::Speechify.WebhookToolConfig value) => new AgentToolConfig((global::Speechify.WebhookToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.WebhookToolConfig?(AgentToolConfig @this) => @this.WebhookToolConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfig(global::Speechify.WebhookToolConfig? value)
        {
            WebhookToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfig FromWebhookToolConfig(global::Speechify.WebhookToolConfig? value) => new AgentToolConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfig(global::Speechify.ClientToolConfig value) => new AgentToolConfig((global::Speechify.ClientToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.ClientToolConfig?(AgentToolConfig @this) => @this.ClientToolConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfig(global::Speechify.ClientToolConfig? value)
        {
            ClientToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfig FromClientToolConfig(global::Speechify.ClientToolConfig? value) => new AgentToolConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AgentToolConfig(global::Speechify.MCPToolConfig value) => new AgentToolConfig((global::Speechify.MCPToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.MCPToolConfig?(AgentToolConfig @this) => @this.MCPToolConfig;

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfig(global::Speechify.MCPToolConfig? value)
        {
            MCPToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AgentToolConfig FromMCPToolConfig(global::Speechify.MCPToolConfig? value) => new AgentToolConfig(value);

        /// <summary>
        ///
        /// </summary>
        public AgentToolConfig(
            global::Speechify.BuiltinToolConfig? builtinToolConfig,
            global::Speechify.WebhookToolConfig? webhookToolConfig,
            global::Speechify.ClientToolConfig? clientToolConfig,
            global::Speechify.MCPToolConfig? mCPToolConfig
            )
        {
            BuiltinToolConfig = builtinToolConfig;
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
            BuiltinToolConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BuiltinToolConfig?.ToString() ??
            WebhookToolConfig?.ToString() ??
            ClientToolConfig?.ToString() ??
            MCPToolConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuiltinToolConfig && !IsWebhookToolConfig && !IsClientToolConfig && !IsMCPToolConfig || !IsBuiltinToolConfig && IsWebhookToolConfig && !IsClientToolConfig && !IsMCPToolConfig || !IsBuiltinToolConfig && !IsWebhookToolConfig && IsClientToolConfig && !IsMCPToolConfig || !IsBuiltinToolConfig && !IsWebhookToolConfig && !IsClientToolConfig && IsMCPToolConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.BuiltinToolConfig, TResult>? builtinToolConfig = null,
            global::System.Func<global::Speechify.WebhookToolConfig, TResult>? webhookToolConfig = null,
            global::System.Func<global::Speechify.ClientToolConfig, TResult>? clientToolConfig = null,
            global::System.Func<global::Speechify.MCPToolConfig, TResult>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltinToolConfig && builtinToolConfig != null)
            {
                return builtinToolConfig(BuiltinToolConfig!);
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
            global::System.Action<global::Speechify.BuiltinToolConfig>? builtinToolConfig = null,

            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,

            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,

            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltinToolConfig)
            {
                builtinToolConfig?.Invoke(BuiltinToolConfig!);
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
            global::System.Action<global::Speechify.BuiltinToolConfig>? builtinToolConfig = null,
            global::System.Action<global::Speechify.WebhookToolConfig>? webhookToolConfig = null,
            global::System.Action<global::Speechify.ClientToolConfig>? clientToolConfig = null,
            global::System.Action<global::Speechify.MCPToolConfig>? mCPToolConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBuiltinToolConfig)
            {
                builtinToolConfig?.Invoke(BuiltinToolConfig!);
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
                BuiltinToolConfig,
                typeof(global::Speechify.BuiltinToolConfig),
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
        public bool Equals(AgentToolConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.BuiltinToolConfig?>.Default.Equals(BuiltinToolConfig, other.BuiltinToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.WebhookToolConfig?>.Default.Equals(WebhookToolConfig, other.WebhookToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.ClientToolConfig?>.Default.Equals(ClientToolConfig, other.ClientToolConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::Speechify.MCPToolConfig?>.Default.Equals(MCPToolConfig, other.MCPToolConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AgentToolConfig obj1, AgentToolConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AgentToolConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AgentToolConfig obj1, AgentToolConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AgentToolConfig o && Equals(o);
        }
    }
}
