
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class LinkInfoListResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("items")]
        [Validation(Required=true)]
        public List<LinkInfoResponse> Items { get; set; }

    }

}
