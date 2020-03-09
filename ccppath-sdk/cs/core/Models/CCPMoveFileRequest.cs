// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 文件移动请求
     */
    public class CCPMoveFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("new_name")]
        [Validation(Required=false, Pattern=".{1,1000}")]
        public string NewName { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false, MaxLength=50, Pattern="[a-z0-9.-_]{1,50}")]
        public string FileId { get; set; }

        [NameInMap("to_parent_file_id")]
        [Validation(Required=false, MaxLength=50)]
        public string ToParentFileId { get; set; }

    }

}
