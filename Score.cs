using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 李荣武
{
   public class Score
    {
        public string XueHao;
        public string XinMin;
        public decimal XuanXiuKe;
        public decimal SiYanKe;
        public decimal BiXueKe;
        public Score(string xuehao,string xinmin, string xuanxiuke, string siyanke, string bixiuke) { 
            XinMin = xinmin;
            XueHao= xuehao;
            XuanXiuKe= decimal.Parse(xuanxiuke);
            SiYanKe= decimal.Parse(siyanke);
            BiXueKe= decimal.Parse(bixiuke);
        }
    }
}
