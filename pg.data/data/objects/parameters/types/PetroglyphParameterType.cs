namespace pg.data.data.objects.parameters.types
{
    public enum PetroglyphParameterType
    {
        BooleanType = 0, // "Yes", "No", "true", "false"
        UIntType2 = 2, // Only positive integers.
        OneMinusOneType = 3, // Only -1 and 1
        MinMaxPercentageType = 4, // 0 - 100; seems to support a comma separated range like 20,30
        UIntType5 = 5, // Only positive integers; no obvious difference to UIntType2
        IntType = 6, // Basic integer.
        FloatType = 8, // Basic floats.
        DoubleType = 9, // Could be either float or double.
        PgType10 = 10,
        PgType12 = 12,
        PgType13 = 13,
        PgType14 = 14,
        PgType15 = 15,
        PgType16 = 16,
        PgType17 = 17,
        PgType18 = 18,
        PgType19 = 19,
        PgType20 = 20,
        PgType21 = 21,
        PgType22 = 22,
        StringType = 23,
        PgType26 = 26,
        PgType27 = 27,
        PgType28 = 28,
        PgType29 = 29,
        PgType30 = 30,
        PgType31 = 31,
        PgType32 = 32,
        PgType33 = 33,
        PgType34 = 34,
        PgType35 = 35,
        PgType36 = 36,
        PgType37 = 37,
        PgType38 = 38,
        PgType39 = 39,
        PgType40 = 40,
        PgType41 = 41,
        PgType42 = 42,
        PgType43 = 43,
        PgType45 = 45,
        PgType47 = 47,
        PgType48 = 48,
        PgType50 = 50,
        TerrainToModelMapType = 52,
        PgType53 = 53,
        PgType54 = 54,
        PgType55 = 55,
        PgType56 = 56,
        PgType57 = 57,
        PgType58 = 58,
        PgType59 = 59,
        PgType60 = 60,
        PgType61 = 61,
        PgType62 = 62,
        PgType63 = 63,
        PgType64 = 64,
        PgType65 = 65,
        PgType66 = 66,
        PgType67 = 67,
        PgType68 = 68,
        PgType69 = 69,
        PgType70 = 70,
        PgType71 = 71,
        PgType72 = 72,
        PgType73 = 73,
        PgType74 = 74,
        PgType75 = 75,
        PgType76 = 76,
        PgType77 = 77,
        PgType78 = 78,
        PgType79 = 79,
        PgType80 = 80,
        PgType81 = 81,
        PgType82 = 82
    }
}