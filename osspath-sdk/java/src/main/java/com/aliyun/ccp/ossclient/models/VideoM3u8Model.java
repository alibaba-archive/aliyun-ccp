// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoM3u8Model extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public byte[] body;

    public static VideoM3u8Model build(java.util.Map<String, ?> map) throws Exception {
        VideoM3u8Model self = new VideoM3u8Model();
        return TeaModel.build(map, self);
    }

}
