// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 
     */
    public class StreamInfo : TeaModel {
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("content_md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        [NameInMap("part_info_list")]
        [Validation(Required=false)]
        public List<UploadPartInfo> PartInfoList { get; set; }

        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

        [NameInMap("size")]
        [Validation(Required=true)]
        public long Size { get; set; }

    }

}
