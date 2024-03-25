
// Adapter Design Pattern - Structural Category //







class JsonBankApiAdapter : IBankApi
{
    private readonly JsonBankApi jsonBankApi;

    public JsonBankApiAdapter()
    {
        jsonBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        // voltajı kontrol et
        return jsonBankApi.ExecuteTransaction(transaction);
    }
}
