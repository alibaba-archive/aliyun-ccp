// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class OSSListUploadedPartResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("next_part_number_marker")]
        [Validation(Required=false)]
        public string NextPartNumberMarker { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        [NameInMap("uploaded_parts")]
        [Validation(Required=false)]
        public List<UploadPartInfo> UploadedParts { get; set; }

    }

}
