// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoTranscodeRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoTranscodeRequest body;

    public static VideoTranscodeRequestModel build(java.util.Map<String, ?> map) throws Exception {
        VideoTranscodeRequestModel self = new VideoTranscodeRequestModel();
        return TeaModel.build(map, self);
    }

}
