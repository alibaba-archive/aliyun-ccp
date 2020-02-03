// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class GetDriveRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    public static GetDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDriveRequest self = new GetDriveRequest();
        return TeaModel.build(map, self);
    }

}
