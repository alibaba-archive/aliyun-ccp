// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UserAuthentication : TeaModel {
        [NameInMap("AuthenticationType")]
        [Validation(Required=true)]
        public string AuthenticationType { get; set; }

        [NameInMap("CreatedAt")]
        [Validation(Required=true)]
        public long CreatedAt { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=true)]
        public string Detail { get; set; }

        [NameInMap("DomainID")]
        [Validation(Required=true)]
        public string DomainID { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=true)]
        public string Identity { get; set; }

        [NameInMap("LastLoginTime")]
        [Validation(Required=true)]
        public long LastLoginTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

        [NameInMap("UserID")]
        [Validation(Required=true)]
        public string UserID { get; set; }

    }

}
