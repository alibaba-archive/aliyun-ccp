// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DownloadFileRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public DownloadFileRequestHeader Header { get; set; }
        public class DownloadFileRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("DriveID")]
        [Validation(Required=true)]
        public string DriveID { get; set; }

        [NameInMap("FileID")]
        [Validation(Required=true)]
        public string FileID { get; set; }

        [NameInMap("ImageProcess")]
        [Validation(Required=false)]
        public string ImageProcess { get; set; }

    }

}
