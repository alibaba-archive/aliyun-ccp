// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CCPGetAsyncTaskRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public CCPGetAsyncTaskRequestHeader Header { get; set; }
        public class CCPGetAsyncTaskRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

    }

}
