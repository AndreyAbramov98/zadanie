﻿
int dayNumber = new Random().Next(1, 1000);                    //Генерируем рандомное число которые будет обозначать день
Console.WriteLine(dayNumber);                                  //Выводим число дня              
  if (dayNumber %6==0 || dayNumber  %7==0) {                   //Говорим что если рандомное число кратно 6 или 7 это выходной
  Console.WriteLine("(этот день ВЫХОДНОЙ) да");                //Выводим "(этот день ВЫХОДНОЙ) да"
  }
  else Console.WriteLine("(этот день НЕ выходной) нет");       //Иначе выводим это "(этот день НЕ выходной) нет"

//____________________________________________________________________________

Console.Write("Введите 3-х значное число: ");                   
int dayNumbers = Convert.ToInt32( Console.ReadLine());
  if (dayNumbers %6==0 || dayNumbers  %7==0) {                   
  Console.WriteLine("(этот день ВЫХОДНОЙ) да");                
  }
  else Console.WriteLine("(этот день НЕ выходной) нет");       

