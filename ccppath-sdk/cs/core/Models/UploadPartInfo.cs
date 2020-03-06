// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 
     */
    public class UploadPartInfo : TeaModel {
        [NameInMap("etag")]
        [Validation(Required=false)]
        public string Etag { get; set; }

        [NameInMap("part_number")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public long PartNumber { get; set; }

        [NameInMap("part_size")]
        [Validation(Required=false)]
        public long PartSize { get; set; }

        [NameInMap("upload_url")]
        [Validation(Required=false)]
        public string UploadUrl { get; set; }

    }

}
