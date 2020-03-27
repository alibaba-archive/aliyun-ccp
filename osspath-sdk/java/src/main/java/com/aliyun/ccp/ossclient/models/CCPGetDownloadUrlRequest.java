// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取文件下载地址的请求body
 */
public class CCPGetDownloadUrlRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_name")
    public String fileName;

    public static CCPGetDownloadUrlRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPGetDownloadUrlRequest self = new CCPGetDownloadUrlRequest();
        return TeaModel.build(map, self);
    }

}
