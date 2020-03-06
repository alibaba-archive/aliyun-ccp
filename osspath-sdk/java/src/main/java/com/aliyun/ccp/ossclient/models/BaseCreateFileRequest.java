// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * create file request
 */
public class BaseCreateFileRequest extends TeaModel {
    @NameInMap("content_md5")
    @Validation(required = true)
    public String contentMd5;

    @NameInMap("content_type")
    @Validation(required = true)
    public String contentType;

    @NameInMap("name")
    @Validation(required = true)
    public String name;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("size")
    @Validation(required = true)
    public Long size;

    @NameInMap("type")
    @Validation(required = true)
    public String type;

    public static BaseCreateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseCreateFileRequest self = new BaseCreateFileRequest();
        return TeaModel.build(map, self);
    }

}
