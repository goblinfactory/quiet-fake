using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFake.Lib
{
    public class Script
    {
        private readonly bool _isAdmin;

        public Script(bool isAdmin)
        {
            _isAdmin = isAdmin;
        }

        public bool IsTrue()
        {
            return _isAdmin;
        }

        public void CheckIsAdmin()
        {
            if (!_isAdmin)
            {
                Console.WriteLine("You must be administrator to run this script!");
                Environment.Exit(5000);
            }
        }
    }
}
