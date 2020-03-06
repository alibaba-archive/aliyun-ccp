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
    public class RemoveStoreRequest : TeaModel {
        [NameInMap("domain_id")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=true)]
        public string StoreId { get; set; }

    }

}
