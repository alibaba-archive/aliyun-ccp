using System;
using System.Reflection;

namespace baseClientUnitTests
{
    public class TestHelper
    {
        /// <summary>
        /// 调用静态方法
        /// </summary>
        /// <param name="t">类全名</param>
        /// <param name="strMethod">方法名</param>
        /// <param name="aobjParams">参数表</param>
        /// <returns>函数返回值</returns>
        public static void RunStaticMethod(Type t, string strMethod, object[] aobjParams)
        {
            BindingFlags eFlags =
                BindingFlags.Static | BindingFlags.Public |
                BindingFlags.NonPublic;
            RunMethod(t, strMethod, null, aobjParams, eFlags);
        }

        /// <summary>
        /// 调用实例方法
        /// </summary>
        /// <param name="t">类全名</param>
        /// <param name="strMethod">方法名</param>
        /// <param name="objInstance">类的实例</param>
        /// <param name="aobjParams">参数表</param>
        ///<returns>函数返回值</returns>
        public static object RunInstanceMethod(Type t, string strMethod, object objInstance, object[] aobjParams)
        {
            BindingFlags eFlags = BindingFlags.Instance | BindingFlags.Public |
                BindingFlags.NonPublic;
            return RunMethod(t, strMethod,
                objInstance, aobjParams, eFlags);
        }

        private static object RunMethod(Type t, string strMethod, object objInstance, object[] aobjParams,
            BindingFlags eFlags)
        {
            MethodInfo m;
            try
            {
                m = t.GetMethod(strMethod, eFlags);
                if (m == null)
                {
                    throw new ArgumentException("There is no method '" + strMethod + "' for type'" + t + "'.");
                }

                object objRet = m.Invoke(objInstance, aobjParams);
                return objRet;
            }
            catch (TargetInvocationException ex)
            {
                if (null != ex.InnerException)
                {
                    throw ex.InnerException;
                }

                throw;
            }
        }
    }
}
