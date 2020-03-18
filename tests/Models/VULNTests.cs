using Xunit;
using openrmf_save_api.Models;
using System;

namespace tests.Models
{
    public class VULNTests
    {
        [Fact]
        public void Test_NewVULNIsValid()
        {
<<<<<<< HEAD
            VULN v = new VULN();
            Assert.True(v != null);
=======
            VULN vuln = new VULN();

            // Testing
            Assert.False(vuln == null);
>>>>>>> Added/Changed tests for Models and Data
        }
    
        [Fact]
        public void Test_VULNWithDataIsValid()
        {
<<<<<<< HEAD
            VULN v = new VULN();
            v.STATUS = "my status";
            v.FINDING_DETAILS = "my status";
            v.COMMENTS = "my status";
            v.SEVERITY_OVERRIDE = "my status";
            v.SEVERITY_JUSTIFICATION = "my status";

            // test things out
            Assert.True(v != null);
            Assert.True(v.STIG_DATA != null);
            Assert.True(v.STIG_DATA.Count == 0);
            Assert.True(!string.IsNullOrEmpty(v.STATUS));
            Assert.True(!string.IsNullOrEmpty(v.FINDING_DETAILS));
            Assert.True(!string.IsNullOrEmpty(v.COMMENTS));
            Assert.True(!string.IsNullOrEmpty(v.SEVERITY_OVERRIDE));
            Assert.True(!string.IsNullOrEmpty(v.SEVERITY_JUSTIFICATION));
=======
            VULN vuln = new VULN();
            
            vuln.STIG_DATA.Add(new STIG_DATA());
            vuln.STIG_DATA.Add(new STIG_DATA());

            vuln.STATUS = "Alive";
            vuln.FINDING_DETAILS = "Living looking";
            vuln.COMMENTS = "Witty comment";
            vuln.SEVERITY_OVERRIDE = "No idea";
            vuln.SEVERITY_JUSTIFICATION = "Justified?";

            // Testing
            Assert.True(vuln.STIG_DATA.Count == 2);
            Assert.True(vuln.STATUS == "Alive");
            Assert.True(vuln.FINDING_DETAILS == "Living looking");
            Assert.True(vuln.COMMENTS == "Witty comment");
            Assert.True(vuln.SEVERITY_OVERRIDE == "No idea");
            Assert.True(vuln.SEVERITY_JUSTIFICATION == "Justified?");
>>>>>>> Added/Changed tests for Models and Data
        }
    }
}
