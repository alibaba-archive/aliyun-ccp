// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class OSSListUploadedPartRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public OSSListUploadedPartRequestHeader Header { get; set; }
        public class OSSListUploadedPartRequestHeader : TeaModel {
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
        [Validation(Required=true)]
        public string FilePath { get; set; }

        [NameInMap("limit")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public long Limit { get; set; }

        [NameInMap("part_number_marker")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public long PartNumberMarker { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-z-]+")]
        public string ShareId { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
