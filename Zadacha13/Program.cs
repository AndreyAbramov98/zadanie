//Данный код был взять с интернета и переделан.
//Я не смог придумать условия решения данной задачи.
int Number = new Random().Next(1, 10000);                           //создаем рандомное число 
Console.WriteLine(Number);                                          //выводим рандомное число 
string anyNumberText = Convert.ToString(Number);                    //конвертируем int в string (из числа в строку)
if (anyNumberText.Length > 2){                                      //Если длина строки больше 2
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);         //Выводим "третья цифра -> " + значения под 2 номером массива(3число от 0)
} 
else {                                                              // Иначе
  Console.WriteLine("-> третьей цифры нет");                        //Выводим "-> третьей цифры нет"
}
//____________________________________________________________

Console.Write("Введите число: ");                                   //Вводим число 
int Numbers = Convert.ToInt32( Console.ReadLine());                 //выводим  число 
string NumberText = Convert.ToString(Numbers);                      //конвертируем int в string (из числа в строку)
if (NumberText.Length > 2){                                         //Если длина строки больше 2
  Console.WriteLine("третья цифра -> " + NumberText[2]);            //Выводим "третья цифра -> " + значения под 2 номером массива(3число от 0)
} 
else {                                                              // Иначе
  Console.WriteLine("-> третьей цифры нет");                        //Выводим "-> третьей цифры нет"
}
