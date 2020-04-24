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
    public class Address : TeaModel {
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
