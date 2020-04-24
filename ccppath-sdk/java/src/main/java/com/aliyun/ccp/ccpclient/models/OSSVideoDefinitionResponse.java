// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 转码接口response
 */
public class OSSVideoDefinitionResponse extends TeaModel {
    @NameInMap("definition_list")
    public java.util.List<String> definitionList;

    public static OSSVideoDefinitionResponse build(java.util.Map<String, ?> map) throws Exception {
        OSSVideoDefinitionResponse self = new OSSVideoDefinitionResponse();
        return TeaModel.build(map, self);
    }

}
