using System;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Maticsoft.Common
{
    /// <summary>
    /// INI文件读写类。
    /// </summary>
    public class INIFile
    {
        public string path;

        public INIFile()
        {
            path = Application.StartupPath + "/config.ini";
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defVal, Byte[] retVal, int size, string filePath);


        /// <summary>
        /// 写INI文件
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <param name="Value"></param>
        public void IniWriteValue(string Section, string Key, string Value)
        {
            Key = Key.ToLower();
            WritePrivateProfileString(Section, Key, Value, this.path);
            string CacheKey = "INISettings-" + Section + "-" + Key;
            Cache.Instance.Remove(CacheKey);
        }

        /// <summary>
        /// 读取INI文件（使用了缓存）
        /// </summary>
        /// <param name="Section"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public string IniReadValue(string Section, string Key)
        {
            Key = Key.ToLower();
            string CacheKey = "INISettings-" + Section + "-" + Key;
            object objModel = Cache.Instance[CacheKey];
            if (objModel != null)
                return objModel.ToString();
            else
            {
                StringBuilder temp = new StringBuilder(255);
                int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
                Cache.Instance.Add(CacheKey, temp);
                return temp.ToString();
            }
        }
        public byte[] IniReadValues(string Section, string Key)
        {
            Key = Key.ToLower();
            byte[] temp = new byte[255];
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.path);
            return temp;

        }

        public string IniReadLongValue(string Section, string Key)
        {
            Key = Key.ToLower();
            string CacheKey = "INISettings-" + Section + "-" + Key;
            object objModel = Cache.Instance[CacheKey];
            if (objModel != null)
                return objModel.ToString();
            else
            {
                StringBuilder temp = new StringBuilder(5000);
                int i = GetPrivateProfileString(Section, Key, "", temp, 5000, this.path);
                Cache.Instance.Add(CacheKey, temp);
                return temp.ToString();
            }
        }

        /// <summary>
        /// 删除ini文件下所有段落
        /// </summary>
        public void ClearAllSection()
        {
            IniWriteValue(null, null, null);
        }
        /// <summary>
        /// 删除ini文件下personal段落下的所有键
        /// </summary>
        /// <param name="Section"></param>
        public void ClearSection(string Section)
        {
            IniWriteValue(Section, null, null);
        }

    }


}
