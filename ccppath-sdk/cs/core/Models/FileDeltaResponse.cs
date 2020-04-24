// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * the file op info
     */
    public class FileDeltaResponse : TeaModel {
        [NameInMap("current_category")]
        [Validation(Required=false)]
        public string CurrentCategory { get; set; }

        [NameInMap("file")]
        [Validation(Required=false)]
        public BaseCCPFileResponse File { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

    }

}
