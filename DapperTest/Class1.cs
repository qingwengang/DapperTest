using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi1.Respositories;

namespace Test
{
    public class Class1
    {
        static void main(String[] args)
        {
            List<Student> ss = new List<Student>();
            ss = SqlHelper.QuerySQL<Student>("select * from student").ToList<Student>();
            Console.WriteLine(ss);
        }
    }
}
