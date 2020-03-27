// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoResolutionModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoResolutionResponse body;

    public static VideoResolutionModel build(java.util.Map<String, ?> map) throws Exception {
        VideoResolutionModel self = new VideoResolutionModel();
        return TeaModel.build(map, self);
    }

}
