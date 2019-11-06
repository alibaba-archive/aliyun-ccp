
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class PreHashCheckSuccessResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("parent_file_id")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9]{1, 50}")]
        public string ParentFileId { get; set; }

        [NameInMap("pre_hash")]
        [Validation(Required=false)]
        public string PreHash { get; set; }

    }

}
