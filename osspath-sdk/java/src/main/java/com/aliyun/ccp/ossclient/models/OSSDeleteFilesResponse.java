// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class OSSDeleteFilesResponse extends TeaModel {
    @NameInMap("requestId")
    @Validation(pattern = "", maxLength = 0)
    public String requestId;

    @NameInMap("deleted_file_id_list")
    @Validation(pattern = "", maxLength = 0)
    public String[] deletedFileIdList;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+", maxLength = 0)
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String shareId;

}

