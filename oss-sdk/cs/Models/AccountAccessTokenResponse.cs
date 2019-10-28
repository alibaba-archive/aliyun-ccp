// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class AccountAccessTokenResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("access_token")]
        [Validation(Required=true)]
        public string AccessToken { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=true)]
        public string ExpireTime { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=true)]
        public long ExpiresIn { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=true)]
        public string RefreshToken { get; set; }

        [NameInMap("role")]
        [Validation(Required=true)]
        public string Role { get; set; }

        [NameInMap("state")]
        [Validation(Required=true)]
        public string State { get; set; }

        [NameInMap("token_type")]
        [Validation(Required=true)]
        public string TokenType { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=true)]
        public string UserId { get; set; }

    }

}
