// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CCPCreateFileRequest : TeaModel {
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

        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false, MaxLength=0)]
        public string Description { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool Hidden { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9]{1, 50}")]
        public string ParentFileId { get; set; }

        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public object Tags { get; set; }

    }

}
