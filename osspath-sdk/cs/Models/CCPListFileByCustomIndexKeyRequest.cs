// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace Aliyun.SDK.CCP.OSSClient.Models
{
    /**
     * 列举文件
     */
    public class CCPListFileByCustomIndexKeyRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("image_thumbnail_process")]
        [Validation(Required=false)]
        public string ImageThumbnailProcess { get; set; }

        [NameInMap("image_url_process")]
        [Validation(Required=false)]
        public string ImageUrlProcess { get; set; }

        [NameInMap("limit")]
        [Validation(Required=false, Pattern="[0-9]{1,3}")]
        public long Limit { get; set; }

        [NameInMap("marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("video_thumbnail_process")]
        [Validation(Required=false)]
        public string VideoThumbnailProcess { get; set; }

        [NameInMap("Starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("custom_index_key")]
        [Validation(Required=false)]
        public string CustomIndexKey { get; set; }

        [NameInMap("encrypt_mode")]
        [Validation(Required=false)]
        public string EncryptMode { get; set; }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

        [NameInMap("order_direction")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public long UrlExpireSec { get; set; }

    }

}
