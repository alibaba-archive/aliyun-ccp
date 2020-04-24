// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileByCustomIndexKeyRequestModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPListFileByCustomIndexKeyRequest body;

    public static ListFileByCustomIndexKeyRequestModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileByCustomIndexKeyRequestModel self = new ListFileByCustomIndexKeyRequestModel();
        return TeaModel.build(map, self);
    }

}
