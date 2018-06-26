using System;
using System.Collections.Generic;

namespace PingPongGame
{
    public class PingPong
    {
        private List<int> _rangeList = new List<int>();

        public bool IsNotInteger(string input)
        {
            int num;
            bool result = int.TryParse(input, out num);
            return result;
        }

        public bool FirstLastElement(int integer)
        {
            for (int i = 1; i <= integer; i++)
            {
                _rangeList.Add(i);
            }
            
            if (_rangeList[0] == 1 && _rangeList[integer - 1] == integer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LengthListTest(int integer)
        {
            for (int i = 1; i <= integer; i++)
            {
                _rangeList.Add(i);
            }

            if (_rangeList.Count == integer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string PingPongTest(int integer)
        {
            if (integer % 3 == 0 && integer % 5 == 0)
            {
                return "ping-pong";
            }
            else if (integer % 3 == 0)
            {
                return "ping";
            }
            else if (integer % 5 == 0)
            {
                return "pong";
            }
            else
            {
                string intString = integer.ToString();
                return intString;
            }
        }
        // public bool PingTest(int integer)
        // {
        //     if (integer % 3 == 0)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        //
        // public bool PongTest(int integer)
        // {
        //     if (integer % 5 == 0)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
        //
        // public bool BothTest(int integer)
        // {
        //     if (integer % 3 == 0 && integer % 5 == 0)
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         return false;
        //     }
        // }
    }
}
