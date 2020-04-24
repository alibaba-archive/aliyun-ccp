// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 展示地点分组列表
     */
    public class SearchImageAddressGroupsResponse : TeaModel {
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ImageAddressResponse> Items { get; set; }

    }

}
