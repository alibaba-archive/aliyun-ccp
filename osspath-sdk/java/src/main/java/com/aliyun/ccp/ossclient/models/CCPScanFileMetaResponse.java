// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * scan file meta response
 */
public class CCPScanFileMetaResponse extends TeaModel {
    @NameInMap("items")
    public java.util.List<BaseCCPFileResponse> items;

    @NameInMap("next_marker")
    public String nextMarker;

    public static CCPScanFileMetaResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPScanFileMetaResponse self = new CCPScanFileMetaResponse();
        return TeaModel.build(map, self);
    }

}
