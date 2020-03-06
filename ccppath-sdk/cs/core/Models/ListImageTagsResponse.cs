// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 展示标签集合
     */
    public class ListImageTagsResponse : TeaModel {
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ImageTagResponse> Tags { get; set; }

    }

}
