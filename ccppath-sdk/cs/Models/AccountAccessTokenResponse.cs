
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class AccountAccessTokenResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("access_token")]
        [Validation(Required=true)]
        public string AccessToken { get; set; }

        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("default_drive_id")]
        [Validation(Required=false)]
        public string DefaultDriveId { get; set; }

        [NameInMap("exist_link")]
        [Validation(Required=false)]
        public List<LinkInfo> ExistLink { get; set; }

        [NameInMap("expire_time")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("expires_in")]
        [Validation(Required=false)]
        public long ExpiresIn { get; set; }

        [NameInMap("need_link")]
        [Validation(Required=true)]
        public bool NeedLink { get; set; }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("refresh_token")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        [NameInMap("token_type")]
        [Validation(Required=false)]
        public string TokenType { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
