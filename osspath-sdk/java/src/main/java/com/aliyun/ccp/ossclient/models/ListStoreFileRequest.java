// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListStoreFileRequest extends TeaModel {
    @NameInMap("limit")
    @Validation(pattern = "", maxLength = 0)
    public Long limit;

    @NameInMap("marker")
    @Validation(pattern = "", maxLength = 0)
    public String marker;

    @NameInMap("parent_file_path")
    @Validation(pattern = "", maxLength = 0)
    public String parentFilePath;

    @NameInMap("store_id")
    @Validation(pattern = "", maxLength = 0)
    public String storeId;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

}

