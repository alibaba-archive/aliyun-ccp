using System.Collections.Generic;

namespace AlibabaCloud.AccessTokenCredential.Utils
{
    internal class DictUtils
    {
        internal static object GetDicValue(Dictionary<string, object> dic, string keyName)
        {
            if (dic.ContainsKey(keyName))
            {
                return dic[keyName];
            }
            return null;
        }
    }
}
