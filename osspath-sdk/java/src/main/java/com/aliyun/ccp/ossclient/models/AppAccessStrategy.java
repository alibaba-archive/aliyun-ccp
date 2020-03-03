// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class AppAccessStrategy extends TeaModel {
    @NameInMap("effect")
    public String effect;

    @NameInMap("except_app_id_list")
    public java.util.List<String> exceptAppIdList;

    public static AppAccessStrategy build(java.util.Map<String, ?> map) throws Exception {
        AppAccessStrategy self = new AppAccessStrategy();
        return TeaModel.build(map, self);
    }

}
