// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoTranscodeRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoTranscodeRequest body;

    public static OSSVideoTranscodeRequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoTranscodeRequestModel self = new OSSVideoTranscodeRequestModel();
        return TeaModel.build(map, self);
    }

}
