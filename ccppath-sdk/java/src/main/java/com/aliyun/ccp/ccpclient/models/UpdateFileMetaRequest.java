// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class UpdateFileMetaRequest extends TeaModel {
    @NameInMap("header")
    public UpdateFileMetaRequestHeader header;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("hidden")
    public Boolean hidden;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String name;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("starred")
    public Boolean starred;

    @NameInMap("tags")
    public java.util.Map<String, Object> tags;

    public static UpdateFileMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateFileMetaRequest self = new UpdateFileMetaRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPUpdateFileMetaRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPUpdateFileMetaRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPUpdateFileMetaRequestHeader self = new CCPUpdateFileMetaRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class UpdateFileMetaRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static UpdateFileMetaRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            UpdateFileMetaRequestHeader self = new UpdateFileMetaRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
