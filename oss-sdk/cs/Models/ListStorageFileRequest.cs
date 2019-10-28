// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    public class ListStorageFileRequest : TeaModel {
        [NameInMap("limit")]
        [Validation(Required=false)]
        public long Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("parent_file_path")]
        [Validation(Required=false)]
        public string ParentFilePath { get; set; }

        [NameInMap("store_id")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
