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

namespace Microsoft.WindowsAzure.Management.MediaServices.Models
{
    /// <summary>
    /// The Create Media Services Account operation response.
    /// </summary>
    public partial class MediaServicesCreatedAccount
    {
        private string _accountId;
        
        /// <summary>
        /// Optional. The Id of the created Media Services account.
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }
        
        private string _accountName;
        
        /// <summary>
        /// Optional. The Name of the created Media Services account.
        /// </summary>
        public string AccountName
        {
            get { return this._accountName; }
            set { this._accountName = value; }
        }
        
        private string _subscriptionId;
        
        /// <summary>
        /// Optional. The subscription Id associated with the created Media
        /// Services account.
        /// </summary>
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MediaServicesCreatedAccount class.
        /// </summary>
        public MediaServicesCreatedAccount()
        {
        }
    }
}
