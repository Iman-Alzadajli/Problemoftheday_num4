 namespace Problemoftheday_num4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] Matrix = { { 1, 2, 3 },
                { 4,5,6},
            { 9,8,9} };

            int rows= Matrix.GetLength(0); // نحسب عدد الصفوف و الاعمدة 
            int cols= Matrix.GetLength(1);

           int  firstDiagonal = 0;
            int secondDiagonal = 0;

            for (int i = 0;i < rows; i++) {
                firstDiagonal = firstDiagonal + Matrix[i,i]; // 0,0 / 1,1 / 2,2

                secondDiagonal = secondDiagonal + Matrix[i,cols-1-i]; //its like col(3-1-0) = 0,2 / 3-1-1 = 1,1 / 3-1 -2 = 2,2


            }

            int result = Math.Abs(firstDiagonal - secondDiagonal); //  Math.Abs  its Absolute just take postive numbers 
            Console.WriteLine("The absolute different between the sum of diagonals is : "+ result);


        }
    }
}
