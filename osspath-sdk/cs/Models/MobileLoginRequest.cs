// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class MobileLoginRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("auto_register")]
        [Validation(Required=false)]
        public bool AutoRegister { get; set; }

        [NameInMap("captcha_id")]
        [Validation(Required=false)]
        public string CaptchaId { get; set; }

        [NameInMap("captcha_text")]
        [Validation(Required=false)]
        public string CaptchaText { get; set; }

        [NameInMap("password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        [NameInMap("phone_number")]
        [Validation(Required=true)]
        public string PhoneNumber { get; set; }

        [NameInMap("sms_code")]
        [Validation(Required=false)]
        public string SmsCode { get; set; }

        [NameInMap("sms_code_id")]
        [Validation(Required=false)]
        public string SmsCodeId { get; set; }

    }

}
