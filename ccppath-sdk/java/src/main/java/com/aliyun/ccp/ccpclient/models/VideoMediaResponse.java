// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class VideoMediaResponse extends TeaModel {
    @NameInMap("address_line")
    public String addressLine;

    @NameInMap("city")
    public String city;

    @NameInMap("country")
    public String country;

    @NameInMap("district")
    public String district;

    @NameInMap("duration")
    public String duration;

    @NameInMap("location")
    public String location;

    @NameInMap("province")
    public String province;

    @NameInMap("time")
    public String time;

    @NameInMap("township")
    public String township;

    public static VideoMediaResponse build(java.util.Map<String, ?> map) throws Exception {
        VideoMediaResponse self = new VideoMediaResponse();
        return TeaModel.build(map, self);
    }

}
