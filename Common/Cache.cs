using System;
using System.Collections;
using System.Collections.Generic;

namespace Maticsoft.Common
{

    /// <summary>
    /// 全局统一的缓存类
    /// </summary>
    public class Cache
    {
        private SortedDictionary<string, object> dic = new SortedDictionary<string, object>();
        private static volatile Cache instance = null;
        private static object lockHelper = new object();

        private Cache()
        {
        }
        /// <summary>
        /// 增加到缓存中
        /// </summary>
        public void Add(string key, object value)
        {
            if (dic.ContainsKey(key))
                dic[key] = value;
            else
                dic.Add(key, value);
        }
        /// <summary>
        /// 从缓存中删除
        /// </summary>
        /// <param name="key"></param>
        public void Remove(string key)
        {
            if (dic.ContainsKey(key))
                dic.Remove(key);
        }

        /// <summary>
        /// 索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[string index]
        {
            get
            {
                if (dic.ContainsKey(index))
                    return dic[index];
                else
                    return null;
            }
            set { dic[index] = value; }
        }

        public static Cache Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockHelper)
                    {
                        if (instance == null)
                        {
                            instance = new Cache();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
