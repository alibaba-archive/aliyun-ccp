// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * batch operation response
     */
    public class CCPBatchResponse : TeaModel {
        [NameInMap("responses")]
        [Validation(Required=false)]
        public List<BatchSubResponse> Responses { get; set; }

    }

}
