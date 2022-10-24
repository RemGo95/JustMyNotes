using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pmost;
using Prototy;

 class Program
{
        static void Main(string[] args)
        {
            Client client = new Client();

            ActiveRoboProject Robot;
            // The client code should be able to work with any pre-configured
            // abstraction-implementation combination.
            Robot = new Robot(new ConcreteImplementationA());
            client.ClientCode(Robot);
            
            Console.WriteLine();
            
            Robot = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(Robot);
        }
}