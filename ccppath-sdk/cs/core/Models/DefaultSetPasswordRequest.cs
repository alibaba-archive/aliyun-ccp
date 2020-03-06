// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 
     */
    public class DefaultSetPasswordRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("new_password")]
        [Validation(Required=true)]
        public string NewPassword { get; set; }

        [NameInMap("state")]
        [Validation(Required=true)]
        public string State { get; set; }

    }

}
