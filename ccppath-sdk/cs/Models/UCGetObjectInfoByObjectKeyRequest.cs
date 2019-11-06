
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UCGetObjectInfoByObjectKeyRequest : TeaModel {
        [NameInMap("object_key")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
