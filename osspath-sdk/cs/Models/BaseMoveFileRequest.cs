// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 文件移动请求
     */
    public class BaseMoveFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("new_name")]
        [Validation(Required=false)]
        public string NewName { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

    }

}
