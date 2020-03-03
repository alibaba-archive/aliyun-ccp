// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class ListStoreFileRequest extends TeaModel {
    @NameInMap("header")
    public ListStoreFileRequestHeader header;

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

    public static class ListStoreFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListStoreFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListStoreFileRequestHeader self = new ListStoreFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
