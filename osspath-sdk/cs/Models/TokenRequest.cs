// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class TokenRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public TokenRequestHeader Header { get; set; }
        public class TokenRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

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
