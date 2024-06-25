namespace ConsoleApp744
{
    internal class TriangleArea
    {
        static void Main(string[] args)
        {
            //1. 변수선언 및 입력부
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            //2. 알고리즘 수식
            double resut = (width * height) / 2; //수식


            //3. 출력부
            Console.WriteLine($"넓이는 {resut} 입니다.");
        }
    }
}
