// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * list drive response
     */
    public class ListDriveResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<BaseDriveResponse> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
