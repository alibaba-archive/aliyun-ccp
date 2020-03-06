// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListDrivesModel extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListDriveResponse body;

    public static ListDrivesModel build(java.util.Map<String, ?> map) throws Exception {
        ListDrivesModel self = new ListDrivesModel();
        return TeaModel.build(map, self);
    }

}
