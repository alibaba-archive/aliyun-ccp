// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CreateDriveRequest extends TeaModel {
    @NameInMap("default")
    public boolean _default;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_name")
    @Validation(required = true)
    public String driveName;

    @NameInMap("drive_type")
    public String driveType;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("owner")
    @Validation(required = true)
    public String owner;

    @NameInMap("relative_path")
    public String relativePath;

    @NameInMap("status")
    public String status;

    @NameInMap("store_id")
    public String storeId;

    @NameInMap("total_size")
    public Long totalSize;

    public static CreateDriveRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateDriveRequest self = new CreateDriveRequest();
        return TeaModel.build(map, self);
    }

}
