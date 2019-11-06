
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class ListDomainsRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
