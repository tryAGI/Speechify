#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// For a built-in, the full `BuiltinToolConfig`. Rejected for shared kinds.
    /// </summary>
    public readonly partial struct UpdateAgentToolRequestConfig : global::System.IEquatable<UpdateAgentToolRequestConfig>
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
        ///
        /// </summary>
        public static implicit operator UpdateAgentToolRequestConfig(global::Speechify.BuiltinToolConfig value) => new UpdateAgentToolRequestConfig((global::Speechify.BuiltinToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Speechify.BuiltinToolConfig?(UpdateAgentToolRequestConfig @this) => @this.BuiltinToolConfig;

        /// <summary>
        ///
        /// </summary>
        public UpdateAgentToolRequestConfig(global::Speechify.BuiltinToolConfig? value)
        {
            BuiltinToolConfig = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UpdateAgentToolRequestConfig FromBuiltinToolConfig(global::Speechify.BuiltinToolConfig? value) => new UpdateAgentToolRequestConfig(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BuiltinToolConfig as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BuiltinToolConfig?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBuiltinToolConfig;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Speechify.BuiltinToolConfig, TResult>? builtinToolConfig = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Speechify.BuiltinToolConfig>? builtinToolConfig = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Speechify.BuiltinToolConfig>? builtinToolConfig = null,
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
        public bool Equals(UpdateAgentToolRequestConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Speechify.BuiltinToolConfig?>.Default.Equals(BuiltinToolConfig, other.BuiltinToolConfig)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UpdateAgentToolRequestConfig obj1, UpdateAgentToolRequestConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateAgentToolRequestConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UpdateAgentToolRequestConfig obj1, UpdateAgentToolRequestConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateAgentToolRequestConfig o && Equals(o);
        }
    }
}
