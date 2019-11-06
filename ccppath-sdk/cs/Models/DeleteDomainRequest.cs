
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DeleteDomainRequest : TeaModel {
        [NameInMap("domain_id")]
        [Validation(Required=true)]
        public string DomainId { get; set; }

    }

}
