// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class LoginByCodeRequest : TeaModel {
        [NameInMap("access_token")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("auth_code")]
        [Validation(Required=false)]
        public string AuthCode { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
