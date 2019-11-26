// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CCPGetUploadUrlResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("create_at")]
        [Validation(Required=false)]
        public string CreateAt { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false, Pattern="[a-z0-9A-Z]+")]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false, MaxLength=50, Pattern="[a-z0-9]{1, 50}")]
        public string FileId { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
