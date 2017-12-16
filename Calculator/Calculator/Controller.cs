using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Controller
    {
        private static Controller m_Controller;           // 唯一实例
        private string m_Analysis;                        // 待分析的字符串
        private Math.MathematicalMatching m_Mathch;       // 数学分析类 
        
        private Controller() {}

        /// <summary>
        /// 获得唯一的实例
        /// </summary>
        /// <returns></returns>
        public static Controller GetInstance()
        {
            if (m_Controller == null)
            {
                m_Controller =  new Controller();
            }

            return m_Controller;
        }
    }
}
