// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * get last file op cursor response
 */
public class GetLastCursorResponse extends TeaModel {
    @NameInMap("cursor")
    public String cursor;

    public static GetLastCursorResponse build(java.util.Map<String, ?> map) throws Exception {
        GetLastCursorResponse self = new GetLastCursorResponse();
        return TeaModel.build(map, self);
    }

}
