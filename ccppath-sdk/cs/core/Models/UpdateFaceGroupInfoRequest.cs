// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * Update face group info request
     */
    public class UpdateFaceGroupInfoRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("group_id")]
        [Validation(Required=true)]
        public string GroupId { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

    }

}
