// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 
     */
    public class LinkInfoListResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=true)]
        public List<LinkInfoResponse> Items { get; set; }

    }

}
