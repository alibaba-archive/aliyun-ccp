// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class CCPGetDownloadUrlRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public long ExpireSec { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9.-_]{1, 50}")]
        public string FileId { get; set; }

        [NameInMap("file_name")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9.-]{1,1024}")]
        public string FileName { get; set; }

    }

}
