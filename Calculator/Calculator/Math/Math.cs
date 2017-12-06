using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Math
{
    class Mathematics
    {
        /// <summary>
        /// 任意两个数的加法运算
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <param name="b">第二个类型为T的数字</param>
        /// <returns>返回T类型的加法结果</returns>
        public static T Add<T>(T a, T b) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return (T)(d1 + d2);
        }

        /// <summary>
        /// 任意两个数的减法运算
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <param name="b">第二个类型为T的数字</param>
        /// <returns>返回T类型的减法结果</returns>
        public static T Subtraction<T>(T a, T b) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return (T)(d1 - d2);
        }

        /// <summary>
        /// 任意两个数的乘法运算
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <param name="b">第二个类型为T的数字</param>
        /// <returns>返回T类型的乘法结果</returns>
        public static T Multiplication<T>(T a, T b) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return (T)(d1 * d2);
        }

        /// <summary>
        /// 任意两个数的除法运算
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <param name="b">第二个类型为T的数字</param>
        /// <returns>返回T类型的除法结果</returns>
        public static T Division<T>(T a, T b) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = b;
            dynamic d3 = -1;

            try
            {
                d3 = (T)(d1 / d2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return d3;
        }

        /// <summary>
        /// 一个数的开根号
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的求根结果</returns>
        public static T Sqrt<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Sqrt(d1);
        }

        /// <summary>
        /// 一个数的Sin值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的Sin结果</returns>
        public static T Sin<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Sin(d1);
        }

        /// <summary>
        /// 一个数的ArcSin值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的Sin结果</returns>
        public static T ArcSin<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Asin(d1);
        }

        /// <summary>
        /// 一个数的Cos值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的ArcSin结果</returns>
        public static T Cos<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Cos(d1);
        }

        /// <summary>
        /// 一个数的ArcCos值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的ArcCos结果</returns>
        public static T ArcCos<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Acos(d1);
        }

        /// <summary>
        /// 一个数的Tan值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的Cos结果</returns>
        public static T Tan<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Tan(d1);
        }

        /// <summary>
        /// 一个数的ArcTan值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的ArcTan结果</returns>
        public static T ArcTan<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Atan(d1);
        }

        /// <summary>
        /// 一个数的平方值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的平方结果</returns>
        public static T Square<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Tan(d1 * d1);
        }

        /// <summary>
        /// 一个数的立方值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的立方结果</returns>
        public static T Cube<T>(T a) where T : struct
        {
            dynamic d1 = a;
            return System.Math.Tan(d1 * d1 * d1);
        }

        /// <summary>
        /// 一个数的任意次方值
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的立方结果</returns>
        public static T Pow<T>(T a, T exponential) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = exponential;
            return System.Math.Pow(d1, d2);
        }

        /// <summary>
        /// 一个数的倒数
        /// </summary>
        /// <typeparam name="T">约束类型结构为值类型</typeparam>
        /// <param name="a">第一个类型为T的数字</param>
        /// <returns>返回T类型的倒数字符串结果</returns>
        public static string Reciprocal<T>(T a) where T : struct
        {
            dynamic d1 = a;
            dynamic d2 = 0;
            dynamic d3 = 1;

            string Tempstring = Convert.ToString(d1);
            if (Tempstring.IndexOf('.') != -1)
            {
                // 拆分小数和整数
                string part1 = Tempstring.Substring(0, Tempstring.IndexOf('.'));
                string part2 = Tempstring.Substring(Tempstring.IndexOf('.') + 1, Tempstring.Length - 1 - Tempstring.IndexOf('.'));

                d2 = long.Parse(part1) * (10 * part2.Length) + long.Parse(part2);
                d3 = 10 * part2.Length;

                return Convert.ToString(d2) + "/" + Convert.ToString(d3);
            }
            else
            {
                return "1" + "/" + Convert.ToString(d1);
            }
        }
    }

    class MathematicalMatching : Mathematics
    {
        // 字段 _Symbol
        // 该字段用来搜集需要匹配的字符串
        private string _Symbol;

        // 属性
        public string Symbol
        {
            get
            {
                return _Symbol;
            }

            set
            {
                _Symbol = value;
            }
        }

        // 以下以需要构造一个栈结构

    }
}
