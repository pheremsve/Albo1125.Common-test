
namespace Albo1125.Common.CommonLibrary
{
    /// <summary>
    /// Provides common variables and utility data for the application.
    /// </summary>
    public static class CommonVariables
    {
        /// <summary>
        /// A shared instance of the Random class for generating random numbers.
        /// </summary>
        public static Random rnd = new Random();

        /// <summary>
        /// Indicates whether to display the time in the application.
        /// </summary>
        internal static bool DisplayTime = false;

        /// <summary>
        /// A collection of ground vehicle models to select from, including cars and motorbikes.
        /// </summary>
        public static Model[] GroundVehiclesToSelectFrom
        {
            get
            {
                return _CarsToSelectFrom.Concat<Model>(_MotorBikesToSelectFrom).ToArray<Model>();
            }
        }
        private static List<Model> _CarsToSelectFrom = new List<Model>
{
    // ?? Sedans
    "ASEA", "ASTEROPE", "INTRUDER", "PREMIER", "PRIMO", "REGINA", "SCHAFTER2", "STANIER", "STRATUM", "SURGE", "TAILGATER", "WARRENER", "WASHINGTON",

    // ?? Coupes
    "FELON", "FELON2", "F620", "EXEMPLAR", "WINDSOR", "WINDSOR2", "ZION", "ZION2", "COGCABRIO", "SENTINEL", "SENTINEL2",

    // ?? Sports
    "SULTAN", "SULTAN2", "RAPIDGT", "RAPIDGT2", "SCHWARZER", "BUFFALO", "BUFFALO2", "BUFFALO3", "JESTER", "JESTER2", "FUSILADE", "KURUMA", "KURUMA2", "9F", "9F2", "PENUMBRA", "FELTZER2", "COQUETTE", "MASSACRO", "MASSACRO2", "CARBONIZZARE", "COMET2",

    // ?? Super
    "ADDER", "ZENTORNO", "INFERNUS", "VACA", "ENTITYXF", "T20", "CHEETAH", "OSIRIS", "REAPER", "BULLET", "ZTYPE",

    // ?? Muscle
    "DOMINATOR", "DOMINATOR2", "DOMINATOR3", "DUKES", "DUKES2", "GAUNTLET", "GAUNTLET2", "GAUNTLET3", "PHOENIX", "NIGHTSHADE", "VIRGO", "CHINO", "BLADE", "VIGERO",

    // ?? SUVs
    "BALLER", "BALLER2", "BJXL", "CAVALCADE", "CAVALCADE2", "FQ2", "GRANGER", "HABANERO", "LANDSTALKER", "RADI", "ROCOTO", "SEMINOLE", "SERRANO", "GRESLEY",

    // ?? Off-road / Utility
    "BISON", "BISON2", "BISON3", "RANCHERXL", "REBEL", "REBEL2", "DLOADER", "BOBCATXL", "SANDKING", "SANDKING2", "KAMACHO", "GUARDIAN",

    // ? Compacts
    "BLISTA", "BLISTA2", "BLISTA3", "DILETTANTE", "ISSI2", "PRAIRIE", "RHAPSODY",

    // ? Classic / Misc
    "CASCO", "FAGALOA", "MANANA", "PEYOTE", "STINGER", "STINGERGT", "TORNADO", "TORNADO2", "TORNADO3", "TORNADO4", "VIRGO2", "VIRGO3", "ZTYPE"
};

        /// <summary>
        /// A collection of car models to select from.
        /// </summary>
        public static Model[] CarsToSelectFrom
        {
            get
            {
                return _CarsToSelectFrom.ToArray();
            }
        }

        private static List<Model> _MotorBikesToSelectFrom = new List<Model>
{
    // ?? Sport Bikes
    "BATI", "BATI2", "AKUMA", "DOUBLE", "VORTEX", "DEFILER", "THRUST", "LECTRO", "HAKUCHOU", "HAKUCHOU2", "CARBONRS", "NIGHTBLADE", "OPPRESSOR", "OPPRESSOR2", "SHOTARO",

    // ?? Touring / Cruisers
    "BAGGER", "CHIMERA", "SOVEREIGN", "VADER", "AVARUS", "ZOMBIEA", "ZOMBIEB", "SANCTUS", "INNOVATION", "DAEMON", "DAEMON2", "WOLFSBANE",

    // ?? Off-road / Trail
    "SANCHEZ", "SANCHEZ2", "MANCHEZ", "MANCHEZ2", "ENDURO", "CLIFFHANGER", "ESSKEY", "RATBIKE",

    // ?? Utility / Quads
    "BLAZER", "BLAZER2", "BLAZER3", "BLAZER4", "BLAZER5",

    // ? Scooters
    "FAGGIO", "FAGGIO2", "FAGGIO3",

    // ?? Rare / Special / Unknown (Fallback bucket)
    "HEXER", "DIABLO", "RUFFIAN"
};




        /// <summary>
        /// A collection of motorbike models to select from.
        /// </summary>
        public static Model[] MotorbikesToSelectFrom
        {
            get
            {
                return _MotorBikesToSelectFrom.ToArray();
            }
        }

        /// <summary>
        /// A list of traffic stop spawn points with their respective headings.
        /// </summary>
        public static TupleList<Vector3, float> TrafficStopSpawnPointsWithHeadings
        {
            get
            {
                return _TrafficStopSpawnPointsWithHeadings;
            }
        }

        /// <summary>
        /// A collection of vowel characters.
        /// </summary>
        public static string[] Vowels = new string[] { "a", "e", "o", "i", "u" };

