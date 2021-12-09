using System;
using System.Text;
using System.Linq;


namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str2;
            char[] chr;
            char caracter;
            int nb;
            string[] strArray = { "Volvo", "Mercedes", "Audi", "Logan", "BMW" };
            bool result;

            Console.WriteLine("1. Write a method that to remove the nth index character from a nonempty string.");
            //Console.WriteLine(RemoveNthIndexCharacter(InputString(), InputCharacter()));
            Console.WriteLine(String.Format("Stringul rezultat este: {0}", RemoveNthIndexCharacter(InputString(), InputIndex())));

            Console.WriteLine("2.Write a method that to remove the characters which have odd index values of a given string.");
            Console.WriteLine(RemoveOddIndexCharacters(InputString()));
            Console.WriteLine();

            Console.WriteLine("3. Write a method that takes input from the user and displays that input back in upper and lower cases.");
            str = InputString();
            Console.WriteLine("Stringul ToUpper este {0} \nStringul ToLower este {1}", str.ToUpper(), str.ToLower());
            Console.WriteLine();

            Console.WriteLine("4th(str));. Write a method that reverses a string if it's length is a multiple of 4");
            str = InputString();
            Console.WriteLine(CheckIfMultipleOf(GetStringLength(str), 4) ? "Stringul inversat este: " + ReverseString(str) : "Lungimea stringului este {0}, nu se face reverse ", GetStringLength(str));
            Console.WriteLine();

            Console.WriteLine("5. Write method to convert a given string to all uppercase if it contains at least 2 uppercase characters in the first 4 characters.");
            str = InputString();
            Console.WriteLine(CheckIfUppercase(str, 2, 4) ? str.ToUpper() : "Stringul nu contine 2 litere mari in primele 4 caractere");
            Console.WriteLine();

            Console.WriteLine("6. Write a method that to remove a newline.");
            str = "Linia 1 din string  \nlinia 2 din string";
            Console.WriteLine(str);
            Console.WriteLine("Stringul fara new line este: {0}", RemoveFromCharacter(str, '\n'));
            Console.WriteLine();

            Console.WriteLine("7.Write a method to display formatted text (width=50) as output. For example: If I have a text that's 134 characters long, the formatted string should have maximum of 50 characters per line. In this case we will have 3 lines of text.");
            str = "01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123";
            Console.WriteLine("Stringul initial: \n{0}", str);
            Console.WriteLine();
            Console.WriteLine("Stringul formatat este: \n{0}", FormatString(str, 50));
            Console.WriteLine();

            Console.WriteLine("8. Write a method that formats a number with a percentage: ");
            Console.WriteLine("Numarul de formatat este: {0}", 0.6580);
            Console.WriteLine("Numarul formatat este: {0}", FormatNumberToPercentage(0.6580));
            Console.WriteLine();

            Console.WriteLine("9. Write a method that reverses a string.");
            Console.WriteLine("Stringul inversat este: {0}", ReverseString(InputString()));
            Console.WriteLine();

            Console.WriteLine("10. Write a method that strips a set of characters from a string.");
            str = InputString();
            chr = InputCharacters();
            Console.WriteLine("Stringul fara caracterele introduse este: {0} ", StripString(str, chr));   //str.Trim(chr)
            Console.WriteLine();

            Console.WriteLine("11.Write a method that transforms to lowercase first n characters in a string");
            str = InputString();
            nb = InputNumber();
            Console.WriteLine("Stringul cu primele {0} caractere lowercase este: {1}", nb, TransformToLoweCase(str, nb));
            Console.WriteLine();

            Console.WriteLine("12.Write a method to capitalize first and last letters of each word of a given string.");
            str = InputString();
            Console.WriteLine(CapitalizeFirstAndLastLetterOfEachWord(str));
            Console.WriteLine();

            Console.WriteLine("13. Write a method to compute sum of digits of a given string(if any).");
            str = InputString();
            Console.WriteLine("Suma cifrelor din string este: {0} ", SumOfDigits(str));
            Console.WriteLine();

            Console.WriteLine("14.Clean the text: ");
            Console.WriteLine(" Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.");
            Console.WriteLine(CleanText());
            Console.WriteLine();

            Console.WriteLine("15. Write a method to add 'ing' at the end of a given string (length should be at least 3). If the given string already ends with 'ing' then add 'ly' instead. If the string length of the given string is less than 3, leave it unchanged.");
            str = InputString();
            Console.WriteLine($"Stringul returnat este: {AddIng(str)}");
            Console.WriteLine();


            Console.WriteLine("16. Obfuscate Email");
            str = InputString();
            Console.WriteLine(ObfuscateEmail(str));
            Console.WriteLine();


            Console.WriteLine("17. Write a method to get a string made of the first 2 and the last 2 chars from a given a string. If the string length is less than 2, return instead of the empty string.");
            str = InputString();
            Console.WriteLine($"Stringul returnat este: {ReString(str)}");
            Console.WriteLine();

            Console.WriteLine("18. Write a method to get a string from a given string where all occurrences of its first char have been changed to '$', except the first char itself.");
            str = InputString();
            Console.WriteLine($"Stringul cu primul caracter inlocuit(cu exceptia primei aparitii) este: {ReplaceCharsExceptFirst(str)} ");
            Console.WriteLine();

            Console.WriteLine("19. Write a method to get a single string from two given strings, separated by a space and swap the first two characters of each string.");
            str = InputString();
            str2 = InputString();
            Console.WriteLine(GetSwappedString(str, str2));
            Console.WriteLine();

            Console.WriteLine("20. Write a method to find the first appearance of the substring 'not' and 'poor' from a given string, if 'not' follows the 'poor', replace the whole 'not'...'poor' substring with 'good'. Return the resulting string.");
            Console.WriteLine(ReplaceSubstring(InputString()));

            Console.WriteLine("21. Write a method that takes a list of words and returns the length of the longest one.");
            Console.WriteLine("Lista de cuvinte este: ");
            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine((strArray[i]));
            }
            Console.WriteLine("Lungimea celui mai mare cuvant este {0}", LongestWord(strArray));
            Console.WriteLine();

            Console.WriteLine("22. Write a method to get the last part of a string before a specified character.");
            str = InputString();
            Console.WriteLine(GetStringBeforeCharacter(str, InputCharacter()));

            Console.WriteLine("23. Write a method to check whether a string starts with specified characters");
            str = InputString();
            caracter = InputCharacter();
            result = CheckIfStartsWith(str, caracter);
            Console.WriteLine(result ? "Yes, starts with {0}" : "No, it doesn't start with {0}", caracter);
            Console.WriteLine();

            Console.WriteLine("24. Write a method to count occurrences of a substring in a string");
            str = InputString();
            str2 = InputString();
            Console.WriteLine($"Numarul de aparitii pentru {str2} in {str} este: {CountSubstringOccurence(str, str2)}");
            Console.WriteLine();

            Console.WriteLine("25. Write a method to swap comma and dot in a string.");
            str = "32.054,23";
            Console.WriteLine($"Stringul 32.054,23 dupa inverarea caracterelor este: {SwapComma(str)}");
            Console.WriteLine();

            Console.WriteLine("26. Write a method to remove spaces from a given string");
            Console.WriteLine($"Stringul fara spatii este: {RemoveSpaces(InputString())}");
            Console.WriteLine();

            Console.WriteLine("27. Check if a string is palindrome (same value read from left to right and right to left) Ex: alabala -> True");
            str = InputString();
            str2 = new String(str.Reverse().ToArray());
            Console.WriteLine(str.Equals(str2));

            //merge si asa
            //Console.WriteLine(str.SequenceEqual(str.Reverse()));

        }


        static string InputString()
        {
            Console.WriteLine("Introduceti stringul: ");
            return Console.ReadLine();
        }
        static char InputCharacter()
        {

            Console.WriteLine("Introduceti caracterul: ");
            return char.Parse(Console.ReadLine());
        }

        static char[] InputCharacters()
        {
            int nb;
            Console.WriteLine("Introduceti numarul de caractere pe care vreti sa le eliminati din string:");
            nb = int.Parse(Console.ReadLine());

            char[] chr = new char[nb];
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine("Introduceti caracterul {0} ", i + 1);
                chr[i] = char.Parse(Console.ReadLine());
            }

            return chr;
        }

        static int InputIndex()
        {
            Console.WriteLine("Introduceti indexul caracterului de sters: ");
            return int.Parse(Console.ReadLine());
        }

        static int InputNumber()
        {
            Console.WriteLine("Introduceti numarul de caractere: ");
            return int.Parse(Console.ReadLine());
        }
        static string RemoveNthIndexCharacter(string str, int nb)
        {
            //sterge caracterul de la indexul dat de user
            if (str.Length > 0)
                if (nb < str.Length && nb >=0)
                    return str.Remove(nb, 1);
                else
                    return str;
            else
                return "";

            //sterge prima aparitie a caracterului din string, de verificat cerinta la curs
            //if (str.Length > 0)
            //    if (str.IndexOf(chr) != -1)
            //        return str.Remove(str.IndexOf(chr), 1);
            //    else
            //        return str;
            //else
            //    return "";

            // cu StringBuilder
            //StringBuilder sb = new StringBuilder(str);
            //sb.Remove(str.IndexOf(chr), 1);
            //return sb.ToString();
        }

        static string RemoveOddIndexCharacters(string str)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    // indexul e numar par, il pun in string
                    newString.Append(str[i]);
            }
            return newString.ToString();

        }

        static string CleanText()
        {
            //string s = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            //string clean = s.Trim(new Char[] { '^', '<', ',', '>', '&', '+', '@', '%', '$' }); //  --> nu merge cu TRIM, asta face doar la inceputul si la sfarsitul stringului!!!

            string s = "Hi^>there<<I’m+ telling%%you, you &need% to$ do& your $homeworks. @Hate ^me^ %now% and %thank% me &later.";
            string clean = s.Replace("^", "").Replace("<", " ").Replace(">", " ").Replace("&", " ").Replace("+", " ").Replace("@", " ").Replace("%", " ").Replace("$", " ").Replace("  ", " ");     //s.Trim(' ', ',', '!', '<', '>');

            return clean;
        }

        static string ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        static string FormatNumberToPercentage(double nb)
        {
            return nb.ToString("P2");
        }

        static bool CheckIfMultipleOf(int nb, int multipleOf)
        {
            if (nb % multipleOf == 0)
                return true;
            else
                return false;
        }

        static int GetStringLength(string str)
        {
            return str.Length;
        }

        static bool CheckIfUppercase(string str, int nbOfUpperCase, int nrOfCharacters)
        {
            for (int i = 0; i < nrOfCharacters; i++)
            {
                if (str[i].Equals(char.ToUpper(str[i])))
                    nbOfUpperCase--;
            }

            return (nbOfUpperCase <= 0) ? true : false;
        }

        static string RemoveFromCharacter(string str, char chr)
        {
            return str.Replace("\n", "");

            //daca voiam sa-mi scoata toata linia 2 din string
            //return str.Remove(str.IndexOf(chr));
        }

        static string FormatString(string str, int nbOfCharacters)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i += nbOfCharacters)
            {
                sb.Append(str.Substring(i, (i + nbOfCharacters > str.Length ? str.Length - i : nbOfCharacters)));
                sb.Append('\n');
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }

        static string TransformToLoweCase(string str, int nb)
        {
            return  str.Substring(0, nb).ToLower() + str.Substring(nb, str.Length - nb);
        }


        static string CapitalizeFirstAndLastLetterOfWord(string str)
        {
            int n = str.Length;
            if (n <= 2)
            {
                // daca are mai putin de 3 caractere le fac upper
                return str.ToUpper();
            }
            else

                return str.Substring(0, 1).ToUpper() + str.Substring(1, n - 2) + str.Substring(n - 1, 1).ToUpper();
        }

        static string CapitalizeFirstAndLastLetterOfEachWord(string str)
        {

            String[] words = str.Split(' ');
            String result = "";
            for (int i = 0; i < words.Length; i++)
            {
                if (i != 0)
                {
                    result += " " + CapitalizeFirstAndLastLetterOfWord(words[i]);
                }
                else
                {
                    result = CapitalizeFirstAndLastLetterOfWord(words[i]);
                }
            }
            return result;
        }

        static int SumOfDigits(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum += int.Parse(str[i].ToString());
                }
            }
            return sum;
        }

        static string AddIng(string str)
        {

            if (str.Length >= 3)
                // if (str.Substring(str.Length - 3, 3).Equals("ing"))
                if (str.EndsWith("ing"))
                {
                    return String.Concat(str, "ly");
                }
                else
                {
                    return String.Concat(str, "ing");
                }
            else
                return str;

            //StringBuilder sb = new StringBuilder();
            //sb.Append(str);

            //if (str.Length >= 3)
            //   // if (str.Substring(str.Length - 3, 3).Equals("ing"))
            //        if (str.EndsWith("ing"))
            //    {
            //        sb.Append("ly");
            //    }
            //    else
            //    {
            //        sb.Append("ing");
            //    }
            //return sb.ToString();
        }


        static string ObfuscateEmail(string str)
        {

            StringBuilder sb = new StringBuilder();
            int nbOfChars = str.IndexOf("@");
            sb.Append('*', nbOfChars);
            sb.Append(str.Substring(nbOfChars, str.Length - nbOfChars));

            return sb.ToString();

        }

        static string ReString(string str)
        {
            if (str.Length < 2)
                return "";
            else
                return str.Substring(0, 2) + str.Substring(str.Length - 2, 2);
        }

        static string ReplaceCharsExceptFirst(string str)
        {
            //daca prrimul caracter e litera mare si urmatoarele sunt cu litere mici nu face inlocuirea
            char chr = char.Parse(str.Substring(0, 1));
            str = chr.ToString() + str.Substring(1, str.Length - 1).Replace(chr, '$');
            return str;
        }

        static string GetSwappedString(string str1, string str2)
        {
            //asa  nu merge daca cele 2 stringuri sunt mama si tata, le inlocuieste cu totul
            //return str1.Replace(str1.Substring(0, 2), str2.Substring(0, 2)) + " " + str2.Replace(str2.Substring(0, 2), str1.Substring(0, 2));

            StringBuilder sb = new StringBuilder();
            sb.Append(string.Concat(str2.Substring(0, 2), str1.Substring(2)));
            sb.Append(" ");
            sb.Append(string.Concat(str1.Substring(0, 2), str2.Substring(2)));
            return sb.ToString();

        }

        static string ReplaceSubstring(string str)
        {
            //Input: 'The lyrics is not that poor!'
            //Output: 'The lyrics is poor!'
            //Input: 'The lyrics is good!'
            //Output: 'The lyrics is poor!'

            int nbNot = str.IndexOf("not");
            int nbPoor = str.IndexOf("poor");

            if (nbNot != -1)
            {
                //daca l-a gasit pe Not, testez sa daca l-a gasit si pe poor si e dupa Not
                if (nbPoor != -1 && nbNot < nbPoor)
                    {
                        return str.Replace(str.Substring(nbNot), "poor!");
                    }
                else
                    {
                        return str;
                    }
            }

            if (str.IndexOf("good") != -1)
            {
                return str.Replace(str.Substring(str.IndexOf("good"),"good".Length), "poor");
            }
            else
                return str;

        }

        static int LongestWord(string[] str)
        {
            int longestwd = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (longestwd < str[i].Length)
                    longestwd = str[i].Length;
            }
            return longestwd;
        }

        static string GetStringBeforeCharacter(string str, char chr)
        {
            if (str.IndexOf(chr) != -1)
                return str.Remove(str.IndexOf(chr));
            else
                return "";
        }

        static bool CheckIfStartsWith(string str, char chr)
        {
            return str.StartsWith(chr.ToString()) ? true : false;
        }

        static int CountSubstringOccurence(string str1, string str2)
        {
            int count = 0, idx = 0;
            idx = str1.IndexOf(str2, idx);
            while (idx != -1)
            {
                count += 1;
                idx = str1.IndexOf(str2, idx + str2.Length);   // in caz ca am alala si vreau sa caute ala dc vreau sa returneze 2 nu mai maresc cu str2.Length ci cu idx+1
            }
            return count;
        }

        static string SwapComma(string str)
        {
            return str.Replace(',', 'C').Replace('.', ',').Replace('C', '.');
        }

        static string RemoveSpaces(string str)
        {
            return str.Replace(" ", string.Empty);     //str.Replace(' ', '\0');
        }


        static string StripString(string str, char[] chr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            for (int i = 0; i < chr.Length; i++)
            {
                sb = sb.Replace(chr[i], '\0');
            }
            return sb.ToString();
        }

    }
}
