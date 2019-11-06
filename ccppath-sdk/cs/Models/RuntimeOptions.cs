
using System;
using System.Collections.Generic;

using Tea;

namespace Aliyun.SDK.CCP.CCPClient.Models
{
    public class RuntimeOptions : TeaModel {
        [NameInMap("autoretry")]
        [Validation(Required=false)]
        public bool Autoretry { get; set; }

        [NameInMap("ignoreSSL")]
        [Validation(Required=false)]
        public bool IgnoreSSL { get; set; }

        [NameInMap("maxAttempts")]
        [Validation(Required=false)]
        public int MaxAttempts { get; set; }

        [NameInMap("backoffPolicy")]
        [Validation(Required=false)]
        public string BackoffPolicy { get; set; }

        [NameInMap("backoffPeriod")]
        [Validation(Required=false)]
        public int BackoffPeriod { get; set; }

        [NameInMap("readTimeout")]
        [Validation(Required=false)]
        public int ReadTimeout { get; set; }

        [NameInMap("connectTimeout")]
        [Validation(Required=false)]
        public int ConnectTimeout { get; set; }

        [NameInMap("httpProxy")]
        [Validation(Required=false)]
        public string HttpProxy { get; set; }

        [NameInMap("httpsProxy")]
        [Validation(Required=false)]
        public string HttpsProxy { get; set; }

        [NameInMap("noProxy")]
        [Validation(Required=false)]
        public string NoProxy { get; set; }

        [NameInMap("maxIdleConns")]
        [Validation(Required=false)]
        public int MaxIdleConns { get; set; }

        [NameInMap("localAddr")]
        [Validation(Required=false)]
        public string LocalAddr { get; set; }

        [NameInMap("socks5Proxy")]
        [Validation(Required=false)]
        public string Socks5Proxy { get; set; }

        [NameInMap("socks5NetWork")]
        [Validation(Required=false)]
        public string Socks5NetWork { get; set; }

    }

}
