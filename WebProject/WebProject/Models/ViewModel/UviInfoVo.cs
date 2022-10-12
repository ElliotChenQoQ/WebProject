using System.Collections.Generic;

namespace WebProject.Models.ViewModel
{
    public class UviInfoVo
    {
        public string DateTime { get; set; }
        public List<UviDataVo> UviDatas { get; set; }
    }

    public class UviDataVo
    {
        public string UviValue { get; set; }
        public string City { get; set; }
        public string DisplayStyle { get; set; }
    }
}
