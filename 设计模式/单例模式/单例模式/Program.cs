using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    class Program
    {
        public AppConfig AppConfig
        {
            get => default(AppConfig);
            set
            {
            }
        }

        static void Main(string[] args)
        {
            AppConfig appConfig = AppConfig.GetInstance();
            Console.WriteLine(appConfig.GetParameterA());
            appConfig.SetParameterA("1");
            Console.WriteLine(appConfig.GetParameterA());
            AppConfig config = AppConfig.GetInstance();
            if(appConfig==config)
            {
                Console.WriteLine("实现了单例模式");
            }
            else
            {
                Console.WriteLine("没有实现单例模式");
            }
            Console.ReadLine();
        }
    }
    public class AppConfig
    {
        private static AppConfig instance = new AppConfig();
        private string ParameterA = "defaolt";
        private AppConfig() { }

        public static AppConfig GetInstance()
        {
            return instance;
        }

        public string  GetParameterA()
        {
            return this.ParameterA;
        }

        public void SetParameterA(string s)
        {
            this.ParameterA = s;
        }

    }
}
