// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Type of enclave requested on the database i.e. Default or VBS enclaves. </summary>
    public readonly partial struct AlwaysEncryptedEnclaveType : IEquatable<AlwaysEncryptedEnclaveType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AlwaysEncryptedEnclaveType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AlwaysEncryptedEnclaveType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string VBSValue = "VBS";

        /// <summary> Default. </summary>
        public static AlwaysEncryptedEnclaveType Default { get; } = new AlwaysEncryptedEnclaveType(DefaultValue);
        /// <summary> VBS. </summary>
        public static AlwaysEncryptedEnclaveType VBS { get; } = new AlwaysEncryptedEnclaveType(VBSValue);
        /// <summary> Determines if two <see cref="AlwaysEncryptedEnclaveType"/> values are the same. </summary>
        public static bool operator ==(AlwaysEncryptedEnclaveType left, AlwaysEncryptedEnclaveType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AlwaysEncryptedEnclaveType"/> values are not the same. </summary>
        public static bool operator !=(AlwaysEncryptedEnclaveType left, AlwaysEncryptedEnclaveType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AlwaysEncryptedEnclaveType"/>. </summary>
        public static implicit operator AlwaysEncryptedEnclaveType(string value) => new AlwaysEncryptedEnclaveType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AlwaysEncryptedEnclaveType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AlwaysEncryptedEnclaveType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
