using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ExceptionDemo
{
    class ExceptionDemoExecutor
    {
        static void Main(string[] args)
        {
            StreamReader DataFromFile = null;
            try
            {
                DataFromFile = new StreamReader(@"C:\Rainbow\Data.txt");
                Console.WriteLine(DataFromFile.ReadToEnd());

            }
            catch (FileNotFoundException exception)
            {
                //Log the details to DB
                Console.WriteLine("Please check if the file {0} exists", exception.FileName);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                if (DataFromFile != null)
                {
                    DataFromFile.Close();
                }
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
