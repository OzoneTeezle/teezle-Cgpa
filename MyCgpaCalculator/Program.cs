using System;

namespace MyCgpaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, grade;
            double m, n, o, p, q, r, s; 
            double MAT, GST, BIO, PHY, CHM, BCH, MCB, total, cgpa;
            int matric, gradePoint;

            Console.WriteLine("Enter your first namee:");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your Matric number:");
            matric = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Grades: A, B, C, D, E, F");
          
            Console.WriteLine("Enter your MAT101 grade:");
            grade = Console.ReadLine().ToUpper();
            m = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your GST101 grade point:");
            grade = Console.ReadLine().ToUpper();
            n = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your BIO101 grade point:");
            grade = Console.ReadLine().ToUpper();
            o = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your PHY101 grade point:");
            grade = Console.ReadLine().ToUpper();
            p = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your CHM101 grade point:");
            grade = Console.ReadLine().ToUpper();
            q = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your BCH103 grade point:");
            grade = Console.ReadLine().ToUpper();
            r = gradePoint = GetGradePoint(grade);

            Console.WriteLine("Enter your MCB111 grade point:");
            grade = Console.ReadLine().ToUpper();
            s = gradePoint = GetGradePoint(grade);

            static int GetGradePoint(string grade)
            {
                switch (grade)
                {
                    case "A":
                        return 5;
                    case "B":
                        return 4;
                    case "C":
                        return 3;
                    case "D":
                        return 2;
                    case "E":
                        return 1;
                    case "F":
                        return 0;
                    default:
                        return -1;
                }
            }

            
            MAT = m * 3;
            GST = n * 2;
            BIO = o * 3;
            PHY = p * 3;
            CHM = q * 3;
            BCH = r * 2;
            MCB = s * 1;

            total = MAT + GST + BIO + PHY + CHM + BCH + MCB;

            cgpa = total / 17;

            Console.WriteLine("Dear " + firstName + " " + lastName);
            Console.WriteLine("with matric number: " + matric);

            if (cgpa >= 4.50 && cgpa <= 5.0)
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You are a first class student");
            }
            else if (cgpa >= 3.50 && cgpa <= 4.49)
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You are in the second class upper division");
            }
            else if (cgpa >= 2.50 && cgpa <= 3.49)
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You are in the second class lower division");
            }
            else if (cgpa >= 1.50 && cgpa <= 2.49)
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You are a third class student");
            }
            else if (cgpa >= 1.00 && cgpa <= 1.49)
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You are in the pass level");
            }
            else
            {
                Console.WriteLine("Your CGPA is: " + cgpa + ", You failed");
            }

            Console.ReadKey();
              







        }
    }
}
