// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class Captcha : TeaModel {
        [NameInMap("captcha")]
        [Validation(Required=true)]
        public string Captcha_ { get; set; }

        [NameInMap("captcha_format")]
        [Validation(Required=true)]
        public string CaptchaFormat { get; set; }

        [NameInMap("captcha_id")]
        [Validation(Required=true)]
        public string CaptchaId { get; set; }

    }

}
