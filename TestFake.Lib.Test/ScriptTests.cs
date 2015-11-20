using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestFake.Lib.Test
{
    public class ScriptTests
    {
        //[Test]
        //public void CheckIsAdminShouldXYZIfAdmin()
        //{
        //    var s = new Script(true);
        //    s.CheckIsAdmin();
        //}


        //[Test]
        //public void CheckIsAdminShouldABCWhenNotAdmin()
        //{
        //    var s = new Script(false);
        //    s.CheckIsAdmin();
        //}

        [Test]
        public void CheckIsTrue()
        {
            var s = new Script(true);
            Assert.IsTrue(s.IsTrue());
        }
    }
}
