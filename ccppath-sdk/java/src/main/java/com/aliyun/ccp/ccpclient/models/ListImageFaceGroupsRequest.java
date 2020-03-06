// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * List image face groups request
 */
public class ListImageFaceGroupsRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("limit")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    public static ListImageFaceGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListImageFaceGroupsRequest self = new ListImageFaceGroupsRequest();
        return TeaModel.build(map, self);
    }

}
