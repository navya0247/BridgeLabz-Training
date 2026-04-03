using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace BridgeLabzTraining.methods.level2
{
    internal class VoteChecker
    {
        // Method to check voting eligibility
        public bool CanStudentVote(int age)
        {
            if (age <= 0)
            {
                return false;
            }
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


            public static void Main(string[] args)
            {

            //create object because method is non-static
            VoteChecker checker = new VoteChecker();

                // Take input for 10 students
                int[] age = new int[10];
                for (int i = 0; i < age.Length; i++)
                {
                    age[i] = int.Parse(Console.ReadLine());
                }

                // Check voting eligibility
                for (int i = 0; i < age.Length; i++)
                {
                bool result = checker.CanStudentVote(age[i]);
                    if (age[i] < 0)
                    {
                        Console.WriteLine("Invalid age");

                    }
               
                else if (result)
                {
                    Console.WriteLine("Student can Vote");
                }
                else
                {
                    Console.WriteLine("Student cannot Vote");

                }
                }

            }
        }
    }











