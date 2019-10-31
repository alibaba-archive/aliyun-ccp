// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UploadPartInfo extends TeaModel {
    @NameInMap("etag")
    @Validation(pattern = "", maxLength = 0)
    public String etag;

    @NameInMap("part_number")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public Long partNumber;

    @NameInMap("part_size")
    @Validation(pattern = "", maxLength = 0)
    public Long partSize;

    @NameInMap("upload_url")
    @Validation(pattern = "", maxLength = 0)
    public String uploadUrl;

}

