// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class SharePermissionPolicy extends TeaModel {
    @NameInMap("file_path")
    public String filePath;

    @NameInMap("permission_inheritable")
    public Boolean permissionInheritable;

    @NameInMap("permission_list")
    public java.util.List<String> permissionList;

    @NameInMap("permission_type")
    public String permissionType;

    public static SharePermissionPolicy build(java.util.Map<String, ?> map) throws Exception {
        SharePermissionPolicy self = new SharePermissionPolicy();
        return TeaModel.build(map, self);
    }

}
