using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static string SwapThirds(string input)
        {
            int length = input.Length;
            int thirdLength = length / 3;

            string firstThird = input.Substring(0, thirdLength);
            string secondThird = input.Substring(thirdLength, thirdLength);
            string thirdThird = input.Substring(2 * thirdLength, thirdLength);

            string resultA = thirdThird + firstThird + secondThird;
            return resultA;
        }
        static void Main(string[] args)
        {
            string input = "ABCDEFGHIJKL"; 
            string resultA = SwapThirds(input);
            Console.WriteLine("Результат A: " + resultA);

            string resultB = SwapThirds(resultA); 
            Console.WriteLine("Результат B: " + resultB);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Ваше предложение с буквами е и Е"; 

            string modifiedSentence = sentence.Replace("е", "и").Replace("Е", "И");

            Console.WriteLine("Исходное предложение: " + sentence);
            Console.WriteLine("Предложение после замены: " + modifiedSentence);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static string SwapCharacters(string word, int index1, int index2)
        {
            if (index1 >= 0 && index1 < word.Length && index2 >= 0 && index2 < word.Length)
            {
                char[] charArray = word.ToCharArray();
                char temp = charArray[index1];
                charArray[index1] = charArray[index2];
                charArray[index2] = temp;
                return new string(charArray);
            }
            return word;
        }
        static void Main(string[] args)
        {
            string word = "Ваше_слово"; 

            int index1 = 1; 
            int index2 = 4; 

            string swappedWord = SwapCharacters(word, index1, index2);

            Console.WriteLine("Исходное слово: " + word);
            Console.WriteLine("Слово после замены: " + swappedWord);
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static bool IsPalindrome(string str)
        {
            string cleanStr = str.Replace(" ", "").ToLower();

            int length = cleanStr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (cleanStr[i] != cleanStr[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();

            if (IsPalindrome(input))
            {
                Console.WriteLine("Это палиндром.");
            }
            else
            {
                Console.WriteLine("Это не палиндром.");
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static int CountWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string input = Console.ReadLine();

            int wordCount = CountWords(input);
            Console.WriteLine("Количество слов в предложении: " + wordCount);
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = random.Next(-100, 101);
                }
            }

            Console.WriteLine("Исходный двумерный массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int minRow = 0;
            int minCol = 0;
            int maxRow = 0;
            int maxCol = 0;

            int min = array[0, 0];
            int max = array[0, 0];

 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            int sum = 0;
            bool betweenMinMax = false;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((i == minRow && j == minCol) || (i == maxRow && j == maxCol))
                    {
                        if (betweenMinMax)
                            break;
                        betweenMinMax = true;
                    }
                    if (betweenMinMax)
                        sum += array[i, j];
                }
            }

            Console.WriteLine("Минимальный элемент: " + min);
            Console.WriteLine("Максимальный элемент: " + max);
            Console.WriteLine("Сумма элементов между минимальным и максимальным: " + sum);
        }


    }
    }





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите малую русскую букву: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            if (IsLowerRussianLetter(inputChar))
            {
                char upperChar = ToUpperRussianLetter(inputChar);
                Console.WriteLine("Соответствующая большая буква: " + upperChar);
            }
            else
            {
                Console.WriteLine("Вы ввели не малую русскую букву.");
            }

        }
        static bool IsLowerRussianLetter(char c)
        {
            return (c >= 'а' && c <= 'я');
        }

        static char ToUpperRussianLetter(char c)
        {
            if (IsLowerRussianLetter(c))
            {
                return (char)(c - 'а' + 'А');
            }
            return c;
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 3, 4, 5, 6, 7 };

            int[] resultArray = new int[Math.Min(array1.Length, array2.Length)]; 

            int resultCount = 0; 
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        bool isDuplicate = false;
                       
                        for (int k = 0; k < resultCount; k++)
                        {
                            if (array1[i] == resultArray[k])
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        if (!isDuplicate)
                        {
                            resultArray[resultCount] = array1[i];
                            resultCount++;
                        }
                    }
                }
            }

            Console.WriteLine("Общие элементы без повторений:");
            for (int i = 0; i < resultCount; i++)
            {
                Console.WriteLine(resultArray[i]);
            }
        }
                }

}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Привет! Меня зовут Милана. Мне семь лет!"; 

            int countM = 0;
            int countN = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                char c = char.ToLower(sentence[i]);
                if (c == 'м')
                {
                    countM++;
                }
                else if (c == 'н')
                {
                    countN++;
                }
            }

            if (countM > countN)
            {
                Console.WriteLine("Букв 'м' больше чем букв 'н' в предложении.");
            }
            else if (countN > countM)
            {
                Console.WriteLine("Букв 'н' больше чем букв 'м' в предложении.");
            }
            else
            {
                Console.WriteLine("Количество букв 'м' и 'н' одинаково в предложении.");
            }
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "нгопагушпао------==+++++++"; 

            int countPlus = 0;
            int countMinus = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '+')
                {
                    countPlus++;
                }
                else if (text[i] == '–')
                {
                    countMinus++;
                }
            }

            Console.WriteLine("Количество символов '+' в тексте: " + countPlus);
            Console.WriteLine("Количество символов '–' в тексте: " + countMinus);

            int totalCount = countPlus + countMinus;
            Console.WriteLine("Общее количество символов '+' и '–' в тексте: " + totalCount);

        }
    }
}

