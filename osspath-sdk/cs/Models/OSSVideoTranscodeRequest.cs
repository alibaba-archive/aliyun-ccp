// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 启动视频转码请求
     */
    public class OSSVideoTranscodeRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=true, MaxLength=1000)]
        public string FilePath { get; set; }

        [NameInMap("hls_time")]
        [Validation(Required=false)]
        public long HlsTime { get; set; }

        [NameInMap("remarks")]
        [Validation(Required=false)]
        public string Remarks { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9a-zA-Z-]+")]
        public string ShareId { get; set; }

        [NameInMap("transcode")]
        [Validation(Required=false)]
        public bool? Transcode { get; set; }

    }

}
