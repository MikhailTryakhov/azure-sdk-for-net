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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    /// <summary>
    /// The response structure for the Network Operations List operation.
    /// </summary>
    public partial class NetworkListResponse : OperationResponse, IEnumerable<NetworkListResponse.VirtualNetworkSite>
    {
        private IList<NetworkListResponse.VirtualNetworkSite> _virtualNetworkSites;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<NetworkListResponse.VirtualNetworkSite> VirtualNetworkSites
        {
            get { return this._virtualNetworkSites; }
            set { this._virtualNetworkSites = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the NetworkListResponse class.
        /// </summary>
        public NetworkListResponse()
        {
            this.VirtualNetworkSites = new LazyList<NetworkListResponse.VirtualNetworkSite>();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualNetworkSites.
        /// </summary>
        public IEnumerator<NetworkListResponse.VirtualNetworkSite> GetEnumerator()
        {
            return this.VirtualNetworkSites.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of VirtualNetworkSites.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        public partial class AddressSpace
        {
            private IList<string> _addressPrefixes;
            
            /// <summary>
            /// Optional. Address spaces, in CIDR format in the virtual network.
            /// </summary>
            public IList<string> AddressPrefixes
            {
                get { return this._addressPrefixes; }
                set { this._addressPrefixes = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the AddressSpace class.
            /// </summary>
            public AddressSpace()
            {
                this.AddressPrefixes = new LazyList<string>();
            }
        }
        
        /// <summary>
        /// Specifies the type of connection of the local network site. The
        /// value of this element can be either IPsec or Dedicated. The
        /// default value is IPsec.
        /// </summary>
        public partial class Connection
        {
            private LocalNetworkConnectionType _type;
            
            /// <summary>
            /// Optional.
            /// </summary>
            public LocalNetworkConnectionType Type
            {
                get { return this._type; }
                set { this._type = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Connection class.
            /// </summary>
            public Connection()
            {
            }
        }
        
        public partial class DnsServer
        {
            private string _address;
            
            /// <summary>
            /// Optional. The IPv4 address of the DNS server.
            /// </summary>
            public string Address
            {
                get { return this._address; }
                set { this._address = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of the DNS server.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the DnsServer class.
            /// </summary>
            public DnsServer()
            {
            }
        }
        
        /// <summary>
        /// Contains gateway references to the local network sites that the
        /// virtual network can connect to.
        /// </summary>
        public partial class Gateway
        {
            private GatewayProfile _profile;
            
            /// <summary>
            /// Optional. The gateway connection size.
            /// </summary>
            public GatewayProfile Profile
            {
                get { return this._profile; }
                set { this._profile = value; }
            }
            
            private IList<NetworkListResponse.LocalNetworkSite> _sites;
            
            /// <summary>
            /// Optional. The list of local network sites that the virtual
            /// network can connect to.
            /// </summary>
            public IList<NetworkListResponse.LocalNetworkSite> Sites
            {
                get { return this._sites; }
                set { this._sites = value; }
            }
            
            private NetworkListResponse.VPNClientAddressPool _vPNClientAddressPool;
            
            /// <summary>
            /// Optional. The VPN Client Address Pool reserves a pool of IP
            /// addresses for VPN clients. This object is used for
            /// point-to-site connectivity.
            /// </summary>
            public NetworkListResponse.VPNClientAddressPool VPNClientAddressPool
            {
                get { return this._vPNClientAddressPool; }
                set { this._vPNClientAddressPool = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Gateway class.
            /// </summary>
            public Gateway()
            {
                this.Sites = new LazyList<NetworkListResponse.LocalNetworkSite>();
            }
        }
        
        /// <summary>
        /// Contains the list of parameters defining the local network site.
        /// </summary>
        public partial class LocalNetworkSite
        {
            private NetworkListResponse.AddressSpace _addressSpace;
            
            /// <summary>
            /// Optional. The address space of the local network site.
            /// </summary>
            public NetworkListResponse.AddressSpace AddressSpace
            {
                get { return this._addressSpace; }
                set { this._addressSpace = value; }
            }
            
            private IList<NetworkListResponse.Connection> _connections;
            
            /// <summary>
            /// Optional. Specifies the types of connections to the local
            /// network site.
            /// </summary>
            public IList<NetworkListResponse.Connection> Connections
            {
                get { return this._connections; }
                set { this._connections = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. The name of the local network site.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _vpnGatewayAddress;
            
            /// <summary>
            /// Optional. The IPv4 address of the local network site.
            /// </summary>
            public string VpnGatewayAddress
            {
                get { return this._vpnGatewayAddress; }
                set { this._vpnGatewayAddress = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the LocalNetworkSite class.
            /// </summary>
            public LocalNetworkSite()
            {
                this.Connections = new LazyList<NetworkListResponse.Connection>();
            }
        }
        
        public partial class Subnet
        {
            private string _addressPrefix;
            
            /// <summary>
            /// Optional. Represents an address space, in CIDR format that
            /// defines the subnet.
            /// </summary>
            public string AddressPrefix
            {
                get { return this._addressPrefix; }
                set { this._addressPrefix = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Name of the subnet.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _networkSecurityGroup;
            
            /// <summary>
            /// Optional. Name of Network Security Group associated with this
            /// subnet.
            /// </summary>
            public string NetworkSecurityGroup
            {
                get { return this._networkSecurityGroup; }
                set { this._networkSecurityGroup = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the Subnet class.
            /// </summary>
            public Subnet()
            {
            }
        }
        
        /// <summary>
        /// Contains the collections of parameters used to configure a virtual
        /// network space that is dedicated to your subscription without
        /// overlapping with other networks
        /// </summary>
        public partial class VirtualNetworkSite
        {
            private NetworkListResponse.AddressSpace _addressSpace;
            
            /// <summary>
            /// Optional. The list of network address spaces for a virtual
            /// network site. This represents the overall network space
            /// contained within the virtual network site.
            /// </summary>
            public NetworkListResponse.AddressSpace AddressSpace
            {
                get { return this._addressSpace; }
                set { this._addressSpace = value; }
            }
            
            private string _affinityGroup;
            
            /// <summary>
            /// Optional. An affinity group, which indirectly refers to the
            /// location where the virtual network exists.
            /// </summary>
            public string AffinityGroup
            {
                get { return this._affinityGroup; }
                set { this._affinityGroup = value; }
            }
            
            private IList<NetworkListResponse.DnsServer> _dnsServers;
            
            /// <summary>
            /// Optional. The list of available DNS Servers associated with the
            /// virtual network site.
            /// </summary>
            public IList<NetworkListResponse.DnsServer> DnsServers
            {
                get { return this._dnsServers; }
                set { this._dnsServers = value; }
            }
            
            private NetworkListResponse.Gateway _gateway;
            
            /// <summary>
            /// Optional. The gateway that contains a list of Local Network
            /// Sites which enable the Virtual Network Site to communicate
            /// with a customer's on-premise networks.
            /// </summary>
            public NetworkListResponse.Gateway Gateway
            {
                get { return this._gateway; }
                set { this._gateway = value; }
            }
            
            private string _id;
            
            /// <summary>
            /// Optional. A unique string identifier that represents the
            /// virtual network site.
            /// </summary>
            public string Id
            {
                get { return this._id; }
                set { this._id = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. The friendly identifier for the site.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _location;
            
            /// <summary>
            /// Optional. Gets or sets the virtual network location.
            /// </summary>
            public string Location
            {
                get { return this._location; }
                set { this._location = value; }
            }
            
            private string _name;
            
            /// <summary>
            /// Optional. Name of the virtual network site.
            /// </summary>
            public string Name
            {
                get { return this._name; }
                set { this._name = value; }
            }
            
            private string _state;
            
            /// <summary>
            /// Optional. Current status of the virtual network. (Created,
            /// Creating, Updating, Deleting, or Unavailable.)
            /// </summary>
            public string State
            {
                get { return this._state; }
                set { this._state = value; }
            }
            
            private IList<NetworkListResponse.Subnet> _subnets;
            
            /// <summary>
            /// Optional. The list of network subnets for a virtual network
            /// site. All network subnets must be contained within the overall
            /// virtual network address spaces.
            /// </summary>
            public IList<NetworkListResponse.Subnet> Subnets
            {
                get { return this._subnets; }
                set { this._subnets = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the VirtualNetworkSite class.
            /// </summary>
            public VirtualNetworkSite()
            {
                this.DnsServers = new LazyList<NetworkListResponse.DnsServer>();
                this.Subnets = new LazyList<NetworkListResponse.Subnet>();
            }
        }
        
        /// <summary>
        /// The VPN Client Address Pool reserves a pool of IP addresses for VPN
        /// clients. This object is used for point-to-site connectivity.
        /// </summary>
        public partial class VPNClientAddressPool
        {
            private IList<string> _addressPrefixes;
            
            /// <summary>
            /// Optional. The CIDR identifiers that identify addresses in the
            /// pool.
            /// </summary>
            public IList<string> AddressPrefixes
            {
                get { return this._addressPrefixes; }
                set { this._addressPrefixes = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the VPNClientAddressPool class.
            /// </summary>
            public VPNClientAddressPool()
            {
                this.AddressPrefixes = new LazyList<string>();
            }
        }
    }
}
