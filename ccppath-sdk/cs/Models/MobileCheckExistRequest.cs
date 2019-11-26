// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class MobileCheckExistRequest : TeaModel {
        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("phone_number")]
        [Validation(Required=true)]
        public string PhoneNumber { get; set; }

    }

}
