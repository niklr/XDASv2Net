using NUnit.Framework;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using XDASv2Net.Attributes;
using XDASv2Net.Extensions;
using XDASv2Net.Model;
using XDASv2Net.Tests.Extensions;

namespace XDASv2Net.Tests.Integration
{
    /// <summary>
    /// The JSON serialization tests are based on the PDF available online:
    /// https://www.netiq.com/documentation/edir88/pdfdoc/edirxdas_admin/edirxdas_admin.pdf
    /// Released: September 2013
    /// </summary>
    [TestFixture]
    public class JsonSerializationExamples
    {
        [Test]
        public void JsonSerializationExamples_Create_Account()
        {
            //assemble
            XDASv2Event exampleEvent = new XDASv2Event()
            {
                Source = "eDirectory#DS",
                Initiator = new Initiator()
                {
                    Account = new Account()
                    {
                        Name = "CN=admin,O=mycom",
                        Id = 32805
                    }
                },
                Target = new Target()
                {
                    Data = new Dictionary<string, string>()
                    {
                        { "ClassName", "User" },
                        { "Name", "CN=USER,O=mycom" }
                    }
                },
                Observer = new Observer()
                {
                    Account = new Account()
                    {
                        Domain = "MYTREE",
                        Name = "CN=SLES11-SP2,O=mycom"
                    },
                    Entity = new Entity()
                    {
                        SysAddr = "100.1.1.2",
                        SysName = "SLES11-SP2.my.com"
                    }
                },
                Action = new Action()
                {
                    Event = new Event()
                    {
                        Id = EventType.CREATE_ACCOUNT.GetAttribute<EventInformationAttribute>().EventIdentifier,
                        Name = EventType.CREATE_ACCOUNT.ToString(),
                        CorrelationId = "eDirectory#25#0ef05b4ce864-4d4c-f7a9-4c5bf00e64e8"
                    },
                    SubEvent = new SubEvent()
                    {
                        Name = "DSE_CREATE_ENTRY"
                    },
                    Log = new Log()
                    {
                        Severity = 7
                    },
                    Time = new Time()
                    {
                        Offset = 1389173763
                    },
                    Outcome = "0",
                    ExtendedOutcome = "0"
                }
            };

            var context = new ValidationContext(exampleEvent, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            bool isValid = Validator.TryValidateObject(exampleEvent, context, results, true);
            string json = exampleEvent.ToJson();

            //assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(0, results.Count);
            Assert.AreEqual(@"{
  ""Source"": ""eDirectory#DS"",
  ""Initiator"": {
    ""Account"": {
      ""Name"": ""CN=admin,O=mycom"",
      ""Id"": 32805
    }
  },
  ""Target"": {
    ""Data"": {
      ""ClassName"": ""User"",
      ""Name"": ""CN=USER,O=mycom""
    }
  },
  ""Observer"": {
    ""Account"": {
      ""Domain"": ""MYTREE"",
      ""Name"": ""CN=SLES11-SP2,O=mycom""
    },
    ""Entity"": {
      ""SysAddr"": ""100.1.1.2"",
      ""SysName"": ""SLES11-SP2.my.com""
    }
  },
  ""Action"": {
    ""Event"": {
      ""Id"": ""0.0.0.0"",
      ""Name"": ""CREATE_ACCOUNT"",
      ""CorrelationId"": ""eDirectory#25#0ef05b4ce864-4d4c-f7a9-4c5bf00e64e8""
    },
    ""SubEvent"": {
      ""Name"": ""DSE_CREATE_ENTRY""
    },
    ""Log"": {
      ""Severity"": 7
    },
    ""Time"": {
      ""Offset"": 1389173763,
      ""Certainty"": 100
    },
    ""Outcome"": ""0"",
    ""ExtendedOutcome"": ""0""
  }
}", json);

        }

        [Test]
        public void JsonSerializationExamples_Create_Access_Token()
        {
            //assemble
            XDASv2Event exampleEvent = new XDASv2Event()
            {
                Source = "eDirectory#DS",
                Initiator = new Initiator()
                {
                    Account = new Account()
                    {
                        Domain = "MYTREE"
                    },
                    Entity = new Entity()
                    {
                        SysAddr = "0.0.0.0:0"
                    }
                },
                Target = new Target()
                {
                    Data = new Dictionary<string, string>()
                    {
                        { "ClassName", "NCP Server" },
                        { "Name", "CN=SRV1,O=mycom" }
                    }
                },
                Observer = new Observer()
                {
                    Account = new Account()
                    {
                        Domain = "MYTREE",
                        Name = "CN=SRV1,O=mycom"
                    },
                    Entity = new Entity()
                    {
                        SysAddr = "100.1.2.164",
                        SysName = "SLES11-SP2-164"
                    }
                },
                Action = new Action()
                {
                    Event = new Event()
                    {
                        Id = EventType.CREATE_ACCESS_TOKEN.GetAttribute<EventInformationAttribute>().EventIdentifier,
                        Name = EventType.CREATE_ACCESS_TOKEN.ToString(),
                        CorrelationId = "eDirectory#0#"
                    },
                    SubEvent = new SubEvent()
                    {
                        Name = "DSE_ALLOW_LOGIN"
                    },
                    Log = new Log()
                    {
                        Severity = 7
                    },
                    Time = new Time()
                    {
                        Offset = 1389847714
                    },
                    Outcome = "0",
                    ExtendedOutcome = "0"
                }
            };

            var context = new ValidationContext(exampleEvent, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            //act
            bool isValid = Validator.TryValidateObject(exampleEvent, context, results, true);
            string json = exampleEvent.ToJson();

            //assert
            Assert.IsTrue(isValid);
            Assert.AreEqual(0, results.Count);
            Assert.AreEqual(@"{
  ""Source"": ""eDirectory#DS"",
  ""Initiator"": {
    ""Account"": {
      ""Domain"": ""MYTREE""
    },
    ""Entity"": {
      ""SysAddr"": ""0.0.0.0:0""
    }
  },
  ""Target"": {
    ""Data"": {
      ""ClassName"": ""NCP Server"",
      ""Name"": ""CN=SRV1,O=mycom""
    }
  },
  ""Observer"": {
    ""Account"": {
      ""Domain"": ""MYTREE"",
      ""Name"": ""CN=SRV1,O=mycom""
    },
    ""Entity"": {
      ""SysAddr"": ""100.1.2.164"",
      ""SysName"": ""SLES11-SP2-164""
    }
  },
  ""Action"": {
    ""Event"": {
      ""Id"": ""0.0.11.4"",
      ""Name"": ""CREATE_ACCESS_TOKEN"",
      ""CorrelationId"": ""eDirectory#0#""
    },
    ""SubEvent"": {
      ""Name"": ""DSE_ALLOW_LOGIN""
    },
    ""Log"": {
      ""Severity"": 7
    },
    ""Time"": {
      ""Offset"": 1389847714,
      ""Certainty"": 100
    },
    ""Outcome"": ""0"",
    ""ExtendedOutcome"": ""0""
  }
}", json);
        }
    }
}
