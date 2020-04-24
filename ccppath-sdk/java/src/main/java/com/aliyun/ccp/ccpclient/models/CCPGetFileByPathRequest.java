// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 根据路径获取 File 接口 body
 */
public class CCPGetFileByPathRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("fields")
    public String fields;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("url_expire_sec")
    public Long urlExpireSec;

    @NameInMap("video_thumbnail_process")
    public String videoThumbnailProcess;

    public static CCPGetFileByPathRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPGetFileByPathRequest self = new CCPGetFileByPathRequest();
        return TeaModel.build(map, self);
    }

}
