// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * search file response
 */
public class CCPSearchFileResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<BaseCCPFileResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static CCPSearchFileResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPSearchFileResponse self = new CCPSearchFileResponse();
        return TeaModel.build(map, self);
    }

}
