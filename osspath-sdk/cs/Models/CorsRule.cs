// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CorsRule : TeaModel {
        [NameInMap("allowed_header")]
        [Validation(Required=false)]
        public List<string> AllowedHeader { get; set; }

        [NameInMap("allowed_method")]
        [Validation(Required=false)]
        public List<string> AllowedMethod { get; set; }

        [NameInMap("allowed_origin")]
        [Validation(Required=false)]
        public List<string> AllowedOrigin { get; set; }

        [NameInMap("expose_header")]
        [Validation(Required=false)]
        public List<string> ExposeHeader { get; set; }

        [NameInMap("max_age_seconds")]
        [Validation(Required=false)]
        public long MaxAgeSeconds { get; set; }

    }

}
