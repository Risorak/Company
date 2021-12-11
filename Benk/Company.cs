using System;
using System.Collections.Generic;
using System.Text;

namespace Benk
{
    class Company
	{
		private List<Employee> employees;
		private string name;
		private int resource;

		public Company(string name)
		{
			this.name = name;
			this.employees = new List<Employee>();
			this.resource = 0;
		}

		public void AddEmployee(Employee employee)
		{
			this.employees.Add(employee);
		}

		public void RemoveEmployee(Employee employee)
		{
			this.employees.Remove(employee);
		}

		public void MonthSalary()
		{
			foreach (Employee emp in this.employees)
			{
				this.resource += emp.GetEfficiency();
			}
		}

		public void SumSalaries()
		{

			int sum = 0;

			foreach (Employee emp in this.employees)
			{
				sum += emp.GetSalary();
			}

			this.resource -= sum;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();

			foreach (Employee em in this.employees)
			{
				stringBuilder.Append(em.GetName());
				stringBuilder.Append("\n");
			}

			stringBuilder.Append("zasoby firmy: " + this.resource);

			return $"firma: {name}, pracownicy:\n{stringBuilder.ToString()}";

		}
	}
}

