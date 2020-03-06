// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 列举uploadID对应的已上传分片
     */
    public class CCPListUploadedPartRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9.-_]{1,50}")]
        public string FileId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public long Limit { get; set; }

        [NameInMap("part_number_marker")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public long PartNumberMarker { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
