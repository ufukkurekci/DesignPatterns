
// Adapter Design Pattern - Structural Category //






class XmlBankApiAdapter : IBankApi
{
    private readonly XmlBankApi xmlBankApi;

    public XmlBankApiAdapter()
    {
        xmlBankApi = new();
    }

    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        // voltajı düşür
        return xmlBankApi.ExecuteTransaction(transaction);
    }
}
