// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * the file op info
 */
public class FileDeltaResponse extends TeaModel {
    @NameInMap("current_category")
    public String currentCategory;

    @NameInMap("file")
    public BaseCCPFileResponse file;

    @NameInMap("file_id")
    public String fileId;

    @NameInMap("op")
    public String op;

    public static FileDeltaResponse build(java.util.Map<String, ?> map) throws Exception {
        FileDeltaResponse self = new FileDeltaResponse();
        return TeaModel.build(map, self);
    }

}
