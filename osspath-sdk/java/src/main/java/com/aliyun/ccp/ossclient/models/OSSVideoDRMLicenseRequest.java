// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 获取视频DRM License
 */
public class OSSVideoDRMLicenseRequest extends TeaModel {
    @NameInMap("drmType")
    @Validation(required = true)
    public String drmType;

    @NameInMap("licenseRequest")
    @Validation(required = true)
    public String licenseRequest;

    public static OSSVideoDRMLicenseRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoDRMLicenseRequest self = new OSSVideoDRMLicenseRequest();
        return TeaModel.build(map, self);
    }

}
