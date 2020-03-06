// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class LinkInfo extends TeaModel {
    @NameInMap("identity")
    public String identity;

    @NameInMap("type")
    public String type;

    public static LinkInfo build(java.util.Map<String, ?> map) throws Exception {
        LinkInfo self = new LinkInfo();
        return TeaModel.build(map, self);
    }

}
