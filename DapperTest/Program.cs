using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Student> ss = new List<Student>();
                ss = SqlHelper.QuerySQL<Student>("select * from student").ToList<Student>();
                Console.WriteLine(ss);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
