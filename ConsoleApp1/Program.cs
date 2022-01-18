using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static ActivityControl contorl = new ActivityControl();
        static void Main(string[] args)
        {
            List<SampleData> list = new List<SampleData>();
            SampleData data = new SampleData()
            {
                Name = "Data 1"
            };
            SampleData data2 = new SampleData()
            {
                Name = "Data 2"
            };
            list.Add(data);
            list.Add(data2);
            contorl.Initiallize(list);
            contorl.Datas[0].Name = "Data 11";
            contorl.Logger.Log(new SampleData() { Name = "Fake Data" });
            Console.ReadKey();
        }
    }
}
