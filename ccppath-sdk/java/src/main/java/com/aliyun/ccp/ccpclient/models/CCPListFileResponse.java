// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPListFileResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("items")
    public BaseCCPFileResponse[] items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static CCPListFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPListFileResponse self = new CCPListFileResponse();
        return TeaModel.build(map, self);
    }

}
