using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base
{
    public enum Tuning { OpenC, Standard, OpenD , DroppedB , None}
    public static class G_Rules
    {
        public enum Shapes { One, Two, Three,  Four, Five, Six, Seven }

        public static List<int> Intervals = new List<int>() { 2, 2, 1, 2, 2, 2, 1 };
        public static List<string> Notes = new List<string>() { "A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#" };
        public static int TotalNotes = 7;
        public static int TotalIntvals = 12;
        public static int FretCount = 12;
        public static int ShapeNotesOnString = 3;
        public static int StandardStrings = 6;

        public static List<string> StandardTuning = new List<string>() { "E", "B", "G", "D", "A", "E" , "B" , "G"};
        public static List<string> OpenC = new List<string>() { "E", "C", "G", "C", "G", "C", "E", "C" };
        public static List<string> OpenD = new List<string>() { "D", "A", "F", "C", "G", "D", "A", "F" };
        public static List<string> DroppedB = new List<string>() { "B", "F#", "B", "E", "G#", "C#", "E", "B" };

        public static string FlatNotes(string pNote, int pRepeates)
        {
            for (int i = 0; i < pRepeates; ++i)
            {
                pNote = FlatNote(pNote);
            }

            return pNote;
        }

        public static string RaiseNote(string pNote, int pRepeates)
        {
            for (int i = 0; i < pRepeates; ++i)
            {
                pNote = RaiseNote(pNote);
            }

            return pNote;
        }

        public static string FlatNote(string pNote)
        {
            switch (pNote)
            {
                case "A":
                    return "G#";
                case "A#":
                    return "A";
                case "B":
                    return "A#";
                case "C":
                    return "B";
                case "C#":
                    return "C";
                case "D":
                    return "c#";
                case "D#":
                    return "D";
                case "E":
                    return "D#";
                case "F":
                    return "E";
                case "F#":
                    return "F";
                case "G":
                    return "F#";
                case "G#":
                    return "G";
            }

            return "Error no valid note ";
        }

        public static string RaiseNote(string pNote)
        {
            switch (pNote)
            {
                case "A":
                    return "A#";
                case "A#":
                    return "B";
                case "B":
                    return "C";
                case "C":
                    return "C#";
                case "C#":
                    return "D";
                case "D":
                    return "D#";
                case "D#":
                    return "E";
                case "E":
                    return "F";
                case "F":
                    return "F#";
                case "F#":
                    return "G";
                case "G":
                    return "G#";
                case "G#":
                    return "A";
            }

            return "Error no valid note ";
        }

        public static int GetNoteIndex(string pNode)
        {
            int noteIndex = 0;
            foreach (string note in G_Rules.Notes)
            {
                if (pNode == note)
                    break;

                ++noteIndex;
            }

            return noteIndex;
        }

        /// <summary>
        /// Zero based return value.
        /// </summary>
        /// <param name="pNoteIndex"></param>
        /// <param name="Increment"></param>
        public static int IncrementByInterval(int pNoteIndex, int pIncrement)
        {
            for(int i = 0; i < pIncrement; ++i)
            {
                pNoteIndex += 1;

                if (pNoteIndex >= TotalIntvals)
                    pNoteIndex = 0;
            }

            return pNoteIndex;
        }

        public static List<string> GetTuning(Tuning pTuning)
        {
            switch (pTuning)
            {
                case Tuning.OpenD:
                    {
                        return OpenD;
                    }
                case Tuning.OpenC:
                    {
                        return OpenC;
                    }
                case Tuning.DroppedB:
                    {
                        return DroppedB;
                    }
                default :
                    {
                        return StandardTuning;
                    }
                    
            }
        }
    }
}
