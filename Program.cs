using System;

// Console.WriteLine("Quel est votre nom ?");
//         string? nom = Console.ReadLine();
//         Console.WriteLine($"Bonjour, {nom} !");

//         // Exemple de calcul
//         int a = 5, b = 3;
//         Console.WriteLine($"La somme de {a} et {b} est {a + b}"); 


Singleton s1 = Singleton.Instance;
Singleton s2 = Singleton.Instance;


if (s1 == s2)
{
        Console.WriteLine("Singleton works, both variables contain the same instance.");
}
else
{
        Console.WriteLine("Singleton failed, variables contain different instances.");
}