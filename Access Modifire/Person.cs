namespace Access_Modifire
{
    class Person
    {
        /// <summary>
        /// Define public and private fields
        /// that can be accessed...!
        /// </summary>        

        public int Age;
        public string FullName;
        public decimal Salary;
        private int Id;
        private string Post;

        /// <summary>
        /// Creating public and private fields
        /// for the class whose access level is specified...!
        /// </summary>

        public static int age;
        public static string fullname;
        public static decimal salary;
        private static int id;
        private static string post;

        /// <summary>
        /// The multiplication function
        /// of two numbers is 10...!
        /// </summary>
        /// <returns>Returns the result value</returns>

        public int SomeFunction()
        {
            int Result;

            Result = 10 * 10;

            return Result;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine($"This man, name is {FullName} and {Age} years old. His salary is within a month's time with {Salary}");
        }

        /// <summary>
        /// A function that calculates 
        /// a number in the power of another number...!
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Power</param>
        /// <returns>The result is the power of two numbers</returns>

        public static int FunctionPower(int number1, int number2 )

        {
            int Result=1;

            for (int i = 0; i < number2; i++)
            {
                Result = Result * number1;
            }            

            return Result;
        }


    }
}
