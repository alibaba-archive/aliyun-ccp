// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 更新人脸分组信息结果
 */
public class UpdateFaceGroupInfoResponse extends TeaModel {
    @NameInMap("drive_id")
    public String driveId;

    @NameInMap("group_id")
    public String groupId;

    public static UpdateFaceGroupInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateFaceGroupInfoResponse self = new UpdateFaceGroupInfoResponse();
        return TeaModel.build(map, self);
    }

}
