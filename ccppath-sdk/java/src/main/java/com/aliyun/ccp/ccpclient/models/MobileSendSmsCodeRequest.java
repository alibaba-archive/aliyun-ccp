// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.ccp.ccpclient.models;

import com.aliyun.tea.*;

public class MobileSendSmsCodeRequest extends TeaModel {
    @NameInMap("app_id")
    @Validation(pattern = "", maxLength = 0)
    public String appId;

    @NameInMap("captcha_id")
    @Validation(pattern = "", maxLength = 0)
    public String captchaId;

    @NameInMap("captcha_text")
    @Validation(pattern = "", maxLength = 0)
    public String captchaText;

    @NameInMap("phone_number")
    @Validation(pattern = "", maxLength = 0)
    public String phoneNumber;

    @NameInMap("type")
    @Validation(pattern = "", maxLength = 0)
    public String type;

}

