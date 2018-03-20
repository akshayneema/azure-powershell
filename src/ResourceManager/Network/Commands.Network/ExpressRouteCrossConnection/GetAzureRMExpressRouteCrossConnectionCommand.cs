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
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Management.Network;
using Microsoft.Azure.Management.Network.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using AutoMapper;
using CNM = Microsoft.Azure.Commands.Network.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.Get, "AzureRmExpressRouteCrossConnection"), OutputType(typeof(PSExpressRouteCrossConnection))]
    public partial class GetAzureRmExpressRouteCrossConnection : ExpressRouteCrossConnectionBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = "The resource group name of express route cross connection.",
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The name of express route cross connection.",
            ValueFromPipelineByPropertyName = true)]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        public override void Execute()
        {
            base.Execute();
            if (!string.IsNullOrEmpty(this.Name))
            {
                var crossConnection = this.GetExpressRouteCrossConnection(this.ResourceGroupName, this.Name);

                WriteObject(crossConnection);
            }
            else
            {
                IPage<ExpressRouteCrossConnection> crossConnectionPage;
                if (!string.IsNullOrEmpty(this.ResourceGroupName))
                {
                    crossConnectionPage = this.ExpressRouteCrossConnectionClient.List(this.ResourceGroupName);
                }
                else
                {
                    crossConnectionPage = this.ExpressRouteCrossConnectionClient.ListAll();
                }

                // Get all resources by polling on next page link
                var crossConnectionList = ListNextLink<ExpressRouteCrossConnection>.GetAllResourcesByPollingNextLink(crossConnectionPage, this.ExpressRouteCrossConnectionClient.ListNext);

                var psCircuits = new List<PSExpressRouteCrossConnection>();
                foreach (var crossConnection in crossConnectionList)
                {
                    var psVnet = this.ToPsExpressRouteCrossConnection(crossConnection);
                    psVnet.ResourceGroupName = NetworkBaseCmdlet.GetResourceGroup(crossConnection.Id);
                    psCircuits.Add(psVnet);
                }

                WriteObject(psCircuits, true);
            }
        }
    }
}
