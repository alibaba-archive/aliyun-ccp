// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * List storage file
     */
    public class ListStoreFileResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<StoreFile> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
