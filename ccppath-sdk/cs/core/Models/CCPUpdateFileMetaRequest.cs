// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    /**
     * 更新文件元数据
     */
    public class CCPUpdateFileMetaRequest : TeaModel {
        [NameInMap("custom_index_key")]
        [Validation(Required=false)]
        public string CustomIndexKey { get; set; }

        [NameInMap("description")]
        [Validation(Required=false, MaxLength=1024)]
        public string Description { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=true, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=true, MaxLength=50, Pattern="[a-z0-9.-_]{1,50}")]
        public string FileId { get; set; }

        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        [NameInMap("meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("name")]
        [Validation(Required=false, Pattern="[a-zA-Z0-9.-]{1,1000}")]
        public string Name { get; set; }

        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

    }

}
