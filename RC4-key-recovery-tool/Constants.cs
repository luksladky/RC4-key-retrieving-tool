using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_key_recovery_tool
{
    class AlgorithmParameters
    {
        public int m;
        public int nc;

        public AlgorithmParameters(int m, int nc)
        {
            this.m = m;
            this.nc = nc;
        }
    }

    class Constants
    {
        public const int N = 256;
        public const int sumAllKeyBytesDepth = 4;

        public const int updateGroupLength = 4;

        public const double prob_th = 0.01;
        public const double prob_diff_boost = 1.5;

        public static readonly AlgorithmParameters[] defaults = {null,null, null, null, null,
            new AlgorithmParameters(3,256), //5
            null, null, new AlgorithmParameters(4,8), //8
            null, new AlgorithmParameters(6,8), // 10
            null, new AlgorithmParameters(8,8), //12
            null,null,null, new AlgorithmParameters(12,16), //16}
            null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null,null
        };
    }
}
