// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSVideoM3U8RequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OSSVideoM3U8Request body;

    public static OSSVideoM3U8RequestModel build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoM3U8RequestModel self = new OSSVideoM3U8RequestModel();
        return TeaModel.build(map, self);
    }

}
