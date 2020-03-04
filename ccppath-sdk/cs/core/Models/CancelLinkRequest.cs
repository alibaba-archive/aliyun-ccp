// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class CancelLinkRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public CancelLinkRequestHeader Header { get; set; }
        public class CancelLinkRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("temporary_token")]
        [Validation(Required=true)]
        public string TemporaryToken { get; set; }

    }

}
