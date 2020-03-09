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
    public class BaseCreateFileRequest : TeaModel {
        [NameInMap("content_md5")]
        [Validation(Required=true)]
        public string ContentMd5 { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=true)]
        public string ContentType { get; set; }

        [NameInMap("name")]
        [Validation(Required=true)]
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
