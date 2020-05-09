// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoM3u8RequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoM3U8Request body;

    public static VideoM3u8RequestModel build(java.util.Map<String, ?> map) throws Exception {
        VideoM3u8RequestModel self = new VideoM3u8RequestModel();
        return TeaModel.build(map, self);
    }

}
