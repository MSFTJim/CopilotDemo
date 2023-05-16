using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("Start of demo");

List<string> APIM_Terms = new() { "APIM", "API Management" };
List<string> SB_Terms = new() { "Service Bus", "ServiceBus" };
List<string> LA_Terms = new() { "Logic App", "LogicApp" };
List<string> Functions_Terms = new() { "function" };


List<string> Integration_Terms = new() { "API", "event", "Functions", "AIS", "Integration", "serverless" };
Integration_Terms.AddRange(APIM_Terms);
Integration_Terms.AddRange(SB_Terms);
Integration_Terms.AddRange(LA_Terms);
Integration_Terms.AddRange(Functions_Terms);



Console.WriteLine("End of demo");









