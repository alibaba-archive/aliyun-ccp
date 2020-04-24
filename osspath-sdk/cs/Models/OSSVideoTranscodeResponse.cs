// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 转码接口response
     */
    public class OSSVideoTranscodeResponse : TeaModel {
        [NameInMap("definition_list")]
        [Validation(Required=false)]
        public List<string> DefinitionList { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public long Duration { get; set; }

        [NameInMap("hls_time")]
        [Validation(Required=false)]
        public long HlsTime { get; set; }

    }

}
