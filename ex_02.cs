//Modifique o programa anterior para que ele consiga também pesquisar por
//cpf's e encontrar seus telefones.

using System;
using System.Collections;

class HelloWorld
{
    static void Main()
    {
        Hashtable listaCPFTel = new Hashtable();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Digite o CPF da pessoa {i}: ");
            string cpf = Console.ReadLine();

            Console.Write($"Digite o número de telefone da pessoa {i}: ");
            string telefone = Console.ReadLine();

            listaCPFTel[cpf] = telefone;

            Console.WriteLine();
        }
        foreach (DictionaryEntry entry in listaCPFTel)
        {
            string cpf = (string)entry.Key;
            string telefone = (string)entry.Value;

            Console.WriteLine($"CPF: {cpf}, Telefone: {telefone}");
        }
        procurarCPF(listaCPFTel);
        Console.ReadLine();
    }
    static void procurarCPF(Hashtable listaCPFTel)
    {
        Console.WriteLine("Buscar cpf");
        string cpf = Console.ReadLine();
        Console.WriteLine($"CPF: {cpf}, Telefone: {listaCPFTel[cpf]}");

    }
}