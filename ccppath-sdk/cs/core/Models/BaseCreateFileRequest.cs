// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class BaseCreateFileRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public BaseCreateFileRequestHeader Header { get; set; }
        public class BaseCreateFileRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("content_md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=true)]
        public string ContentType { get; set; }

        [NameInMap("name")]
        [Validation(Required=true, Pattern="[a-z0-9.-_]{1,1000}")]
        public string Name { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("size")]
        [Validation(Required=true)]
        public long Size { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
