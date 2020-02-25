// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class AccountLinkRequest : TeaModel {
        [NameInMap("detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("identity")]
        [Validation(Required=true)]
        public string Identity { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=true)]
        public string UserId { get; set; }

    }

}
