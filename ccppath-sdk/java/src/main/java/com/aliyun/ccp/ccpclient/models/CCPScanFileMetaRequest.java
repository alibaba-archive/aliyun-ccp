// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 全量获取file元信息的请求body
 */
public class CCPScanFileMetaRequest extends TeaModel {
    @NameInMap("category")
    public String category;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static CCPScanFileMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPScanFileMetaRequest self = new CCPScanFileMetaRequest();
        return TeaModel.build(map, self);
    }

}
