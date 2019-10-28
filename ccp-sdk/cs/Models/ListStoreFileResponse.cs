// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class ListStoreFileResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("items")]
        [Validation(Required=false)]
        public List<StoreFile> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
