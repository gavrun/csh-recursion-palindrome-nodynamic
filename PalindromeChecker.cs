namespace csh_recursion_palindrome_nodynamic;

using System;

public class PalindromeChecker
{
    public static bool IsPalindrome(string word)
    {
        // Приведение строки к нижнему регистру и удаление пробелов
        word = word.ToLower().Replace(" ", "");

        // Базовый случай: если длина строки <= 1, это палиндром
        if (word.Length <= 1)
        {
            return true;
        }

        // Если первый и последний символы не совпадают, это не палиндром
        if (word[0] != word[word.Length - 1])
        {
            return false;
        }

        // Рекурсивный случай: проверяем подстроку без первого и последнего символов
        string shorterWord = word.Substring(1, word.Length - 2);
        return IsPalindrome(shorterWord);
    }

    public static void Main(string[] args)
    {
        // Пример использования функции для проверки фразы "Dogma I am God"
        string word = "Dogma I am God";
        Console.WriteLine("{0} is palindrome: {1}", word, IsPalindrome(word));
    }
}
