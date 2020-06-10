// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * DRM License response
 */
public class OSSVideoDRMLicenseResponse extends TeaModel {
    @NameInMap("data")
    @Validation(required = true)
    public String data;

    @NameInMap("states")
    @Validation(required = true)
    public Long states;

    public static OSSVideoDRMLicenseResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoDRMLicenseResponse self = new OSSVideoDRMLicenseResponse();
        return TeaModel.build(map, self);
    }

}
