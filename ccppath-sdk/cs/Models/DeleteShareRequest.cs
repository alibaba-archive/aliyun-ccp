
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DeleteShareRequest : TeaModel {
        [NameInMap("share_id")]
        [Validation(Required=true)]
        public string ShareId { get; set; }

    }

}
