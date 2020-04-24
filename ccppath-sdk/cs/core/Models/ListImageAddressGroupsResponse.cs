// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 展示地点分组集合
     */
    public class ListImageAddressGroupsResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ImageAddressResponse> Items { get; set; }

        [NameInMap("next_marker")]
        [Validation(Required=false)]
        public string NextMarker { get; set; }

    }

}
