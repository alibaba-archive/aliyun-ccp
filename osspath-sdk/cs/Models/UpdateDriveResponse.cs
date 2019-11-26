// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class UpdateDriveResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        [NameInMap("drive_type")]
        [Validation(Required=false)]
        public string DriveType { get; set; }

        [NameInMap("owner")]
        [Validation(Required=false)]
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

        [NameInMap("used_size")]
        [Validation(Required=false)]
        public long UsedSize { get; set; }

    }

}
