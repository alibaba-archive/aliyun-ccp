// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * list file op response
 */
public class ListFileDeltaResponse extends TeaModel {
    @NameInMap("cursor")
    public String cursor;

    @NameInMap("has_more")
    public Boolean hasMore;

    @NameInMap("items")
    public java.util.List<FileDeltaResponse> items;

    public static ListFileDeltaResponse build(java.util.Map<String, ?> map) throws Exception {
        ListFileDeltaResponse self = new ListFileDeltaResponse();
        return TeaModel.build(map, self);
    }

}
