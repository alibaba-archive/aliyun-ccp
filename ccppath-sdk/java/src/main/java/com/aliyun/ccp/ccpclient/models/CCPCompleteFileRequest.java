// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 合并文件上传任务
 */
public class CCPCompleteFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("upload_id")
    public String uploadId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1,50}")
    public String fileId;

    public static CCPCompleteFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CCPCompleteFileRequest self = new CCPCompleteFileRequest();
        return TeaModel.build(map, self);
    }

}
