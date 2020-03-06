// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 
     */
    public class ListStoresResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=true)]
        public List<Store> Items { get; set; }

    }

}
