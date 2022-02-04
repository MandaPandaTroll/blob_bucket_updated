using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneDatabase 
{



public static string red = "RED", green = "GRN",  blue = "LLY", move = "MVV", turnt = "TRN", rep = "REP", lifeL = "LIF";

 

        


public int [,] loci = new int[8,10] {
        {0,27,54,81,108,135,162,189,216,243} , {0,27,54,81,108,135,162,189,216,243},

        {0,27,54,81,108,135,162,189,216,243} , {0,27,54,81,108,135,162,189,216,243},

        {0,27,54,81,108,135,162,189,216,243} , {0,27,54,81,108,135,162,189,216,243},

        {0,27,54,81,108,135,162,189,216,243} , {0,27,54,81,108,135,162,189,216,243},
        };






public int GetSites ( int chromosome, int locus){

    return loci[chromosome,locus];

}









}
