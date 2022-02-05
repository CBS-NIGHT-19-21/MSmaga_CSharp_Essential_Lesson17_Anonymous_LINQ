

namespace Task4_Translator
{
    public class Translator
    {
        public static void Translate(string word)
        {
            var engList = new List<EnglishWord>
        { new EnglishWord{ Id = 0, Word = "Ship" }, new EnglishWord{ Id = 1, Word = "Lost"},
          new EnglishWord{ Id = 2, Word = "Big" }, new EnglishWord{ Id = 3, Word = "Boat"},
          new EnglishWord{ Id = 4, Word = "Black" }, new EnglishWord{ Id = 5, Word = "Battleship"},
          new EnglishWord{ Id = 6, Word = "Royal" }, new EnglishWord{ Id = 7, Word = "Frigate"},
          new EnglishWord{ Id = 8, Word = "Pirate" }, new EnglishWord{ Id = 9, Word = "Attack"}
        };

            var ruList = new List<RussianWord>
        { new RussianWord{ Id = 0, Word = "Корабль" }, new RussianWord{ Id = 1, Word = "Пропавший"},
          new RussianWord{ Id = 2, Word = "Большой" }, new RussianWord{ Id = 3, Word = "Лодка"},
          new RussianWord{ Id = 4, Word = "Черный" }, new RussianWord{ Id = 5, Word = "Линкор"},
          new RussianWord{ Id = 6, Word = "Королевский" }, new RussianWord{ Id = 7, Word = "Фригат"},
          new RussianWord{ Id = 8, Word = "Пиратский" }, new RussianWord{ Id = 9, Word = "Атака"}
        };

            var transWord = from engWord in engList
                            join ruWord in ruList
                            on engWord.Id equals ruWord.Id
                            where engWord.Word == word
                            select new
                            { transWord = ruWord.Word };

            foreach (var item in transWord)
            {

                Console.WriteLine(item.transWord);
            }
        }

    }
}
