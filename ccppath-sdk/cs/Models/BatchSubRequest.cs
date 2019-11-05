// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class BatchSubRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public object Body { get; set; }

        [NameInMap("headers")]
        [Validation(Required=false)]
        public object Headers { get; set; }

        [NameInMap("id")]
        [Validation(Required=true)]
        public string Id { get; set; }

        [NameInMap("method")]
        [Validation(Required=true)]
        public string Method { get; set; }

        [NameInMap("url")]
        [Validation(Required=true)]
        public string Url { get; set; }

    }

}
