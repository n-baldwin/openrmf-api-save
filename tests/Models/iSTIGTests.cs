using Xunit;
using openrmf_save_api.Models;
using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> Added/Changed tests for Models and Data

namespace tests.Models
{
    public class iSTIGTests
    {
        [Fact]
        public void Test_NewiSTIGIsValid()
        {
            iSTIG istig = new iSTIG();

            // Testing
            Assert.False(istig == null);
        }
    
        [Fact]
        public void Test_iSTIGWithDataIsValid()
        {
            iSTIG istig = new iSTIG();

            istig.STIG_INFO = new STIG_INFO();
            
            List<VULN> vulns = new List<VULN>();
            vulns.Add(new VULN());
            vulns.Add(new VULN());
            istig.VULN = vulns;

            // Testing
            Assert.False(istig.STIG_INFO == null);
            Assert.False(istig.VULN == null);
            Assert.False(istig.VULN[0] == null);
            Assert.False(istig.VULN[1] == null);
        }
    }
}
