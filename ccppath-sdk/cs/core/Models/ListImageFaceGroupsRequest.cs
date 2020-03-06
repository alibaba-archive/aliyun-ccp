// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * List image face groups request
     */
    public class ListImageFaceGroupsRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true)]
        public string DriveId { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false)]
        public long Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

    }

}
