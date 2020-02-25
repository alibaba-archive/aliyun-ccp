// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class AddStoreRequest : TeaModel {
        [NameInMap("base_path")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=true)]
        public string Endpoint { get; set; }

        [NameInMap("ownership")]
        [Validation(Required=false)]
        public string Ownership { get; set; }

        [NameInMap("role_arn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
