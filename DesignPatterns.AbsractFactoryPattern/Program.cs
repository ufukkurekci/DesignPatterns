

using DesignPatterns.AbsractFactoryPattern;

AccountManager accountManager = new AccountManager(new Factory1());
AccountManager accountManager2 = new AccountManager(new Factory2());

accountManager.AccountCreate();
accountManager2.AccountCreate();



public abstract class BaseFactory
{
    public abstract Logging CreateLogger();
    public abstract Caching CreateCaching();
}

public class Factory1 : BaseFactory
{
    public override Caching CreateCaching()
    {
        return new RedisCache();
    }

    public override Logging CreateLogger()
    {
        return new Log4Net();
    }
}

public class Factory2 : BaseFactory
{
    public override Caching CreateCaching()
    {
        return new InMemoryCache();
    }

    public override Logging CreateLogger()
    {
        return new Nlogger();
    }
}

public class AccountManager
{
    private BaseFactory _factory;
    private Logging _logging;
    private Caching _caching;
    public AccountManager(BaseFactory baseFactory)
    {
        _factory = baseFactory;
        _caching = _factory.CreateCaching();
        _logging = _factory.CreateLogger();
    }

    public void AccountCreate()
    {
        Console.WriteLine("account created");
        _logging.Log("logged account");
        _caching.Cache("cache saved");
    }
}




