using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Func_Test
{
    class Program
    {
        //https://dotblogs.com.tw/initials/2017/02/11/a02_func
        //https://dotblogs.com.tw/kinanson/2015/04/12/151032
        //https://dotblogs.com.tw/lastsecret/2010/06/26/16201
        //https://az787680.vo.msecnd.net/user/lastsecret/1006/Funclambda_F7B4/image_thumb_1.png
        //http://www.huanlintalk.com/2009/01/delegate-revisited-csharp-1-to-2-to-3.html
        static void Main(string[] args)
        {
            //傳入int ,回傳string  ;*Func(一定有回傳) 沒有回傳的是Action
            //Func<int, string> doo = Method;

            // doo傳入int 5的數字, 預期回傳string
            //string re = doo(5);

            //Console.WriteLine(re);
            //Console.ReadLine();

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



 public static string Method(int x)
        {
            var temp = "傳入的數字是: " + x.ToString();
            return temp; //回傳String
        }
    }
}
