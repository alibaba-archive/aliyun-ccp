// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 批处理
     */
    public class CCPBatchRequest : TeaModel {
        [NameInMap("requests")]
        [Validation(Required=true)]
        public List<BatchSubRequest> Requests { get; set; }

        [NameInMap("resource")]
        [Validation(Required=true)]
        public string Resource { get; set; }

    }

}
