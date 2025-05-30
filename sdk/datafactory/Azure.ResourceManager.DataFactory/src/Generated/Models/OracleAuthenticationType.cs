// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Authentication type for connecting to the Oracle database. Only used for Version 2.0. </summary>
    public readonly partial struct OracleAuthenticationType : IEquatable<OracleAuthenticationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="OracleAuthenticationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public OracleAuthenticationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";

        /// <summary> Basic. </summary>
        public static OracleAuthenticationType Basic { get; } = new OracleAuthenticationType(BasicValue);
        /// <summary> Determines if two <see cref="OracleAuthenticationType"/> values are the same. </summary>
        public static bool operator ==(OracleAuthenticationType left, OracleAuthenticationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="OracleAuthenticationType"/> values are not the same. </summary>
        public static bool operator !=(OracleAuthenticationType left, OracleAuthenticationType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="OracleAuthenticationType"/>. </summary>
        public static implicit operator OracleAuthenticationType(string value) => new OracleAuthenticationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is OracleAuthenticationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(OracleAuthenticationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
