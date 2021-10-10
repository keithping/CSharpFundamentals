using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_ValueTypes
{
    public enum PastryTypes
    {
        Cake = 0,
        Danish,
        Donut
    }

    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void InitAndDeclareVariables()
        {
            //Declaring a Variable
            int numOne;
            numOne = 1;

            //Declaring and Initializing a Variable
            int numTwo = 2;

            //A Variable is a named location in computer memory (AKA RAM)
        }

        [TestMethod]
        public void  ValueTypeVariables()
        {
            //Whole Numbers
            byte byteExample = 255;
            sbyte sByteExample = -128;
            short shortExample = 32165;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            int intMax = 2147483647;
            Int32 anotherIntExample = 123456;
            long longMax = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
            
            //Decimals
            //A Double can also end with the suffix d, but is not required to by default
            //A Float must end with the suffix f
            //A Decimal must end with the suffix m
            double doubleExample = 1.123456789;
            float floatExample = 1.123456789f;
            decimal decimalExample = 1.11223546657489m;

            Console.WriteLine(doubleExample);

            //Character
            char charExample = 'a';
            char number = '3';
            char symbol = '&';
            char space = ' ';
            char specialChar = '\n';

            //Bool
            bool isHungry = true;
            bool isTired = false;


            //Enum
            PastryTypes myPastry = PastryTypes.Donut;

            //Struts
            DateTime today = DateTime.Now;
            Console.WriteLine(today);

        }
    }
}
