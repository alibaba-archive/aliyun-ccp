// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListFileByCustomIndexKeyModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public CCPListFileResponse body;

    public static ListFileByCustomIndexKeyModel build(java.util.Map<String, ?> map) throws Exception {
        ListFileByCustomIndexKeyModel self = new ListFileByCustomIndexKeyModel();
        return TeaModel.build(map, self);
    }

}
