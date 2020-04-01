// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 获取增量文件操作记录
     */
    public class ListFileDeltaRequest : TeaModel {
        [NameInMap("cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
