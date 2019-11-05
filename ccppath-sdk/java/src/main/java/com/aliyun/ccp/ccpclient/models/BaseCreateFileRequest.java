// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class BaseCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    @Validation(required = true)
    public String contentMd5;

    @NameInMap("content_type")
    @Validation(required = true)
    public String contentType;

    @NameInMap("name")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,1024}")
    public String name;

    @NameInMap("part_info_list")
    public UploadPartInfo[] partInfoList;

    @NameInMap("size")
    @Validation(required = true)
    public Long size;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

}

