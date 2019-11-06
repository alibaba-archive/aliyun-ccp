
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class GetCaptchaRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

    }

}
