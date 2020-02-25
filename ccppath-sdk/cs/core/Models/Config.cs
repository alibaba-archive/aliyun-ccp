// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class Config : TeaModel {
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("domainId")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

        [NameInMap("protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("credentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        [NameInMap("securityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("accessKeyId")]
        [Validation(Required=false)]
        public string AccessKeyId { get; set; }

        [NameInMap("accessKeySecret")]
        [Validation(Required=false)]
        public string AccessKeySecret { get; set; }

        [NameInMap("clientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("refreshToken")]
        [Validation(Required=false)]
        public string RefreshToken { get; set; }

        [NameInMap("clientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        [NameInMap("expireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("userAgent")]
        [Validation(Required=false)]
        public string UserAgent { get; set; }

    }

}
