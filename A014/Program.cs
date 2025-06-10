namespace A014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int value;

            Console.WriteLine("1. int로 변환할 문자열을 입력하세요");
            input = Console.ReadLine(); // 문자열 입력
            bool result = Int32.TryParse(input, out value);

            if (!result)
            {
                Console.WriteLine("{0}는 int로 변환될 수 없습니다.\n", input);
            }

            else
            {
                Console.WriteLine("{0}는 input로 변환 되었습니다 \n", input);
            }

            Console.WriteLine("2. double 로 변환할 문자열을 입력하세요");
            
            input = Console.ReadLine(); // 문자열 입력

            try
            {
                double m = Double.Parse(input);
                Console.WriteLine("double{0}으로 변환 되었습니다", input);
            }

            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }          

        }
    }
}
