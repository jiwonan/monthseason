using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {
            String month;

            Console.Write("월(Month)을 입력하시오: ");
            month = Console.ReadLine();
            if(month.Contains("03") || month.Contains("3") || month.Contains("3월") ||
                month.Contains("03") || month.Contains("4") || month.Contains("4월") ||
                month.Contains("05") || month.Contains("5") || month.Contains("5월"))
            {
                Console.WriteLine("봄입니다.");
            }
            else if (month.Contains("06") || month.Contains("6") || month.Contains("6월") ||
                month.Contains("07") || month.Contains("7") || month.Contains("7월") ||
                month.Contains("08") || month.Contains("8") || month.Contains("8월"))
            {
                Console.WriteLine("여름입니다.");
            }
            else if (month.Contains("09") || month.Contains("9") || month.Contains("9월") ||
                month.Contains("10") || month.Contains("10") || month.Contains("10월") ||
                month.Contains("11") || month.Contains("11") || month.Contains("11월"))
            {
                Console.WriteLine("가을입니다.");
            }
            else if (month.Contains("12") || month.Contains("12") || month.Contains("12월") ||
                month.Contains("01") || month.Contains("1") || month.Contains("1월") ||
                month.Contains("02") || month.Contains("2") || month.Contains("2월"))
            {
                Console.WriteLine("겨울입니다.");
            }
            else
            {
                Console.WriteLine("1 - 12 사이의 숫자를 입력해주세요.");
            }
        }
    }
}
