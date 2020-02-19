// This file is auto-generated, don't edit it. Thanks.

using Tea;

namespace AlibabaCloud.AccessTokenCredential.Models
{
    public class Config : TeaModel {
        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("domainId")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

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

    }

}
