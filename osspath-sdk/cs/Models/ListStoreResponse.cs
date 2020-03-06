// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * List storage
     */
    public class ListStoreResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<StoreItemResponse> Items { get; set; }

    }

}
