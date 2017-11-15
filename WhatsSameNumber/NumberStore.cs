using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatsSameNumber
{
    class NumberStore
    {
        List<int> _numbers = new List<int>();

        public NumberStore()
        {
        }

        public string CreateNumbers(int maxNumber = 4)
        {
            try
            {
                _numbers.Clear();
                Random random = new Random();
                int tempNubmer = maxNumber/2;
                while (tempNubmer > 0)
                {
                    int randomNumber = random.Next(1, maxNumber);
                    if (_numbers.Any(x => x == randomNumber))
                        continue;

                    _numbers.Add(randomNumber);
                    _numbers.Add(randomNumber);
                    tempNubmer -= 1;
                }

                _numbers = ShuffleList(_numbers);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return null;
        }

        List<int> ShuffleList(List<int> inputList) 
        {
            List<int> randomList = new List<int>();

            Random random = new Random();
            int randomIndex = 0;

            while (inputList.Count > 0)
            {
                randomIndex = random.Next(0, inputList.Count);
                randomList.Add(inputList[randomIndex]);
                inputList.RemoveAt(randomIndex);
            }

            return randomList;
        }

        public List<int> Numbers
        {
            get
            {
                return _numbers;
            }
        }
    }
}
