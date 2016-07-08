﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RC4_key_recovery_tool
{
    class Weights
    {
        public static readonly double[] JS =
        {
            0.3708012, 0.3668428, 0.36436, 0.3639024, 0.364697, 0.35993,
            0.3598548, 0.3574639, 0.359362, 0.357061, 0.3530676, 0.3548021,
            0.3520392, 0.3516725, 0.3473542, 0.3487007, 0.3475667, 0.3453994,
            0.3414811, 0.3417829, 0.3412372, 0.3405327, 0.3376485, 0.3367261,
            0.3335365, 0.3343181, 0.3318144, 0.3314887, 0.3294659, 0.3346581,
            0.3275621, 0.3244505, 0.3235858, 0.3224388, 0.3223539, 0.3194742,
            0.316631, 0.317461, 0.3154539, 0.3110369, 0.31192, 0.3103517,
            0.3088558, 0.3078778, 0.3117473, 0.3062447, 0.3038079, 0.3008669,
            0.3001922, 0.2951171, 0.2967155, 0.2969246, 0.294332, 0.2922569,
            0.2922964, 0.2904728, 0.2899096, 0.2878556, 0.2855383, 0.2811463,
            0.2822446, 0.2824226, 0.2807538, 0.2787941, 0.2782391, 0.2756852,
            0.274127, 0.2729125, 0.2713894, 0.2715197, 0.2698049, 0.2667019,
            0.2645341, 0.2640002, 0.2629208, 0.2616304, 0.2603622, 0.2583488,
            0.2565279, 0.2563727, 0.2544223, 0.2537854, 0.2520719, 0.2497865,
            0.2491373, 0.2475291, 0.2469218, 0.2442225, 0.2430874, 0.2417069,
            0.2399948, 0.2388703, 0.2374831, 0.2358377, 0.2343582, 0.2328463,
            0.2320279, 0.2305167, 0.2287249, 0.2273832, 0.2258734, 0.2245188,
            0.2228765, 0.2217629, 0.2206705, 0.2190139, 0.2173579, 0.2159165,
            0.2144948, 0.2131144, 0.2115766, 0.2104146, 0.2090013, 0.2071587,
            0.2060626, 0.204673, 0.2033564, 0.2018279, 0.2001729, 0.1987505,
            0.1974713, 0.195888, 0.1945554, 0.1930731, 0.1917419, 0.1901566,
            0.1888257, 0.1875443, 0.1862536, 0.1845039, 0.1830789, 0.1818387,
            0.1805136, 0.1788573, 0.1774076, 0.176109, 0.1747725, 0.1731535,
            0.171661, 0.1701961, 0.1689713, 0.1672643, 0.1661679, 0.1646785,
            0.1631223, 0.1616396, 0.1601357, 0.1587372, 0.1573001, 0.1558738,
            0.1545718, 0.1532355, 0.151822, 0.150265, 0.1488573, 0.1475279,
            0.1460914, 0.1446014, 0.1434111, 0.1415421, 0.1403434, 0.1391098,
            0.1375247, 0.1360202, 0.134734, 0.1332999, 0.1317849, 0.1301957,
            0.1290888, 0.1275983, 0.1260284, 0.1246477, 0.1230987, 0.12184,
            0.1206388, 0.1189721, 0.117525, 0.116119, 0.1145108, 0.1131851,
            0.1116441, 0.1104402, 0.1090644, 0.1075461, 0.1062856, 0.1047198,
            0.1033072, 0.1020106, 0.1004664, 0.0990736, 0.0977185, 0.0961745,
            0.0946612, 0.0933128, 0.0919102, 0.0904245, 0.0889459, 0.0877742,
            0.0862005, 0.0848579, 0.0831644, 0.0819414, 0.0805425, 0.079071,
            0.0775743, 0.0761206, 0.0747811, 0.0733259, 0.0718756, 0.0705436,
            0.0689978, 0.0676575, 0.0662126, 0.0648457, 0.0633807, 0.0620497,
            0.0606492, 0.0591417, 0.0576598, 0.0562197, 0.0548481, 0.0534452,
            0.0519809, 0.050524, 0.049101, 0.0476358, 0.0462675, 0.0448588,
            0.043456, 0.0420125, 0.0405254, 0.0391936, 0.0377574, 0.0362742,
            0.0348576, 0.0334449, 0.031971, 0.0305913, 0.0291677, 0.0276445,
            0.0263405, 0.0247503, 0.0234363, 0.0220391, 0.0206374, 0.0191987,
            0.0177304, 0.0163209, 0.0148794, 0.0134807, 0.0121107, 0.0105823,
            0.0092153, 0.0077464, 0.0063065, 0.0049518
        };

        public static readonly double[] JInvS =
        {
            0.0049811, 0.0063357, 0.0077595, 0.0092615, 0.0104824, 0.0120796,
            0.0135134, 0.0149684, 0.016434, 0.0182167, 0.0191807, 0.0206532,
            0.02212, 0.0235404, 0.0251577, 0.0262898, 0.0276776, 0.0290614,
            0.0306283, 0.0314132, 0.0337773, 0.0346277, 0.0362241, 0.037603,
            0.0411053, 0.0406021, 0.0418263, 0.0434944, 0.0451505, 0.0389665,
            0.0474099, 0.0493637, 0.0509621, 0.0526293, 0.0512838, 0.0542997,
            0.0572819, 0.0569382, 0.0578603, 0.0634336, 0.062544, 0.0629394,
            0.0639664, 0.0670304, 0.061693, 0.0673203, 0.0704353, 0.0720917,
            0.0736586, 0.0788112, 0.0766448, 0.076813, 0.0793027, 0.0807902,
            0.081246, 0.0834767, 0.0841699, 0.0854025, 0.0875856, 0.093106,
            0.0917519, 0.090782, 0.0919926, 0.0945968, 0.0951936, 0.0977676,
            0.0985337, 0.1008863, 0.1023671, 0.1005196, 0.1030517, 0.1070783,
            0.1101534, 0.1095544, 0.1110499, 0.1113741, 0.1142909, 0.1151752,
            0.1166258, 0.1166265, 0.1200692, 0.1196567, 0.1209223, 0.1232551,
            0.1253486, 0.1256727, 0.1267943, 0.1281872, 0.1311027, 0.1316652,
            0.1334051, 0.1334929, 0.1368138, 0.1369574, 0.1382905, 0.1396041,
            0.1426525, 0.1423482, 0.1443675, 0.1456812, 0.1476415, 0.1483006,
            0.1505882, 0.1502477, 0.1539614, 0.1539429, 0.1560167, 0.1565286,
            0.1597953, 0.1598304, 0.1613978, 0.163143, 0.1656872, 0.1659992,
            0.1677851, 0.1681663, 0.1711814, 0.1719978, 0.172524, 0.1743835,
            0.1761057, 0.1774018, 0.1785239, 0.179957, 0.1816447, 0.1823799,
            0.1844698, 0.1857211, 0.1875245, 0.1882727, 0.1908266, 0.1918966,
            0.1942398, 0.194035, 0.1965551, 0.1964134, 0.1997637, 0.1999122,
            0.2020322, 0.2028134, 0.2047262, 0.205388, 0.2067662, 0.2085547,
            0.2117356, 0.2110234, 0.2131306, 0.2142566, 0.2167399, 0.2169714,
            0.2193064, 0.2191243, 0.2226984, 0.2218782, 0.2242441, 0.2254644,
            0.2283827, 0.2282918, 0.2302967, 0.2310167, 0.234944, 0.2339129,
            0.2355837, 0.236866, 0.2400419, 0.2400506, 0.2413805, 0.2427172,
            0.2459355, 0.2447218, 0.2473246, 0.2482003, 0.2506805, 0.2505789,
            0.2531512, 0.2531924, 0.2570801, 0.2566811, 0.2575877, 0.2595616,
            0.2618522, 0.262212, 0.2645722, 0.2651643, 0.2679564, 0.2686923,
            0.2700404, 0.2707308, 0.2741995, 0.2735888, 0.2754777, 0.27672,
            0.280712, 0.2789992, 0.2820667, 0.2822505, 0.2855906, 0.2850946,
            0.287513, 0.287371, 0.2922836, 0.2904656, 0.2925797, 0.2936932,
            0.2980826, 0.2959636, 0.2990385, 0.2988922, 0.302478, 0.3024944,
            0.3047084, 0.3052435, 0.3091346, 0.307252, 0.3101507, 0.3115861,
            0.3147309, 0.3139913, 0.3162667, 0.3164215, 0.3212634, 0.3193276,
            0.3215374, 0.3223305, 0.3266743, 0.3255606, 0.3277183, 0.3292509,
            0.3307489, 0.3313351, 0.3332337, 0.3339755, 0.3381895, 0.3367526,
            0.3388326, 0.3400527, 0.3432619, 0.3414399, 0.34317, 0.3449769,
            0.3493474, 0.3472773, 0.3500973, 0.3495182, 0.3546251, 0.3539897,
            0.3554677, 0.3573618, 0.3603495, 0.3586391, 0.3603055, 0.3630929,
            0.365996, 0.3644622, 0.3661195, 0.367874
        };

        public static readonly double[] JSS = 
        {
            0.136625, 0.1362306, 0.1356353, 0.1352195, 0.1346263, 0.1342992,
            0.1335666, 0.133292, 0.1327648, 0.1340151, 0.1316732, 0.1311154,
            0.1305851, 0.1299773, 0.1295264, 0.1289056, 0.128545, 0.1279156,
            0.1275628, 0.1260702, 0.126328, 0.1258997, 0.1252675, 0.1249436,
            0.1233425, 0.1237333, 0.1235404, 0.1227776, 0.1224918, 0.1244488,
            0.1214862, 0.120744, 0.1202253, 0.1195908, 0.1197689, 0.1187512,
            0.1180605, 0.1181849, 0.1174364, 0.1159785, 0.1161242, 0.1159032,
            0.1155015, 0.1146945, 0.1161378, 0.1140133, 0.1132854, 0.1123725,
            0.1121924, 0.1103397, 0.1108349, 0.1106896, 0.1098692, 0.1090779,
            0.1089776, 0.1081999, 0.1083459, 0.1077782, 0.1067307, 0.105103,
            0.1054554, 0.105567, 0.1052324, 0.1043115, 0.1041949, 0.1031656,
            0.1026854, 0.102125, 0.10174, 0.102089, 0.1009845, 0.0998564,
            0.0992481, 0.0989641, 0.0987022, 0.0982647, 0.0976372, 0.0970439,
            0.0962296, 0.0962483, 0.0955999, 0.095198, 0.0947518, 0.094136,
            0.0936647, 0.0930687, 0.0925316, 0.0919774, 0.0914686, 0.0909227,
            0.0904457, 0.0899945, 0.0895156, 0.0889749, 0.0884965, 0.0877863,
            0.0876319, 0.0868275, 0.0863518, 0.0857496, 0.0853172, 0.0847232,
            0.0843915, 0.0837391, 0.0832342, 0.0828218, 0.082375, 0.0818302,
            0.0812252, 0.0806445, 0.0801428, 0.0797157, 0.0792602, 0.0785756,
            0.0782201, 0.0775142, 0.0772331, 0.0765005, 0.0762106, 0.0755045,
            0.0750356, 0.0747163, 0.0739169, 0.0734501, 0.0728423, 0.0724769,
            0.0719284, 0.071437, 0.0708527, 0.0703369, 0.0698557, 0.0693325,
            0.0686443, 0.0682347, 0.0678657, 0.0674701, 0.066856, 0.0662944,
            0.0658799, 0.0653382, 0.0646749, 0.0642471, 0.0637221, 0.0631584,
            0.0626522, 0.0622485, 0.0616233, 0.0611592, 0.0606354, 0.0601915,
            0.0595648, 0.0591345, 0.0586487, 0.0581242, 0.0574534, 0.0569054,
            0.0564847, 0.0558954, 0.0553778, 0.0549976, 0.054504, 0.0539876,
            0.0535257, 0.0528385, 0.0523423, 0.051965, 0.0513595, 0.0507393,
            0.050475, 0.0497463, 0.0491948, 0.0488066, 0.0482323, 0.04774,
            0.0471382, 0.0467455, 0.0462595, 0.0455423, 0.0451515, 0.0447126,
            0.044112, 0.0437279, 0.0431002, 0.0426391, 0.0421436, 0.041516,
            0.0410309, 0.0405997, 0.0399635, 0.0395773, 0.0389911, 0.0384069,
            0.0380214, 0.0374326, 0.0369024, 0.0363455, 0.0359816, 0.0353505,
            0.0348139, 0.034385, 0.0337518, 0.0332348, 0.0328212, 0.0322403,
            0.0317822, 0.0312355, 0.0307705, 0.030163, 0.0297392, 0.0291632,
            0.0286204, 0.0281051, 0.0276879, 0.0271275, 0.0267054, 0.0261986,
            0.0256237, 0.0250678, 0.0244907, 0.0239995, 0.0235399, 0.0230118,
            0.0225537, 0.0219926, 0.0214733, 0.0210018, 0.0205076, 0.0199655,
            0.0194112, 0.0189481, 0.018403, 0.0179847, 0.01737, 0.0168969,
            0.0163393, 0.015815, 0.0153425, 0.0147495, 0.0141656, 0.0137911,
            0.0131973, 0.0127649, 0.0122194, 0.0116449, 0.0112814, 0.010737,
            0.0101754, 0.0096329, 0.0091594, 0.0086383, 0.0080927, 0.0075661,
            0.0070932, 0.0065741, 0.0060492, 0.0055262
        };
        public static readonly double[] JInvSInvS = 
        {
            0.0055266, 0.0060364, 0.0065594, 0.0070848, 0.0075605, 0.0080764,
            0.0086052, 0.009129, 0.009647, 0.0114189, 0.0105834, 0.0111005,
            0.0117064, 0.0122027, 0.012695, 0.0131927, 0.0137606, 0.0142379,
            0.0147278, 0.0145589, 0.0157925, 0.0161676, 0.0167321, 0.0172303,
            0.0181415, 0.0183533, 0.0189572, 0.0194537, 0.0199768, 0.0185331,
            0.0207859, 0.0213272, 0.0219928, 0.022632, 0.0222932, 0.0233816,
            0.0242315, 0.0243283, 0.0246674, 0.0263021, 0.0262883, 0.0264992,
            0.0270386, 0.0278406, 0.0260947, 0.0282416, 0.0292097, 0.0297344,
            0.0302141, 0.0319925, 0.0315788, 0.0315008, 0.0324237, 0.0329977,
            0.0332278, 0.0338041, 0.0341588, 0.0345652, 0.0355141, 0.0375579,
            0.0367361, 0.0366459, 0.0371196, 0.0378585, 0.0378935, 0.0390626,
            0.0395813, 0.0400235, 0.0403862, 0.0402289, 0.04103, 0.0422003,
            0.0432589, 0.0432596, 0.0435193, 0.0440411, 0.0447001, 0.0453381,
            0.0459872, 0.0459845, 0.046943, 0.0469386, 0.0475979, 0.0483238,
            0.0486366, 0.0491152, 0.0497537, 0.0503248, 0.0508513, 0.0514183,
            0.0519134, 0.0523634, 0.0527963, 0.0534173, 0.0538397, 0.0545602,
            0.0548779, 0.0554306, 0.0560671, 0.0565019, 0.0569843, 0.0574063,
            0.0580806, 0.0586483, 0.0591175, 0.0596661, 0.0598066, 0.0603299,
            0.0610539, 0.0615774, 0.0623473, 0.0625629, 0.0632011, 0.0635731,
            0.0642287, 0.0647275, 0.0652533, 0.0658581, 0.0663782, 0.0666597,
            0.0674316, 0.0677826, 0.0681817, 0.0689423, 0.0692852, 0.0699709,
            0.0703899, 0.0709243, 0.0711144, 0.0720318, 0.0724169, 0.0728383,
            0.0734053, 0.0739838, 0.0743275, 0.0750427, 0.0754697, 0.0760761,
            0.0765912, 0.0772147, 0.0776143, 0.0782104, 0.07866, 0.0789737,
            0.0796704, 0.0801665, 0.0807856, 0.0809429, 0.0818176, 0.0823774,
            0.0826891, 0.0832201, 0.0837704, 0.0842082, 0.0848355, 0.0850984,
            0.0858961, 0.0863954, 0.086776, 0.0872564, 0.0879245, 0.0884587,
            0.0888735, 0.0892651, 0.09007, 0.0903601, 0.0910097, 0.0916039,
            0.0920135, 0.0925833, 0.093117, 0.0936356, 0.0940654, 0.0948349,
            0.0950665, 0.0955739, 0.0961391, 0.0968125, 0.0973342, 0.097758,
            0.0982865, 0.0982738, 0.0990272, 0.0996196, 0.100139, 0.100733,
            0.1013016, 0.101704, 0.1025088, 0.1028226, 0.1034342, 0.1038478,
            0.1043569, 0.1050284, 0.1054032, 0.1057912, 0.106541, 0.1067787,
            0.1076872, 0.1081243, 0.108352, 0.1088899, 0.1095899, 0.1102112,
            0.1105538, 0.1110686, 0.1113066, 0.1120565, 0.112643, 0.1129574,
            0.1133891, 0.1139222, 0.1145896, 0.115141, 0.1157409, 0.1160831,
            0.1167682, 0.1173067, 0.1177666, 0.1182734, 0.118658, 0.1190595,
            0.1197098, 0.1203223, 0.121011, 0.1214527, 0.1218417, 0.1222311,
            0.1228511, 0.1231151, 0.1238537, 0.1241775, 0.1248761, 0.1255601,
            0.1259123, 0.1265877, 0.1269461, 0.1272328, 0.128109, 0.1285342,
            0.1290077, 0.1293504, 0.1301299, 0.1307515, 0.1312239, 0.1317196,
            0.1321861, 0.1324633, 0.1333755, 0.1338857, 0.1343868, 0.1348298,
            0.1354622, 0.1358786, 0.13638, 0.1368303
        };

        public static readonly double[] JSSS = 
        {
            0.0769277, 0.0769442, 0.0767693, 0.0764352, 0.0761644, 0.0761362,
            0.075742, 0.0755019, 0.0750656, 0.0763741, 0.074611, 0.0740046,
            0.0739455, 0.0737546, 0.0736316, 0.0729507, 0.0727615, 0.0724405,
            0.0722431, 0.0710713, 0.0715274, 0.0712442, 0.0710075, 0.0709025,
            0.0698646, 0.0702304, 0.0700496, 0.0695865, 0.0696027, 0.0707328,
            0.0688791, 0.0684974, 0.0682691, 0.0677123, 0.0679545, 0.067541,
            0.0669716, 0.0671637, 0.0667487, 0.0662419, 0.0660415, 0.0659592,
            0.0657281, 0.0651233, 0.066479, 0.0649996, 0.0644762, 0.0643747,
            0.0638267, 0.0630501, 0.0632009, 0.0632023, 0.0626885, 0.0625997,
            0.0622543, 0.0618322, 0.0618287, 0.0616048, 0.0611899, 0.0602181,
            0.0604301, 0.0604012, 0.0602551, 0.0598496, 0.0599176, 0.0592162,
            0.0589655, 0.0584999, 0.0584941, 0.0585414, 0.0582398, 0.0574529,
            0.0570006, 0.0569884, 0.0567542, 0.0565386, 0.0561632, 0.0558421,
            0.0554955, 0.0555087, 0.0550135, 0.0549782, 0.0546798, 0.0540928,
            0.0539933, 0.0537994, 0.0534232, 0.0531399, 0.0528815, 0.0526868,
            0.0523146, 0.0520027, 0.0518093, 0.0514208, 0.0511695, 0.0509452,
            0.0507327, 0.0504362, 0.0500584, 0.0499299, 0.0496471, 0.0492402,
            0.0490275, 0.0485828, 0.0484474, 0.0481371, 0.0479612, 0.04759,
            0.0473919, 0.0469777, 0.0468472, 0.0465209, 0.0461112, 0.0459862,
            0.0457247, 0.045526, 0.0451943, 0.0449255, 0.0445014, 0.0444317,
            0.044105, 0.0436724, 0.0434497, 0.0432093, 0.0429836, 0.0426165,
            0.0422978, 0.0420572, 0.0417867, 0.0414857, 0.0413435, 0.0410037,
            0.0406503, 0.0403912, 0.0400723, 0.0398723, 0.0396244, 0.0393324,
            0.0389761, 0.0387759, 0.038518, 0.0380899, 0.037971, 0.0376852,
            0.0373466, 0.0371596, 0.0368256, 0.0365948, 0.0363409, 0.0360427,
            0.0357365, 0.0354833, 0.035248, 0.034907, 0.0346406, 0.0344089,
            0.034083, 0.0338428, 0.0335484, 0.033226, 0.0329727, 0.0325859,
            0.0324066, 0.0321452, 0.031805, 0.0315351, 0.0313663, 0.0310756,
            0.0307543, 0.0304261, 0.030214, 0.0299626, 0.0295603, 0.0293348,
            0.0290377, 0.0287367, 0.0285243, 0.0281612, 0.0279289, 0.0276624,
            0.0274515, 0.0271016, 0.0268936, 0.0267255, 0.0263145, 0.0259214,
            0.0258384, 0.0253704, 0.0251751, 0.0249927, 0.0247041, 0.0243497,
            0.0241701, 0.0238113, 0.0235062, 0.0232163, 0.0229194, 0.0227343,
            0.0224697, 0.0220855, 0.0218816, 0.0216004, 0.0214092, 0.0209888,
            0.0208096, 0.0204467, 0.0201923, 0.0199031, 0.0196529, 0.0193297,
            0.0190939, 0.0188105, 0.0186053, 0.0183308, 0.0180402, 0.0177107,
            0.0174201, 0.0171271, 0.0168704, 0.0165999, 0.0163322, 0.0160228,
            0.0157837, 0.0155003, 0.0152927, 0.014946, 0.0146449, 0.0143706,
            0.0141885, 0.0138286, 0.0135744, 0.0133692, 0.0130253, 0.0127194,
            0.0124767, 0.0121814, 0.0118102, 0.0115971, 0.0113742, 0.0110467,
            0.0108315, 0.0104688, 0.0102354, 0.0100229, 0.0096626, 0.0094094,
            0.0091147, 0.0088805, 0.008611, 0.0083219, 0.0080044, 0.0077485,
            0.0075272, 0.0071754, 0.0069351, 0.0066723
        };
        public static readonly double[] JInvSInvSInvS =
        {
            0.0064551, 0.0069572, 0.0071839, 0.0074734, 0.0077329, 0.0080481,
            0.008276, 0.0085838, 0.0088483, 0.0104047, 0.0092695, 0.0096138,
            0.0099519, 0.0102385, 0.0105122, 0.0107832, 0.0110734, 0.0113024,
            0.0115551, 0.011126, 0.0120983, 0.0122945, 0.0126307, 0.0129761,
            0.0132162, 0.0135653, 0.0138024, 0.0141337, 0.0143665, 0.0139005,
            0.0148658, 0.0150882, 0.0155495, 0.0158183, 0.0155847, 0.0162415,
            0.016732, 0.0167148, 0.0170352, 0.017759, 0.0177921, 0.0177895,
            0.0181863, 0.0186278, 0.017737, 0.0188612, 0.0193204, 0.0196252,
            0.0198886, 0.0208228, 0.0206647, 0.0207407, 0.0211671, 0.0213971,
            0.0215022, 0.0218929, 0.0220086, 0.0222317, 0.0227448, 0.0239033,
            0.0234626, 0.0233737, 0.0235397, 0.0241044, 0.0241242, 0.0246828,
            0.0250118, 0.0252678, 0.0254235, 0.025287, 0.0258215, 0.0264327,
            0.0267295, 0.0269602, 0.0270534, 0.0273592, 0.0277235, 0.027855,
            0.0283752, 0.0284834, 0.028841, 0.0289222, 0.0293672, 0.0297038,
            0.0296074, 0.0302182, 0.0304026, 0.0307074, 0.0309542, 0.0314031,
            0.0315487, 0.0318395, 0.03198, 0.0324718, 0.032631, 0.0330098,
            0.0331912, 0.0334967, 0.0338789, 0.0340865, 0.0342527, 0.0346136,
            0.0349932, 0.0353226, 0.0354449, 0.0357282, 0.0360144, 0.0362028,
            0.0364433, 0.036848, 0.0371178, 0.0373447, 0.0374365, 0.0379238,
            0.0381677, 0.038419, 0.0386513, 0.0390809, 0.0392834, 0.039629,
            0.0398328, 0.0400686, 0.0404339, 0.0407743, 0.0411454, 0.0412658,
            0.0415736, 0.0418217, 0.0419485, 0.0424314, 0.0427322, 0.0429482,
            0.0431773, 0.0434505, 0.0436427, 0.0440733, 0.0441321, 0.0445309,
            0.0447484, 0.0451902, 0.0455066, 0.0456426, 0.0459359, 0.046221,
            0.0465369, 0.0468271, 0.0472011, 0.0472825, 0.0476625, 0.0479492,
            0.0481988, 0.0486033, 0.0487146, 0.0491607, 0.0493887, 0.0495799,
            0.0499232, 0.0500228, 0.0504568, 0.0507716, 0.0510311, 0.0512659,
            0.0516201, 0.0519028, 0.0519085, 0.0522642, 0.0526862, 0.0528404,
            0.0530098, 0.0535941, 0.0538239, 0.0540424, 0.0542986, 0.0545587,
            0.0547847, 0.0551998, 0.0553038, 0.0557065, 0.0560251, 0.0562044,
            0.0566502, 0.0567817, 0.0570004, 0.0574164, 0.0575601, 0.0579815,
            0.0582122, 0.0584463, 0.0584713, 0.0589812, 0.0592447, 0.0595294,
            0.0596846, 0.0601588, 0.0603508, 0.0608012, 0.0609273, 0.0612994,
            0.0613847, 0.0618994, 0.0619782, 0.0623594, 0.0627294, 0.06291,
            0.0630108, 0.0635545, 0.0636459, 0.0640934, 0.0641278, 0.0645463,
            0.0647114, 0.0650926, 0.0651366, 0.0655639, 0.0658682, 0.0661536,
            0.0662588, 0.0667341, 0.0670119, 0.0674335, 0.0674018, 0.0680329,
            0.0680868, 0.068335, 0.0684225, 0.068806, 0.0691752, 0.0694029,
            0.0697723, 0.0700292, 0.0703728, 0.0704416, 0.0709041, 0.0712027,
            0.0714262, 0.071653, 0.071945, 0.072217, 0.0724859, 0.0728052,
            0.0730807, 0.0734832, 0.0737706, 0.0740906, 0.0741622, 0.0744662,
            0.0747558, 0.0749993, 0.07507, 0.0756846, 0.0760048, 0.0762173,
            0.0761226, 0.0766933, 0.0769009, 0.0773266
        };

        public static readonly double[] JSSSS = 
        {
            0.0518017, 0.0518781, 0.0515894, 0.0515335, 0.05112, 0.0511885,
            0.0508354, 0.0508248, 0.0504052, 0.0521779, 0.0502925, 0.049742,
            0.0497451, 0.0494611, 0.0495677, 0.0491168, 0.0488869, 0.0487553,
            0.0487529, 0.0473155, 0.0481715, 0.0480484, 0.0478798, 0.0479525,
            0.0468544, 0.0474919, 0.0472243, 0.0471449, 0.0468569, 0.0480278,
            0.0464773, 0.0461894, 0.0461479, 0.0458052, 0.0457696, 0.0454979,
            0.0452641, 0.0452857, 0.0450202, 0.0450473, 0.0446387, 0.0446563,
            0.0445094, 0.0442292, 0.0448243, 0.0439117, 0.0435999, 0.0434857,
            0.0433525, 0.0427149, 0.0429808, 0.0426722, 0.0424762, 0.0422909,
            0.0422411, 0.0420953, 0.0420788, 0.0418327, 0.041415, 0.0409674,
            0.0410028, 0.041145, 0.0409755, 0.0406152, 0.0405862, 0.0401707,
            0.0402142, 0.0398885, 0.039936, 0.0398042, 0.0394995, 0.03908,
            0.0388984, 0.0389125, 0.0386711, 0.0384667, 0.038367, 0.0380922,
            0.0378416, 0.0378227, 0.0374208, 0.0375201, 0.0372454, 0.036993,
            0.0369631, 0.0367511, 0.0364902, 0.0364658, 0.0361961, 0.0359582,
            0.0358564, 0.0357043, 0.0353813, 0.0353079, 0.0351359, 0.0349299,
            0.0347829, 0.0346184, 0.0343572, 0.0341355, 0.0339884, 0.0338397,
            0.0336642, 0.0334504, 0.0333177, 0.0331487, 0.0329727, 0.0328631,
            0.0325599, 0.0323778, 0.0322663, 0.0322104, 0.0318355, 0.0317517,
            0.0315815, 0.0313647, 0.0312013, 0.0309748, 0.0307681, 0.0307202,
            0.0304796, 0.0301685, 0.0300906, 0.0299549, 0.029697, 0.0296419,
            0.0294546, 0.029182, 0.0290237, 0.0288041, 0.0287114, 0.0284003,
            0.0282711, 0.0281497, 0.0279684, 0.0278532, 0.0277267, 0.0274223,
            0.0271394, 0.0270951, 0.0268741, 0.0266721, 0.0266137, 0.0262904,
            0.0262454, 0.0259997, 0.0258041, 0.0255254, 0.0254196, 0.0253223,
            0.0251187, 0.0248247, 0.0247586, 0.0246074, 0.0243542, 0.0241947,
            0.0241016, 0.0238895, 0.02367, 0.0234803, 0.0233189, 0.0231159,
            0.022866, 0.022746, 0.0226171, 0.022434, 0.0222683, 0.0220559,
            0.0218964, 0.0217331, 0.0214988, 0.0212879, 0.021163, 0.021004,
            0.0206986, 0.0205941, 0.0204191, 0.0201917, 0.0200644, 0.0198289,
            0.0198041, 0.0194947, 0.0193549, 0.0192524, 0.0189151, 0.0188211,
            0.0186437, 0.0185047, 0.0182575, 0.0181358, 0.0179338, 0.0177259,
            0.0175957, 0.0173397, 0.0172232, 0.0170793, 0.0169297, 0.0166186,
            0.0164442, 0.0162859, 0.0161448, 0.015876, 0.0157289, 0.0156207,
            0.0154301, 0.015164, 0.0150256, 0.0148458, 0.014791, 0.014539,
            0.0143177, 0.0141078, 0.0139715, 0.0138073, 0.0136273, 0.0134253,
            0.0133066, 0.0130993, 0.0128369, 0.0127666, 0.0125603, 0.0123256,
            0.0122091, 0.0120414, 0.0119027, 0.0116154, 0.0114908, 0.0112696,
            0.0111225, 0.0109009, 0.010755, 0.0105651, 0.0104333, 0.0102182,
            0.0100678, 0.0099029, 0.0096568, 0.0094897, 0.0092591, 0.0091657,
            0.0089464, 0.0087783, 0.0086611, 0.0084188, 0.0082867, 0.0080806,
            0.0078918, 0.0076725, 0.007511, 0.0073554, 0.0072018, 0.0069721,
            0.0068229, 0.0066121, 0.0064213, 0.0063291
        };

        public static readonly double[] JInvSInvSInvSInvS = 
        {
            0.0062578, 0.0064713, 0.0066386, 0.0068426, 0.0069438, 0.0071719,
            0.0073084, 0.0075261, 0.0077778, 0.0096272, 0.0079638, 0.0082073,
            0.0083709, 0.0085378, 0.0087931, 0.0088965, 0.0091235, 0.0092957,
            0.0094285, 0.0086603, 0.0097718, 0.0098972, 0.0101092, 0.0103276,
            0.0102067, 0.0107754, 0.0109453, 0.0111401, 0.0113243, 0.0111915,
            0.0116056, 0.0116581, 0.0119996, 0.0122162, 0.0119431, 0.0124701,
            0.0127284, 0.0128899, 0.0129603, 0.0134791, 0.0134351, 0.0134784,
            0.0137337, 0.0141136, 0.0134028, 0.0141553, 0.014396, 0.0146328,
            0.0148399, 0.0154502, 0.0153987, 0.0153298, 0.015612, 0.0158193,
            0.0158867, 0.0161375, 0.0162745, 0.0163517, 0.0166992, 0.0174565,
            0.0172119, 0.017117, 0.0172355, 0.0175622, 0.0174784, 0.018019,
            0.0181492, 0.0183453, 0.0183845, 0.0183619, 0.0186185, 0.0191052,
            0.0192662, 0.0194077, 0.0194291, 0.0196779, 0.0198975, 0.0200472,
            0.0202705, 0.0204371, 0.0206196, 0.020756, 0.0209828, 0.0211984,
            0.0211486, 0.0214858, 0.0217146, 0.0218838, 0.0219806, 0.0222356,
            0.0224025, 0.0225728, 0.0226898, 0.0229964, 0.0231997, 0.0233796,
            0.0233499, 0.0236457, 0.023756, 0.0240163, 0.0242751, 0.0243802,
            0.0245141, 0.0247789, 0.0247896, 0.0250689, 0.0252027, 0.0254301,
            0.0255485, 0.0257858, 0.0260325, 0.0261745, 0.026214, 0.0265379,
            0.0266443, 0.0269284, 0.0270422, 0.0272501, 0.0273257, 0.0275362,
            0.0277764, 0.0280136, 0.0280718, 0.0281888, 0.0285232, 0.0288024,
            0.0288407, 0.0290524, 0.0291642, 0.0294578, 0.0294839, 0.0297857,
            0.0298964, 0.0301548, 0.0302195, 0.030566, 0.0305895, 0.0307535,
            0.0309735, 0.0311913, 0.0313256, 0.0315474, 0.0316901, 0.0320542,
            0.0319587, 0.0322629, 0.0323693, 0.0326352, 0.0328822, 0.0330263,
            0.0331833, 0.0334355, 0.0333761, 0.0337408, 0.0338926, 0.0340674,
            0.0341795, 0.0343556, 0.034563, 0.0347363, 0.0347805, 0.0351196,
            0.0352989, 0.0355347, 0.0355689, 0.0359204, 0.0358589, 0.0362088,
            0.036274, 0.0365344, 0.0366025, 0.0369554, 0.0369878, 0.0373479,
            0.0373666, 0.0377223, 0.0377738, 0.0379788, 0.0382529, 0.0383612,
            0.0384965, 0.0387671, 0.0388943, 0.0389825, 0.0391499, 0.0393675,
            0.0396385, 0.0398447, 0.0399049, 0.0401147, 0.0403171, 0.0405855,
            0.0406157, 0.0409352, 0.0409697, 0.0412722, 0.0413627, 0.0414841,
            0.0416707, 0.042009, 0.0420696, 0.0423835, 0.042515, 0.0426641,
            0.0426744, 0.0431327, 0.0431505, 0.0433672, 0.0435532, 0.0437535,
            0.04384, 0.044119, 0.0442133, 0.0444251, 0.044604, 0.0448652,
            0.0447953, 0.0450347, 0.0452955, 0.0455691, 0.0454897, 0.0459567,
            0.0459883, 0.0462685, 0.0462701, 0.0465624, 0.0466373, 0.046871,
            0.0471606, 0.0472678, 0.0473079, 0.0477531, 0.0476229, 0.047973,
            0.0481852, 0.0483501, 0.0482568, 0.0488316, 0.0489474, 0.049208,
            0.0490612, 0.0494458, 0.0495556, 0.049842, 0.0499617, 0.050205,
            0.0503607, 0.0505152, 0.0506882, 0.0509528, 0.0511158, 0.0511842,
            0.0513393, 0.0516646, 0.0519378, 0.0520398
        };


        public static readonly double[] sumS = 
        {
            0.3709107, 0.3653235, 0.3600969, 0.355458, 0.3508225, 0.33967,
            0.331887, 0.3203038, 0.3124601, 0.2996461, 0.2853603, 0.2739877,
            0.2602227, 0.2458949, 0.2287595, 0.2175581, 0.2039187, 0.188528,
            0.1731526, 0.1589107, 0.1493543, 0.1365494, 0.1235685, 0.1119423,
            0.1007536, 0.0922271, 0.0825471, 0.073549, 0.0657453, 0.0633846,
            0.0520668, 0.0460441, 0.0415158, 0.0365242, 0.031142, 0.0280411,
            0.0243842, 0.0215391, 0.018916, 0.0154237, 0.0143727, 0.0129672,
            0.0110324, 0.009922, 0.0089859, 0.0075907, 0.0067605, 0.0060095,
            0.0056152, 0.0049982, 0.0044078, 0.0042395, 0.003951, 0.0037517,
            0.0035675, 0.0034233, 0.0033371, 0.0033388, 0.0032835, 0.0032755,
            0.0033434, 0.0033758, 0.0034269, 0.003472, 0.0035943, 0.0036441,
            0.0037397, 0.0038249, 0.0039312, 0.0039271, 0.0040467, 0.0041089,
            0.0041135, 0.0041271, 0.0041294, 0.0041158, 0.0040943, 0.0040761,
            0.0040615, 0.0039923, 0.0039767, 0.003931, 0.0039051, 0.0038624,
            0.0038757, 0.0038833, 0.0038613, 0.0038865, 0.0039086, 0.0038962,
            0.0039431, 0.0039183, 0.0039363, 0.0039049, 0.0039304, 0.0039039,
            0.0039133, 0.0039041, 0.0039215, 0.003914, 0.0039073, 0.0039055,
            0.0039101, 0.0038852, 0.0038897, 0.0038699, 0.0038955, 0.0039117,
            0.0039124, 0.0039026, 0.0039241, 0.0039395, 0.0039711, 0.0039284,
            0.0039406, 0.003913, 0.0039101, 0.0038968, 0.0039221, 0.0039155,
            0.0039181, 0.0039625, 0.0039096, 0.0039152, 0.0038804, 0.0038894,
            0.0039222, 0.0039512, 0.0039033, 0.003951, 0.0039346, 0.00388,
            0.003942, 0.0039095, 0.0039185, 0.0039257, 0.0039132, 0.0039038,
            0.0039072, 0.0038821, 0.0039266, 0.003905, 0.0039321, 0.0039218,
            0.0039577, 0.0039206, 0.0039105, 0.0039249, 0.0039102, 0.0039137,
            0.0039286, 0.0039222, 0.0039327, 0.0039241, 0.0039234, 0.0039118,
            0.0038805, 0.0039172, 0.0039079, 0.0039224, 0.0038941, 0.0038888,
            0.0039035, 0.003936, 0.0039471, 0.003934, 0.0038899, 0.0039391,
            0.0039008, 0.0039101, 0.003928, 0.0039132, 0.0039152, 0.0039036,
            0.0039257, 0.0039291, 0.0039048, 0.0039189, 0.0038985, 0.0038943,
            0.0039243, 0.003897, 0.0038725, 0.0039097, 0.0038939, 0.0039165,
            0.0038937, 0.0038594, 0.0039477, 0.0038993, 0.0039091, 0.0039317,
            0.0039138, 0.0039204, 0.0038714, 0.0039258, 0.0038996, 0.0039164,
            0.0039241, 0.0039355, 0.0039513, 0.0038731, 0.0039156, 0.0038805,
            0.0038956, 0.0038922, 0.0039045, 0.0039054, 0.0038888, 0.0038795,
            0.0039287, 0.003903, 0.0039027, 0.0038911, 0.0039472, 0.0039357,
            0.0039147, 0.0038968, 0.0038988, 0.0038842, 0.0039323, 0.0038798,
            0.0039324, 0.0039215, 0.0039411, 0.0039166, 0.003889, 0.0039039,
            0.0039208, 0.0039255, 0.0039159, 0.0038918, 0.0039145, 0.003904,
            0.0039166, 0.0038898, 0.0039019, 0.0038748, 0.003908, 0.0038929,
            0.0039027, 0.0039156, 0.0039111, 0.0038876, 0.0039209, 0.0039112,
            0.003849, 0.0039108, 0.0038811, 0.0039315, 0.0039056, 0.0039142,
            0.0039283, 0.0038832, 0.003893, 0.0038802
        };

        public static readonly double[] sumSS = 
        {
            0.0769352, 0.0767775, 0.0761274, 0.0749488, 0.0734201, 0.0721391,
            0.070001, 0.0681347, 0.065699, 0.0650283, 0.0610575, 0.0581483,
            0.0555445, 0.0524418, 0.0500191, 0.0468581, 0.0441406, 0.0411945,
            0.0387965, 0.0344394, 0.0335327, 0.0308306, 0.0282019, 0.0258461,
            0.0230328, 0.021835, 0.0200488, 0.0182153, 0.0167099, 0.0166228,
            0.0136601, 0.0125201, 0.0116584, 0.0106403, 0.0093359, 0.008895,
            0.0082799, 0.0076616, 0.0070782, 0.0062758, 0.0061183, 0.0058404,
            0.0054831, 0.0051532, 0.0050262, 0.0046958, 0.0045262, 0.0043873,
            0.0042848, 0.0041244, 0.003992, 0.0040095, 0.0039223, 0.0038972,
            0.0038278, 0.0038277, 0.0038321, 0.0038206, 0.0037777, 0.0037719,
            0.0037875, 0.00379, 0.0037569, 0.0038144, 0.0038058, 0.0038148,
            0.0038509, 0.003894, 0.0039002, 0.0039187, 0.003911, 0.0039326,
            0.003947, 0.0039139, 0.0039251, 0.0039426, 0.0039278, 0.0039663,
            0.0039127, 0.0039442, 0.0039245, 0.003897, 0.0039199, 0.0038997,
            0.0039265, 0.0038612, 0.0039275, 0.0038968, 0.0039184, 0.0039217,
            0.0039118, 0.0038978, 0.0039121, 0.003914, 0.0039107, 0.0039111,
            0.0038899, 0.0038892, 0.0039265, 0.0038761, 0.0039031, 0.0038901,
            0.0038964, 0.0039024, 0.0039406, 0.0039153, 0.0038607, 0.0038886,
            0.0039327, 0.0039237, 0.00391, 0.0039055, 0.0039234, 0.0038816,
            0.0038956, 0.0039473, 0.003867, 0.0038967, 0.0039211, 0.0038969,
            0.0039016, 0.0039127, 0.0038943, 0.0039309, 0.003878, 0.003886,
            0.0038819, 0.00391, 0.0039117, 0.003909, 0.003878, 0.0039014,
            0.003904, 0.0038827, 0.0039263, 0.0039139, 0.0038982, 0.0039253,
            0.0038995, 0.0039138, 0.0038943, 0.0039025, 0.0039348, 0.0039135,
            0.0039193, 0.0038748, 0.0038916, 0.0038514, 0.0038852, 0.0039078,
            0.003915, 0.0039684, 0.0039172, 0.0039146, 0.0039186, 0.0039261,
            0.0038655, 0.0038996, 0.003893, 0.0039164, 0.0039228, 0.0039173,
            0.0039218, 0.0038916, 0.0038944, 0.0039075, 0.0039008, 0.0039122,
            0.0039139, 0.0039153, 0.0039113, 0.003928, 0.0039118, 0.003938,
            0.0038853, 0.0039176, 0.0039471, 0.0038961, 0.0039231, 0.0039148,
            0.0038953, 0.0038932, 0.0038638, 0.0038806, 0.0039218, 0.0038775,
            0.0039206, 0.003926, 0.0038942, 0.0039312, 0.0038817, 0.0038921,
            0.0039455, 0.0038777, 0.0039326, 0.0039002, 0.0039249, 0.0038961,
            0.0038809, 0.0038935, 0.0039207, 0.003909, 0.0039084, 0.0038764,
            0.0039032, 0.0039288, 0.0038841, 0.0039088, 0.0038875, 0.0038965,
            0.0039078, 0.0039144, 0.0038621, 0.0039136, 0.0039135, 0.003927,
            0.003855, 0.0038899, 0.0038956, 0.0038885, 0.0038715, 0.0038856,
            0.0039222, 0.0039143, 0.0038694, 0.0039255, 0.0039253, 0.0039062,
            0.0039136, 0.0039786, 0.0039149, 0.0039343, 0.0039139, 0.0039274,
            0.0039108, 0.0038848, 0.0039173, 0.0039006, 0.0039284, 0.0038957,
            0.0039194, 0.0039025, 0.0039134, 0.0038668, 0.0038889, 0.0039112,
            0.003898, 0.0039047, 0.0039249, 0.0039149, 0.0039419, 0.0039136,
            0.0039053, 0.0038747, 0.0039021, 0.0039175
        };


        public static readonly double[] sumSSS = 
        {
            0.0769352, 0.0767775, 0.0761274, 0.0749488, 0.0734201, 0.0721391,
            0.070001, 0.0681347, 0.065699, 0.0650283, 0.0610575, 0.0581483,
            0.0555445, 0.0524418, 0.0500191, 0.0468581, 0.0441406, 0.0411945,
            0.0387965, 0.0344394, 0.0335327, 0.0308306, 0.0282019, 0.0258461,
            0.0230328, 0.021835, 0.0200488, 0.0182153, 0.0167099, 0.0166228,
            0.0136601, 0.0125201, 0.0116584, 0.0106403, 0.0093359, 0.008895,
            0.0082799, 0.0076616, 0.0070782, 0.0062758, 0.0061183, 0.0058404,
            0.0054831, 0.0051532, 0.0050262, 0.0046958, 0.0045262, 0.0043873,
            0.0042848, 0.0041244, 0.003992, 0.0040095, 0.0039223, 0.0038972,
            0.0038278, 0.0038277, 0.0038321, 0.0038206, 0.0037777, 0.0037719,
            0.0037875, 0.00379, 0.0037569, 0.0038144, 0.0038058, 0.0038148,
            0.0038509, 0.003894, 0.0039002, 0.0039187, 0.003911, 0.0039326,
            0.003947, 0.0039139, 0.0039251, 0.0039426, 0.0039278, 0.0039663,
            0.0039127, 0.0039442, 0.0039245, 0.003897, 0.0039199, 0.0038997,
            0.0039265, 0.0038612, 0.0039275, 0.0038968, 0.0039184, 0.0039217,
            0.0039118, 0.0038978, 0.0039121, 0.003914, 0.0039107, 0.0039111,
            0.0038899, 0.0038892, 0.0039265, 0.0038761, 0.0039031, 0.0038901,
            0.0038964, 0.0039024, 0.0039406, 0.0039153, 0.0038607, 0.0038886,
            0.0039327, 0.0039237, 0.00391, 0.0039055, 0.0039234, 0.0038816,
            0.0038956, 0.0039473, 0.003867, 0.0038967, 0.0039211, 0.0038969,
            0.0039016, 0.0039127, 0.0038943, 0.0039309, 0.003878, 0.003886,
            0.0038819, 0.00391, 0.0039117, 0.003909, 0.003878, 0.0039014,
            0.003904, 0.0038827, 0.0039263, 0.0039139, 0.0038982, 0.0039253,
            0.0038995, 0.0039138, 0.0038943, 0.0039025, 0.0039348, 0.0039135,
            0.0039193, 0.0038748, 0.0038916, 0.0038514, 0.0038852, 0.0039078,
            0.003915, 0.0039684, 0.0039172, 0.0039146, 0.0039186, 0.0039261,
            0.0038655, 0.0038996, 0.003893, 0.0039164, 0.0039228, 0.0039173,
            0.0039218, 0.0038916, 0.0038944, 0.0039075, 0.0039008, 0.0039122,
            0.0039139, 0.0039153, 0.0039113, 0.003928, 0.0039118, 0.003938,
            0.0038853, 0.0039176, 0.0039471, 0.0038961, 0.0039231, 0.0039148,
            0.0038953, 0.0038932, 0.0038638, 0.0038806, 0.0039218, 0.0038775,
            0.0039206, 0.003926, 0.0038942, 0.0039312, 0.0038817, 0.0038921,
            0.0039455, 0.0038777, 0.0039326, 0.0039002, 0.0039249, 0.0038961,
            0.0038809, 0.0038935, 0.0039207, 0.003909, 0.0039084, 0.0038764,
            0.0039032, 0.0039288, 0.0038841, 0.0039088, 0.0038875, 0.0038965,
            0.0039078, 0.0039144, 0.0038621, 0.0039136, 0.0039135, 0.003927,
            0.003855, 0.0038899, 0.0038956, 0.0038885, 0.0038715, 0.0038856,
            0.0039222, 0.0039143, 0.0038694, 0.0039255, 0.0039253, 0.0039062,
            0.0039136, 0.0039786, 0.0039149, 0.0039343, 0.0039139, 0.0039274,
            0.0039108, 0.0038848, 0.0039173, 0.0039006, 0.0039284, 0.0038957,
            0.0039194, 0.0039025, 0.0039134, 0.0038668, 0.0038889, 0.0039112,
            0.003898, 0.0039047, 0.0039249, 0.0039149, 0.0039419, 0.0039136,
            0.0039053, 0.0038747, 0.0039021, 0.0039175
        };

        private static double pow(double x, int exp)
        {
            double result = 1;
            for (int i = 0; i < exp; i++)
            {
                result *= x;
            }

            return result;
        }

        public static double[] getWeightsSumDiff(int diff)
        {
            double N = Constants.N;
            double[] weights = new double[Constants.N];
            for (int i1 = 0; i1 < N - diff; i1++)
            {
                int i2 = i1 + diff;
                double curr = pow((N - i2) / N, 2) * pow((N - i2 + i1 - 2) / N, i1) * pow((N - 2) / N, Constants.N - i2 - 1);
                for (int r = 0; r < i2 - i1 - 1; r++)
                {
                    curr *= (N - r - 2) / N;
                }
                weights[i1] = curr * Constants.prob_diff_boost; 
            }
            return weights;
        }


        public static double[] getWeightsSumDiffInv(int diff)
        {
            double N = Constants.N;
            double[] weights = new double[Constants.N];
            for (int i1 = 0; i1 < N - diff; i1++)
            {
                int i2 = i1 + diff;
                double curr = (N - 1) / N * pow((N - i2 + i1 - 1) / N, i1);
                for (int r = 1; r < i2 - i1 + 1; r++)
                {
                    curr *= (N - r) / N * (i1 + 1) / N * (i2 + 1) / N * pow((N - 1) / N, 2 * Constants.N - i1 - i2 - 2);
                }
                weights[i1] = curr * Constants.prob_diff_boost; 
            }
            return weights;
        }
    }
}