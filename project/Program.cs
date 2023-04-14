//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = new string[4] { "Hello", "-334", "6", "Ok" };
string[] newarray = new string[array.Length];

string [] getarray(string [] array,string [] mewarray)
{
    int index = 0;
    int temp = 0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            newarray[index] = array[i];
            index = index + 1;
        }


    }
    return newarray;
}

getarray(array,newarray);

