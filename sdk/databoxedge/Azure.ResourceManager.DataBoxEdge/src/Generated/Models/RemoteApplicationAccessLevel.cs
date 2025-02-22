// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Access level allowed for this remote application type. </summary>
    public readonly partial struct RemoteApplicationAccessLevel : IEquatable<RemoteApplicationAccessLevel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RemoteApplicationAccessLevel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RemoteApplicationAccessLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "None";
        private const string ReadOnlyValue = "ReadOnly";
        private const string ReadWriteValue = "ReadWrite";
        private const string FullAccessValue = "FullAccess";

        /// <summary> None. </summary>
        public static RemoteApplicationAccessLevel None { get; } = new RemoteApplicationAccessLevel(NoneValue);
        /// <summary> ReadOnly. </summary>
        public static RemoteApplicationAccessLevel ReadOnly { get; } = new RemoteApplicationAccessLevel(ReadOnlyValue);
        /// <summary> ReadWrite. </summary>
        public static RemoteApplicationAccessLevel ReadWrite { get; } = new RemoteApplicationAccessLevel(ReadWriteValue);
        /// <summary> FullAccess. </summary>
        public static RemoteApplicationAccessLevel FullAccess { get; } = new RemoteApplicationAccessLevel(FullAccessValue);
        /// <summary> Determines if two <see cref="RemoteApplicationAccessLevel"/> values are the same. </summary>
        public static bool operator ==(RemoteApplicationAccessLevel left, RemoteApplicationAccessLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RemoteApplicationAccessLevel"/> values are not the same. </summary>
        public static bool operator !=(RemoteApplicationAccessLevel left, RemoteApplicationAccessLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RemoteApplicationAccessLevel"/>. </summary>
        public static implicit operator RemoteApplicationAccessLevel(string value) => new RemoteApplicationAccessLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RemoteApplicationAccessLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RemoteApplicationAccessLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
