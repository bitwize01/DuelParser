using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuelParser
{
    public class FistsMatrix
    {
        //The array of moves: compare it to http://www.duelingzone.com/dz/tools/Duel_of_Fists.html
        private double[] Jab        = {    2,    1,    1,    2,    1,    1,    1,    1,   -1, -0.5,    1, -0.5, -0.5,    1 };
        private double[] Hook       = {   -1,    2,   -1,    2,   -1,    1,   -1,   -1,   -1, -0.5,    1,    1, -0.5,    1 };
        private double[] UpperCut   = {   -1,    1,    2,   -1,    1,    1,   -1,   -1,   -1, -0.5,    1,    1, -0.5,    1 };
        private double[] Chop       = {    2,    2,    1,    2,   -1,    1,    1,   -1,   -1,    1, -0.5, -0.5,    1,    1 };
        private double[] JumpKick   = {   -1,    1,   -1,    1,    0,    1,    1,    0,   -1, -0.5,    1, -0.5, -0.5,    1 };
        private double[] SpinKick   = {   -1,   -1,   -1,   -1,   -1,    2,   -1,   -1,    1,    1,    1,    1, -0.5,    1 };
        private double[] SnapKick   = {   -1,    1,    1,   -1,   -1,    1,    2,    1,    1, -0.5, -0.5, -0.5,    1, -0.5 };
        private double[] LegSweep   = {   -1,    1,    1,    1,    0,    1,   -1,    2,    1,    1,   -1,    1,    1, -0.5 };
        private double[] Flip       = {    1,    1,   -1,    1,    1,   -1,   -1,   -1,    0,   -1,    0, -0.5, -0.5, -0.5 };
        private double[] ArmBlock   = {  0.5,  0.5,  0.5,  0.5,  0.5,   -1,  0.5,   -1,   -1,    0,    0,    0,    0,    0 };
        private double[] LegBlock   = {   -1,   -1,   -1,   -1,   -1,   -1,  0.5,  0.5,    0,    0,    0,    0,    0,    0 };
        private double[] Dodge      = {  0.5,   -1,  0.5,  0.5,  0.5,   -1,  0.5,   -1,  0.5,    0,    0,    0,    0,    0 };
        private double[] Duck       = {  0.5,  0.5,  0.5,   -1,  0.5,  0.5,   -1,   -1,  0.5,    0,    0,    0,    0,    0 };
        private double[] Leap       = {   -1,   -1,   -1,   -1,   -1,   -1,  0.5,  0.5,  0.5,    0,    0,    0,    0,    0 };

        //An enumerated type containing the possible results of a comparison
        enum possibleResults { All, Win, Advantage, Miss, Disadvantage, Loss };

        //A dictionary relating the scores of the matrix to the enumerated type above
        private static Dictionary<double, possibleResults> moveDictionary = new Dictionary<double, possibleResults>()
        {
            {2,     possibleResults.All},
            {1,     possibleResults.Win},
            {0.5,   possibleResults.Advantage},
            {0,     possibleResults.Miss},
            {-0.5,  possibleResults.Disadvantage},
            {-1,    possibleResults.Loss}
        };

        FistsMove[] Matrix = new FistsMove[14];

        //Generic constructor
        public FistsMatrix()
        {
            FistsMove Jab = new FistsMove("Jab", this.Jab);
            FistsMove Hook = new FistsMove("Hook", this.Hook);
            FistsMove UpperCut = new FistsMove("UpperCut", this.UpperCut);
            FistsMove Chop = new FistsMove("Chop", this.Chop);
            FistsMove JumpKick = new FistsMove("JumpKick", this.JumpKick);
            FistsMove SpinKick = new FistsMove("SpinKick", this.SpinKick);
            FistsMove SnapKick = new FistsMove("SnapKick", this.SnapKick);
            FistsMove LegSweep = new FistsMove("LegSweep", this.LegSweep);
            FistsMove Flip = new FistsMove("Flip", this.Flip);
            FistsMove ArmBlock = new FistsMove("ArmBlock", this.ArmBlock);
            FistsMove LegBlock = new FistsMove("LegBlock", this.LegBlock);
            FistsMove Dodge = new FistsMove("Dodge", this.Dodge);
            FistsMove Duck = new FistsMove("Duck", this.Duck);
            FistsMove Leap = new FistsMove("Leap", this.Leap);

            Matrix[0] = Jab;
            Matrix[1] = Hook;
            Matrix[2] = UpperCut;
            Matrix[3] = Chop;
            Matrix[4] = JumpKick;
            Matrix[5] = SpinKick;
            Matrix[6] = SnapKick;
            Matrix[7] = LegSweep;
            Matrix[8] = Flip;
            Matrix[9] = ArmBlock;
            Matrix[10] = LegBlock;
            Matrix[11] = Dodge;
            Matrix[12] = Duck;
            Matrix[13] = Leap;
        }
    }
}
