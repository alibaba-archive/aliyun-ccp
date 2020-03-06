// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 删除文件请求
 */
public class OSSDeleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("permanently")
    public Boolean permanently;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-z-]+")
    public String shareId;

    public static OSSDeleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFileRequest self = new OSSDeleteFileRequest();
        return TeaModel.build(map, self);
    }

}
