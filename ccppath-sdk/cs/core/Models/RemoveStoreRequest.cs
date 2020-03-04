// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class RemoveStoreRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public RemoveStoreRequestHeader Header { get; set; }
        public class RemoveStoreRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("domain_id")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=true)]
        public string StoreId { get; set; }

    }

}
