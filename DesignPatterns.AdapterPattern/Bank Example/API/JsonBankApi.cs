
// Adapter Design Pattern - Structural Category //








class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $$""""
                      {
                        ""FromIBAN"": ""{{transaction.FromIBAN}}"",
                        ""ToIBAN"":   ""{{transaction.ToIBAN}}"",
                        ""Amount"":   ""{{transaction.Amount:C2}}""
                      }
                     """";

        // Call bank api with JSON
        Console.WriteLine($"{GetType().Name} worked with;");
        Console.WriteLine(json);
        return true;
    }
}
