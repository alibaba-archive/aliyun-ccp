// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class OSSVideoTranscodeRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public OSSVideoTranscodeRequestHeader Header { get; set; }
        public class OSSVideoTranscodeRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=true, MaxLength=1000)]
        public string FilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-z-]+")]
        public string ShareId { get; set; }

    }

}
