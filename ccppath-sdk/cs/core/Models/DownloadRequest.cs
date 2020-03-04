// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DownloadRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public DownloadRequestHeader Header { get; set; }
        public class DownloadRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("DriveID")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveID { get; set; }

        [NameInMap("FileID")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9.-_]{1,50}")]
        public string FileID { get; set; }

        [NameInMap("ImageProcess")]
        [Validation(Required=false)]
        public string ImageProcess { get; set; }

        [NameInMap("ShareID")]
        [Validation(Required=false)]
        public string ShareID { get; set; }

    }

}
