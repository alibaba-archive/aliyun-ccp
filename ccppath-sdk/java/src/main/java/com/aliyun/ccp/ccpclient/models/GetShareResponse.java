// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Get share response
 */
public class GetShareResponse extends TeaModel {
    @NameInMap("created_at")
    public String createdAt;

    @NameInMap("creator")
    public String creator;

    @NameInMap("description")
    public String description;

    @NameInMap("domain_id")
    public String domainId;

    @NameInMap("drive_id")
    public String driveId;

    @NameInMap("expiration")
    public String expiration;

    @NameInMap("expired")
    public Boolean expired;

    @NameInMap("owner")
    public String owner;

    @NameInMap("permissions")
    public java.util.List<String> permissions;

    @NameInMap("share_file_path")
    public String shareFilePath;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("share_name")
    public String shareName;

    @NameInMap("share_policy")
    public java.util.List<SharePermissionPolicy> sharePolicy;

    @NameInMap("status")
    public String status;

    @NameInMap("updated_at")
    public String updatedAt;

    public static GetShareResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShareResponse self = new GetShareResponse();
        return TeaModel.build(map, self);
    }

}
