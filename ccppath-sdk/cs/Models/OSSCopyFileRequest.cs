// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class OSSCopyFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("new_name")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9.-]{1,1024}")]
        public string NewName { get; set; }

        [NameInMap("overwrite")]
        [Validation(Required=false)]
        public bool Overwrite { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-z-]+")]
        public string ShareId { get; set; }

        [NameInMap("to_drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string ToDriveId { get; set; }

        [NameInMap("to_parent_file_path")]
        [Validation(Required=true)]
        public string ToParentFilePath { get; set; }

        [NameInMap("to_share_id")]
        [Validation(Required=false)]
        public string ToShareId { get; set; }

    }

}
