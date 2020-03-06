// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * Get AsyncTask Response
 */
public class CCPGetAsyncTaskResponse extends TeaModel {
    @NameInMap("async_task_id")
    public String asyncTaskId;

    @NameInMap("message")
    public String message;

    @NameInMap("state")
    public String state;

    public static CCPGetAsyncTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        CCPGetAsyncTaskResponse self = new CCPGetAsyncTaskResponse();
        return TeaModel.build(map, self);
    }

}
