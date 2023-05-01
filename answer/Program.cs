using System.ComponentModel.Design;

namespace answer
{
    internal class Program
    {
        static int solution(int num)
        {
            if (num == 1)
            {
                return 0;
            }
            int answer = 0;
            while (answer <= 500)
            {
                if (num % 2 == 0)
                {
                    num = num / 2;
                    answer++;
                }
                if (num == 1)
                {
                    return answer;
                }
                if (num % 2 == 1)
                {
                    num = num * 3 + 1;
                    answer++;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int num = 626331;
            Console.WriteLine(solution(num));
        }
    }
}