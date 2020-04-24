// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class StreamUploadInfo extends TeaModel {
    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("pre_rapid_upload")
    public Boolean preRapidUpload;

    @NameInMap("rapid_upload")
    public Boolean rapidUpload;

    @NameInMap("upload_id")
    public String uploadId;

    public static StreamUploadInfo build(java.util.Map<String, ?> map) throws Exception {
        StreamUploadInfo self = new StreamUploadInfo();
        return TeaModel.build(map, self);
    }

}
