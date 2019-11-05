// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class PreHashCheckSuccessResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("code")
    public String code;

    @NameInMap("file_name")
    public String fileName;

    @NameInMap("message")
    public String message;

    @NameInMap("parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9]{1, 50}")
    public String parentFileId;

    @NameInMap("pre_hash")
    public String preHash;

}

