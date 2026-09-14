#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Speechify
{
    /// <summary>
    /// The document inline: a JSON object, or a string holding the JSON<br/>
    /// or YAML text. At most 2 MiB.
    /// </summary>
    public readonly partial struct ImportOpenApiRequestSpec : global::System.IEquatable<ImportOpenApiRequestSpec>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ImportOpenApiRequestSpecVariant1 { get; init; }
#else
        public object? ImportOpenApiRequestSpecVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportOpenApiRequestSpecVariant1))]
#endif
        public bool IsImportOpenApiRequestSpecVariant1 => ImportOpenApiRequestSpecVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImportOpenApiRequestSpecVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ImportOpenApiRequestSpecVariant1;
            return IsImportOpenApiRequestSpecVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public object PickImportOpenApiRequestSpecVariant1() => IsImportOpenApiRequestSpecVariant1
            ? ImportOpenApiRequestSpecVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportOpenApiRequestSpecVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ImportOpenApiRequestSpecVariant2 { get; init; }
#else
        public string? ImportOpenApiRequestSpecVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImportOpenApiRequestSpecVariant2))]
#endif
        public bool IsImportOpenApiRequestSpecVariant2 => ImportOpenApiRequestSpecVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImportOpenApiRequestSpecVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ImportOpenApiRequestSpecVariant2;
            return IsImportOpenApiRequestSpecVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickImportOpenApiRequestSpecVariant2() => IsImportOpenApiRequestSpecVariant2
            ? ImportOpenApiRequestSpecVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImportOpenApiRequestSpecVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ImportOpenApiRequestSpec(string value) => new ImportOpenApiRequestSpec((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(ImportOpenApiRequestSpec @this) => @this.ImportOpenApiRequestSpecVariant2;

        /// <summary>
        ///
        /// </summary>
        public ImportOpenApiRequestSpec(string? value)
        {
            ImportOpenApiRequestSpecVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ImportOpenApiRequestSpec FromImportOpenApiRequestSpecVariant2(string? value) => new ImportOpenApiRequestSpec(value);

        /// <summary>
        ///
        /// </summary>
        public ImportOpenApiRequestSpec(
            object? importOpenApiRequestSpecVariant1,
            string? importOpenApiRequestSpecVariant2
            )
        {
            ImportOpenApiRequestSpecVariant1 = importOpenApiRequestSpecVariant1;
            ImportOpenApiRequestSpecVariant2 = importOpenApiRequestSpecVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ImportOpenApiRequestSpecVariant2 as object ??
            ImportOpenApiRequestSpecVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ImportOpenApiRequestSpecVariant1?.ToString() ??
            ImportOpenApiRequestSpecVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImportOpenApiRequestSpecVariant1 && !IsImportOpenApiRequestSpecVariant2 || !IsImportOpenApiRequestSpecVariant1 && IsImportOpenApiRequestSpecVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<object, TResult>? importOpenApiRequestSpecVariant1 = null,
            global::System.Func<string, TResult>? importOpenApiRequestSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportOpenApiRequestSpecVariant1 && importOpenApiRequestSpecVariant1 != null)
            {
                return importOpenApiRequestSpecVariant1(ImportOpenApiRequestSpecVariant1!);
            }
            else if (IsImportOpenApiRequestSpecVariant2 && importOpenApiRequestSpecVariant2 != null)
            {
                return importOpenApiRequestSpecVariant2(ImportOpenApiRequestSpecVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<object>? importOpenApiRequestSpecVariant1 = null,

            global::System.Action<string>? importOpenApiRequestSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportOpenApiRequestSpecVariant1)
            {
                importOpenApiRequestSpecVariant1?.Invoke(ImportOpenApiRequestSpecVariant1!);
            }
            else if (IsImportOpenApiRequestSpecVariant2)
            {
                importOpenApiRequestSpecVariant2?.Invoke(ImportOpenApiRequestSpecVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<object>? importOpenApiRequestSpecVariant1 = null,
            global::System.Action<string>? importOpenApiRequestSpecVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImportOpenApiRequestSpecVariant1)
            {
                importOpenApiRequestSpecVariant1?.Invoke(ImportOpenApiRequestSpecVariant1!);
            }
            else if (IsImportOpenApiRequestSpecVariant2)
            {
                importOpenApiRequestSpecVariant2?.Invoke(ImportOpenApiRequestSpecVariant2!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ImportOpenApiRequestSpecVariant1,
                typeof(object),
                ImportOpenApiRequestSpecVariant2,
                typeof(string),
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
        public bool Equals(ImportOpenApiRequestSpec other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ImportOpenApiRequestSpecVariant1, other.ImportOpenApiRequestSpecVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ImportOpenApiRequestSpecVariant2, other.ImportOpenApiRequestSpecVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ImportOpenApiRequestSpec obj1, ImportOpenApiRequestSpec obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ImportOpenApiRequestSpec>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ImportOpenApiRequestSpec obj1, ImportOpenApiRequestSpec obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ImportOpenApiRequestSpec o && Equals(o);
        }
    }
}
