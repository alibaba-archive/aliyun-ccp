// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class DefaultSetPasswordRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public DefaultSetPasswordRequestHeader Header { get; set; }
        public class DefaultSetPasswordRequestHeader : TeaModel {
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

        [NameInMap("new_password")]
        [Validation(Required=true)]
        public string NewPassword { get; set; }

        [NameInMap("state")]
        [Validation(Required=true)]
        public string State { get; set; }

    }

}
