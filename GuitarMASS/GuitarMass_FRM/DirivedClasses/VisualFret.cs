using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Base;
using System.Drawing;

namespace GuitarMass_FRM.DirivedClasses
{
    public class VisualFret : Fret
    {
        Image _NoteImage = null;
        //Image _SelectedImage = null;

        Point _Position = new Point(0, 0);
        Point _Scale = new Point(40, 40);

        public bool IsDrawable { get; set; }
        public Point Position { get { return _Position; } }

        public VisualFret(bool pIsDrawable, Point pPosition): base()
        {
            IsDrawable = pIsDrawable;
            _Position = pPosition;
            SetImages();
        }

        public void Draw(Graphics pGraphics)
        {
            if (!IsDrawable || _NoteImage == null) return;

            pGraphics.DrawImage(_NoteImage, _Position.X - (_Scale.X / 2), _Position.Y - (_Scale.Y / 2), _Scale.X, _Scale.Y);
        }

        private void SetImages()
        {
            Image stringImg = null;
            if (AppData.Instance.GetImageByName("" + _Note + ".png", ref stringImg))
                _NoteImage = stringImg;
        }

        public override void Identify(string pNote, int pIndex)
        {
            _Note = pNote;
            _Index = pIndex;

            SetImages();
        }

        public Fret ConvertToFret()
        {
            Fret fret = new Fret();
            fret.Identify(_Note, _Index);
            return fret;
        }
    }
}
