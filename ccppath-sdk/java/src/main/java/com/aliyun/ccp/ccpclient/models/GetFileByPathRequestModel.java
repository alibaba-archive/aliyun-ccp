// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class GetFileByPathRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPGetFileByPathRequest body;

    public static GetFileByPathRequestModel build(java.util.Map<String, ?> map) throws Exception {
        GetFileByPathRequestModel self = new GetFileByPathRequestModel();
        return TeaModel.build(map, self);
    }

}
