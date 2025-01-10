class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст для шифру:");
        string inputText = Console.ReadLine();

        Console.WriteLine("Введіть числовий ключ для шифру:");
        int key = int.Parse(Console.ReadLine());

        string encryptedInputText = Encrypt(inputText, key);
        Console.WriteLine("Зашифрований текст: " + encryptedInputText);

        // Дешифрування
        string decryptedText = Decrypt(encryptedInputText, key);
        Console.WriteLine("Розшифрований текст: " + decryptedText);
    }

    static string Encrypt(string text, int key)
    {
        char[] encrypted = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            encrypted[i] = (char)(text[i] + key); 
        }
        return new string(encrypted);
    }

    static string Decrypt(string text, int key)
    {
        char[] decrypted = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            decrypted[i] = (char)(text[i] - key);
        }
        return new string(decrypted);
    }
}