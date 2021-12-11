using System;

namespace Benk
{
    class Program
	{
      
 
	//Zdefiniuj klasę Pracownik.Następnie zdefiniuj klasę Firma, która
	//by przechowywała w tablicy spis wszystkich pracowników (możesz założyć,
	//że liczba pracowników nie przekracza 100).
	//
	//Zdefiniuj metody dodawania
	//nowych pracowników do firmy oraz wypisywania aktualnego spisu pracowników.

		
			static void Main(string[] args)
			{
				Employee em1 = new Employee("świder", 3400);
				Employee em2 = new Employee("gąbka", 4100);
				Employee em3 = new Employee("miszcz", 2900);
				Employee em4 = new Employee("maliniak", 3300);

				Company company = new Company("Jajax");
				company.AddEmployee(em1);
				company.AddEmployee(em3);
				company.AddEmployee(em4);

				Console.WriteLine(company);

				for (int i = 0; i < 24; i++)
				{
					company.MonthSalary(); //zarabia na pracownikach
					company.SumSalaries(); //wypłaca pracownikom pensje
				}


				Console.WriteLine(company);




			}
		}
	}


