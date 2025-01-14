// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents the response to a list elastic pool database activity request. </summary>
    internal partial class ElasticPoolDatabaseActivityListResult
    {
        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivityListResult. </summary>
        /// <param name="value"> The list of elastic pool database activities. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ElasticPoolDatabaseActivityListResult(IEnumerable<ElasticPoolDatabaseActivity> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ElasticPoolDatabaseActivityListResult. </summary>
        /// <param name="value"> The list of elastic pool database activities. </param>
        internal ElasticPoolDatabaseActivityListResult(IReadOnlyList<ElasticPoolDatabaseActivity> value)
        {
            Value = value;
        }

        /// <summary> The list of elastic pool database activities. </summary>
        public IReadOnlyList<ElasticPoolDatabaseActivity> Value { get; }
    }
}
