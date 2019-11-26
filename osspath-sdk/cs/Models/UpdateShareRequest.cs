// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class UpdateShareRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false, MaxLength=1024)]
        public string Description { get; set; }

        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<string> Permissions { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=true)]
        public string ShareId { get; set; }

        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
