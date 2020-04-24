// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 列举文件
 */
public class CCPListFileByCustomIndexKeyRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]{1,3}")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("video_thumbnail_process")
    public String videoThumbnailProcess;

    @NameInMap("Starred")
    public Boolean Starred;

    @NameInMap("category")
    public String category;

    @NameInMap("custom_index_key")
    public String customIndexKey;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("fields")
    public String fields;

    @NameInMap("order_direction")
    public String orderDirection;

    @NameInMap("status")
    public String status;

    @NameInMap("type")
    public String type;

    @NameInMap("url_expire_sec")
    public Long urlExpireSec;

    public static CCPListFileByCustomIndexKeyRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPListFileByCustomIndexKeyRequest self = new CCPListFileByCustomIndexKeyRequest();
        return TeaModel.build(map, self);
    }

}
