using System;

namespace Packt.Shared{
    [System.Flags]
    public enum WondersOfTheAncientWorld:byte{
        None                        =0b00000000,
        GreatPyramidOfGiza          =0b00000001, 
        HangingGardensOfBabylon     =0b00000010, 
        StatueOfZeusAtOlympia       =0b00000100, 
        TempleOfArtemisAtEphesus    =0b00001000, 
        MausoleumAtHalicarnassus    =0b00010000, 
        ColossusOfRhodes            =0b00100000, 
        LighthouseOfAlexandria      =0b01000000
    }
}