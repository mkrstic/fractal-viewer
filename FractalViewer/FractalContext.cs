using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FractalViewer
{
    public class FractalContext
    {
        private double _xstart, _ystart, _xend, _yend, _xzoom, _yzoom;
        private Bitmap _bitmap;

        public FractalContext()
        {
        }
        public FractalContext(Bitmap bitmap, double xstart, double ystart, double xend, double yend, double xzoom, double yzoom)
        {
            Bitmap = bitmap;
            Xstart = xstart;
            Ystart = ystart;
            Xend = xend;
            Yend = yend;
            Xzoom = xzoom;
            Yzoom = yzoom;
        }
        public Bitmap Bitmap
        {
            get { return _bitmap; }
            set { _bitmap = value; }
        }
        public double Xstart
        {
            get { return _xstart; }
            set { _xstart = value; }
        }
        public double Ystart
        {
            get { return _ystart; }
            set { _ystart = value; }
        }
        public double Xend
        {
            get { return _xend; }
            set { _xend = value; }

        }

        public double Yend
        {
            get { return _yend; }
            set { _yend = value; }
        }
        public double Xzoom
        {
            get { return _xzoom; }
            set { _xzoom = value; }
        }
        public double Yzoom
        {
            get { return _yzoom; }
            set { _yzoom = value; }
        }
    }

}