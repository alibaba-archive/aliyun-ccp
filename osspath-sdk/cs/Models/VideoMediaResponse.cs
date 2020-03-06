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
    public class VideoMediaResponse : TeaModel {
        [NameInMap("address_line")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        [NameInMap("duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
