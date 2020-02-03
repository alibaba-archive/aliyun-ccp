// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateDriveResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("domain_id")
    public String domainId;

    @NameInMap("drive_id")
    public String driveId;

    public static CreateDriveResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDriveResponse self = new CreateDriveResponse();
        return TeaModel.build(map, self);
    }

}
