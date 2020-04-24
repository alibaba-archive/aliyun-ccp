// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class Address extends TeaModel {
    @NameInMap("city")
    public String city;

    @NameInMap("country")
    public String country;

    @NameInMap("district")
    public String district;

    @NameInMap("province")
    public String province;

    @NameInMap("township")
    public String township;

    public static Address build(java.util.Map<String, ?> map) throws Exception {
        Address self = new Address();
        return TeaModel.build(map, self);
    }

}
