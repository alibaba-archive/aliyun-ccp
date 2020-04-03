// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DownloadFileQuery : TeaModel {
        [NameInMap("DriveID")]
        [Validation(Required=true)]
        public string DriveID { get; set; }

        [NameInMap("FileID")]
        [Validation(Required=true)]
        public string FileID { get; set; }

        [NameInMap("ImageProcess")]
        [Validation(Required=false)]
        public string ImageProcess { get; set; }

    }

}
