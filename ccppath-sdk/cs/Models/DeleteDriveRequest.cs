
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class DeleteDriveRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=true)]
        public string DriveId { get; set; }

    }

}
