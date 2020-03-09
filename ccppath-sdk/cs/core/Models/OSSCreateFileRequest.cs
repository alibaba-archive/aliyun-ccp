// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * create file request
     */
    public class OSSCreateFileRequest : TeaModel {
        [NameInMap("content_md5")]
        [Validation(Required=false)]
        public string ContentMd5 { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long Size { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("parent_file_path")]
        [Validation(Required=false)]
        public string ParentFilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, MaxLength=40)]
        public string ShareId { get; set; }

    }

}
