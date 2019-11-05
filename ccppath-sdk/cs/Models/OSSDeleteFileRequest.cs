// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class OSSDeleteFileRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9.-_]{1,50}")]
        public string FilePath { get; set; }

        [NameInMap("permanently")]
        [Validation(Required=false)]
        public bool Permanently { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-z-]+")]
        public string ShareId { get; set; }

    }

}
