// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoLicenseRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoDRMLicenseRequest body;

    public static VideoLicenseRequestModel build(java.util.Map<String, ?> map) throws Exception {
        VideoLicenseRequestModel self = new VideoLicenseRequestModel();
        return TeaModel.build(map, self);
    }

}
