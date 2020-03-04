// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CCPDeleteFilesRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public CCPDeleteFilesRequestHeader Header { get; set; }
        public class CCPDeleteFilesRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_id_list")]
        [Validation(Required=true)]
        public List<string> FileIdList { get; set; }

    }

}
