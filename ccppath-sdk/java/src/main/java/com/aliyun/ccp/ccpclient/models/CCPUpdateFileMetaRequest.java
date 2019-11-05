// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPUpdateFileMetaRequest extends TeaModel {
    @NameInMap("custom_index_key")
    @Validation(pattern = "", maxLength = 0)
    public String customIndexKey;

    @NameInMap("description")
    @Validation(pattern = "", maxLength = 0)
    public String description;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+", maxLength = 0)
    public String driveId;

    @NameInMap("file_id")
    @Validation(pattern = "[a-z0-9.-_]{1,50}", maxLength = 0)
    public String fileId;

    @NameInMap("hidden")
    @Validation(pattern = "", maxLength = 0)
    public boolean hidden;

    @NameInMap("labels")
    @Validation(pattern = "", maxLength = 0)
    public String[] labels;

    @NameInMap("meta")
    @Validation(pattern = "", maxLength = 0)
    public String meta;

    @NameInMap("name")
    @Validation(pattern = "[a-zA-Z0-9.-]{1,1024}", maxLength = 0)
    public String name;

    @NameInMap("starred")
    @Validation(pattern = "", maxLength = 0)
    public boolean starred;

}

