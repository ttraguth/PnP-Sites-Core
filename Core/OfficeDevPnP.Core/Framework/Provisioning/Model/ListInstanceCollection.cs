﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDevPnP.Core.Framework.Provisioning.Model
{
    /// <summary>
    /// Collection of ListInstance objects
    /// </summary>
    public partial class ListInstanceCollection : ProvisioningTemplateCollection<ListInstance>
    {
        public ListInstanceCollection(ProvisioningTemplate parentTemplate) : base(parentTemplate)
        {

        }
    }
}
