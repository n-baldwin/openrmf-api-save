using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace openstig_save_api.Models
{
    [Serializable]
    public class Artifact
    {
        public Artifact () {
            id= Guid.NewGuid();
        }

        public DateTime created { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string rawChecklist { get; set; }
        
        [BsonId]
        // standard BSonId generated by MongoDb
        public ObjectId InternalId { get; set; }

        public Guid id { get; set; }
        public STIGtype type { get; set; }

        [BsonDateTimeOptions]
        // attribute to gain control on datetime serialization
        public DateTime? updatedOn { get; set; }

        public Guid createdBy { get; set; }
        public Guid? updatedBy { get; set; }
    }

    public enum STIGtype{
       
        Other = 0, // those not listed here, those you need via PKI, etc.

        /* Development Technologies */
        ApplicationSecurityAndDevelopment = 10,
        OracleJRE8UNIX = 101,
        OracleJRE8Windows = 102,
        MSDotNet4 = 105,

        /* ANTI VIRUS */
        McAfeeAntiVirusLocalClient = 201,
        McAfeeAntiVirusManagedClient = 202,
        McAfeeAntiVirusEnterpriseLinuxLocalClient = 203,
        McAfeeAntiVirusEnterpriseLinuxManagedClient = 204,
        McAfeeAntiVirusEnterpriseLinux = 200,
        WindowsDefender = 205,

        /* Application Servers */
        ColdFusion = 301,
        BromiumSecurePlatform4 = 305,
        IBMMQAppliancev9AS = 310,
        IBMMQAppliancev9NDM = 311,
        IBMMQAppliancev9 = 312,
        IBMWebSphere = 315,
        MSExchange2010ClientAccess = 320,
        MSExchange2010Edge = 322,
        MSExchange2010Hub = 324,
        MSExchange2010Mailbox = 326,
        MSExchange2013ClientAccess = 330,
        MSExchange2013Edge = 332,
        MSExchange2013Mailbox = 336,
        MSExchange2016EdgeTransportServer = 340,
        MSExchange2016MailboxServer = 342,
        MSSharePoint2010 = 350,
        MSSharePoint2013 = 355,
        OracleWebLogic12c = 360,
        RHJBossEAP63 = 370,
        Tanium65 = 380,
        Tanium70 = 385,

        /* Browsers */
        Chrome = 400,
        IE10 = 405,
        IE11 = 410,
        Firefox = 415,

        /* Databases */

        SQLServer2012Database = 500,
        SQLServer2012Instance = 502,
        SQLServer2014Database = 505,
        SQLServer2014Instance = 507,
        SQLServer2016Database = 510,
        SQLServer2016Instance = 512,
        MongoDBEnterpriseAdvanced3 = 515,
        Oracle112g = 520,
        Oracle11g = 525,
        Oracle12c = 530,
        PostgreSQL = 535,
        EDBPostgresAdvancedServer9onRedHat = 540, // WTF is this?
        EDBPostgresAdvancedServer = 545,
        IBMDB2v105LUW = 550,

        /* Web Servers */
        Apache22Windows = 600,
        Apache22Unix = 605,
        Apache24UnixServer = 610,
        Apache24UnixSite = 615,
        ApacheWindowsServer = 620,
        ApacheWindowsSite = 625,
        IIS7 = 630,
        IIS85Server = 635,
        IIS85Site = 637,
        OracleHTTP = 640,

        /* Desktop Applications */
        AdobeAcrobatProDCClassic = 700,
        AdobeAcrobatProDCCOntinuous = 705,
        AdobeAcrobatReaderDCClassic = 710,
        AdobeAcrobatReaderDCCOntinuous = 715,

        /* ESRI */
        EsriArcGISServer103 = 800,

        /* Google Search Appliance */
        GoogleSearchAppliance = 850,

        /* MS Office Products */
        MSOfficeAccess2010 = 900,
        MSOfficeAccess2013 = 902,
        MSOfficeAccess2016 = 904,
        MSOfficeExcel2010 = 910,
        MSOfficeExcel2013 = 912,
        MSOfficeExcel2016 = 914,
        MSOfficeGroove2016 = 920,
        MSOfficeInfoPath2010 = 925,
        MSOfficeInfoPath2013 = 927,
        MSOfficeSystem2010 = 930,
        MSOfficeSystem2013 = 932,
        MSOfficeSystem2016 = 934,
        MSOneDriveBusiness = 940,
        MSOneNote2010 = 950,
        MSOneNote2013 = 952,
        MSOneNote2016 = 954,
        MSOutlook2010 = 960,
        MSOutlook2013 = 962,
        MSOutlook2016 = 964,
        MSPowerPoint2010 = 970,
        MSPowerPoint2013 = 972,
        MSPowerPoint2016 = 974,
        MSProject2010 = 980,
        MSProject2013 = 982, 
        MSProject2016 = 984,
        MSPublisher2010 = 990,
        MSPublisher2013 = 992,
        MSPublisher2016 = 994,
        MSSharePointDesigner2013 = 1000,
        MSSkypeBusiness2016 = 1010,
        MSVisio2013 = 1020,
        MSVisio2016 = 1022,
        MSWord2010 = 1030,
        MSWord2013 = 1032,
        MSWord2016 = 1034,

        /* Trend Micro */
        TrendMicroDeepSecurity9 = 1050,

        /* Remote Desktop */
        CitrixXenDesktop7 = 1060,
        CitrixXenDesktop7LicenseServer = 1065,
        CitrixXenDesktop7Receiver = 1070,
        CitrixXenDesktop7DeliveryController = 1075,
        CitrixXenDesktop7StoreFront = 1080,
        CitrixXenDesktop7WindowsVDA = 1085,

        /* HBSS */
        McAfeeApplicationControl = 2000,

        /* Mobile */
        AppleIOS12 = 2100,
        BlackBerryEnterpriseMobilityServer2 = 2110,
        BlackBerryOS103 = 2115,
        BlackBerryUEM127 = 2120,
        BlackBerryUEM128 = 2122,
        CMDPolicy = 2130,
        IBMMaaS360Watson10 = 2135,
        LGAndroid6 = 2140,
        MDMServerPolicy = 2145,
        MSWindows10Mobile = 2150,
        MobileIronCore9 = 2155,
        MobilePolicy = 2160,
        SamsungAndroid7Knox2 = 2170,
        SamsungAndroid5Knox2 = 2172,
        SamsungAndroid6Knox2 = 2174,
        SamsungAndroid8Knox2COBO = 2176,
        SamsungAndroid8Knox2COPE = 2178,
        SamsungSDSEMM15 = 2180,
        VMAirWatch9 = 2185,

        /* Network Perimeter */
        EnclaveTestAndDevelopment = 2200,

        /* Operating Systems */

        AppleMacOSX1011Workstation = 2300,
        AppleMacOSX1012Workstation = 2305,
        AppleMacOSX1013Workstation = 2310,
        IBMHMC = 2320,
        IMBzVMCAVMSecure = 2325,
        SLESV11SystemZ = 2330,
        zOSAFC2 = 2335,
        zOSRACF = 2340,
        zOSTSS = 2350,
        AIX61 = 2350,
        CanonicalUbuntu1604 = 2355,
        OracleLinux5 = 2360,
        OracleLinux6 = 2365,
        RedHat6 = 2370,
        RHEL7 = 2375,
        Solaris10SPARC = 2380,
        Solaris10x86 = 2385,
        Solaris11SPARC = 2390,
        Solaris11x86 = 2395,
        SUSELinuxEnterpriseServer = 2400,
        VMWareESXi5vCenter = 2405,
        VMWareESXi5VirtualMachine = 2410,
        VMWareESXi5Server = 2415,
        VMWarevRealizeAutomation7Application = 2420,
        VMWarevRealizeAutomation7HAProxy = 2425,
        VMWarevRealizeAutomation7Lighttpd = 2430,
        VMWarevRealizeAutomation7Overview = 2435,
        VMWarevRealizeAutomation7PostgreSQL = 2440,
        VMWarevRealizeAutomation7SLES = 2445,
        VMWarevRealizeAutomation7tcServer = 2450,
        VMWarevRealizeAutomation7vAMI = 2455,
        VMWarevRealizeAutomation7vIDM = 2460,
        VMWarevRealizeOperationsManagerCassandra = 2465,
        VMWarevRealizeOps6Application = 2470,
        VMWarevRealizeOps6PostgreSQL = 2475,
        VMWarevRealizeOps6SLES113 = 2480,
        VMWarevRealizeOps6txServer = 2485,
        VMWarevSphere6ESXi = 2490,
        VMWarevSphere6vCenterServerWindows = 2495,
        VMWarevSphere6VirtualMachine = 2500,
        MSActiveDirectoryDomain = 2510,
        MSActiveDirectoryForest = 2515,
        MSWindows10 = 2520,
        MSWindows2008DC = 2525,
        MSWindows2008MS = 2530,
        MSWindows2008DCR2 = 2535,
        MSWindows2008R2MS = 2540,
        MSWindows2012DC = 2545,
        MSWindows2012MS = 2550,
        MSWindowsFirewallAdvancedSecurity = 2560,
        MSWindowsPrivilegedAccessWorkstation = 2565,
        MSWindows2016MSDC = 2570
    }

}