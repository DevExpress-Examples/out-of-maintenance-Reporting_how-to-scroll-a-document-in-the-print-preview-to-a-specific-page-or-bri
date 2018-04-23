using System;
using System.Windows.Forms;

namespace PrintGoToPage
{
    public partial class Form1 : Form
    {
        public delegate void ActivateFormDelegate();

        public void ActivateFormMethod() {
            this.Activate();
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            for(int i = 0; i < 500; i++) {
                SimpleLink link = new SimpleLink("Simple Text " + i.ToString());
                compositeLink1.Links.Add(link);
            }
            
            compositeLink1.ShowPreview();
            button2.Enabled = true;
            button3.Enabled = true;

            this.BeginInvoke(new ActivateFormDelegate(ActivateFormMethod));
        }

        private void button2_Click(object sender, EventArgs e) {
            printingSystem1.PreviewFormEx.PrintControl.SelectedPageIndex = 2;
        }

        private void button3_Click(object sender, EventArgs e) {
            DevExpress.XtraPrinting.Page page = printingSystem1.Document.Pages[3];
            DevExpress.XtraPrinting.BrickEnumerator brickEnumerator = page.GetEnumerator();
            DevExpress.XtraPrinting.Brick brick = null;

            for(int i = 0; i < 5; i++) {
                brickEnumerator.MoveNext();
                brick = brickEnumerator.CurrentBrick;
            }

            printingSystem1.PreviewFormEx.PrintControl.ShowBrick(brick, page);
            printingSystem1.MarkBrick(brick, page);
        }

    }
}