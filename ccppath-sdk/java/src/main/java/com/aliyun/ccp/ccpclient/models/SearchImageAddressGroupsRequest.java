// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Search image address groups request
 */
public class SearchImageAddressGroupsRequest extends TeaModel {
    @NameInMap("address_level")
    public String addressLevel;

    @NameInMap("address_names")
    public java.util.List<String> addressNames;

    @NameInMap("br_geo_point")
    public String brGeoPoint;

    @NameInMap("drive_id")
    @Validation(required = true)
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("tl_geo_point")
    public String tlGeoPoint;

    public static SearchImageAddressGroupsRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchImageAddressGroupsRequest self = new SearchImageAddressGroupsRequest();
        return TeaModel.build(map, self);
    }

}
