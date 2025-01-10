class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текст для шифру:");
        string inputText = Console.ReadLine();

        Console.WriteLine("Введіть числовий ключ для шифру:");
        int key = int.Parse(Console.ReadLine());

        string encryptedInputText = EncryptDecrypt(inputText, key);
        Console.WriteLine("Зашифрований текст: " + encryptedInputText);

        // Дешифрування
        string decryptedText = EncryptDecrypt(encryptedInputText, key);
        Console.WriteLine("Розшифрований текст: " + decryptedText);
    }
    static string EncryptDecrypt(string text, int key)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            result[i] = (char)(text[i] ^ key); 
        }

        return new string(result);
    }
}