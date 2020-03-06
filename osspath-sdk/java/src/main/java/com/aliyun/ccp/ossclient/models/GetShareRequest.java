// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * get share request
 */
public class GetShareRequest extends TeaModel {
    @NameInMap("share_id")
    public String shareId;

    public static GetShareRequest build(java.util.Map<String, ?> map) throws Exception {
        GetShareRequest self = new GetShareRequest();
        return TeaModel.build(map, self);
    }

}
