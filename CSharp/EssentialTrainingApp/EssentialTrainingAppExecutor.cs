using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;
namespace EssentialTrainingApp
{
    class EssentialTrainingAppExecutor
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The Program started");
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Cheese");
            Words.Add("Milk");
            CrazyMathProblem();
        }
        private static void ReadTextFile()
        {
            try
            {
                using (var sr = new StreamReader(@"C:\temp\test1.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.Write(contents);
                }

            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                logger.Error("The directory was not found." + ex.Message);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                logger.Error("Couldn't find the file" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("the finally runs");
            }
        }
        private static int CrazyMathProblem()
        {
            var income = 1000;
            for (var i = 10; i > 0; i--)
            {
                income = income = (income / i);
            }
            return income;
        }
    }
}
