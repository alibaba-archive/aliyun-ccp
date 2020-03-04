// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class GetUserAccessTokenRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public GetUserAccessTokenRequestHeader Header { get; set; }
        public class GetUserAccessTokenRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=true)]
        public string UserId { get; set; }

    }

}
