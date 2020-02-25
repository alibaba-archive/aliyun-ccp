// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class GetAccessTokenByLinkInfoRequest : TeaModel {
        [NameInMap("identity")]
        [Validation(Required=true)]
        public string Identity { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
