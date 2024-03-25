
// Adapter Design Pattern - Structural Category //

//var trans = new TransferTransaction() { Amount = 10, FromIBAN = "1", ToIBAN = "2" };

//var adapter = new JsonBankApiAdapter();
//var result = adapter.ExecuteTransaction(trans);

//Console.WriteLine("Result: {0}", result);




using DesignPatterns.AdapterPattern.Log_Example;

Log4Adapter log4Adapter = new Log4Adapter();
UKLoggerAdapter uKLoggerAdapter = new UKLoggerAdapter();
uKLoggerAdapter.Log("ornek");

log4Adapter.Log("ornek");
















Console.ReadLine();
