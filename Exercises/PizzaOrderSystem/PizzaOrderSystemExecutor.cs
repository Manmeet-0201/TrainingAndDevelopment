using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaOrderSystem.Component;
using PizzaOrderSystem.ConcreteComponent;
using PizzaOrderSystem.ConcreteDecorator;

namespace PizzaOrderSystem
{
    class PizzaOrderSystemExecutor
    {
        
        static void Main(string[] args)
        {
            string PizzaTypesDataPath = @"C:\Users\ss186092\source\repos\TrainingAndDevelopment\Exercises\PizzaOrderSystem\Data\PizzaTypes.txt";
            string PizzaToppingsDataPath = @"C:\Users\ss186092\source\repos\TrainingAndDevelopment\Exercises\PizzaOrderSystem\Data\PizzaToppings.txt";
            Console.WriteLine("Hello Welcome To Rajesh Pizza Hut");
            List<Pizza> OrderedPizzas = new List<Pizza>();
            List<String> PizzaTypes = new List<String>();
            List<String> PizzaToppings = new List<String>();
            PizzaTypes=AddPizzaTypes(PizzaTypesDataPath);
            PizzaToppings=AddPizzaToppings(PizzaToppingsDataPath);
            string PizzaOption;
            do
            {
                Console.WriteLine("Do You Wanna order some pizza");
                Console.WriteLine("Below is the list of pizzas");
                Console.WriteLine("Enter any Pizza name from given below options");
               foreach(string pizzatype in PizzaTypes){
                    Console.WriteLine(pizzatype);
                }
                Console.WriteLine("Enter any other option to exit");
                PizzaOption = Console.ReadLine();
                Pizza OrderedPizza=null;
                switch (PizzaOption)
                {
                    case "ChickenPizza":
                        OrderedPizza = new ChickenPizza();
                        break;
                    case "FlatBreadPizza":
                        OrderedPizza = new FlatBreadPizza();
                        break;
                    case "PepperoniCheesePizza":
                        OrderedPizza = new PepperoniCheesePizza();
                        break;
                    default:
                        break;
                }
                //Console.WriteLine(PizzaOption);
                if (!Object.ReferenceEquals(OrderedPizza,null))
                {
                    string PizzaToppingsOption;
                    do
                    {
                        Console.WriteLine("Do You wanna add Some Toppings on it?");
                        Console.WriteLine("Here are the list of Some Toppings");
                        Console.WriteLine("Enter any Pizza Toppings from given below options");
                        foreach (string pizzatopping in PizzaToppings)
                        {
                            Console.WriteLine(pizzatopping);
                        }
                        Console.WriteLine("Enter any other option to exit");
                   
                        PizzaToppingsOption = Console.ReadLine();
                        switch (PizzaToppingsOption)
                        {
                            case "Onion":
                                OrderedPizza = new Onion(OrderedPizza);
                                break;
                            case "Mushroom":
                                OrderedPizza = new Mushroom(OrderedPizza);
                                break;
                            case "BlackOlive":
                                OrderedPizza = new BlackOlive(OrderedPizza);
                                break;
                            default:
                                break;
                        }
                        //Console.WriteLine(PizzaToppings.Contains(PizzaToppingsOption));
                    } while (PizzaToppings.Contains(PizzaToppingsOption));
                    OrderedPizzas.Add(OrderedPizza);
                }
            } while (PizzaTypes.Contains(PizzaOption));
            foreach(Pizza pizza in OrderedPizzas)
            {
                Console.WriteLine(pizza.GetDescription());
                Console.WriteLine(pizza.GetPizzaPrice());
            }
            Console.ReadKey();
        }
        public static List<String> AddPizzaTypes(string path)
        {
            List<String> pizzaTypes = new List<String>();
            using (var fs= new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(var sr=new StreamReader(fs,Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        pizzaTypes.Add(sr.ReadLine());
                    }
                }
            }
            return pizzaTypes;
        }
        public static List<String> AddPizzaToppings(string path)
        {
            List<String> pizzaToppings = new List<String>();
            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        pizzaToppings.Add(sr.ReadLine());
                    }
                 }
            }
            return pizzaToppings;
        }
    }
}
