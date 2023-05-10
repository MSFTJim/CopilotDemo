// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start of demo");

List<string> APIM_Terms = new() { "APIM", "API Management" };
List<string> SB_Terms = new() { "Service Bus", "ServiceBus" };
List<string> LA_Terms = new() { "Logic App", "LogicApp" };
List<string> Functions_Terms = new() { "function" };


List<string> Integration_Terms = new() { "event", "Functions", "AIS", "Integration", "API", "serverless" };



foreach (var item in Integration_Terms)
{
    Console.WriteLine(item);    
}


Console.WriteLine("End of demo");

