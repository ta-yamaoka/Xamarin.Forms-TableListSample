using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableListSample.Models;

namespace TableListSample.ViewModels
{
    public class SampleViewModel
    {
        public List<TestModel> SampleList { get; set; }

        public SampleViewModel()
        {
            this.SampleList = new List<TestModel>();
            this.CreateTestData();
        }

        public void CreateTestData()
        {
            this.SampleList.Add(new TestModel() { Name1 = "name1", Value1 = "value1", Name2 = "name2", Value2 = "value2" });
            this.SampleList.Add(new TestModel() { Name1 = "あ", Value1 = "い", Name2 = "う", Value2 = "え" });
            this.SampleList.Add(new TestModel() { Name1 = "か", Value1 = "き", Name2 = "く", Value2 = "け" });
        }
    }
}
