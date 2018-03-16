using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PrinterManager
{
    class ConfigurationManager
    {
        public static string ReadSetting(string key)
        {
            try
            {
                /**********
                //var appSettings = ConfigurationManager.AppSettings;
                //string result = appSettings[key] ?? "Not Found";
                //Console.WriteLine(result);
                *************/
                //获取Configuration对象
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //根据Key读取<add>元素的Value
                string value = config.AppSettings.Settings[key].Value;
                return value;
            }
            catch (ConfigurationErrorsException)
            {
                //Console.WriteLine("Error reading app settings");
                return "";
            }
        }

        public static void ModifySetting(string key,string value)
        {
            try
            {
                 //获取Configuration对象
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //写入<add>元素的Value
                config.AppSettings.Settings[key].Value = value;
                //一定要记得保存，写不带参数的config.Save()也可以
                config.Save(ConfigurationSaveMode.Modified);
                //刷新，否则程序读取的还是之前的值（可能已装入内存）
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                //Console.WriteLine("Error reading app settings");
            }
        }

        public static void AddSetting(string key, string value)
        {
            try
            {
                //获取Configuration对象
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //增加<add>元素
                config.AppSettings.Settings.Add(key, value);
                config.Save(ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                //Console.WriteLine("Error reading app settings");
            }
        }

        public static void DeleteSetting(string key)
        {
            try
            {
                //获取Configuration对象
                Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //删除<add>元素
                config.AppSettings.Settings.Remove(key);
                config.Save(ConfigurationSaveMode.Modified);
                System.Configuration.ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
                //Console.WriteLine("Error reading app settings");
            }
        }

    }
}
