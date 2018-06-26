using System;
using System.Collections.Generic;

namespace PingPongGame
{
    public class PingPong
    {
        private List<int> _rangeList = new List<int>();
        private List<string> _finalList = new List<string>();

        public bool IsInteger(string input)
        {
            int num;
            bool result = int.TryParse(input, out num);
            return result;
        }

        public List<int> PopulateRangeList(string input)
        {
            int integer = int.Parse(input);
            for (int i = 1; i <= integer; i++)
            {
                _rangeList.Add(i);
            }
            return _rangeList;
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

        public List<string> PopulateResultsList(string input)
        {
            _rangeList = PopulateRangeList(input);
            for (int i = 0; i < _rangeList.Count; i++)
            {
                _finalList.Add(PingPongTest(_rangeList[i]));
            }
            return _finalList;
        }
    }
}
