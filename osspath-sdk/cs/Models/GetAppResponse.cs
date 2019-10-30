// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class GetAppResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ali_owner_id")]
        [Validation(Required=true)]
        public string AliOwnerId { get; set; }

        [NameInMap("app_id")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("app_name")]
        [Validation(Required=true, MaxLength=128, Pattern="[0-9a-zA-Z]+")]
        public string AppName { get; set; }

        [NameInMap("app_secret")]
        [Validation(Required=true)]
        public string AppSecret { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=true)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=true, MaxLength=128)]
        public string Description { get; set; }

        [NameInMap("logo")]
        [Validation(Required=true)]
        public string Logo { get; set; }

        [NameInMap("provider")]
        [Validation(Required=true)]
        public string Provider { get; set; }

        [NameInMap("redirect_uri")]
        [Validation(Required=true)]
        public string RedirectUri { get; set; }

        [NameInMap("scope")]
        [Validation(Required=true)]
        public List<string> Scope { get; set; }

        [NameInMap("screenshots")]
        [Validation(Required=true)]
        public List<string> Screenshots { get; set; }

        [NameInMap("stage")]
        [Validation(Required=true)]
        public string Stage { get; set; }

        [NameInMap("type")]
        [Validation(Required=true)]
        public string Type { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=true)]
        public string UpdatedAt { get; set; }

    }

}
