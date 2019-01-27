namespace Access_Modifire
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------------------------------------------------------
            //----------Build the Person object from the Person---------------
            //----------class and set the available Person's Object fields...!         
            //----------------------------------------------------------------


            Person person = new Person();

            person.Age = 20;

            person.FullName = "Ali Molaie";

            person.Salary = 15000;

            person.ShowInfo();

            System.Console.WriteLine();

            //---------------------------------------------------------------------
            //----------The function SomeFunction is a general function------------
            //----------that is at the disposal of the object and can be used...!--
            //---------------------------------------------------------------------

            person.SomeFunction();

            //----------------------------------------------------------------------
            //----------Use the power function that was made------------------------
            //----------for the Person class.---------------------------------------
            //----------------------------------------------------------------------

            System.Console.WriteLine
                ($"The power of two numbers 12 and 3 gets: {Person.FunctionPower(12, 3)}");



            System.Console.WriteLine();
            System.Console.ReadLine();


        }
    }
}
