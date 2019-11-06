
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class CCPBatchResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("responses")]
        [Validation(Required=false)]
        public List<BatchSubResponse> Responses { get; set; }

    }

}
