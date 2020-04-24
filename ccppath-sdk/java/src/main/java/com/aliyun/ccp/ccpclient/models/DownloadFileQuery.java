// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class DownloadFileQuery extends TeaModel {
    @NameInMap("DriveID")
    @Validation(required = true)
    public String DriveID;

    @NameInMap("FileID")
    @Validation(required = true)
    public String FileID;

    @NameInMap("ImageThumbnailProcess")
    public String ImageThumbnailProcess;

    @NameInMap("VideoThumbnailProcess")
    public String VideoThumbnailProcess;

    public static DownloadFileQuery build(java.util.Map<String, ?> map) throws Exception {
        DownloadFileQuery self = new DownloadFileQuery();
        return TeaModel.build(map, self);
    }

}
