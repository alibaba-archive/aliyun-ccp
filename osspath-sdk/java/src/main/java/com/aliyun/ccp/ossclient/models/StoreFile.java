// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class StoreFile extends TeaModel {
    @NameInMap("domain_id")
    public String domainId;

    @NameInMap("name")
    public String name;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("store_id")
    public String storeId;

    @NameInMap("type")
    public String type;

    public static StoreFile build(java.util.Map<String, ?> map) throws Exception {
        StoreFile self = new StoreFile();
        return TeaModel.build(map, self);
    }

}
