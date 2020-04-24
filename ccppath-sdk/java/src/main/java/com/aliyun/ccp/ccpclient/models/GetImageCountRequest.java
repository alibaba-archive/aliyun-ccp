// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Get photo count request
 */
public class GetImageCountRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    public static GetImageCountRequest build(java.util.Map<String, ?> map) throws Exception {
        GetImageCountRequest self = new GetImageCountRequest();
        return TeaModel.build(map, self);
    }

}
