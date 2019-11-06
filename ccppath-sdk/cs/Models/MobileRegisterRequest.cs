
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class MobileRegisterRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("phone_number")]
        [Validation(Required=true)]
        public string PhoneNumber { get; set; }

        [NameInMap("sms_code")]
        [Validation(Required=true)]
        public string SmsCode { get; set; }

        [NameInMap("sms_code_id")]
        [Validation(Required=true)]
        public string SmsCodeId { get; set; }

    }

}
