
// Observer Design Pattern - Behavioral Category //

//var samsung = new Product("Samsung S23", 1000);
//var apple = new Product("iPhone 14", 1000);

//var amazon = new Amazon();
//var salihObserver = new SalihObserver("Salih Cantekin");
//var cantekinObserver = new CantekinObserver("Cantekin Salih");

//amazon.Register(salihObserver, samsung);
//amazon.Register(cantekinObserver, apple);

//amazon.NotifyForProductName("iPhone 14");


//amazon.NotifyAll();


using System.Security.Cryptography;
using System.Text;


// Örnek bir metin
string user = "AU_PersonalLocation";
string password = "pR$40lph#0R$soke?R_z";

// Secret key
string secretKey = "MySecretKey12345";

// Metni şifrele ve ardından şifrelenmiş veriyi orijinal metne dönüştür
string encryptedUser = EncryptString(user, secretKey);
string encryptedPassword = EncryptString(password, secretKey);
string decryptedUser = DecryptString(encryptedUser, secretKey);
string decryptedPassword = DecryptString(encryptedPassword, secretKey);

Console.WriteLine("Original Text: " + user);
Console.WriteLine("Original Text: " + password);
Console.WriteLine("EncryptedUser Text: " + encryptedUser);
Console.WriteLine("EncryptedPassword Text: " + encryptedPassword);
Console.WriteLine("DecryptedUser Text: " + decryptedUser);
Console.WriteLine("DecryptedPassword Text: " + decryptedPassword);

Console.ReadLine();


static string EncryptString(string plainText, string key)
{
    using (Aes aesAlg = Aes.Create())
    {
        aesAlg.Key = Encoding.UTF8.GetBytes(key);
        aesAlg.IV = new byte[16]; // Initialization vector

        ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
        using (MemoryStream msEncrypt = new MemoryStream())
        {
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
            {
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(plainText);
                }
            }
            return Convert.ToBase64String(msEncrypt.ToArray());
        }
    }
}

static string DecryptString(string cipherText, string key)
{
    using (Aes aesAlg = Aes.Create())
    {
        aesAlg.Key = Encoding.UTF8.GetBytes(key);
        aesAlg.IV = new byte[16]; // Initialization vector

        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
        using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(cipherText)))
        {
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
            {
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}




