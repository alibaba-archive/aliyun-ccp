// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseCreateFileRequest extends TeaModel {
    @NameInMap("header")
    public BaseCreateFileRequestHeader header;

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

    public static class BaseCreateFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseCreateFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseCreateFileRequestHeader self = new BaseCreateFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
