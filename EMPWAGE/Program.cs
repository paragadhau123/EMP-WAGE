using System;

namespace EMPWAGE
{
    class Program
    {
		public static  int IS_FULL_TIME = 1;
		public static  int IS_PART_TIME = 2;
		private  String Company;
        private  int empRatePerHour;
		private  int numOfWorkingDays;
		private  int maxHoursPerMonth;

		Program(String Company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
		{

			this.Company = Company;
			this.empRatePerHour = empRatePerHour;
			this.numOfWorkingDays = numOfWorkingDays;
			this.maxHoursPerMonth = maxHoursPerMonth;

		}

		private int computeEmpWage()
		{

			int empHrs = 0;
			int empWage = 0;
			int TotalEmpWage = 0;
			int TotalWorkingHours = 0;
			int day = 0;

			while (day < numOfWorkingDays || TotalWorkingHours <= maxHoursPerMonth)

			{
				Random random = new Random();

				int empCheck = random.Next(2);
				day++;
				switch ((int)empCheck)
				{
					case 1:
						empHrs = 8;
						break;
					case 2:
						empHrs = 4;
						break;
					default:
						empHrs = 0;
						break;

				}
				TotalWorkingHours += empHrs;
				empWage = empHrs * empRatePerHour;
				TotalEmpWage += empWage;
			}
			//System.out.println("Total Emp wage :"+ TotalEmpWage);
			return TotalEmpWage;

		}
		 static void Main(String[] args)
		{
			Program dMart = new Program("Dmart", 20, 20, 100);
			Program Realiance = new Program("Realiance", 30, 20, 80);
			Console.WriteLine("Total Emp wage of Realiance : " + Realiance.computeEmpWage());
			Console.WriteLine("Total Emp wage of dMart : " + dMart.computeEmpWage());
		}


	}
}
