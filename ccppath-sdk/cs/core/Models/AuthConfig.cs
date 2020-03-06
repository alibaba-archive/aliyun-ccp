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
    public class AuthConfig : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        [NameInMap("enterprise_id")]
        [Validation(Required=false)]
        public string EnterpriseId { get; set; }

    }

}
