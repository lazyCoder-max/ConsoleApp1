using System.Collections.Generic;

namespace ConsoleApp1
{
    public class ActivityControl
    {
        public ActionLog Logger { get; set; } = new ActionLog();
        public List<SampleData> Datas { get; set; } = new List<SampleData>();


        public void Initiallize(List<SampleData> datas)
        {
            Datas.AddRange(datas);
            Logger.Log(datas[0]);
        }
    }
}
