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
    public class ImageFaceGroupResponse : TeaModel {
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("face_count")]
        [Validation(Required=false)]
        public long FaceCount { get; set; }

        [NameInMap("group_cover_url")]
        [Validation(Required=false)]
        public string GroupCoverUrl { get; set; }

        [NameInMap("group_id")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("group_name")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("image_count")]
        [Validation(Required=false)]
        public long ImageCount { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
