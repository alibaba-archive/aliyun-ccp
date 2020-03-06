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
    public class SharePermissionPolicy : TeaModel {
        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("permission_inheritable")]
        [Validation(Required=false)]
        public bool? PermissionInheritable { get; set; }

        [NameInMap("permission_list")]
        [Validation(Required=false)]
        public List<string> PermissionList { get; set; }

        [NameInMap("permission_type")]
        [Validation(Required=false)]
        public string PermissionType { get; set; }

    }

}
