// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

/**
 * 
 */
public class StreamInfo extends TeaModel {
    @NameInMap("content_hash")
    public String contentHash;

    @NameInMap("content_hash_name")
    public String contentHashName;

    @NameInMap("content_md5")
    @Validation(required = true)
    public String contentMd5;

    @NameInMap("part_info_list")
    public java.util.List<UploadPartInfo> partInfoList;

    @NameInMap("pre_hash")
    public String preHash;

    @NameInMap("size")
    @Validation(required = true)
    public Long size;

    public static StreamInfo build(java.util.Map<String, ?> map) throws Exception {
        StreamInfo self = new StreamInfo();
        return TeaModel.build(map, self);
    }

}
