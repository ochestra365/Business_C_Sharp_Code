using System;

namespace GIT에_올릴_업무코드
{
    class Rectangle
    {
        private double width;
        private double height;
        public double GetWidth()
        {
            return width;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetWidth(Double width)
        {
            if (width > 0) this.width = width;
        }
        public void SetHeight(Double height)
        {
            if (height > 0) this.height = height;
        }
    }
    class RectWithProp
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class RectWithPropFull
    {
        private double width;

        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
        private double height;
        public double Height { get { return height; } set { if (value >= 0) height = value; } }
        class Property
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle();
                r.SetHeight(10.0);
                r.SetHeight(10.0);

                RectWithProp r1 = new RectWithProp();
                r1.Width = 10.0;
                r1.Height = 10.0;

                RectWithPropFull r2 = new RectWithPropFull();
                r2.width = 10.0;
                r2.height = 10.0;

                RectWithPropFull r3 = new RectWithPropFull();
                r3.width = 10.0;
                r3.height = -10.0;
            }
        }
    }
}
