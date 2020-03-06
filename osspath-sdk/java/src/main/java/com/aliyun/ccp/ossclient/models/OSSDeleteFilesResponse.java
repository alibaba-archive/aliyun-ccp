// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

/**
 * 批量删除文件 response
 */
public class OSSDeleteFilesResponse extends TeaModel {
    @NameInMap("deleted_file_id_list")
    public java.util.List<String> deletedFileIdList;

    @NameInMap("domain_id")
    @Validation(pattern = "[a-z0-9A-Z]+")
    public String domainId;

    @NameInMap("drive_id")
    @Validation(pattern = "[0-9]+")
    public String driveId;

    @NameInMap("share_id")
    @Validation(pattern = "[0-9]+")
    public String shareId;

    public static OSSDeleteFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSDeleteFilesResponse self = new OSSDeleteFilesResponse();
        return TeaModel.build(map, self);
    }

}
