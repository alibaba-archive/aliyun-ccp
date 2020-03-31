// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class VideoDefinitionModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoDefinitionResponse body;

    public static VideoDefinitionModel build(java.util.Map<String, ?> map) throws Exception {
        VideoDefinitionModel self = new VideoDefinitionModel();
        return TeaModel.build(map, self);
    }

}
