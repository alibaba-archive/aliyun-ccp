// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Update face group info request
 */
public class UpdateFaceGroupInfoRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("group_id")
    @Validation(required = true)
    public String groupId;

    @NameInMap("group_name")
    public String groupName;

    public static UpdateFaceGroupInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFaceGroupInfoRequest self = new UpdateFaceGroupInfoRequest();
        return TeaModel.build(map, self);
    }

}
