using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnStructAndEnumeration_1
{
    public enum Vacancies
    {
        Boss,
        Manager,
        Salesman,
        Clerk,
        Сourier,
        Floorswasher
    };
    public struct Workers
    {
        public int[] _dateOfEmployment;
        public string Worker { get; set; }
        public double Salary { get; set; }
        public Vacancies _Vacancies { get; set; }
        public void InfoOnWorker()
        {
            Console.WriteLine("ФИО: " + Worker + "\n" +
                "Занимаемая должность: " + _Vacancies + "\n" +
                "Зароботная плата: " + Salary + "\n" +
                "Дата принятия на работу: " + _dateOfEmployment[0] + "." + _dateOfEmployment[1] + "." + _dateOfEmployment[2] + "\n" +
                "____________________________________________________");
        }
    }
}
