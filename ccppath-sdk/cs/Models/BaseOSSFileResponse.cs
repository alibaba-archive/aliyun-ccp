
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class BaseOSSFileResponse : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        [NameInMap("content_type")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domain_id")]
        [Validation(Required=false, Pattern="[a-z0-9A-Z]+")]
        public string DomainId { get; set; }

        [NameInMap("download_url")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

        [NameInMap("drive_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string DriveId { get; set; }

        [NameInMap("file_extension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        [NameInMap("file_path")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("name")]
        [Validation(Required=true, Pattern="[a-zA-Z0-9.-]{1,1024}")]
        public string Name { get; set; }

        [NameInMap("parent_file_path")]
        [Validation(Required=false, MaxLength=50, Pattern="[a-z0-9]{1, 50}")]
        public string ParentFilePath { get; set; }

        [NameInMap("share_id")]
        [Validation(Required=false, Pattern="[0-9]+")]
        public string ShareId { get; set; }

        [NameInMap("size")]
        [Validation(Required=false)]
        public long Size { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        [NameInMap("trashed_at")]
        [Validation(Required=false)]
        public string TrashedAt { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("upload_id")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
