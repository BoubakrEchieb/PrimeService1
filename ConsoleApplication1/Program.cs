using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            foreach (var item in data.GetData().FirstOrDefault())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadKey();
        }
        public class Data : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }
            public IEnumerable<Person[]> GetData()
            {
                yield return new Person[]
                {
                    new Person {Name = "Tribbiani", Age = 56},
                    new Person {Name = "Gotti", Age = 16},
                    new Person {Name = "Sopranos", Age = 15},
                    new Person {Name = "Corleone", Age = 27}
                };

                yield return new Person[]
                {
                    new Person {Name = "Mancini", Age = 79},
                    new Person {Name = "Vivaldi", Age = 16},
                    new Person {Name = "Serpico", Age = 19},
                    new Person {Name = "Salieri", Age = 20}
                };
            }
            public class Person
            {
                public string Name { get; set; }
                public int Age { get; set; }
            }
        }
    }
}
