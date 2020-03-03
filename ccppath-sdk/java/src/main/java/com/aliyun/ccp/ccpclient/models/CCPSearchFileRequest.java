// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPSearchFileRequest extends TeaModel {
    @NameInMap("header")
    public CCPSearchFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    public Integer limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("order_by")
    public String orderBy;

    @NameInMap("query")
    public String query;

    public static CCPSearchFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPSearchFileRequest self = new CCPSearchFileRequest();
        return TeaModel.build(map, self);
    }

    public static class CCPSearchFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPSearchFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPSearchFileRequestHeader self = new CCPSearchFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
