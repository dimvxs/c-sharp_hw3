

// Задание 1
// Создайте приложение, которое отображает количество
// чётных, нечётных, уникальных элементов массива.



using System;
namespace hw1
{
    class First
    {

          static void Main()
  {

// int[] array = new int[10];


// Random random = new Random();   
// for (int i = 0; i < array.Length; i++){
//     array[i] = random.Next(1, 100);
// }

//         Console.Write("even numbers: ");
// for(int i = 0; i < array.Length; i++){
//     if(array[i] % 2 == 0){
//         Console.Write(array[i] + " ");
//     }
// }  


//        Console.Write("odd numbers: ");
// for(int i = 0; i < array.Length; i++){
//     if(array[i] % 2 != 0){
//         Console.Write(array[i] + " ");
//     }
// }  

//  Console.Write("\n");

//     Console.Write("unique numbers: ");
// for(int i = 0; i < array.Length; i++){
//     if(array[i] % 2 != 0 && array[i] % 2 == 0){
//         Console.Write(array[i] + " ");
//     }
// }  

//  Console.Write("\n");




//     Задание 2
// Создайте приложение, отображающее количество
// значений в массиве меньше заданного параметра пользо-
// вателем. Например, количество значений меньших, чем 7
// (7 введено пользователем с клавиатуры).


// Console.WriteLine("enter the number: ");
// string userNumber = Console.ReadLine();
// int number = int.Parse(userNumber);

// int[] array = new int[100];

// for(int i = 0; i < array.Length; i++){
//     array[i] = i;
// }


// Console.Write("values in array less then your number: ");
// for(int i = 0; i < array.Length; i++){
//     if(array[i] < number){
//     Console.Write(array[i] + " ");
//     }
// }

//     Console.Write("\n");









// Задание 3
// Пользователь вводит с клавиатуры три числа. Необхо-
// димо подсчитать сколько раз последовательность из этих
// трёх чисел встречается в массиве.
// Например:
// пользователь ввёл: 7 6 5;
// массив: 7 6 5 3 4 7 6 5 8 7 6 5;
// количество повторений последовательности: 3.

// int[] userArray = new int[3];
// int[] array = { 1, 2, 3, 1, 2, 3, 1, 2, 3};
// int times = 0;
// for(int i = 0; i < userArray.Length; i++) 
// {
//     Console.WriteLine("enter a number: ");
//     string number = Console.ReadLine();
//      int number1 = int.Parse(number);
//      userArray[i] = number1;
// }

//    for (int i = 0; i <= array.Length - userArray.Length; i++)
//             {
//                 bool isMatch = true;
//                 for (int j = 0; j < userArray.Length; j++)
//                 {
//                     if (array[i + j] != userArray[j])
//                     {
//                         isMatch = false; 
//                         break;
//                     }
//                 }
//                 if (isMatch) 
//                 {
//                     times++;
//                 }
                  
// }

// Console.Write("repeats: " + times + "\n");




// Задание 4
// Даны 2 массива размерности М и N соответственно.
// Необходимо переписать в третий массив общие эле-
// менты первых двух массивов без повторений.

int[] array = { 1, 2, 3, 4, 5};
int[] array2 = {6, 7, 8, 9};
int size = array.Length + array2.Length;
int[] array3 = new int[size];

int index = 0;
for(int i = 0; i < array.Length; i++){
        array3[index] = array[i];
        index++;
    
}

for(int i = 0; i < array2.Length; i++){
    array3[index] = array2[i];
        index++;
}

Console.WriteLine("new array: ");

for(int i = 0; i < size; i++){
    Console.WriteLine(array3[i] + " ");
}


    }
}
}