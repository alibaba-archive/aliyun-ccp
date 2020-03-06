// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取文件元数据
 */
public class OSSGetFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String filePath;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    public static OSSGetFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSGetFileRequest self = new OSSGetFileRequest();
        return TeaModel.build(map, self);
    }

}
