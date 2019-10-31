// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPCreateFileResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String fileId;

    @NameInMap("parent_file_id")
    @Validation(pattern = "[a-z0-9]{1, 50}", maxLength = 0)
    public String parentFileId;

    @NameInMap("part_info_list")
    @Validation(pattern = "", maxLength = 0)
    public UploadPartInfo[] partInfoList;

    @NameInMap("rapid_upload")
    @Validation(pattern = "", maxLength = 0)
    public boolean rapidUpload;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

    @NameInMap("upload_id")
    @Validation(pattern = "", maxLength = 0)
    public String uploadId;

}

