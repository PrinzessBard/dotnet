namespace ConsoleApp1 {
  internal class Program {
    static void Main(string[] args) {
      bool isOpen = true;

      string[,] books = {
        {"А.Пушкин", "М.Лермонтов", "С.Есенин"},
        {"Р.Мартин", "Д.Шелл", "С.Тепляков"},
        {"С.Кинг", "Г.Лавкрафт", "Б.Стокер"}
      };

      while(isOpen) {
        Console.SetCursorPosition(0, 20);
        System.Console.WriteLine("\nВесь список авторов\n");
        for (int i = 0; i < books.GetLength(0); i++) {
          for (int j = 0; j < books.GetLength(1); j++) {
            System.Console.Write(books[i, j] + " | ");
          }
          System.Console.WriteLine("");
        }

        Console.SetCursorPosition(0, 1);
        System.Console.WriteLine("Библиотека");
        System.Console.WriteLine("\n1 - узнать автора по индексу книги" +
                                  "\n2 - найти книгу по автору" +
                                  "\n3 - выход");

        System.Console.Write("\nВыберите пункт меню: ");
        switch(Convert.ToInt32(Console.ReadLine())) {
          case 1:
            int line, column;
            System.Console.WriteLine("Введите номер полки: ");
            line = Convert.ToInt32(Console.ReadLine())-1;
            System.Console.WriteLine("Введите номер столбец: ");
            column = Convert.ToInt32(Console.ReadLine())-1;
            System.Console.WriteLine($"Автор: {books[line, column]}");
            break;
          case 2:
            string author;
            bool authorFound = false;
            System.Console.Write("Введите автора: ");
            author = Console.ReadLine();
            for(int i = 0; i < books.GetLength(0); i++) {
              for(int j = 0; j < books.GetLength(1); j++) {
                if(books[i, j].ToLower() == author.ToLower()) {
                  System.Console.WriteLine($"Автор {books[i, j]} находиться по адресу: " +
                                            $"полка {i+1} место {j+1} ");
                  authorFound = true;
                }
              }
            }
            if(!authorFound) {
              System.Console.WriteLine("Автора нет");
            }
            break;
          case 3:
            isOpen = false;
            break;
          default:
            System.Console.WriteLine("Введена неверная команда");
            break;
        }

        if(isOpen) {
          System.Console.WriteLine("\nНажмите любую клавишу для продолжения...");
        }

        Console.ReadKey();
        Console.Clear();
      }
    }
  } 
}