// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Get drive response
 */
public class GetDriveResponse extends TeaModel {
    @NameInMap("creator")
    public String creator;

    @NameInMap("description")
    public String description;

    @NameInMap("domain_id")
    public String domainId;

    @NameInMap("drive_id")
    public String driveId;

    @NameInMap("drive_name")
    public String driveName;

    @NameInMap("drive_type")
    public String driveType;

    @NameInMap("encrypt_data_access")
    public Boolean encryptDataAccess;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("owner")
    public String owner;

    @NameInMap("relative_path")
    public String relativePath;

    @NameInMap("status")
    public String status;

    @NameInMap("store_id")
    public String storeId;

    @NameInMap("total_size")
    public Long totalSize;

    @NameInMap("used_size")
    public Long usedSize;

    public static GetDriveResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDriveResponse self = new GetDriveResponse();
        return TeaModel.build(map, self);
    }

}
