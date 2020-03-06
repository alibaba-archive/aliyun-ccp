// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * search file response
 */
public class OSSSearchFileResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<BaseOSSFileResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static OSSSearchFileResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSSearchFileResponse self = new OSSSearchFileResponse();
        return TeaModel.build(map, self);
    }

}
