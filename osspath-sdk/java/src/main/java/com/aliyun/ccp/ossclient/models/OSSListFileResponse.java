// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSListFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public java.util.List<BaseOSSFileResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static OSSListFileResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSListFileResponse self = new OSSListFileResponse();
        return TeaModel.build(map, self);
    }

}
