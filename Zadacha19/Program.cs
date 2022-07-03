Console.Write("Введите число: ");                                 //Просим ввести число
string? number = Console.ReadLine();                               //Вводим число

void Numbers(string number)                                         //Из числа в строку
{                                      
  if (number[0]==number[4] || number[1]==number[3])                //Если 1 число =5 , а 2 ровно 4
  {               
    Console.WriteLine($"Ваше число: {number} - палиндром.");       //То "Ваше число: number - палиндром."
  }
  else Console.WriteLine($"Ваше число: {number} - НЕ палиндром."); //Иначе "Ваше число: number - НЕ палиндром."
}

if (number!.Length == 5)                                          //Проверяем какое это число (5-и значное?)
{                                       
  Numbers(number);                                                
}
else Console.WriteLine($"Введи правильное число(5-и значное)");  //Если нет то просим ввести правильное число