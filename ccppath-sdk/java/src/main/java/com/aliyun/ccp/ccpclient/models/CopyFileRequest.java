// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CopyFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String driveId;

    @NameInMap("file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String fileId;

    @NameInMap("file_path")
    public String filePath;

    @NameInMap("new_name")
    @Validation(required = true, pattern = "[a-zA-Z0-9.-]{1,1000}")
    public String newName;

    @NameInMap("overwrite")
    public boolean overwrite;

    @NameInMap("share_id")
    public String shareId;

    @NameInMap("to_drive_id")
    @Validation(required = true, pattern = "[0-9]+")
    public String toDriveId;

    @NameInMap("to_parent_file_id")
    @Validation(required = true, pattern = "[a-z0-9.-_]{1,50}")
    public String toParentFileId;

    @NameInMap("to_parent_file_path")
    public String toParentFilePath;

    @NameInMap("to_share_id")
    public String toShareId;

}

