// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * List image address groups request
 */
public class ListImageAddressGroupsRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    public static ListImageAddressGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListImageAddressGroupsRequest self = new ListImageAddressGroupsRequest();
        return TeaModel.build(map, self);
    }

}
