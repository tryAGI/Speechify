
#nullable enable

namespace Speechify
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class HostedAPIMountOperation
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Operation { get; set; }

        /// <summary>
        /// The operation's summary or description; the created route's description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The operation's effective action class, or empty for a stale route whose operation is gone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action_class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActionClass { get; set; }

        /// <summary>
        /// The operation's effective approval, or empty for a stale route whose operation is gone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approval")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Approval { get; set; }

        /// <summary>
        /// Whether a route can serve it now (approval `auto`, and a read, or a write on a route with `allow_write` on an API that names a person).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("servable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Servable { get; set; }

        /// <summary>
        /// Whether the route serves a write: set on a create when the mount includes writes, and the existing route's own value otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_write")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowWrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Speechify.JsonConverters.HostedApiMountOperationActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Speechify.HostedApiMountOperationAction Action { get; set; }

        /// <summary>
        /// Why a `skip` or a `stale` entry is one, and what fixes it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// What an `update` rewrites.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public global::System.Collections.Generic.IList<global::Speechify.HostedApiMountOperationChangesItems>? Changes { get; set; }

        /// <summary>
        /// The route's name, the MCP tool name the face lists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("route")]
        public global::Speechify.HostedAPIRoute? Route { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountOperation" /> class.
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="description">
        /// The operation's summary or description; the created route's description.
        /// </param>
        /// <param name="actionClass">
        /// The operation's effective action class, or empty for a stale route whose operation is gone.
        /// </param>
        /// <param name="approval">
        /// The operation's effective approval, or empty for a stale route whose operation is gone.
        /// </param>
        /// <param name="servable">
        /// Whether a route can serve it now (approval `auto`, and a read, or a write on a route with `allow_write` on an API that names a person).
        /// </param>
        /// <param name="allowWrite">
        /// Whether the route serves a write: set on a create when the mount includes writes, and the existing route's own value otherwise.
        /// </param>
        /// <param name="action"></param>
        /// <param name="name">
        /// The route's name, the MCP tool name the face lists.
        /// </param>
        /// <param name="path"></param>
        /// <param name="reason">
        /// Why a `skip` or a `stale` entry is one, and what fixes it.
        /// </param>
        /// <param name="changes">
        /// What an `update` rewrites.
        /// </param>
        /// <param name="route"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HostedAPIMountOperation(
            string operation,
            string description,
            string actionClass,
            string approval,
            bool servable,
            bool allowWrite,
            global::Speechify.HostedApiMountOperationAction action,
            string name,
            string path,
            string? reason,
            global::System.Collections.Generic.IList<global::Speechify.HostedApiMountOperationChangesItems>? changes,
            global::Speechify.HostedAPIRoute? route)
        {
            this.Operation = operation ?? throw new global::System.ArgumentNullException(nameof(operation));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ActionClass = actionClass ?? throw new global::System.ArgumentNullException(nameof(actionClass));
            this.Approval = approval ?? throw new global::System.ArgumentNullException(nameof(approval));
            this.Servable = servable;
            this.AllowWrite = allowWrite;
            this.Action = action;
            this.Reason = reason;
            this.Changes = changes;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Route = route;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HostedAPIMountOperation" /> class.
        /// </summary>
        public HostedAPIMountOperation()
        {
        }

    }
}