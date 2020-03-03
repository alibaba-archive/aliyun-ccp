// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class ListFileRequest extends TeaModel {
    @NameInMap("header")
    public ListFileRequestHeader header;

    @NameInMap("all")
    public Boolean all;

    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("image_thumbnail_process")
    public String imageThumbnailProcess;

    @NameInMap("image_url_process")
    public String imageUrlProcess;

    @NameInMap("limit")
    @Validation(pattern = "[0-9]{1,3}")
    public Long limit;

    @NameInMap("marker")
    public String marker;

    @NameInMap("parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String parentFileId;

    @NameInMap("parent_file_path")
    public String parentFilePath;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("status")
    public String status;

    public static ListFileRequest build(java.util.Map<String, ?> map) throws Exception {
        ListFileRequest self = new ListFileRequest();
        return TeaModel.build(map, self);
    }

    public static class BaseListFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static BaseListFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            BaseListFileRequestHeader self = new BaseListFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class CCPListFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static CCPListFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            CCPListFileRequestHeader self = new CCPListFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class ListFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static ListFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            ListFileRequestHeader self = new ListFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

    public static class OSSListFileRequestHeader extends TeaModel {
        @NameInMap("x-pds-trace-id")
        public String traceId;

        @NameInMap("x-pds-device-id")
        public String deviceId;

        public static OSSListFileRequestHeader build(java.util.Map<String, ?> map) throws Exception {
            OSSListFileRequestHeader self = new OSSListFileRequestHeader();
            return TeaModel.build(map, self);
        }

    }

}
