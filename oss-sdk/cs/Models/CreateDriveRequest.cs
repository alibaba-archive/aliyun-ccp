// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class CreateDriveRequest : TeaModel {
        [NameInMap("default")]
        [Validation(Required=false)]
        public bool _default { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("drive_name")]
        [Validation(Required=true)]
        public string DriveName { get; set; }

        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        [NameInMap("owner")]
        [Validation(Required=true)]
        public string Owner { get; set; }

        [NameInMap("relative_path")]
        [Validation(Required=false)]
        public string RelativePath { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("total_size")]
        [Validation(Required=false)]
        public long TotalSize { get; set; }

    }

}
