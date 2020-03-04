// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UCGetObjectInfoByObjectKeyRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public UCGetObjectInfoByObjectKeyRequestHeader Header { get; set; }
        public class UCGetObjectInfoByObjectKeyRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("object_key")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
