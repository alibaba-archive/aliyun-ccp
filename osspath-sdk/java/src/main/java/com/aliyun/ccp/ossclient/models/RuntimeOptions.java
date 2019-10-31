// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ossclient.models;

import com.aliyun.tea.*;

public class RuntimeOptions extends TeaModel {
    @NameInMap("autoretry")
    @Validation(pattern = "", maxLength = 0)
    public boolean autoretry;

    @NameInMap("ignoreSSL")
    @Validation(pattern = "", maxLength = 0)
    public boolean ignoreSSL;

    @NameInMap("maxAttempts")
    @Validation(pattern = "", maxLength = 0)
    public Integer maxAttempts;

    @NameInMap("backoffPolicy")
    @Validation(pattern = "", maxLength = 0)
    public String backoffPolicy;

    @NameInMap("backoffPeriod")
    @Validation(pattern = "", maxLength = 0)
    public Integer backoffPeriod;

    @NameInMap("readTimeout")
    @Validation(pattern = "", maxLength = 0)
    public Integer readTimeout;

    @NameInMap("connectTimeout")
    @Validation(pattern = "", maxLength = 0)
    public Integer connectTimeout;

    @NameInMap("httpProxy")
    @Validation(pattern = "", maxLength = 0)
    public String httpProxy;

    @NameInMap("httpsProxy")
    @Validation(pattern = "", maxLength = 0)
    public String httpsProxy;

    @NameInMap("noProxy")
    @Validation(pattern = "", maxLength = 0)
    public String noProxy;

    @NameInMap("maxIdleConns")
    @Validation(pattern = "", maxLength = 0)
    public Integer maxIdleConns;

    @NameInMap("localAddr")
    @Validation(pattern = "", maxLength = 0)
    public String localAddr;

    @NameInMap("socks5Proxy")
    @Validation(pattern = "", maxLength = 0)
    public String socks5Proxy;

    @NameInMap("socks5NetWork")
    @Validation(pattern = "", maxLength = 0)
    public String socks5NetWork;

}

