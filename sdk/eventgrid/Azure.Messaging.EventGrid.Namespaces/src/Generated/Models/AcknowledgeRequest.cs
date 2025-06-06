// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Messaging.EventGrid.Namespaces
{
    /// <summary> The AcknowledgeRequest. </summary>
    internal partial class AcknowledgeRequest
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected readonly IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        /// <summary> Initializes a new instance of <see cref="AcknowledgeRequest"/>. </summary>
        /// <param name="lockTokens"> Array of lock tokens. </param>
        internal AcknowledgeRequest(IEnumerable<string> lockTokens)
        {
            LockTokens = lockTokens.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AcknowledgeRequest"/>. </summary>
        /// <param name="lockTokens"> Array of lock tokens. </param>
        /// <param name="additionalBinaryDataProperties"> Keeps track of any properties unknown to the library. </param>
        internal AcknowledgeRequest(IList<string> lockTokens, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            LockTokens = lockTokens;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        /// <summary> Array of lock tokens. </summary>
        public IList<string> LockTokens { get; }
    }
}
