// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CreateAppRequest : TeaModel {
        [NameInMap("app_name")]
        [Validation(Required=true, MaxLength=128)]
        public string AppName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false, MaxLength=128)]
        public string Description { get; set; }

        [NameInMap("is_third_party")]
        [Validation(Required=false)]
        public bool IsThirdParty { get; set; }

        [NameInMap("logo")]
        [Validation(Required=true)]
        public string Logo { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=false)]
        public string RedirectUri { get; set; }

        [NameInMap("scope")]
        [Validation(Required=true)]
        public List<string> Scope { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
