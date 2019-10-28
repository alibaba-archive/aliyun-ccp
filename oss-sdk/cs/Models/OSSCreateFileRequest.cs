// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class OSSCreateFileRequest : TeaModel {
        [NameInMap("content_md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=true)]
        public string ContentType { get; set; }

        [NameInMap("name")]
        [Validation(Required=true, Pattern="[a-z0-9.-_]{1,1024}")]
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

        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("parent_file_path")]
        [Validation(Required=true)]
        public string ParentFilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, MaxLength=40)]
        public string ShareId { get; set; }

    }

}
