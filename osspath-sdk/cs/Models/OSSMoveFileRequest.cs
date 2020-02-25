// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class OSSMoveFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("new_name")]
        [Validation(Required=true)]
        public string NewName { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool? Overwrite { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-z-]+")]
        public string ShareId { get; set; }

        [NameInMap("to_parent_file_path")]
        [Validation(Required=false)]
        public string ToParentFilePath { get; set; }

    }

}
