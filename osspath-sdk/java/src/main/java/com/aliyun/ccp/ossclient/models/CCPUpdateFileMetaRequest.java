// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPUpdateFileMetaRequest extends TeaModel {
    @NameInMap("header")
    public CCPUpdateFileMetaRequestHeader header;

    @NameInMap("custom_index_key")
    public String customIndexKey;

    @NameInMap("description")
    public String description;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("encrypt_mode")
    public String encryptMode;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("hidden")
    public Boolean hidden;

    @NameInMap("labels")
    public java.util.List<String> labels;

    @NameInMap("meta")
    public String meta;

    @NameInMap("name")
    @Validation(pattern = ".{1,1000}")
    public String name;

    @NameInMap("starred")
    public Boolean starred;

    public static CCPUpdateFileMetaRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPUpdateFileMetaRequest self = new CCPUpdateFileMetaRequest();
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

}