        /// <summary>
        /// A collection of numeric characters.
        /// </summary>
        public static string[] Numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };


        private static TupleList<Vector3, float> _TrafficStopSpawnPointsWithHeadings = new TupleList<Vector3, float>
        {
            { new Vector3(-879.0662f, 239.9437f, 72.22186f),64.38356f },
            { new Vector3(-834.8604f, 204.1598f, 73.7544f), 265.1725f },
            { new Vector3(-755.9545f, 155.7549f, 64.3354f), 187.7457f },
            { new Vector3(-827.7767f, -9.064098f, 40.30524f), 212.4566f },
            { new Vector3(-831.7559f, -76.78371f, 37.33385f), 117.9508f },
            { new Vector3(-918.3644f, -33.06431f, 40.35612f), 39.54237f },
            { new Vector3(-1043.305f, 162.4217f, 57.30809f), 31.22434f },
            { new Vector3(-1036.512f, 250.366f, 64.46606f), 270.4566f },
            { new Vector3(-860.7089f, 357.527f, 86.6208f), 185.4379f },
            { new Vector3(-792.9432f, 438.9984f, 92.48638f), 278.3127f },
            { new Vector3(-639.832f, 496.3271f, 108.3503f), 281.5251f },
            { new Vector3(-464.9353f, 767.3813f, 171.0595f), 358.8197f },
            { new Vector3(-661.0579f, 921.9384f, 229.3689f), 66.88421f },
            { new Vector3(-710.9297f, 1051.119f, 246.2212f), 342.989f },
            { new Vector3(-698.3875f, 1181.562f, 265.1107f), 310.2824f },
            { new Vector3(-665.4635f, 1303.299f, 281.8141f), 343.3069f },
            { new Vector3(-427.7723f, 1407.998f, 292.7688f), 317.8205f },
            { new Vector3(-87.9101f, 1501.719f, 282.9984f), 250.5602f },
            { new Vector3(93.38171f, 1385.054f, 259.5159f), 267.1825f },
            { new Vector3(193.3249f, 1445.987f, 239.6637f), 42.75747f },
            { new Vector3(374.1024f, 1732.583f, 239.4723f), 131.1164f },
            { new Vector3(1024.931f, 1576.71f, 170.1391f), 169.2246f },
            { new Vector3(1116.184f, 832.7426f, 152.1875f), 329.595f },
            { new Vector3(1136.974f, 665.885f, 123.035f), 146.651f },
            { new Vector3(1203.84f, 643.5349f, 99.16676f), 325.7043f },
            { new Vector3(1374.229f, 682.4608f, 79.23694f), 138.1848f },
            { new Vector3(1341.927f, 611.697f, 80.06128f), 310.6091f },
            { new Vector3(1543.265f, 853.7671f, 77.20865f), 334.3522f },
            { new Vector3(1653.714f, 1174.292f, 84.08136f), 344.168f },
            { new Vector3(1710.493f, 1439.671f, 85.1928f), 347.8249f },
            { new Vector3(1889.301f, 1627.032f, 80.87594f), 256.4026f },
            { new Vector3(2161.595f, 1269.753f, 75.61858f), 209.0838f },
            { new Vector3(2597.98f, 401.2059f, 108.2211f), 323.9391f },
            { new Vector3(2476.985f, 1296.132f, 48.83939f), 329.646f },
            { new Vector3(2582.865f, 1646.836f, 28.1445f), 90.17572f },
            { new Vector3(2547.538f, 2103.621f, 19.32726f), 355.7367f },
            { new Vector3(2579.974f, 2623.6f, 36.76326f), 20.09404f },
            { new Vector3(2668.935f, 3129.403f, 50.35906f), 322.6464f },
            { new Vector3(2929.859f, 3737.787f, 52.38493f), 348.9002f },
            { new Vector3(2866.91f, 4425.019f, 48.54592f), 289.1848f },
            { new Vector3(2743.588f, 4691.754f, 44.06121f), 12.73393f },
            { new Vector3(2725.749f, 5086.909f, 42.65204f), 188.7374f },
            { new Vector3(2722.724f, 5123.943f, 43.98761f), 56.36723f },
            { new Vector3(2516.152f, 5553.152f, 44.50331f), 21.36839f },
            { new Vector3(2177.697f, 6065.309f, 51.7413f), 66.28397f },
            { new Vector3(1661.087f, 6412.976f, 29.40466f), 70.84875f },
            { new Vector3(1235.415f, 6501.709f, 20.5242f), 89.03062f },
            { new Vector3(762.86f, 6515.305f, 25.46921f), 78.15271f },
            { new Vector3(184.4049f, 6574.211f, 31.60049f), 110.5664f },
            { new Vector3(-22.2518f, 6633.133f, 30.45876f), 123.2169f },
            { new Vector3(-324.5273f, 6351.488f, 30.07028f), 134.4314f },
            { new Vector3(-413.6339f, 6024.99f, 31.12768f), 196.1808f },
            { new Vector3(-272.4705f, 6089.522f, 30.97792f), 315.1745f },
            { new Vector3(-256.8849f, 6189.933f, 31.09116f), 42.20694f },
            { new Vector3(-255.5601f, 6270.298f, 31.02397f), 315.8537f },
            { new Vector3(-159.6443f, 6337.343f, 31.21975f), 226.7266f },
            { new Vector3(34.58875f, 6395.486f, 31.01769f), 314.5241f },
            { new Vector3(92.41862f, 6486.325f, 31.112f), 135.7521f },
            { new Vector3(-144.9072f, 6247.682f, 30.93605f), 132.8918f },
            { new Vector3(-578.1945f, 5698.128f, 37.44772f), 153.7781f },
            { new Vector3(-732.8299f, 5531.087f, 36.27608f), 120.7709f },
            { new Vector3(-769.0044f, 5650.879f, 23.81657f), 340.9604f },
            { new Vector3(-926.8969f, 5429.035f, 37.20631f), 106.7766f },
            { new Vector3(-1389.062f, 5107.08f, 60.91629f), 121.7064f },
            { new Vector3(-1642.61f, 4871.636f, 60.56958f), 132.1071f },
            { new Vector3(-2175.74f, 4444.229f, 61.81794f), 141.5286f },
            { new Vector3(-2361.031f, 4046.449f, 30.04111f), 165.7798f },
            { new Vector3(-2526.426f, 3528.103f, 14.17548f), 156.6137f },
            { new Vector3(-2629.063f, 2912.742f, 16.4502f), 171.0384f },
            { new Vector3(-2692.788f, 2475.685f, 16.44287f), 171.4319f },
            { new Vector3(-2856.818f, 2195.172f, 33.0401f), 118.6719f },
            { new Vector3(-3013.057f, 1961.991f, 29.35463f), 155.826f },
            { new Vector3(-3037.866f, 1674.911f, 34.87879f), 199.8088f },
            { new Vector3(-3169.63f, 1244.344f, 10.57515f), 353.6517f },
            { new Vector3(-3135.381f, 824.7528f, 16.52175f), 207.5225f },
            { new Vector3(-3008.429f, 365.8237f, 14.47989f), 169.5816f },
            { new Vector3(-2858.971f, 47.31013f, 14.10655f), 251.2645f },
            { new Vector3(-2659.946f, -95.2246f, 17.78703f), 223.3282f },
            { new Vector3(-2007.747f, -458.8983f, 11.24626f), 228.6517f },
            { new Vector3(-1775.332f, -664.7091f, 10.14362f), 228.8256f },
            { new Vector3(-1369.16f, -867.0697f, 14.94891f), 136.6597f },
            { new Vector3(-1278.625f, -991.2997f, 9.592031f), 195.9247f },
            { new Vector3(-1187.188f, -1344.395f, 4.593719f), 118.2216f },
            { new Vector3(-1076.621f, -1604.209f, 4.032756f), 218.6957f },
            { new Vector3(-1074.099f, -1381.39f, 4.731258f), 346.9388f },
            { new Vector3(-760.4246f, -1158.496f, 10.27134f), 216.7104f },
            { new Vector3(-657.8961f, -1383.699f, 10.26912f), 180.5578f },
            { new Vector3(-825.9415f, -1715.502f, 32.80603f), 124.0214f },
            { new Vector3(-852.8828f, -2034.954f, 27.47351f), 238.9382f },
            { new Vector3(148.0289f, -2667.433f, 18.56385f), 261.9445f },
            { new Vector3(1139.533f, -2579.503f, 32.42434f), 285.4314f },
            { new Vector3(1340.195f, -2394.286f, 51.09689f), 352.4467f },
            { new Vector3(1288.286f, -2130.829f, 46.86113f), 19.57299f },
            { new Vector3(1208.23f, -1892.381f, 36.31029f), 19.5339f },
            { new Vector3(1201.121f, -1707.004f, 35.54856f), 298.7406f },
            { new Vector3(1288.305f, -1495.734f, 39.33773f), 16.79383f },
            { new Vector3(-721.737f, 219.7614f, 77.3844f), 296.6205f },
            { new Vector3(-615.0937f, 252.8152f, 81.41608f), 265.4273f },
            { new Vector3(-546.9728f, 204.5353f, 76.41225f), 176.5449f },
            { new Vector3(-493.2509f, 122.4216f, 63.28051f), 267.9423f },
            { new Vector3(-395.8216f, 69.566f, 57.91032f), 180.9019f },
            { new Vector3(-460.5954f, 18.7797f, 45.31112f), 86.07594f },
            { new Vector3(-287.3965f, -114.2308f, 45.5137f), 164.3491f },
            { new Vector3(-148.7309f, -98.68957f, 54.63776f), 251.9253f },
            { new Vector3(17.82868f, -82.90137f, 59.32726f), 339.1658f },
            { new Vector3(181.0704f, -94.09791f, 66.96805f), 160.5451f },
            { new Vector3(323.3336f, -112.0085f, 67.93071f), 252.1688f },
            { new Vector3(369.6567f, -187.075f, 59.50886f), 162.7569f },
            { new Vector3(253.3059f, -568.2327f, 42.9293f), 160.041f },
            { new Vector3(645.8651f, -609.1694f, 35.53476f), 242.2607f },
            { new Vector3(1064.724f, -851.7159f, 49.05843f), 271.04f },
            { new Vector3(1284.939f, -622.3033f, 68.6316f), 34.44439f },
            { new Vector3(1199.625f, -461.6662f, 66.07552f), 345.359f },
            { new Vector3(1184.6f, -432.9426f, 66.73499f), 166.7311f },
            { new Vector3(1161.999f, -245.3021f, 68.75951f), 64.83382f },
            { new Vector3(924.5276f, -126.709f, 75.74687f), 59.52725f },
            { new Vector3(759.4383f, -16.03819f, 81.56871f), 60.3346f },
            { new Vector3(650.4785f, 46.25991f, 86.21696f), 68.53769f },
            { new Vector3(454.8057f, 117.2612f, 98.70302f), 68.26584f },
            { new Vector3(547.9411f, 160.7395f, 99.12971f), 342.5281f },
            { new Vector3(638.6799f, 261.7792f, 102.8785f), 333.6965f },
            { new Vector3(716.6415f, 335.1924f, 112.3611f), 260.7825f },
            { new Vector3(423.5228f, 435.0939f, 141.3779f), 79.09743f },
            { new Vector3(311.2593f, 584.3569f, 153.9969f), 47.10493f },
            { new Vector3(192.907f, 432.2299f, 118.3631f), 103.4188f },
            { new Vector3(23.75743f, 366.1557f, 112.2589f), 55.28677f },
            { new Vector3(-131.3214f, 398.2202f, 112.9052f), 153.8072f },
            { new Vector3(-91.44661f, 293.6624f, 106.2019f), 244.5741f },
            { new Vector3(-269.7622f, 404.7214f, 109.7564f), 104.9358f },
            { new Vector3(-266.657f, 431.6216f, 107.8918f), 66.77047f },
            { new Vector3(-389.3559f, 528.2809f, 121.467f), 52.29746f },
            { new Vector3(-557.063f, 477.2051f, 102.7821f), 200.2604f },
            { new Vector3(-433.4655f, 347.8044f, 105.6106f), 278.5556f },
            { new Vector3(-1618.639f, -753.9629f, 11.2078f), 236.0776f },
            { new Vector3(-1401.568f, -779.1171f, 10.68114f), 278.5008f },
            { new Vector3(-1144.102f, -680.9578f, 10.64537f), 302.1374f },
            { new Vector3(-709.9083f, -554.6688f, 32.29703f), 258.8638f },
            { new Vector3(-653.1411f, -600.572f, 33.35202f), 174.2366f },
            { new Vector3(-357.3976f, -540.2585f, 24.86592f), 269.5281f },
            { new Vector3(-68.39794f, -538.2088f, 31.47291f), 270.6259f },
            { new Vector3(277.4375f, -536.2589f, 33.65064f), 269.4603f },
            { new Vector3(631.7206f, -602.0262f, 35.48172f), 241.6931f },
            { new Vector3(807.1597f, -690.247f, 41.29946f), 237.8936f },
            { new Vector3(984.5032f, -918.6431f, 30.39319f), 195.9548f },
            { new Vector3(1041.713f, -1201.157f, 25.11361f), 183.2175f },
            { new Vector3(1047.303f, -1664.17f, 30.81324f), 184.9299f },
            { new Vector3(1088.707f, -1815.479f, 36.39512f), 202.1394f },
            { new Vector3(1142.972f, -1856.371f, 36.95048f), 288.8381f },
            { new Vector3(1207.815f, -1892.534f, 36.3627f), 19.71675f },
            { new Vector3(1215.449f, -1829.899f, 37.88774f), 288.4553f },
            { new Vector3(-807.7476f, -1771.474f, 33.35702f), 281.3814f },
            { new Vector3(-740.6782f, -1878.979f, 26.86512f), 196.6002f },
            { new Vector3(-743.3373f, -2134.229f, 13.47859f), 143.4127f },
            { new Vector3(-880.1978f, -2262.259f, 18.54692f), 134.2592f },
            { new Vector3(-753.7152f, -2445.956f, 14.12565f), 329.5831f },
            { new Vector3(-738.1461f, -2448.973f, 13.61676f), 152.3309f },
            { new Vector3(-936.6982f, -2141.153f, 8.623575f), 314.5217f },
            { new Vector3(-1126.706f, -2002.121f, 12.93081f), 230.1958f },
            { new Vector3(-945.4644f, -1816.567f, 19.43041f), 316.7983f },
            { new Vector3(-747.4651f, -1596.623f, 14.10588f), 315.626f },
            { new Vector3(-637.4694f, -1387.105f, 10.21354f), 357.1029f },
            { new Vector3(-497.999f, -1247.719f, 24.07518f), 158.8137f },
            { new Vector3(-461.8662f, -1455.756f, 29.27944f), 183.4107f },
            { new Vector3(-378.4935f, -1503.803f, 34.07191f), 338.5719f },
            { new Vector3(-338.9534f, -1471.684f, 30.34176f), 180.0779f },
            { new Vector3(-356.2729f, -1620.107f, 19.33241f), 159.5053f },
            { new Vector3(-439.0206f, -1767.217f, 20.17466f), 111.1644f },
            { new Vector3(-321.2016f, -1841.528f, 23.86377f), 257.8238f },
            { new Vector3(-473.5977f, -1863.576f, 17.57071f), 104.8539f },
            { new Vector3(-618.1592f, -1885.992f, 29.26057f), 86.39082f },
            { new Vector3(-509.1594f, -1950.435f, 16.92199f), 319.748f },
            { new Vector3(-535.1617f, -1930.524f, 16.94603f), 136.6033f },
            { new Vector3(-803.2914f, -2196.344f, 16.51093f), 130.1717f },
            { new Vector3(-702.6539f, -2150.335f, 13.04433f), 309.8559f },
            { new Vector3(-470.7635f, -2093.834f, 27.09912f), 265.1182f },
            { new Vector3(-359.3956f, -2112.903f, 24.24925f), 259.5192f },
            { new Vector3(-156.0119f, -2042.504f, 22.51941f), 344.4273f },
            { new Vector3(-96.54359f, -2161.338f, 9.963698f), 291.8835f },
            { new Vector3(-118.8373f, -1944.846f, 22.37359f), 51.44443f },
            { new Vector3(-189.7102f, -1804.4f, 29.52428f), 299.6346f },
            { new Vector3(-41.52007f, -1723.465f, 28.91937f), 294.6526f },
            { new Vector3(106.024f, -1735.669f, 28.6365f), 230.662f },
            { new Vector3(145.314f, -1796.092f, 28.25339f), 139.3328f },
            { new Vector3(86.80068f, -1931.629f, 20.39214f), 219.2866f },
            { new Vector3(24.72922f, -1866.857f, 22.87169f), 50.63408f },
            { new Vector3(-18.04709f, -1805.859f, 26.58916f), 321.396f },
            { new Vector3(265.2673f, -1560.085f, 28.80141f), 301.6408f },
            { new Vector3(382.2089f, -1582.908f, 28.91574f), 230.1037f },
            { new Vector3(417.3199f, -1378.427f, 29.43106f), 50.81552f },
            { new Vector3(638.9248f, -1446.777f, 30.11053f), 271.3428f },
            { new Vector3(803.6606f, -1502.201f, 27.88048f), 205.5436f },
            { new Vector3(822.6063f, -1660.162f, 28.96169f), 174.2205f },
            { new Vector3(787.4227f, -1891.604f, 28.93413f), 165.1774f },
            { new Vector3(846.7437f, -2084.76f, 29.71044f), 265.2996f },
            { new Vector3(920.2981f, -2137.56f, 30.11075f), 174.9585f },
            { new Vector3(867.4886f, -2239.341f, 30.13641f), 85.82328f },
            { new Vector3(909.0033f, -2290.304f, 30.29708f), 173.8695f },
            { new Vector3(952.5059f, -2468.922f, 28.19952f), 266.8782f },
            { new Vector3(1045.13f, -2393.99f, 29.80615f), 353.3778f },
            { new Vector3(1158.736f, -2089.312f, 41.72495f), 275.7196f },
            { new Vector3(1301.158f, -2042.849f, 44.55045f), 292.2339f },
            { new Vector3(1091.753f, -1485.87f, 28.15709f), 356.6168f },
            { new Vector3(1073.377f, -1288.431f, 25.79537f), 2.673968f },
            { new Vector3(1033.989f, -887.0514f, 30.39781f), 25.05584f },
            { new Vector3(839.4229f, -648.5521f, 41.98281f), 56.4212f },
            { new Vector3(428.0759f, -485.5653f, 35.53823f), 90.20618f },
            { new Vector3(264.1585f, -483.6436f, 33.6374f), 91.39541f },
            { new Vector3(2.469834f, -484.8999f, 33.39306f), 89.7682f },
            { new Vector3(-245.8612f, -474.4495f, 25.60968f), 82.18053f },
            { new Vector3(-419.8016f, -672.0051f, 36.83847f), 178.3092f },
            { new Vector3(-433.0539f, -803.7357f, 37.43818f), 175.7356f },
            { new Vector3(-431.9308f, -1048.455f, 37.61358f), 168.3263f },
            { new Vector3(-421.3389f, -1212.955f, 54.56474f), 228.2229f },
            { new Vector3(-236.3324f, -1234.64f, 36.87751f), 268.3107f },
            { new Vector3(-41.34225f, -1260.209f, 35.55466f), 264.6257f },
            { new Vector3(40.07463f, -1357.178f, 28.93604f), 91.36675f },
            { new Vector3(-13.6328f, -1355.007f, 28.9059f), 89.38146f },
            { new Vector3(-91.42473f, -1291.281f, 28.90424f), 359.8954f },
            { new Vector3(-76.74903f, -1106.13f, 25.66922f), 340.7221f },
            { new Vector3(-43.9413f, -1016.342f, 28.56779f), 340.5232f },
            { new Vector3(26.28559f, -812.0501f, 30.85511f), 326.5526f },
            { new Vector3(68.91693f, -794.0045f, 31.27548f), 248.6751f },
            { new Vector3(74.5505f, -770.8582f, 31.34095f), 74.34708f },
            { new Vector3(82.09867f, -676.7922f, 31.28652f), 340.5499f },
            { new Vector3(144.9332f, -587.3853f, 30.72762f), 251.8666f },
            { new Vector3(400.9577f, -716.6835f, 28.92295f), 181.5957f },
            { new Vector3(543.4438f, -861.5493f, 40.32827f), 270.097f },
            { new Vector3(438.1588f, -829.4177f, 28.18832f), 269.4521f },
            { new Vector3(496.2575f, -885.5297f, 25.19251f), 180.7264f },
            { new Vector3(455.6572f, -671.9939f, 27.56686f), 92.03419f },
            { new Vector3(385.7715f, -624.6555f, 28.60361f), 330.4307f },
            { new Vector3(1477.523f, -1060.637f, 55.39516f), 303.6907f },
            { new Vector3(1601.981f, -983.0315f, 60.75611f), 301.6481f },
            { new Vector3(1736.998f, -898.2914f, 69.21184f), 304.3146f },
            { new Vector3(1961.882f, -730.3f, 88.62013f), 311.5137f },
            { new Vector3(2497.778f, -541.6506f, 67.8672f), 223.7615f },
            { new Vector3(2371.445f, -680.8045f, 63.09755f), 91.69623f },
            { new Vector3(2457.415f, -176.6767f, 87.96686f), 334.0139f },
            { new Vector3(2543.481f, 14.70534f, 93.62328f), 341.9867f },
            { new Vector3(2554.915f, 297.3891f, 108.2162f), 179.7884f },
            { new Vector3(2532.448f, 858.9391f, 87.09566f), 28.36542f },
            { new Vector3(2366.561f, 1081.046f, 80.8815f), 42.48524f },
            { new Vector3(2206.058f, 1267.12f, 75.76015f), 40.16818f },
            { new Vector3(2040.415f, 1539.554f, 75.10687f), 24.18772f },
            { new Vector3(1945.668f, 2437.175f, 54.29123f), 330.6206f },
            { new Vector3(2106.867f, 2628.424f, 51.49403f), 314.3209f },
            { new Vector3(2031.792f, 2632.85f, 53.04f), 129.9463f },
            { new Vector3(1886.8f, 2450.026f, 54.30777f), 147.2444f },
            { new Vector3(1968.46f, 2524.649f, 54.33545f), 323.6715f },
            { new Vector3(2359.246f, 2816.87f, 42.84689f), 293.3645f },
            { new Vector3(2333.6f, 2986.892f, 47.71206f), 62.20285f },
            { new Vector3(2291.464f, 3112.235f, 47.31563f), 21.11316f },
            { new Vector3(2145.75f, 3268.606f, 45.92772f), 68.50956f },
            { new Vector3(1943.069f, 3318.281f, 45.04067f), 78.45831f },
            { new Vector3(1811.395f, 3317.912f, 41.93379f), 30.2607f },
            { new Vector3(1758.661f, 3538.26f, 35.78361f), 299.7389f },
            { new Vector3(1659.529f, 3585.022f, 35.24927f), 28.27908f },
            { new Vector3(1682.301f, 3620.803f, 35.17736f), 300.1324f },
            { new Vector3(1699.293f, 3683.165f, 34.47552f), 28.74282f },
            { new Vector3(1722.224f, 3733.64f, 33.55905f), 300.1952f },
            { new Vector3(1760.485f, 3720.321f, 33.87332f), 210.4125f },
            { new Vector3(1831.231f, 3707.381f, 33.27387f), 299.6535f },
            { new Vector3(1909.011f, 3810.531f, 32.07688f), 28.60104f },
            { new Vector3(1944.645f, 3861.011f, 32.02096f), 296.6556f },
            { new Vector3(1877.381f, 3954.861f, 32.72955f), 93.55849f },
            { new Vector3(1855.537f, 3930.493f, 32.76587f), 195.1366f },
            { new Vector3(1833.641f, 3890.632f, 33.27746f), 109.5615f },
            { new Vector3(1755.292f, 3851.148f, 34.21868f), 119.3669f },
            { new Vector3(1624.4f, 3826.876f, 34.66964f), 128.7986f },
            { new Vector3(1512.538f, 3740.263f, 34.21819f), 118.2286f },
            { new Vector3(1367.141f, 3679.198f, 33.23569f), 109.7738f },
            { new Vector3(1243.861f, 3639.192f, 33.1542f), 102.6745f },
            { new Vector3(981.7724f, 3638.001f, 32.06542f), 88.33912f },
            { new Vector3(922.3293f, 3594.718f, 32.8696f), 177.7257f },
            { new Vector3(705.4941f, 3529.692f, 33.9128f), 95.63829f },
            { new Vector3(416.562f, 3536.746f, 33.7551f), 5.294222f },
            { new Vector3(220.026f, 3292.726f, 40.60985f), 165.0859f },
            { new Vector3(157.8936f, 3192.95f, 41.91386f), 148.1332f },
            { new Vector3(215.0842f, 3059.348f, 41.98627f), 185.2638f },
            { new Vector3(232.5487f, 2896.307f, 43.0338f), 188.5282f },
            { new Vector3(257.7659f, 2734.152f, 43.67854f), 193.9183f },
            { new Vector3(347.1451f, 2523.22f, 44.34873f), 224.1584f },
            { new Vector3(429.3513f, 2443.905f, 45.9148f), 234.3605f },
            { new Vector3(518.3473f, 2377.183f, 47.84334f), 235.3693f },
            { new Vector3(945.7597f, 2180.917f, 48.34543f), 225.7286f },
            { new Vector3(1106.481f, 1927.708f, 60.92078f), 197.4005f },
            { new Vector3(1143.306f, 1828.5f, 71.85985f), 212.9314f },
            { new Vector3(1194.863f, 1768.858f, 76.9744f), 226.4211f },
            { new Vector3(1286.689f, 1494.001f, 98.05789f), 174.3226f },
            { new Vector3(1293.321f, 1119.309f, 105.3819f), 184.4217f },
            { new Vector3(1281.814f, 882.1503f, 105.5036f), 163.1193f },
            { new Vector3(1198.209f, 653.2236f, 99.25091f), 146.4682f },
            { new Vector3(979.7994f, 520.4236f, 105.1041f), 77.70565f },
            { new Vector3(908.0585f, 473.0307f, 120.6745f), 170.0184f },
            { new Vector3(-527.8233f, -328.4098f, 34.78796f), 27.11495f },
            { new Vector3(-579.0211f, -248.5377f, 35.56088f), 29.59603f },
            { new Vector3(-671.0477f, -118.9586f, 37.48664f), 207.2606f },
            { new Vector3(-714.2009f, -72.85943f, 37.32681f), 117.9772f },
            { new Vector3(-833.0593f, -77.55369f, 37.46744f), 118.3916f },
            { new Vector3(-921.1762f, -67.8033f, 38.13189f), 205.1777f },
            { new Vector3(-931.6444f, -126.5436f, 37.33886f), 118.2233f },
            { new Vector3(-1135.678f, -130.3691f, 38.70284f), 62.76798f },
            { new Vector3(-1509.098f, -120.4148f, 51.78822f), 130.4333f },
            { new Vector3(-1475.627f, -300.2791f, 46.56487f), 222.7826f },
            { new Vector3(-1427.376f, -405.6575f, 35.82045f), 121.7776f },
            { new Vector3(-1431.833f, -504.6223f, 32.81177f), 214.6442f },
            { new Vector3(-1470.078f, -603.6299f, 30.5026f), 124.3793f },
            { new Vector3(-1678.778f, -500.3355f, 37.64358f), 322.7657f },
            { new Vector3(-1723.983f, -429.0814f, 43.21497f), 321.0296f },
            { new Vector3(-1985.194f, -158.1079f, 30.35061f), 88.81802f },
            { new Vector3(-2165.063f, -277.4485f, 12.50782f), 159.7928f },
            { new Vector3(-2331.078f, -286.4114f, 13.48657f), 48.30672f },
            { new Vector3(-2605.468f, -120.1494f, 20.24603f), 44.8329f },
            { new Vector3(-2775.302f, 40.14946f, 14.89248f), 66.97694f },
            { new Vector3(-2979.364f, 416.7055f, 14.73246f), 356.147f },
            { new Vector3(-3078.417f, 782.1501f, 19.59064f), 35.18611f },
            { new Vector3(-3100.047f, 1110.847f, 20.20456f), 354.3354f },
            { new Vector3(-2771.227f, 1334.746f, 78.33389f), 320.3916f },
            { new Vector3(-2557.828f, 1664.582f, 144.3318f), 269.6734f },
            { new Vector3(-2304.393f, 1859.858f, 182.0995f), 263.9536f },
            { new Vector3(-2054.256f, 1967.306f, 188.7556f), 153.9415f },
            { new Vector3(-1754.157f, 2069.49f, 119.857f), 313.4281f },
            { new Vector3(-2018.692f, 2283.358f, 46.609f), 89.16579f },
            { new Vector3(-2020.667f, 2332.11f, 34.05563f), 292.2233f },
            { new Vector3(-1667.934f, 2386.194f, 34.03762f), 224.5537f },
            { new Vector3(-1542.157f, 2217.339f, 55.62569f), 176.639f },
            { new Vector3(-1418.196f, 2141.323f, 52.89112f), 267.2484f },
            { new Vector3(-1348.174f, 2297.088f, 41.56647f), 0.1010481f },
            { new Vector3(-1192.285f, 2588.538f, 14.81376f), 309.2764f },
            { new Vector3(-914.0199f, 2744.896f, 23.97734f), 263.2639f },
            { new Vector3(-893.8494f, 2756.9f, 23.47461f), 80.6081f },
            { new Vector3(-693.5669f, 2814.181f, 27.92593f), 301.6935f },
            { new Vector3(-449.8669f, 2845.685f, 35.05143f), 282.1178f },
            { new Vector3(-171.5812f, 2854.912f, 48.13887f), 248.8324f },
            { new Vector3(41.53094f, 2834.893f, 54.96767f), 287.0063f },
            { new Vector3(159.0195f, 2892.775f, 47.5908f), 311.338f },
            { new Vector3(225.8151f, 3074.531f, 41.94898f), 3.539454f },
            { new Vector3(114.8405f, 3537.019f, 39.47895f), 6.151187f },
            { new Vector3(-20.38006f, 3610.763f, 42.41629f), 88.88354f },
            { new Vector3(-225.0405f, 3903.441f, 37.15809f), 355.1929f },
            { new Vector3(1779.354f, 4565.426f, 37.27317f), 271.9781f },
            { new Vector3(2074.574f, 4687.263f, 40.89493f), 309.4691f },
            { new Vector3(2187.762f, 4919.835f, 40.51136f), 312.3393f },
            { new Vector3(2342.413f, 5074.977f, 45.56913f), 315.297f },
            { new Vector3(2451.547f, 5115.729f, 46.64735f), 245.3988f },
            { new Vector3(2545.398f, 5085.057f, 43.92623f), 285.1831f },
            { new Vector3(569.669f, 6532.055f, 27.71355f), 255.4212f },
            { new Vector3(952.6536f, 6477.655f, 20.82141f), 270.9754f },
            { new Vector3(1267.343f, 6479.2f, 20.24276f), 270.1023f },
            { new Vector3(1584.199f, 6392.307f, 25.34543f), 248.4337f },
            { new Vector3(1937.846f, 6235.569f, 43.65616f), 201.969f },
            { new Vector3(2048.561f, 6072.647f, 48.35519f), 230.5136f },
            { new Vector3(2387.87f, 5727.213f, 45.27164f), 208.5768f },
            { new Vector3(2478.574f, 5531.554f, 44.46292f), 200.9186f },
            { new Vector3(2547.162f, 5309.491f, 44.31543f), 194.0321f },
            { new Vector3(2610.82f, 5066.203f, 44.50698f), 193.8326f },
            { new Vector3(2627.774f, 5005.904f, 44.49127f), 197.4135f },
            { new Vector3(2659.475f, 4882.209f, 44.38361f), 194.8982f },
            { new Vector3(2714.043f, 4636.777f, 44.33315f), 191.3118f },
            { new Vector3(2788.443f, 4337.133f, 49.6213f), 198.3576f },
            { new Vector3(2848.046f, 4180.648f, 49.81651f), 199.4319f },
            { new Vector3(2892.472f, 3755.443f, 52.35806f), 165.0401f },
            { new Vector3(2723.751f, 3295.101f, 55.48774f), 154.1881f },
            { new Vector3(2663.322f, 3226.96f, 53.73331f), 181.8115f },
            { new Vector3(2418.441f, 2943.761f, 40.09993f), 127.708f },
            { new Vector3(2142.749f, 2726.564f, 48.01392f), 123.2781f },
            { new Vector3(2105.212f, 2734.133f, 48.519f), 307.0123f },
            { new Vector3(1976.387f, 2987.119f, 45.42201f), 100.5518f },
            { new Vector3(1865.885f, 2959.887f, 45.41187f), 105.5971f },
            { new Vector3(1697.728f, 2885.539f, 43.4463f), 126.691f },
            { new Vector3(1526.315f, 2771.438f, 37.72758f), 125.7973f },
            { new Vector3(1328.251f, 2688.451f, 37.42355f), 91.91483f },
            { new Vector3(1159.065f, 2689.667f, 37.76839f), 87.02302f },
            { new Vector3(827.5468f, 2705.449f, 40.17546f), 89.26601f },
            { new Vector3(561.266f, 2697.349f, 41.79303f), 98.01508f },
            { new Vector3(1382.744f, -1761.452f, 65.15367f), 108.4341f },
            { new Vector3(1164.261f, -1693.974f, 35.1235f), 345.0715f },
            { new Vector3(1169.421f, -1677.827f, 35.90421f), 334.6752f },
            { new Vector3(1192.494f,-1645.583f,41.72477f),304.0557f },
            { new Vector3(1261.481f,-1590.458f,52.51166f),127.2638f },
            { new Vector3(1169.603f,-1658.508f,36.59523f),145.2478f },
            { new Vector3(970.1829f,-1891.113f,30.72443f),267.8428f },
            { new Vector3(1259.85f,-2151.704f,47.2656f),204.1282f },
            { new Vector3(1296.532f,-2602.941f,45.90883f),275.6055f },
            { new Vector3(1303.099f,-2600.562f,46.26453f),283.5164f },
            { new Vector3(1319.488f,-2598.849f,46.96061f),290.7414f },
            { new Vector3(1340.789f,-2591.354f,47.75403f),285.7692f },
            { new Vector3(1334.001f,-2578.028f,47.69835f),103.0632f },
            { new Vector3(1321.109f,-2581.908f,47.24157f),106.8085f },
            { new Vector3(1617.759f,-2542.454f,70.11839f),278.7705f },
            { new Vector3(1636.946f,-2539.589f,72.70373f),282.1533f },
            { new Vector3(1668.679f,-2381.106f,96.12662f),298.7161f },
            { new Vector3(1684.213f,-2372.74f,97.87152f),309.5768f },
            { new Vector3(1675.313f,-2143.192f,107.2307f),326.6501f },
            { new Vector3(1715.272f,-2079.54f,106.4983f),340.5631f },
            { new Vector3(1697.766f,-2081.652f,106.3397f),154.1042f },
            { new Vector3(1703.38f,-2069.121f,106.5642f),154.8263f },
            { new Vector3(1705.876f,-2048.77f,107.8144f),170.7938f },
            { new Vector3(1721.109f,-2040.138f,108.6662f),7.841102f },
            { new Vector3(1725.014f,-1797.023f,110.5297f),345.4353f },
            { new Vector3(1718.606f,-1771.215f,111.6272f),157.225f },
            { new Vector3(1802.148f,-1551.673f,112.7267f),327.2373f },
            { new Vector3(1891.207f,-1397.302f,135.3975f),329.7821f },
            { new Vector3(1888.222f,-975.2178f,78.60954f),130.856f },
            { new Vector3(1866.928f,-998.4028f,78.69716f),136.2056f },
            { new Vector3(1450.146f,-1506.828f,63.19926f),90.15918f },
            { new Vector3(1370.077f,-1531.899f,55.63334f),108.4459f },
            { new Vector3(1216.197f,-1404.937f,34.81584f),136.8395f },
            { new Vector3(839.6818f,-1077.901f,27.52493f),90.89271f },
            { new Vector3(-1113.087f,-1519.234f,4.013606f),308.183f },
            { new Vector3(-1110.543f,-1510.283f,4.12812f),124.9264f },
            { new Vector3(-431.4144f,6111.874f,31.22791f),148.2477f },
            { new Vector3(-437.1642f,6101.755f,31.06758f),158.1238f },
            { new Vector3(-462.694f,6074.681f,30.70778f),105.1211f },
            { new Vector3(-480.0629f,6069.246f,29.54632f),106.0272f },
            { new Vector3(-499.0636f,6064.216f,27.70989f),103.5008f },
            { new Vector3(-520.698f,6057.961f,25.10528f),99.94907f },
            { new Vector3(-571.3948f,6064.695f,15.9658f),217.1996f },
            { new Vector3(-507.1137f,6052.494f,26.42449f),286.1566f },
            { new Vector3(-440.1305f,5942.582f,31.62948f),139.4977f },
            { new Vector3(-457.9138f,5919.79f,32.25293f),142.7107f },
            { new Vector3(-480.7039f,5889.035f,32.91381f),145.4288f },
            { new Vector3(-496.3574f,5865.584f,33.35479f),146.7011f },
            { new Vector3(-515.4211f,5834.348f,33.98352f),149.4637f },
            { new Vector3(-535.8347f,5793.849f,34.89894f),156.5776f },
            { new Vector3(-570.4221f,5714.404f,36.88438f),153.9186f },
        };

    }
}

