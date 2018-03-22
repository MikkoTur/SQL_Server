using System;
using System.Collections.Generic;
using System.Text;
using PersonDB.Model;

namespace PersonDB.Repositories
{
    class PersonRepository
    {
        private static Tuntitehtava2Context _context = new Tuntitehtava2Context();

        public static void Create(Table1Person person)
        {
            _context.Table1Person.Add(person);
            _context.SaveChanges();
        }
    }
}
