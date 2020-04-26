// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class ImageMediaResponse extends TeaModel {
    @NameInMap("address_line")
    public String addressLine;

    @NameInMap("city")
    public String city;

    @NameInMap("country")
    public String country;

    @NameInMap("district")
    public String district;

    @NameInMap("exif")
    public String exif;

    @NameInMap("faces")
    public String faces;

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

    public static ImageMediaResponse build(java.util.Map<String, ?> map) throws Exception {
        ImageMediaResponse self = new ImageMediaResponse();
        return TeaModel.build(map, self);
    }

}
