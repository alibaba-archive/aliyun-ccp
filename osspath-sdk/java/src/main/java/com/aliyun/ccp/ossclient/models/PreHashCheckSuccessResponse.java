// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class PreHashCheckSuccessResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("code")
    @Validation(pattern = "", maxLength = 0)
    public String code;

    @NameInMap("file_name")
    @Validation(pattern = "", maxLength = 0)
    public String fileName;

    @NameInMap("message")
    @Validation(pattern = "", maxLength = 0)
    public String message;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String parentFileId;

    @NameInMap("pre_hash")
    @Validation(pattern = "", maxLength = 0)
    public String preHash;

}

