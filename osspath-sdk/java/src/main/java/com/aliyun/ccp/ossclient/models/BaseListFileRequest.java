// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class BaseListFileRequest extends TeaModel {
    @NameInMap("header")
    public BaseListFileRequestHeader header;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
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

    @NameInMap("video_thumbnail_process")
    public String videoThumbnailProcess;

    public static BaseListFileRequest build(java.util.Map<String, ?> map) throws Exception {
        BaseListFileRequest self = new BaseListFileRequest();
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

}
