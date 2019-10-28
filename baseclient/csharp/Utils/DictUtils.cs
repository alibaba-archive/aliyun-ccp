using System.Collections.Generic;

namespace Aliyun.SDK.CCP.Utils
{
    public class DictUtils
    {
        public static object GetDicValue(Dictionary<string, object> dic, string keyName)
        {
            if (dic.ContainsKey(keyName))
            {
                return dic[keyName];
            }
            return null;
        }
    }
}