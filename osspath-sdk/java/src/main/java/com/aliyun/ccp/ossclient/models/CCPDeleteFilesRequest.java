// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFilesRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id_list")
    @Validation(required = true)
    public String[] fileIdList;

    public static CCPDeleteFilesRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFilesRequest self = new CCPDeleteFilesRequest();
        return TeaModel.build(map, self);
    }

}
