
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UCGetObjectInfoBySha1Request : TeaModel {
        [NameInMap("sha1")]
        [Validation(Required=false)]
        public string Sha1 { get; set; }

    }

}
