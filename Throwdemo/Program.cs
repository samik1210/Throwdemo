﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Throwdemo
{
    class Student
    {
        static void Main(string[] args)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);


                static void Method1()
                {
                    try
                    {
                        Method2();
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }

                static void Method2()
                {
                    string str = null;
                    try
                    {
                        Console.WriteLine(str[0]);
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
    }
}