// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class BaseMediaResponse extends TeaModel {
    @NameInMap("address_line")
    public String addressLine;

    @NameInMap("city")
    public String city;

    @NameInMap("country")
    public String country;

    @NameInMap("district")
    public String district;

    @NameInMap("height")
    public Long height;

    @NameInMap("location")
    public String location;

    @NameInMap("province")
    public String province;

    @NameInMap("time")
    public String time;

    @NameInMap("township")
    public String township;

    @NameInMap("width")
    public Long width;

    public static BaseMediaResponse build(java.util.Map<String, ?> map) throws Exception {
        BaseMediaResponse self = new BaseMediaResponse();
        return TeaModel.build(map, self);
    }

}
