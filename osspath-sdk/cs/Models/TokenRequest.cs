// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class TokenRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("grant_type")]
        [Validation(Required=true)]
        public string GrantType { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=true)]
        public string RefreshToken { get; set; }

    }

}
