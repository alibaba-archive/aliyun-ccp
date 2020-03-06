// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * List file response
 */
public class CCPListFileResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<BaseCCPFileResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static CCPListFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPListFileResponse self = new CCPListFileResponse();
        return TeaModel.build(map, self);
    }

}
