// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class CopyFileRequest extends TeaModel {
    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String fileId;

    @NameInMap("file_path")
    @Validation(pattern = "", maxLength = 0)
    public String filePath;

    @NameInMap("new_name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String newName;

    @NameInMap("overwrite")
    @Validation(pattern = "", maxLength = 0)
    public boolean overwrite;

    @NameInMap("share_id")
    @Validation(pattern = "", maxLength = 0)
    public String shareId;

    @NameInMap("to_parent_file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String toParentFileId;

    @NameInMap("to_parent_file_path")
    @Validation(pattern = "", maxLength = 0)
    public String toParentFilePath;

}

