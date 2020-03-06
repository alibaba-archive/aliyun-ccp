// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 
     */
    public class LinkInfoResponse : TeaModel {
        [NameInMap("authentication_type")]
        [Validation(Required=true)]
        public string AuthenticationType { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=true)]
        public long CreatedAt { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

        [NameInMap("identity")]
        [Validation(Required=true)]
        public string Identity { get; set; }

        [NameInMap("last_login_time")]
        [Validation(Required=true)]
        public long LastLoginTime { get; set; }

        [NameInMap("status")]
        [Validation(Required=true)]
        public string Status { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=true)]
        public string UserId { get; set; }

    }

}
