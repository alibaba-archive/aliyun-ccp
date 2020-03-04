// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class UpdateUserRequest : TeaModel {
        [NameInMap("header")]
        [Validation(Required=false)]
        public UpdateUserRequestHeader Header { get; set; }
        public class UpdateUserRequestHeader : TeaModel {
            [NameInMap("x-pds-trace-id")]
            [Validation(Required=false)]
            public string TraceId { get; set; }
            [NameInMap("x-pds-device-id")]
            [Validation(Required=false)]
            public string DeviceId { get; set; }
        };

        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=true)]
        public string UserId { get; set; }

    }

}
