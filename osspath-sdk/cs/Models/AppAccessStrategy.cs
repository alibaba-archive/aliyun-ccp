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
    public class AppAccessStrategy : TeaModel {
        [NameInMap("effect")]
        [Validation(Required=false)]
        public string Effect { get; set; }

        [NameInMap("except_app_id_list")]
        [Validation(Required=false)]
        public List<string> ExceptAppIdList { get; set; }

    }

}
