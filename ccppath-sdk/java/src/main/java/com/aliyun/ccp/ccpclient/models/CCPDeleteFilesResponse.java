// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class CCPDeleteFilesResponse extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("deleted_file_id_list")
    public String[] deletedFileIdList;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    public static CCPDeleteFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPDeleteFilesResponse self = new CCPDeleteFilesResponse();
        return TeaModel.build(map, self);
    }

}
