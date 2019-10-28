// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class RuntimeOptions : TeaModel {
        [NameInMap("autoretry")]
        [Validation(Required=true)]
        public bool Autoretry { get; set; }

        [NameInMap("ignoreSSL")]
        [Validation(Required=true)]
        public bool IgnoreSSL { get; set; }

        [NameInMap("maxAttempts")]
        [Validation(Required=true)]
        public int MaxAttempts { get; set; }

        [NameInMap("backoffPolicy")]
        [Validation(Required=true)]
        public string BackoffPolicy { get; set; }

        [NameInMap("backoffPeriod")]
        [Validation(Required=true)]
        public int BackoffPeriod { get; set; }

        [NameInMap("readTimeout")]
        [Validation(Required=true)]
        public int ReadTimeout { get; set; }

        [NameInMap("connectTimeout")]
        [Validation(Required=true)]
        public int ConnectTimeout { get; set; }

        [NameInMap("httpProxy")]
        [Validation(Required=true)]
        public string HttpProxy { get; set; }

        [NameInMap("httpsProxy")]
        [Validation(Required=true)]
        public string HttpsProxy { get; set; }

        [NameInMap("noProxy")]
        [Validation(Required=true)]
        public string NoProxy { get; set; }

        [NameInMap("maxIdleConns")]
        [Validation(Required=true)]
        public int MaxIdleConns { get; set; }

        [NameInMap("localAddr")]
        [Validation(Required=true)]
        public string LocalAddr { get; set; }

        [NameInMap("socks5Proxy")]
        [Validation(Required=true)]
        public string Socks5Proxy { get; set; }

        [NameInMap("socks5NetWork")]
        [Validation(Required=true)]
        public string Socks5NetWork { get; set; }

    }

}
