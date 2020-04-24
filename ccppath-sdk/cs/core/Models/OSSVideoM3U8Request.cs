// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 获取视频的m3u8文件
     */
    public class OSSVideoM3U8Request : TeaModel {
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public long ExpireSec { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=true, MaxLength=1000)]
        public string FilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-Z-]+")]
        public string ShareId { get; set; }

        [NameInMap("sign_token")]
        [Validation(Required=true)]
        public string SignToken { get; set; }

    }

}
