// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class UpdateAppRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public UpdateAppRequestHeader Header { get; set; }
        public class UpdateAppRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("app_name")]
        [Validation(Required=true, MaxLength=128, Pattern="[0-9a-zA-Z]+")]
        public string AppName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false, MaxLength=128)]
        public string Description { get; set; }

        [NameInMap("is_third_party")]
        [Validation(Required=true)]
        public bool? IsThirdParty { get; set; }

        [NameInMap("logo")]
        [Validation(Required=true)]
        public string Logo { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=true)]
        public string RedirectUri { get; set; }

        [NameInMap("scope")]
        [Validation(Required=true)]
        public List<string> Scope { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

    }

}
