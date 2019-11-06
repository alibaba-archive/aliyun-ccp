
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class OSSDeleteFileResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("async_task_id")]
        [Validation(Required=false)]
        public string AsyncTaskId { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false, Pattern="[a-z0-9A-Z]+")]
        public string DomainId { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[a-z0-9A-Z]+")]
        public string ShareId { get; set; }

    }

}
