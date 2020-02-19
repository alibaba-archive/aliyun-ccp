// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListShareRequest extends TeaModel {
    @NameInMap("creator")
    public String creator;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("limit")
    @Validation(required = true)
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("owner")
    public String owner;

    @NameInMap("share_file_path")
    public String shareFilePath;

    public static ListShareRequest build(java.util.Map<String, ?> map) throws Exception {
        ListShareRequest self = new ListShareRequest();
        return TeaModel.build(map, self);
    }

}
