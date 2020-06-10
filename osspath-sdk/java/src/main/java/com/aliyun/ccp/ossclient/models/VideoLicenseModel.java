// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoLicenseModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoDRMLicenseResponse body;

    public static VideoLicenseModel build(java.util.Map<String, ?> map) throws Exception {
        VideoLicenseModel self = new VideoLicenseModel();
        return TeaModel.build(map, self);
    }

}
