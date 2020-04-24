// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取视频的m3u8文件
 */
public class OSSVideoM3U8Request extends TeaModel {
    @NameInMap("definition")
    public String definition;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("expire_sec")
    public Long expireSec;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    @NameInMap("sign_token")
    @Validation(required = true)
    public String signToken;

    public static OSSVideoM3U8Request build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoM3U8Request self = new OSSVideoM3U8Request();
        return TeaModel.build(map, self);
    }

}
