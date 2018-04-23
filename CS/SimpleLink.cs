using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.IO;

namespace PrintGoToPage
{
    class SimpleLink : Link
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public SimpleLink():this("")
        {

        }

        public SimpleLink(string text)
        {
            this.text = text;
        }

        protected override void CreateDetail(BrickGraphics graph)
        {
            base.CreateDetail(graph);

            SizeF textSize = graph.MeasureString(Text, (int)graph.ClientPageSize.Width);

            RectangleF rect = new RectangleF(0, 0, textSize.Width, textSize.Height);
            
            graph.BorderWidth = 0;
            graph.DrawString(text, rect);
        }
    }
}
