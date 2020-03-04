// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class ListStoreRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public ListStoreRequestHeader Header { get; set; }
        public class ListStoreRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

    }

}
