// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DeleteDriveRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public DeleteDriveRequestHeader Header { get; set; }
        public class DeleteDriveRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("drive_id")]
        [Validation(Required=true)]
        public string DriveId { get; set; }

    }

}
