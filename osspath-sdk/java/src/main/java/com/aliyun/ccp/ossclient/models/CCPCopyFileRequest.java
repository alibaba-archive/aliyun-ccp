// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CCPCopyFileRequest extends TeaModel {
    @NameInMap("auto_rename")
    @Validation(pattern = "", maxLength = 0)
    public boolean autoRename;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String fileId;

    @NameInMap("new_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String newName;

    @NameInMap("to_drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String toDriveId;

    @NameInMap("to_parent_file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String toParentFileId;

}

