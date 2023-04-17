using System;
namespace MethodOverloading
{
    public class Methods
    {
        public static int Add(int num1, int num2)

        {
            return num1 + num2;
        }


        public static decimal Add(decimal num1 , decimal num2)
        {
            return (num1+num2);
        }

        public static string Add(int num1, int num2, bool dollars)
        {
            if(dollars && num1 + num2 != 1)
            {
                return $"{num1 + num2} dollars";
            }
            else if ( dollars && num1 + num2 ==1)
            {
                return $"{num1 + num2} dollar";
            }
               else
            {
                return $"{num1 + num2} dollars";
            }
        }

}



}

