using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategyTest
{
    public class MultiLayerTrainingSet
    {
        private static int[] num0 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num01 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num02 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num03 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num04 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num05 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num06 = { 1, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0, 1, 1, 1, 1 };

        private static int[] num1 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num11 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num12 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num13 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num14 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num15 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num16 = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };

        private static int[] num2 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num21 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num22 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num23 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num24 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num25 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        private static int[] num26 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };

        private static int[] num3 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num31 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num32 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num33 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num34 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num35 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num36 = { 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };

        private static int[] num4 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num41 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num42 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num43 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num44 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num45 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num46 = { 1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 1 };

        private static int[] num5 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num51 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num52 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num53 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num54 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num55 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num56 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1 };

        private static int[] num6 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num61 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num62 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num63 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num64 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num65 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num66 = { 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1 };

        private static int[] num7 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num71 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num72 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num73 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num74 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num75 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };
        private static int[] num76 = { 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1 };

        private static int[] num8 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num81 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num82 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num83 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num84 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num85 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        private static int[] num86 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };

        private static int[] num9 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num91 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num92 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num93 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num94 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num95 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };
        private static int[] num96 = { 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1 };

        public int[][] nums = { num0, num01, num02, num03, num04, num05, num06,
                                num1, num11, num12, num13, num14, num15, num16,
                                num2, num21, num22, num23, num24, num25, num26,
                                num3, num31, num32, num33, num34, num35, num36,
                                num4, num41, num42, num43, num44, num45, num46,
                                num5, num51, num52, num53, num54, num55, num56,
                                num6, num61, num62, num63, num64, num65, num66,
                                num7, num71, num72, num73, num74, num75, num76,
                                num8, num81, num82, num83, num84, num85, num86,
                                num9, num91, num92, num93, num94, num95, num96 };
    }
}
