namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Length for Side 1: ");
            string side1 = Console.ReadLine();
            Console.Write("Enter Length for Side 2: ");
            string side2 = Console.ReadLine();
            Console.Write("Enter Length for Side 3: ");
            string side3 = Console.ReadLine();

            string[] trianglesides = {side1, side2, side3};

            Array.Sort(trianglesides);

            double sortedside1 = Convert.ToDouble(trianglesides[0]);
            double sortedside2 = Convert.ToDouble(trianglesides[1]);
            double sortedside3 = Convert.ToDouble(trianglesides[2]);


            if ((sortedside1 + sortedside2) > sortedside3)
            {
                if (((Math.Pow(sortedside1, 2)) + (Math.Pow(sortedside2, 2))) == (Math.Pow(sortedside3, 2)))
                {
                    Console.WriteLine("The given triangle is a right angled triangle.");
                }
                else
                {
                    Console.WriteLine("The given triangle is not a right angled triangle.");
                }
            }
            else
            {
                Console.WriteLine("The given triangle is not a right angled triangle.");
            }
        }
    }
}