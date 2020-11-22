using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace A20_Ex03_Shmuel_204286793_Hen_313468654
{
    public class EllipseLoadingAndGrowingPictureBox : PictureBox
    {
        private const int k_DefaultWidthAndHeight = 90;
        private const int k_AmountToGrow = 10;
        private const bool k_Grow = true;
        private readonly bool r_IsClickAble;

        ////For creation in the form (By drag and drop) - support only Loading status and Ellipse pictureBox
        public EllipseLoadingAndGrowingPictureBox() : base()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        ////For dynmic use - supports all functions.
        public EllipseLoadingAndGrowingPictureBox(bool i_IsClickAble)
        {
            try
            {
                r_IsClickAble = i_IsClickAble;
                SizeMode = PictureBoxSizeMode.StretchImage;
                Size = new Size(k_DefaultWidthAndHeight, k_DefaultWidthAndHeight);

                if (i_IsClickAble)
                {
                    this.Cursor = Cursors.Hand;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            try
            {
                Image = Properties.Resources.loading2Gif;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);
            try
            {
                using (GraphicsPath obj = new GraphicsPath())
                {
                    obj.AddEllipse(0, 0, this.Width - 1, this.Height - 1);
                    Region = new Region(obj);
                    paintEvent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    paintEvent.Graphics.DrawEllipse(
                        new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1, this.Height - 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnMouseEnter(EventArgs i_Args)
        {
            if(r_IsClickAble)
            {
                this.resize(k_Grow);
            }       
        }

        protected override void OnMouseLeave(EventArgs i_Args)
        {
            if(r_IsClickAble)
            {
                this.resize(!k_Grow);
            } 
        }

        private void resize(bool i_Grow)
        {
            int negator = i_Grow ? 1 : -1;

            this.Size = new Size(
                this.Size.Width + (negator * k_AmountToGrow),
                this.Size.Height + (negator * k_AmountToGrow));
        }
    }
}
