using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Controller
    {
        // 字段
        private static Controller m_Controller;                 // 唯一实例
        private string m_Analysis;                              // 待分析的字符串
        private Math.MathematicalMatching m_Mathch;             // 数学分析类 

        // 属性
        public string Alalysis{
            get{
                return m_Analysis;
            }

            set{
                m_Analysis = value;
            }
        }

        public Math.MathematicalMatching Match{
            get{
                return m_Mathch;
            }

            set{
                m_Mathch = value;
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Controller() { }
        
        /// <summary>
        /// 析构函数
        /// </summary>
        //public ~Controller() 
        //{
            //try
            //{
            //    m_Controller = null;
            //    m_Mathch = null;
            //}
            //catch (Exception)
            //{   
            //    throw;
            //}
        //}

        /// <summary>
        /// 获得唯一的实例
        /// </summary>
        /// <returns></returns>
        public static Controller GetInstance(){
            if (m_Controller == null){
                m_Controller =  new Controller();
            }

            return m_Controller;
        }

        /// <summary>
        /// 计算字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public object Result( string rhs ){
            // split string
            // " "| + |" "| - |" "| * |" "| / |" "
            // CalCulateNumber -> 分离出来的数字字符串数组
            // CalCulateFormat -> 分离出来的运算符号字符串数组
            string[] CalCulateNumber = rhs.Split(new char[] { '+', '-', '*', '/' },
                                                 StringSplitOptions.RemoveEmptyEntries);
            
            string[] CalCulateFormat = rhs.Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'},
                                                 StringSplitOptions.RemoveEmptyEntries);

            // 计算测试（ 5+3*9+8-20 ）
            for (int i = 0; i < CalCulateFormat.Length; i++){
                switch (CalCulateFormat[i]){
                    case "+":
                        CalCulateNumber[i + 1] = Add(CalCulateNumber[i], CalCulateNumber[i + 1]);
                        break;
                    case "-":
                        CalCulateNumber[i + 1] = Subtraction(CalCulateNumber[i], CalCulateNumber[i + 1]);
                        break;
                    case "*":
                        CalCulateNumber[i + 1] = Multiplication(CalCulateNumber[i], CalCulateNumber[i + 1]);
                        break;
                    case "/":
                        CalCulateNumber[i + 1] = Division(CalCulateNumber[i], CalCulateNumber[i + 1]);
                        break;
                    default:
                        break;
                }
            }

            return CalCulateNumber[CalCulateFormat.Length];
        }

        /// <summary>
        /// 数字字符串加
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string Add( string lhs, string rhs){
            bool isDouble = (lhs.IndexOf('.') == -1 || rhs.IndexOf('.') == -1);

            if(isDouble)
                return Calculator.Math.Mathematics.Add<int>(int.Parse(lhs), int.Parse(rhs)).ToString();

            return Calculator.Math.Mathematics.Add<double>(double.Parse(lhs), double.Parse(rhs)).ToString();
        }

        /// <summary>
        /// 数字字符串减
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string Subtraction(string lhs, string rhs){
            bool isDouble = (lhs.IndexOf('.') == -1 || rhs.IndexOf('.') == -1);

            if(isDouble)
                return Calculator.Math.Mathematics.Subtraction<int>(int.Parse(lhs), int.Parse(rhs)).ToString();

            return Calculator.Math.Mathematics.Subtraction<double>(double.Parse(lhs), double.Parse(rhs)).ToString();
        }
        
        /// <summary>
        /// 数字符串乘
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string Multiplication(string lhs, string rhs){
            bool isDouble = (lhs.IndexOf('.') == -1 || rhs.IndexOf('.') == -1);

            if(isDouble)
                return Calculator.Math.Mathematics.Multiplication<int>(int.Parse(lhs), int.Parse(rhs)).ToString();

            return Calculator.Math.Mathematics.Multiplication<double>(double.Parse(lhs), double.Parse(rhs)).ToString();
        }

        /// <summary>
        /// 数字字符串除
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string Division(string lhs, string rhs){
            bool isDouble = (lhs.IndexOf('.') == -1 || rhs.IndexOf('.') == -1);

            if(isDouble)
                return Calculator.Math.Mathematics.Division<int>(int.Parse(lhs), int.Parse(rhs)).ToString();

            return Calculator.Math.Mathematics.Division<double>(double.Parse(lhs), double.Parse(rhs)).ToString();
        }

        /// <summary>
        /// 数字字符串的平方
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string X_2(string rhs) {
            bool isDouble = (rhs.IndexOf('.') == -1);

            if (isDouble)
                return Calculator.Math.Mathematics.Pow<int>(int.Parse(rhs), 2).ToString();

            return Calculator.Math.Mathematics.Pow<double>(double.Parse(rhs), 2).ToString();
        }

        /// <summary>
        /// 数字字符串的立方
        /// </summary>
        /// <param name="rhs"></param>
        /// <returns></returns>
        public string X_3(string rhs){
            bool isDouble = (rhs.IndexOf('.') == -1);

            if (isDouble)
                return Calculator.Math.Mathematics.Pow<int>(int.Parse(rhs), 3).ToString();

            return Calculator.Math.Mathematics.Pow<double>(double.Parse(rhs), 3).ToString();
        } 
    }
}
