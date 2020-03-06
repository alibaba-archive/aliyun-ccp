// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 文件移动请求
 */
public class BaseMoveFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("new_name")
    @Validation(pattern = ".{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public Boolean overwrite;

    public static BaseMoveFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseMoveFileRequest self = new BaseMoveFileRequest();
        return TeaModel.build(map, self);
    }

}
