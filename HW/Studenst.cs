using System.Dynamic;
using System.Security.Cryptography;

public class Student {

public string Password { get; set; }


public void Spell()
    {
        System.Console.WriteLine($"пароль {Password} ");
    }

}