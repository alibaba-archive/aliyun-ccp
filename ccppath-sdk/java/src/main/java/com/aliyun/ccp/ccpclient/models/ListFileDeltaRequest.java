// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 获取增量文件操作记录
 */
public class ListFileDeltaRequest extends TeaModel {
    @NameInMap("cursor")
    public String cursor;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("limit")
    public Integer limit;

    public static ListFileDeltaRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFileDeltaRequest self = new ListFileDeltaRequest();
        return TeaModel.build(map, self);
    }

}
