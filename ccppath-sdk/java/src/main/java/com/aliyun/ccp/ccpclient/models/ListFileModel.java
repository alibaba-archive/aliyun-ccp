// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPListFileResponse body;

    public static ListFileModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileModel self = new ListFileModel();
        return TeaModel.build(map, self);
    }

}
