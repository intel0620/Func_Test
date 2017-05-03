using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncDelegate func = new FuncDelegate();
            GetNumber getNumber = new GetNumber();
            //這邊我們動態決定了要使用乘法，傳進去4*5
            Console.WriteLine(getNumber.ReturnString(func.Multiplied, 4, 5)); 
            Console.ReadLine();
        }

        public class GetNumber
        {
            //第一個和第二個皆是要傳入的參考，第三個則是要回傳的型別
            //func 當成一個方法,回傳值及參數,FuncDelegate定義的加減乘除.
            public string ReturnString(Func<int, int, string> func, int a, int b) 
            {
                //這裡可以動態決定要使用何種方式
                return "結果為" + func(a, b); 
            }
        }
        public class FuncDelegate
        {
            public string Plus(int a, int b)
            {
                return string.Format("加法:{0}", a + b);
            }

            public string Minus(int a, int b)
            {
                return string.Format("減法:{0}", a - b);
            }

            public string Multiplied(int a, int b)
            {
                return string.Format("乘法:{0}", a * b);
            }

            public string Division(int a, int b)
            {
                return string.Format("除法:{0}", a / b);
            }

        }
    }
}
