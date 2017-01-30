using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translator
{
    class Program
    {
        class LettersDictionary
        {
           
            private static Dictionary<string, string> letters = new Dictionary<string, string>
            {
                {"а","a"},
                {"б","b"},
                {"в","v"},
                {"г","g"},
                {"д","d"},
                {"е","e"},
                {"ё","yo"},
                {"ж","zh"},
                {"з","z"},
                {"и","i"},
                {"й","j"},
                {"к","k"},
                {"л","l"},
                {"м","m"},
                {"н","n"},
                {"о","o"},
                {"п","p"},
                {"р","r"},
                {"с","s"},
                {"т","t"},
                {"у","u"},
                {"ф","f"},
                {"х","h"},
                {"ц","c"},
                {"ч","ch"},
                {"ш","sh"},
                {"щ","sch"},
                {"ъ","'"},
                {"ы","y"},
                {"ь","'"},
                {"э","e"},
                {"ю","yu"},
                {"я","ya"},

            };
            public string GetTranslate(string text, string translate)
            {
                bool flag = false; //определния флага нахождения совпадения со словарем
                for (int i=0;i<text.Length;i++) // цикл для перебора каждого символа в строке
                {
                    foreach (KeyValuePair<string, string> pair in letters) // циклд для сравнения символа строки с каджым ключом в коллекции Dictionary letters
                    {
                        if(String.Compare(Convert.ToString(text[i]), pair.Key, StringComparison.OrdinalIgnoreCase) == 0) // Сравнение символа с ключом без учета регистра
                        {
                            if (String.Compare(Convert.ToString(text[i]), pair.Key) == 0) // Сравнение симвоа с ключом с учетом регистра.
                            {
                                translate += pair.Value;
                                flag = true;
                            }
                            else
                            {
                                translate += pair.Value.ToUpper();
                                flag = true;
                            }
                        }
                    }
                    if(flag==false)// проверка наличия совпадения
                    {
                        translate += Convert.ToString(text[i]);
                    }
                    flag = false;
                }
                return translate;
            }
        }
       
        static void Main(string[] args)
        {
            LettersDictionary dictionary1 = new LettersDictionary();
            string str1 = String.Empty;
            string str2 = String.Empty;
            Console.WriteLine("Введите текст на русском языке:");
            str1 = Console.ReadLine();
            str2 = dictionary1.GetTranslate(str1, str2);
            Console.WriteLine("\nВведенный текст на транслите:\n{0}",str2);
            Console.ReadKey();
        }
    }
}
