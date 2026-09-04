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
        /// it yet.<br/>
        /// Every request also carries `Speechify-Idempotency-Key`, stable for one<br/>
        /// step of one run and identical to the `Idempotency-Key` a webhook tool<br/>
        /// receives. A durable run is retried if the platform redelivers it, so a<br/>
        /// tool that sends mail or takes payment can be called more than once for<br/>
        /// the same decision: key on this header and refuse to act twice. One<br/>
        /// connector serving both transports dedups on one identifier.
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
        public bool Equals(CreateToolRequestConfig other)
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
