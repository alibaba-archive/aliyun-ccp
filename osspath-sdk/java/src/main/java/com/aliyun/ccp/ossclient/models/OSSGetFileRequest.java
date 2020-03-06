// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取文件元数据
 */
public class OSSGetFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    @NameInMap("url_expire_sec")
    public Long urlExpireSec;

    public static OSSGetFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetFileRequest self = new OSSGetFileRequest();
        return TeaModel.build(map, self);
    }

}
