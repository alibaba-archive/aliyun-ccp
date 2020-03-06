// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 
     */
    public class StoreItemResponse : TeaModel {
        [NameInMap("accelerate_endpoint")]
        [Validation(Required=false)]
        public string AccelerateEndpoint { get; set; }

        [NameInMap("base_path")]
        [Validation(Required=false)]
        public string BasePath { get; set; }

        [NameInMap("bucket")]
        [Validation(Required=true)]
        public string Bucket { get; set; }

        [NameInMap("customized_endpoint")]
        [Validation(Required=false)]
        public string CustomizedEndpoint { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=true)]
        public string Endpoint { get; set; }

        [NameInMap("internal_endpoint")]
        [Validation(Required=false)]
        public string InternalEndpoint { get; set; }

        [NameInMap("ownership")]
        [Validation(Required=true)]
        public string Ownership { get; set; }

        [NameInMap("policy")]
        [Validation(Required=true)]
        public string Policy { get; set; }

        [NameInMap("role_arn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=true)]
        public string StoreId { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
