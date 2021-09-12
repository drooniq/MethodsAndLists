using System;
using System.Runtime.Serialization;

namespace MethodsAndLists.Core
{
    public class AddNumberEngine
    {
        private int[] numberList = new int[2];
        private int numberOfValidInputs = 0;

        public enum Error
        {
            InputIsNotNumber,
            DontHaveTwoValues,
            AlreadyHaveTwoValues,
            SecondValueCantBeLowerThanFirst
        }

        public AddNumberEngine()
        {
        }

        public int Result()
        {
            if (numberOfValidInputs != numberList.Length)
            {
                throw new Exception(Error.DontHaveTwoValues);
            }

            int value = 0;

            for (int i = numberList[0]; i<= numberList[1]; i++)
            {
                value += i;
            }

            return value;
        }

        public void Input(string inputValue)
        {
            if (inputValue == null || inputValue.Length == 0)
                throw new Exception(Error.InputIsNotNumber);

            int value;
            if (int.TryParse(inputValue, out value))
            {
                if (numberOfValidInputs == numberList.Length)
                {
                    throw new Exception(Error.AlreadyHaveTwoValues);
                }

                if (numberOfValidInputs >= 1 && numberList[0] > value)
                {
                    throw new Exception(Error.SecondValueCantBeLowerThanFirst);
                }

                numberList[numberOfValidInputs++] = value;
            }
            else
            {
                throw new Exception(Error.InputIsNotNumber);
            }
        }

        public class Exception : System.Exception
        {
            public Error Error { get; set; }

            public Exception()
            {
            }
            public Exception(Error error)
            {
                Error = error;
            }

            public Exception(string message) : base(message)
            {
            }
        }
    }
}
