using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace CSharpPractice
{
    public static class LinqMethods
    {
        public static void CountAndGroupExtensions()
        {
            string[] arr = { "aaa.txt", "aaa.txt", "bbb.TXT", "xyz.abc.pdf", "aaaa.PDF",
                             "abc.xml", "ccc.txt", "zzz.txt" };

            var egrp = arr.GroupBy(x => x, (ext, extCnt) => new
            {
                Extension = ext,
                Count = extCnt.Count()
            });

            foreach (var v in egrp)
            {
                Console.WriteLine("{0} File(s) with {1} Extension ",
                                    v.Count, v.Extension);
            }

        }

        public static void CheckFileSize()
        {
            try
            {
                string[] values = { "One", "Two", "Three", "Four", "Five" };

                foreach (var val in values)
                {
                    Console.WriteLine("Answer: {0}", val);
                }

                var checkEnum = values.GetEnumerator();
                while (checkEnum.MoveNext())
                {
                    Console.WriteLine("Enum Answer: {0}", checkEnum.Current);
                }

            }
            catch (Exception ex)
            {

            }
        }

        public static void PrintParallelOdd()
        {
            IEnumerable<int> evalue = ParallelEnumerable.Range(2, 2000).Where(x => x % 2 != 0).Select(x => x);

            foreach (var value in evalue)
            {
                Console.WriteLine("Value: {0}", value);
            }
        }

        public static void getAssemblies()
        {
            //Type type = typeof(customers);
            //Console.WriteLine("Name: {0}", type.Name);
            //Console.WriteLine("", type.FullName);
            //Console.WriteLine("", type.Assembly);
            //Console.WriteLine("", type.Namespace);

            DataTable dt = new DataTable("Student");
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("MobileNo", typeof(string));
            dt.Columns.Add("datetime", typeof(DateTime));
            //Data  
            dt.Rows.Add("Manish", "Malhotra", "Hyderabad", "0000000000", new DateTime(2021, 08, 9));
            dt.Rows.Add("Manish", "Malhotra", "Hyderabad", "1000000000", new DateTime(2021, 08, 10));
            dt.Rows.Add("Namit", "Malhotra", "Pune", "1222222222", new DateTime(2021, 08, 10));
            dt.Rows.Add("Abhinav", "Malhotra", "Bhagalpur", "3333333333", new DateTime(2021, 08, 10));

            IEnumerable<DataRow> sequence = dt.AsEnumerable();


            foreach (var value in sequence)
            {
                var checkDuplicate = sequence.Where(x => x.ItemArray[0] == value.ItemArray[0] && x.ItemArray[1] == value.ItemArray[1]).OrderBy(x => x.ItemArray[4]).Take(1);
            }


            //foreach(var value in sequence)
            //{
            var replacestring = sequence.Select(x => x.ItemArray[0].ToString().Replace("Manish", "1"));
            //}

            List<student> students = new List<student>()
            {
                new student { FirstName = "Manish",
                    LastName = "Mathur",
                    Address = "Hyderabad",
                    MobileNo = "1000000000",
                    datetime = new DateTime(2021, 08, 10)},
                new student{FirstName = "Manish",
                    LastName = "Mathur",
                    Address = "Hyderabad",
                    MobileNo = "2000000000",
                    datetime = new DateTime(2021,08,09)},
                new student{FirstName = "Manish",
                    LastName = "Mathur",
                    Address = "Hyderabad",
                    MobileNo = "3000000000",
                    datetime = new DateTime(2021,08,08)},
                new student{FirstName = "Namit",
                    LastName = "Malhotra",
                    Address = "Pune",
                    MobileNo = "1222222222",
                    datetime = new DateTime(2021,08,10)},
                new student{FirstName = "Abhinav",
                    LastName = "Singh",
                    Address = "Bhagalpur",
                    MobileNo = "3333333333",
                    datetime = new DateTime(2021,08,10)},
            };

            //IEnumerable<student> finalLis;

            //foreach(var value in students)
            //{
            //    var checkDuplicate = students.Where(x => x.FirstName == value.FirstName && x.LastName == value.LastName).OrderBy(x=>x.datetime).Take(1);
            //}

            foreach (var value in sequence)
            {
                var checkDuplicate = sequence.Where(x => x.ItemArray[0] == value.ItemArray[0] && x.ItemArray[1] == value.ItemArray[1]).OrderBy(x => x.ItemArray[4]).Take(1);
            }



            //var noDistinct = sequence.GroupBy(x => x.ItemArray).All(x => x.Count() == 1);

            //var abc = sequence.GroupBy(x => x.ItemArray[0]).Select(g => g.First());

            //abc.AsEnumerable().GroupBy(Function(x) convert.ToString(x.Field(of object)("Moile No."))).SelectMany(function(gp) gp.ToArray().Take(1))
            //var xyz = abc.AsEnumerable().GroupBy(x => (x).ToString()).SelectMany(x => x.ToArray().Take(1));

        }

        public static void GroupBy()
        {
            var users = new List<User>()
        {
        new User { Name = "John Doe", Age = 42, HomeCountry = "USA" },
        new User { Name = "Jane Doe", Age = 38, HomeCountry = "USA" },
        new User { Name = "Joe Doe", Age = 19, HomeCountry = "Germany" },
        new User { Name = "Jenna Doe", Age = 19, HomeCountry = "Germany" },
        new User { Name = "James Doe", Age = 8, HomeCountry = "USA" },
        };

            var groupbycountry = users.GroupBy(x => x.HomeCountry);
            foreach (var group in groupbycountry)
            {
                Console.WriteLine("Users from " + group.Key + ":");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name);
            }
        }

    }

    public class student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public DateTime datetime { get; set; }
    }

    public class customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Contact { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeCountry { get; set; }
    }
}
