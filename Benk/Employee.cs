using System;
using System.Collections.Generic;
using System.Text;

namespace Benk
{
    class Employee
	{
		
		
			private string name;
			private int efficiency;
			private int salary;

			public Employee(string name, int salary)
			{
				this.name = name;
				this.salary = salary;
				this.efficiency = 0;
			}

			public string GetName()
			{
				return this.name;
			}

			public int GetSalary()
			{
				return this.salary;
			}

			public int GetEfficiency()
			{
				Random random = new Random();
				this.efficiency = salary * random.Next(0, 4);

				return this.efficiency;
			}



			public override string ToString()
			{
				return $"nazwisko: {name}, zarobki: {salary}";
			}
		}
	}


