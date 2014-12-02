// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// Aggregation type.
    /// </summary>
    public enum AggregationType
    {
        /// <summary>
        /// No aggregation.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Average value in the time range.
        /// </summary>
        Average = 1,
        
        /// <summary>
        /// Least value in the time range.
        /// </summary>
        Minimum = 2,
        
        /// <summary>
        /// Greatest value in the time range.
        /// </summary>
        Maximum = 3,
        
        /// <summary>
        /// Sum of all of the values in the time range.
        /// </summary>
        Total = 4,
        
        /// <summary>
        /// Last sample in the time range.
        /// </summary>
        Last = 5,
    }
}
