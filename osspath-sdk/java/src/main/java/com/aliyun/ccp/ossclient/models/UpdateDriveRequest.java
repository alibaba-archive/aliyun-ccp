// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UpdateDriveRequest extends TeaModel {
    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("drive_name")
    public String driveName;

    @NameInMap("encrypt_data_access")
    public boolean encryptDataAccess;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("status")
    public String status;

    @NameInMap("total_size")
    public Long totalSize;

    public static UpdateDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateDriveRequest self = new UpdateDriveRequest();
        return TeaModel.build(map, self);
    }

}
