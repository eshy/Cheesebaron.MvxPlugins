﻿//---------------------------------------------------------------------------------
// Copyright 2013 Tomasz Cielecki (tomasz@ostebaronen.dk)
// Licensed under the Apache License, Version 2.0 (the "License"); 
// You may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 

// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED, 
// INCLUDING WITHOUT LIMITATION ANY IMPLIED WARRANTIES OR 
// CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE, 
// MERCHANTABLITY OR NON-INFRINGEMENT. 

// See the Apache 2 License for the specific language governing 
// permissions and limitations under the License.
//---------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cheesebaron.MvxPlugins.Connectivity
{
    public interface IConnectivity
    {
        bool IsConnected{ get; }
        Task<bool> IsPingReachable(string host, int msTimeout = 5000);
        Task<bool> IsPortReachable(string host, int port = 80, int msTimeout = 5000);
        IEnumerable<ConnectionType> ConnectionTypes { get; }
        IEnumerable<int> Bandwidths { get; }
    }
}
