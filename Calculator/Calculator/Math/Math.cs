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
        /// 构造函数
        /// </summary>
        public Mathematics() {}

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
        /// <summary>
        /// MathemationMatching子类的构造函数，使用关键字base调用Mathematics基类的构造函数
        /// </summary>
        /// <param name="symbol">需要匹配的字符串</param>
        MathematicalMatching( string symbol ):base()
        {
            this._Symbol = symbol;
        }

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

        // 以下应该需要构造一个栈结构来处理字符串（匹配输入的计算格式是否符合标准）
        // 这里将展示两个版本的栈结构（C#封装好的栈结构、以及手动写栈结构两个版本）
        // 栈（数据结构、栈顶、栈底、出栈、入栈、判空、栈满等基本操作）

        // ------------------------------------------------------------------------------------------------------
        // ---------------------------------------- 第一个版本（手动写栈）---------------------------------------
        // ------------------------------------------------------------------------------------------------------
        class DefineStack
        {
            // 字段
            private int _Stack_Top  = -1;          // 栈顶
            private int _Stack_Max  = 10;          // 栈的容量
            private object[] _Data;                // 存取数据的数组

            // 属性
            public int StackTop
            {
                get
                {
                    return _Stack_Top;
                }
                set
                {
                    _Stack_Top = value;
                }
            }
            public int StackMax
            {
                get
                {
                    return _Stack_Max;
                }
                set
                {
                    _Stack_Max = value;
                }
            }
            public object[] Data
            {
                get
                {
                    return _Data;
                }
                set
                {
                    for (int i = 0; i < _Data.Length; i++)
                    {
                        _Data[i] = value[i];
                    }
                }
            }

            /// <summary>
            /// 判断栈结构是不是满
            /// </summary>
            /// <returns></returns>
            bool isFull()
            {
                if (_Stack_Top >= _Stack_Max)
                    return true;
                return false;
            }

            /// <summary>
            /// 判断栈结构是不是空
            /// </summary>
            /// <returns></returns>
            bool isEmpty()
            {
                if (_Stack_Top == -1)
                    return true;
                return false;
            }

            /// <summary>
            /// 向栈结构中加数据
            /// </summary>
            /// <param name="c">数据</param>
            void Push_Back(char c)
            {
                if (!isFull())
                {
                    _Data[_Stack_Top++] = c;
                }
                else
                {
                    throw new Exception("栈结构已满");
                }
            }

            /// <summary>
            /// 从栈结构中取数据
            /// </summary>
            /// <returns></returns>
            char Pop_Back()
            {
                if (!isEmpty())
                {
                    return (char)(_Data[_Stack_Top--]);
                }
                else
                {
                    throw new Exception("栈结构没有数据（null）");
                }
            }

            /// <summary>
            /// 释放数组
            /// </summary>
            void Dispose()
            {
                if(_Data!=null)
                    _Data = null; 
            }
        }
    }
}
