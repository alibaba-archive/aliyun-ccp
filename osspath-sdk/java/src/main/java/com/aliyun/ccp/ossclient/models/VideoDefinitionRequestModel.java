// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoDefinitionRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoDefinitionRequest body;

    public static VideoDefinitionRequestModel build(java.util.Map<String, ?> map) throws Exception {
        VideoDefinitionRequestModel self = new VideoDefinitionRequestModel();
        return TeaModel.build(map, self);
    }

}
