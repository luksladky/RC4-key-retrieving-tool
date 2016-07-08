using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_key_recovery_tool
{
    class Constants
    {
        public const int N = 256;
        public const int sumAllKeyBytesDepth = 4;

        public const int updateGroupLength = 4;

        public const double prob_th = 0.01;
        public const double prob_diff_boost = 1.5;
    }
}
