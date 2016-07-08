using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_key_recovery_tool
{
    class Utils
    {

        public static void LogArrayHex(int[] key)
        {

            for (int i = 0; i < key.Length; i++)
            {
                Console.Write("{0:X2} ", key[i]);
            }
            Console.WriteLine();
        }

        public int Binomial(int n, int k)
        {
            if (k > n || n < 0)
            {
                return 0;
            }
            int result = 1;
            if (k == n || k == 0)
            {
                return 1;
            }
            int kk = k;

            if (k > (n - k)) //n over k = n over n-k
            {
                kk = n - k;
            }

            //n! / (k! *(n-k)!) = n*(n-1)*...*(n-k+1)	/ (1*2*...*k)
            for (int i = 0; i < kk; i++)
            {
                result = result * (n - i);
                result = result / (i + 1);
            }

            return result;
        }


        public static double[,,] copyArray3D(double[,,] array, int x, int y, int z)
        {
            double[,,] result = new double[x, y, z];
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    for (int k = 0; k < z; k++)
                        result[i, j, k] = array[i, j, k];

            return result;
        }
    }

    public struct KeyByteWeight
    {
        public int keyByte;
        public double weight;

        public KeyByteWeight(int keyByte, double weight)
        {
            this.keyByte = keyByte;
            this.weight = weight;
        }
    }

    public class KeyByteWeightComparer : IComparer<KeyByteWeight>
    {

        public int Compare(KeyByteWeight x, KeyByteWeight y)
        {
            if (x.weight == y.weight)
                return 0;
            if (x.weight > y.weight)
                return -1;

            return 1;
        }
    }
}
