using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnStructAndEnumeration_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Введите численность сотрудников: ");
            int workersNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("\n****************************************\n");
            Workers[] workers = new Workers[workersNumber];

            Random random = new Random();

            #region инициализация полей
            char[] oneWorker;
            int countSymbolInWorker;

            int calendarNumberD=0, calendarNumberM = 0, ddmmyy =3;

            for (int i = 0; i < workersNumber; i++)
            {
                countSymbolInWorker = random.Next(15, 20);
                oneWorker = new char[countSymbolInWorker];

                for (int j = 0; j < countSymbolInWorker; j++)
                {
                    oneWorker[j] = Convert.ToChar(random.Next('а', 'я'));

                }

                oneWorker[0] = char.ToUpper(oneWorker[0]);
                oneWorker[6] = ' ';
                oneWorker[7] = char.ToUpper(oneWorker[0]);

                workers[i].Worker=new string (oneWorker);

                if (i == 0)
                {
                    workers[i]._Vacancies = Vacancies.Boss;
                }
                else
                {
                    workers[i]._Vacancies = (Vacancies)random.Next(1, 6);
                }

                if (workers[i]._Vacancies==(Vacancies)0)
                {
                    workers[i].Salary = 10000000;
                }
             
                else
                {
                    workers[i].Salary = random.Next(10000, maxValue: 100000);
                }

                        calendarNumberD = random.Next(1, 31);
                        calendarNumberM = random.Next(1, 12);

                    workers[i]._dateOfEmployment= new int[] { calendarNumberD, calendarNumberM, 18};
            }
#endregion

            for (int i = 1; i < workersNumber; i++)
            {
                workers[i].InfoOnWorker();
            }

            Console.WriteLine("Нажмите Enter");
            Console.Read();
            Console.Read();

            Array.Sort(workers, delegate (Workers workers1, Workers workers2)
            {
                return workers1.Worker.CompareTo(workers2.Worker);
            });

            #region Вывод сотрудников нанятых после Директора 

            Console.WriteLine("\nВывод сотрудников нанятых после Директора \n");
            for (int i = 1; i < workersNumber; i++)
            {
                for (int j = 0; j < ddmmyy; j++)
                {
                    if((workers[0]._dateOfEmployment[1]< workers[i]._dateOfEmployment[1]) || 
                        ((workers[0]._dateOfEmployment[1] == workers[i]._dateOfEmployment[1]) 
                        && (workers[0]._dateOfEmployment[0] < workers[i]._dateOfEmployment[0])))
                    {
                        workers[i].InfoOnWorker();
                        break;
                    }
                }
            }
            #endregion

            Console.WriteLine("Нажмите Enter");
            Console.Read();
            Console.Read();

            #region Вывод списка менеджеров зарплата которых больше зарплаты всех клерков 

            Console.WriteLine("\nВывод списка менеджеров зарплата которых больше зарплаты всех клерков \n");
            for (int i = 1; i < workersNumber; i++)
            {
                if (workers[i]._Vacancies == (Vacancies)1)
                {
                    for (int j = 1; j < workersNumber; j++)
                    {
                        if(workers[i].Salary>workers[j].Salary && workers[j]._Vacancies == (Vacancies)3)
                        {
                            workers[i].InfoOnWorker();
                            break;
                        }
                    }
                }
            }

            #endregion

            Console.Read();
        }

    }
}
