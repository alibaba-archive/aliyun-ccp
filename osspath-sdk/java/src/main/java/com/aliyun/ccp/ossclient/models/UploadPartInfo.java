// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class UploadPartInfo extends TeaModel {
    @NameInMap("etag")
    public String etag;

    @NameInMap("part_number")
    @Validation(pattern = "[0-9]+")
    public Long partNumber;

    @NameInMap("part_size")
    public Long partSize;

    @NameInMap("upload_url")
    public String uploadUrl;

    public static UploadPartInfo build(java.util.Map<String, ?> map) throws Exception {
        UploadPartInfo self = new UploadPartInfo();
        return TeaModel.build(map, self);
    }

}
