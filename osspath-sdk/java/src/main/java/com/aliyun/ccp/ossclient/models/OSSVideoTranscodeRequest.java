// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 启动视频转码请求
 */
public class OSSVideoTranscodeRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_path")
    @Validation(required = true)
    public String filePath;

    @NameInMap("hls_time")
    public Long hlsTime;

    @NameInMap("remarks")
    public String remarks;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9a-zA-Z-]+")
    public String shareId;

    @NameInMap("transcode")
    public Boolean transcode;

    public static OSSVideoTranscodeRequest build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoTranscodeRequest self = new OSSVideoTranscodeRequest();
        return TeaModel.build(map, self);
    }

}
