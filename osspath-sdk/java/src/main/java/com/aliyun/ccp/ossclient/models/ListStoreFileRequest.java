// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoreFileRequest extends TeaModel {
    @NameInMap("limit")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("store_id")
    public String storeId;

    @NameInMap("type")
    public String type;

    public static ListStoreFileRequest build(java.util.Map<String, ?> map) throws Exception {
        ListStoreFileRequest self = new ListStoreFileRequest();
        return TeaModel.build(map, self);
    }

}
