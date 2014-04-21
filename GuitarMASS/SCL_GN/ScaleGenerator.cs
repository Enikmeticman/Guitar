using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;

namespace GTR_Logic
{
    public static class ScaleGenerator 
    {
        static public ScaleInfo Generate(string pKey)
        {
            return CalculateScale(pKey);
        }

        private static ScaleInfo CalculateScale(string pKey)
        {
            int noteIndex = G_Rules.GetNoteIndex(pKey);
            List<string> scale = new List<string>();

            for(int i = 0 ; i < G_Rules.TotalNotes; ++i)
            {
                scale.Add(G_Rules.Notes[noteIndex]);

                noteIndex = G_Rules.IncrementByInterval(noteIndex , G_Rules.Intervals[i]);
            }

            ScaleInfo scaleInfo = new ScaleInfo(scale);

            return scaleInfo;
        }        
    }
}
