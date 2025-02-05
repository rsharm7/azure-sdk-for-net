// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Search.Documents.Models
{
    /// <summary> Allows the user to choose whether a semantic call should fail completely, or to return partial results. </summary>
    public readonly partial struct SemanticErrorHandling : IEquatable<SemanticErrorHandling>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SemanticErrorHandling"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SemanticErrorHandling(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PartialValue = "partial";
        private const string FailValue = "fail";

        /// <summary> If the semantic processing fails, partial results still return. The definition of partial results depends on what semantic step failed and what was the reason for failure. </summary>
        public static SemanticErrorHandling Partial { get; } = new SemanticErrorHandling(PartialValue);
        /// <summary> If there is an exception during the semantic processing step, the query will fail and return the appropriate HTTP code depending on the error. </summary>
        public static SemanticErrorHandling Fail { get; } = new SemanticErrorHandling(FailValue);
        /// <summary> Determines if two <see cref="SemanticErrorHandling"/> values are the same. </summary>
        public static bool operator ==(SemanticErrorHandling left, SemanticErrorHandling right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SemanticErrorHandling"/> values are not the same. </summary>
        public static bool operator !=(SemanticErrorHandling left, SemanticErrorHandling right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SemanticErrorHandling"/>. </summary>
        public static implicit operator SemanticErrorHandling(string value) => new SemanticErrorHandling(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SemanticErrorHandling other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SemanticErrorHandling other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
