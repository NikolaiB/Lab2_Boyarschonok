namespace ENUM
{
    internal class Program
    {
        enum DaysWeek
        {
            Monday = 1,
            Tuesday,
            Wenesday,
            Thursday,
            Friday,
            Saturday,
            Sunday


        }
        static void Main(string[] args)
        { 
            
        string stringnumday = Console.ReadLine();
            DaysWeek numday = (DaysWeek)Enum.Parse(typeof(DaysWeek), stringnumday);
            //int numday = Convert.ToInt32(stringnumday);
            switch (numday)
            {
                case DaysWeek.Monday:
                    break;
                case DaysWeek.Tuesday:
                    break;
                case DaysWeek.Wenesday:
                    break;
                case DaysWeek.Thursday:
                    break;
                case DaysWeek.Friday:
                    break;
                case DaysWeek.Saturday:
                    break;
                case DaysWeek.Sunday:
                    break;
                default:
                    Console.WriteLine("Неверное число");
                    break;
            }
            Console.WriteLine(numday);


            


        }

             

        

        //static void DaysWeek GetNameDay(int numday)
        // {
        //   if (numday.)


        //  }
    
    }
    

}