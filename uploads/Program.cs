using System;

namespace payroll_management_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            string empName, reply;
            int noOfDaysWork = 0, overtimeHours = 0, leaves = 0, n = 0;
            double dailyRate = 0, overtimePerHourRate = 0, grossPay = 0, overTimePay = 0, 
            lunchAllowance = 0, entertainmentAllowance = 0,uniformAllowance = 0, 
            otherAllowance = 0, totalAllowance = 0, healthInsurance = 0, lifeInsurance = 0, 
            otherDeduction = 0, totalDeduction = 0, netPay = 0;

            do {
                Console.Clear();
                Console.Write("Payroll system");
                Console.Write("\n\n");
                Console.Write("Enter Employee's Name: ");
                empName = Console.ReadLine();
                Console.Write("Enter Number of Day's Work: ");
                noOfDaysWork = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Daily Salary Rate: ");
                dailyRate = Convert.ToDouble(Console.ReadLine());
                grossPay = dailyRate * noOfDaysWork;
                Console.Write("\n\n");
                Console.WriteLine("Gross Pay: Rs {0:0.00}", grossPay);
                Console.Write("\n\n");
                Console.Write("==========Overtime==========");
                Console.Write("\n\n");
                Console.Write("Enter Per Hour Rate: ");
                overtimePerHourRate = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Number of Hour's Work: ");
                overtimeHours = Convert.ToInt32(Console.ReadLine());
                overTimePay = overtimeHours * overtimePerHourRate;
                Console.Write("\n\n");
                Console.WriteLine("Overtime Pay: Rs {0:0.00}", overTimePay);
                Console.Write("\n\n");
                Console.Write("==========Allowances==========");
                Console.Write("\n\n");
                Console.Write("Enter Lunch Allowance: ");
                lunchAllowance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Entertainment Allowance: ");
                entertainmentAllowance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Uniform Allowance: ");
                uniformAllowance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Other Allowance: ");
                otherAllowance = Convert.ToDouble(Console.ReadLine());
                totalAllowance = lunchAllowance + entertainmentAllowance + uniformAllowance + otherAllowance;
                Console.Write("\n\n");
                Console.Write("Total Allowance: Rs {0:0.00}", totalAllowance);
                Console.Write("\n\n");
                Console.Write("==========Deduction==========");
                Console.Write("\n\n");
                Console.Write("Enter Health Insurance Amount: ");
                healthInsurance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Life Insurance Amount: ");
                lifeInsurance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Other Deduction's amount: ");
                otherDeduction = Convert.ToDouble(Console.ReadLine());
                totalDeduction = healthInsurance + lifeInsurance + otherDeduction;
                netPay = grossPay + totalAllowance - totalDeduction;
                Console.Write("\n\n");
                Console.Write("Total Deduction: Rs {0:0.00}", totalDeduction);
                Console.Write("\n\n");
                Console.Write("========== Payslip ==========");
                Console.Write("\n\n");
                Console.WriteLine("Employee's Name : {0}.", empName);
                Console.WriteLine("Gross Pay: Rs {0:0.00}.", grossPay);
                Console.WriteLine("Overtime Pay: Rs {0:0.00}.", overTimePay);
                Console.WriteLine("Total Allowance: Rs {0:0.00}.", totalAllowance);
                Console.WriteLine("Total Deductions: Rs {0:0.00}.", totalDeduction);
                Console.Write("\n\n");
                Console.WriteLine("Net Pay: Rs {0:0.00}.", netPay);
                Console.Write("\n\n");
                Console.Write("Do you want to continue? Y/N: ");
                reply = Console.ReadLine();
                if(reply == "y" || reply == "Y") {
                    continue;
                }
                else if(reply == "n" || reply == "N") {
                    Console.Write("Thankyou for using this software");
                    Console.Write("\n\n");
                    break;
                }

            } while(n == 0) ;
            Console.ReadLine();
        }
    }
}
