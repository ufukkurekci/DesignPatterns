// Singleton Design Pattern
using System;
using DesignPatterns.SingletonPattern;

#region Explanation

/* *** Pros ***
    - Ensure single instance (can be use for memory caching)
    - Globally Access
    - Created only when requested
*/

/* *** Cons ***
    - Difficult to UnitTest (mocking)
    - In multithread word, threads cannot create its own instance
*/

#endregion


//Console.WriteLine(DateTime.Now.ToLongTimeString());
//var countries = await CountryProvider.Instance.GetCountries();

//var countries2 = await CountryProvider.Instance.GetCountries();

//Console.WriteLine(CountryProvider.Instance.CountryCount);

//Console.WriteLine(DateTime.Now.ToLongTimeString());
//Console.ReadLine();

CustomerManager.CreateSingelton().LogTO();


Console.WriteLine("as");
Console.ReadLine();