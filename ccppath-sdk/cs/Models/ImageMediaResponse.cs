
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class ImageMediaResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("height")]
        [Validation(Required=false)]
        public long Height { get; set; }

        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("width")]
        [Validation(Required=false)]
        public long Width { get; set; }

    }

}
