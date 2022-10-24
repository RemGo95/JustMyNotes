using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Prototy
{
    public class ActiveRoboProject
    {
        public string Type;
        public DateTime ActualTime;
        public string Name;
        public string ShortInfo;

        public ActiveRoboProject ShallowCopy()
        {
            return (ActiveRoboProject) this.MemberwiseClone();
        }

        public ActiveRoboProject DeepCopy()
        {
            ActiveRoboProject clone = (ActiveRoboProject) this.MemberwiseClone();
            ActiveRoboProject.ShortInfo = new IdInfo(IdInfo._IPADDRESS);
            ActiveRoboProject.Name = String.Copy(Name);
            return clone;
        }
    }

    public class ShortInfo
    {
        public int IdNumber;

        public ShortInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ActiveRoboProject r01 = new ActiveRoboProject();
            ActiveRoboProject r02 = new ActiveRoboProject();
            ActiveRoboProject r03 = new ActiveRoboProject();

            r01.Name = "Robotic Arm";
            r01.ActualTime = Convert.ToDateTime(DateTime.Now);
            r01.ShortInfo = "First robot 3DOF, 3 motors and servo conctrolers, optic encoders, STM32";
            r01.Type = new IdInfo(001);

            ActiveRoboProject r01 = r01.ShallowCopy();

            ActiveRoboProject r02 = p1.DeepCopy();


            r02.ActualTime = DateTime.Now;
            r02.Name = "Mobile with Solar Panels";
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p01);
        }

        public static void DisplayValues(Person r)
        {
            Console.WriteLine("      Name: {0:s}, ShortInfo: {1:d}, ActualTime: {2:MM/dd/yy}",
                r.Name, r.ShortInfo, r.ActualTime);
            Console.WriteLine("      ID#: {0:d}", r.ShortInfo.IdNumber);
        }
    }
}