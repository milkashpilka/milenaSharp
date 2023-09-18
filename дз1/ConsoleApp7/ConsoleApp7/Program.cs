using System;

class Program
{
    static void Main()
    {
        int newInt = 10;
        float newFloat = 8.4f; // Обратите внимание на суффикс 'f' для указания на тип float
        string newStr = "True";

        // 2. Увеличьте значение, хранимое в переменной newInt, в 3.5 раза.
        float bigInt = newInt * 3.5f;

        // 3. Измените значение, хранимое в переменной newFloat, уменьшив его на единицу, результат свяжите с той же переменной.
        newFloat -= 1;

        // 4. Разделите newInt на newFloat, а затем bigInt на newFloat. Результаты данных выражений выведите на экран.
        Console.WriteLine("Результат деления newInt на newFloat: " + (newInt / newFloat));
        Console.WriteLine("Результат деления bigInt на newFloat: " + (bigInt / newFloat));

        // 5. Измените значение переменной newStr на "NoNoYesYesYes". При формировании нового значения используйте операции конкатенации (+).
        newStr = "NoNo" + newStr + "YesYesYes";

        // 6. Выведите значения всех переменных.
        Console.WriteLine("newInt: " + newInt);
        Console.WriteLine("newFloat: " + newFloat);
        Console.WriteLine("bigInt: " + bigInt);
        Console.WriteLine("newStr: " + newStr);
    }
}
