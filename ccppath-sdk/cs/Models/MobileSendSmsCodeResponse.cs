
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class MobileSendSmsCodeResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("sms_code_id")]
        [Validation(Required=true)]
        public string SmsCodeId { get; set; }

    }

}
