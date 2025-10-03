﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NeupokoevSV.Sprint2.Task1.V22.Lib
{
    public class DataService : ISprint2Task1V22
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a == (c + 70)) | (b > d);
            res[1] = (a != b) & (c > d);
            res[2] = (a < b) || (c > d);
            res[3] = (a  > b) && (c >= d);
            res[4] = !res[0];
            res[5] = (a >= b) ^ (c < d);
            return res;
        }
    }
}
