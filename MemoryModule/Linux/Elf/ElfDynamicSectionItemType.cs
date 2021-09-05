﻿namespace MemoryModule.Linux.Elf
{
    internal enum ElfDynamicSectionItemType : uint
    {
        Null = 0,
        Needed = 1,
        PltRelSz = 2,
        PltGot = 3,
        Hash = 4,
        StrTab = 5,
        SymTab = 6,
        Rela = 7,
        RelaSz = 8,
        RelaEnt = 9,
        StrSz = 10,
        SymEnt = 11,
        Init = 12,
        Fini = 13,
        SoName = 14,
        RPath = 15,
        Symbolic = 16,
        Rel = 17,
        RelSz = 18,
        RelEnt = 19,
        PltRel = 20,
        Debug = 21,
        TextRel = 22,
        JmpRel = 23,
        BindNow = 24,
        InitArray = 25,
        FiniArray = 26,
        InitArraySz = 27,
        FiniArraySz = 28,
        LoOs = 0x60000000,
        HiOs = 0x6fffffff,
        LoProc = 0x70000000,
        HiProc = 0x7fffffff,
    }
}