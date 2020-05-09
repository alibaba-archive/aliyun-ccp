// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class DeviceAuthorizeRequest extends TeaModel {
    @NameInMap("ClientID")
    @Validation(required = true)
    public String ClientID;

    @NameInMap("DeviceInfo")
    public String DeviceInfo;

    @NameInMap("DeviceName")
    @Validation(required = true)
    public String DeviceName;

    @NameInMap("LoginType")
    public String LoginType;

    @NameInMap("Scope")
    public java.util.List<String> Scope;

    public static DeviceAuthorizeRequest build(java.util.Map<String, ?> map) throws Exception {
        DeviceAuthorizeRequest self = new DeviceAuthorizeRequest();
        return TeaModel.build(map, self);
    }

}
