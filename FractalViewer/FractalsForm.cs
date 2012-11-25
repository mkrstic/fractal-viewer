using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Globalization;
using System.Threading;
using System.Drawing.Printing;

namespace FractalViewer
{
    public partial class FractalsForm : Form
    {
        private int maxIterations = 800;      // max iterations
        private const double default_xstart = -2.025; // start value real
        private const double default_ystart = -1.125; // start value imaginary
        private const double default_xend = 0.6;    // end value real
        private const double default_yend = 1.125;  // end value imaginary
        private static int canvasWidth, canvasHeight, mouse_x_start, mouse_y_start, mouse_x_end, mouse_y_end;
        private static double xstart, ystart, xend, yend, xzoom, yzoom;
        private static bool action, isRectangle;
        private static float xy;
        private bool mouseLeftPressed = false;
        private Stack<FractalContext> fractalStack;
        private Point lastMouseRelativePosition;
        private Graphics graphics;
        private Bitmap bitmap;
		
        private Size oldFormSize;
        private int intensity = 255;
        private double gamma = 1.0;
        
        public FractalsForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            zoomOutMenuItem.Enabled = false;
            zoomOutContextMenuItem.Enabled = false;
            zoomOutToolbarButton.Enabled = false;
            fractalStack = new Stack<FractalContext>();
            oldFormSize = this.Size;
            lastMouseRelativePosition = new Point();
            canvasWidth = pictureBox.Size.Width;
            canvasHeight = pictureBox.Size.Height;
            xy = (float)canvasWidth / (float)canvasHeight;
            bitmap = new Bitmap(canvasWidth, canvasHeight, PixelFormat.Format32bppArgb);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            pictureBox.Image = bitmap;
            start();
        }
        public void setOptionsParameters(int maxIterations, int gamma, int intensity)
        {
            this.maxIterations = maxIterations;
            this.gamma = gamma;
            this.intensity = intensity;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fractalStack.Clear();
            canvasWidth = pictureBox.Size.Width;
            canvasHeight = pictureBox.Size.Height;
            zoomOutMenuItem.Enabled = false;
            zoomOutContextMenuItem.Enabled = false;
            zoomOutToolbarButton.Enabled = false;
            start();
            pictureBox.Refresh();
            
            /*    bitmap = new Bitmap(canvasWidth, canvasHeight, PixelFormat.Format32bppArgb);
                graphics = Graphics.FromImage(bitmap);
                pictureBox.Image = bitmap;
                start();*/
        }

        
        public void start()
        {
            action = false;
            isRectangle = false;
            initCalculationValues();
            xzoom = (xend - xstart) / (double)canvasWidth;
            yzoom = (yend - ystart) / (double)canvasHeight;
            DoMandelbrot();
        }
        private void initCalculationValues()
        {
            xstart = default_xstart;
            ystart = default_ystart;
            xend = default_xend;
            yend = default_yend;
            if ((float)((xend - xstart) / (yend - ystart)) != xy)
                xstart = xend - (yend - ystart) * (double)xy;
        }
        private void DoMandelbrot()
        {
            action = false;
            this.Cursor = Cursors.WaitCursor;
            graphics.Clear(Color.White);

            for (int x = 0; x < canvasWidth; x += 2)
            {
                for (int y = 0; y < canvasHeight; y++)
                {
                    int iter = getWaveLength(xstart + xzoom * (double)x, ystart + yzoom * (double)y);
                    Color c = getColorFromWaveLength(iter + 350);
                    Pen pen = new Pen(c);
                    graphics.DrawLine(pen, x, y, x + 1, y);
                }
            }
            this.Cursor = Cursors.Cross;
            action = true;
            
        }
        public void update(Graphics g)
        {
            
            if (isRectangle)
            {
                Pen pen = new Pen(Color.White);
                if (mouse_x_start < mouse_x_end)
                {
                    if (mouse_y_start < mouse_y_end) g.DrawRectangle(pen, mouse_x_start, mouse_y_start, (mouse_x_end - mouse_x_start), (mouse_y_end - mouse_y_start));
                    else g.DrawRectangle(pen, mouse_x_start, mouse_y_end, (mouse_x_end - mouse_x_start), (mouse_y_start - mouse_y_end));

                }
                else
                {
                    if (mouse_y_start < mouse_y_end) g.DrawRectangle(pen, mouse_x_end, mouse_y_start, (mouse_x_start - mouse_x_end), (mouse_y_end - mouse_y_start));
                    else g.DrawRectangle(pen, mouse_x_end, mouse_y_end, (mouse_x_start - mouse_x_end), (mouse_y_start - mouse_y_end));
                }
            }
        }
        
        
        private Color getColorFromWaveLength(int Wavelength)
        {
            double Gamma = gamma;
            int IntensityMax = intensity;

            double Blue;
            double Green;
            double Red;
            double Factor;

            if (Wavelength >= 350 && Wavelength <= 439)
            {
                Red = -(Wavelength - 440d) / (440d - 350d);
                Green = 0.0;
                Blue = 1.0;
            }
            else if (Wavelength >= 440 && Wavelength <= 489)
            {
                Red = 0.0;
                Green = (Wavelength - 440d) / (490d - 440d);
                Blue = 1.0;
            }
            else if (Wavelength >= 490 && Wavelength <= 509)
            {
                Red = 0.0;
                Green = 1.0;
                Blue = -(Wavelength - 510d) / (510d - 490d);
            }
            else if (Wavelength >= 510 && Wavelength <= 579)
            {
                Red = (Wavelength - 510d) / (580d - 510d);
                Green = 1.0;
                Blue = 0.0;
            }
            else if (Wavelength >= 580 && Wavelength <= 644)
            {
                Red = 1.0;
                Green = -(Wavelength - 645d) / (645d - 580d);
                Blue = 0.0;
            }
            else if (Wavelength >= 645 && Wavelength <= 780)
            {
                Red = 1.0;
                Green = 0.0;
                Blue = 0.0;
            }
            else
            {
                Red = 0.0;
                Green = 0.0;
                Blue = 0.0;
            }

            if (Wavelength >= 350 && Wavelength <= 419)
            {
                Factor = 0.3 + 0.7 * (Wavelength - 350d) / (420d - 350d);
            }
            else if (Wavelength >= 420 && Wavelength <= 700)
            {
                Factor = 1.0;
            }
            else if (Wavelength >= 701 && Wavelength <= 780)
            {
                Factor = 0.3 + 0.7 * (780d - Wavelength) / (780d - 700d);
            }
            else
            {
                Factor = 0.0;
            }

            int R = this.factorAdjust(Red, Factor, IntensityMax, Gamma);
            int G = this.factorAdjust(Green, Factor, IntensityMax, Gamma);
            int B = this.factorAdjust(Blue, Factor, IntensityMax, Gamma);

            return Color.FromArgb(R, G, B);
        }

        private int factorAdjust(double Color, double Factor, int IntensityMax, double Gamma)
        {
            if (Color == 0.0)
            {
                return 0;
            }
            else
            {
                return (int)Math.Round(IntensityMax * Math.Pow(Color * Factor, Gamma));
            }
        }

        

        private int getWaveLength(double x0, double y0)
        {
            double x = 0.0, y = 0.0, xtemp = 0.0;
            int iterationsCount = 0;


            while ((iterationsCount < maxIterations) && (x < 4.0))
            {
                iterationsCount++;
                xtemp = x*x - y * y + x0; 
                y = 2.0 * x * y + y0;
                x = xtemp;
            }
            return iterationsCount;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            lastMouseRelativePosition.X = e.X;
            lastMouseRelativePosition.Y = e.Y;
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                mouseLeftPressed = true;
                if (action)
                {
                    mouse_x_start = e.X;
                    mouse_y_start = e.Y;

                }

            }
            else if ((Control.MouseButtons & MouseButtons.Right) == MouseButtons.Right)
            {
                mouseLeftPressed = false;
                pictureBoxContextMenu.Show(Control.MousePosition.X, Control.MousePosition.Y);
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            int mouse_selection_height, mouse_selection_width;

            if (mouseLeftPressed)
            {
                mouseLeftPressed = false;
                if (action)
                {
                    mouse_x_end = e.X;
                    mouse_y_end = e.Y;
                    if (mouse_x_start > mouse_x_end)
                    {
                        int temp = mouse_x_start;
                        mouse_x_start = mouse_x_end;
                        mouse_x_end = temp;
                    }
                    if (mouse_y_start > mouse_y_end)
                    {
                        int temp = mouse_y_start;
                        mouse_y_start = mouse_y_end;
                        mouse_y_end = temp;
                    }
                    mouse_selection_width = (mouse_x_end - mouse_x_start);
                    mouse_selection_height = (mouse_y_end - mouse_y_start);
                    if ((mouse_selection_width < 2) && (mouse_selection_height < 2))
                    {

                        zoomInContextMenuItem_Click(sender, e);
                    }
                    else
                    {
                        FractalContext fc = new FractalContext(bitmap, xstart, ystart, xend, yend, xzoom, yzoom);
                        fractalStack.Push(fc);
                        zoomOutMenuItem.Enabled = true;
                        zoomOutContextMenuItem.Enabled = true;
                        zoomOutToolbarButton.Enabled = true;

                        if (((float)mouse_selection_width > (float)mouse_selection_height * xy))
                            mouse_y_end = (int)((float)mouse_y_start + (float)mouse_selection_width / xy);
                        else
                            mouse_x_end = (int)((float)mouse_x_start + (float)mouse_selection_height * xy);
                        xend = xstart + xzoom * (double)mouse_x_end;
                        yend = ystart + yzoom * (double)mouse_y_end;
                        xstart += xzoom * (double)mouse_x_start;
                        ystart += yzoom * (double)mouse_y_start;
                    }
                    xzoom = (xend - xstart) / (double)canvasWidth;
                    yzoom = (yend - ystart) / (double)canvasHeight;
                    DoMandelbrot();

                    isRectangle = false;
                    pictureBox.Invalidate();
                    pictureBox.Refresh();

                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if ((Control.MouseButtons & MouseButtons.Left) == MouseButtons.Left)
            {
                if (action)
                {
                    mouse_x_end = e.X;
                    mouse_y_end = e.Y;
                    isRectangle = true;
                    pictureBox.Refresh();
                }
            }
        }

        private void zoomOutContextMenuItem_Click(object sender, EventArgs e)
        {
            if (fractalStack.Count > 0)
            {
                FractalContext fc = fractalStack.Pop();
                if (fractalStack.Count == 0)
                {
                    zoomOutMenuItem.Enabled = false;
                    zoomOutContextMenuItem.Enabled = false;
                    zoomOutToolbarButton.Enabled = false;
                }
                xstart = fc.Xstart;
                ystart = fc.Ystart;
                xend = fc.Xend;
                yend = fc.Yend;
                xzoom = fc.Xzoom;
                yzoom = fc.Yzoom;
                bitmap = fc.Bitmap;

                pictureBox.Image = bitmap;
                
                graphics = Graphics.FromImage(pictureBox.Image);                
                DoMandelbrot();
            }
        }

        private void zoomInContextMenuItem_Click(object sender, EventArgs e)
        {
            FractalContext fc = new FractalContext(bitmap, xstart, ystart, xend, yend, xzoom, yzoom);
            fractalStack.Push(fc);
            zoomOutMenuItem.Enabled = true;
            zoomOutContextMenuItem.Enabled = true;
            zoomOutToolbarButton.Enabled = true;
            mouse_x_start = lastMouseRelativePosition.X - 10;
            mouse_x_end = lastMouseRelativePosition.X + 10;
            mouse_y_start = lastMouseRelativePosition.Y - 10;
            mouse_y_end = lastMouseRelativePosition.Y - 10;
            int mouse_selection_width = (mouse_x_end - mouse_x_start);
            int mouse_selection_height = (mouse_y_end - mouse_y_start);
            if (((float)mouse_selection_width > (float)mouse_selection_height * xy))
                mouse_y_end = (int)((float)mouse_y_start + (float)mouse_selection_width / xy);
            else
                mouse_x_end = (int)((float)mouse_x_start + (float)mouse_selection_height * xy);

            xzoom = (xend - xstart) / (double)canvasWidth*1000;
            yzoom = (yend - ystart) / (double)canvasHeight*1000;
            
            xend = xstart + xzoom * (double)mouse_x_end;
            yend = ystart + yzoom * (double)mouse_y_end;
            xstart += xzoom * (double)mouse_x_start;
            ystart += yzoom * (double)mouse_y_start;

            

            DoMandelbrot();
            isRectangle = false;
            pictureBox.Invalidate();
            pictureBox.Refresh();
        }

        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            StringBuilder filters = new StringBuilder("");
            ImageFormat[] fileFormats = new ImageFormat[5];
            filters.Append("Image (*.BMP)|*.bmp|"); fileFormats[0] = ImageFormat.Bmp;
            filters.Append("Image (*.GIF)|*.gif|"); fileFormats[1] = ImageFormat.Gif;
            filters.Append("Image (*.JPEG)|*.jpeg|"); fileFormats[2] = ImageFormat.Jpeg;
            filters.Append("Image (*.PNG)|*.png|"); fileFormats[3] = ImageFormat.Png;
            filters.Append("Image (*.TIFF)|*.tiff|"); fileFormats[4] = ImageFormat.Tiff;
            filters.Append("All Files (*.*)|*.*");
            saveDlg.Filter = filters.ToString();
            saveDlg.FileName = "fractalImage";
            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                int filterIndex = saveDlg.FilterIndex;
                if (filterIndex >= 6)
                    bitmap.Save(saveDlg.FileName + ".png", ImageFormat.Png);
                else
                    bitmap.Save(saveDlg.FileName, fileFormats[saveDlg.FilterIndex - 1]);
                MessageBox.Show(this, "Sucessfully saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolbarButton_Click(object sender, EventArgs e)
        {
            saveAsMenuItem_Click(sender, e);
        }

        private void saveAsContextMenuItem_Click(object sender, EventArgs e)
        {
            saveAsMenuItem_Click(sender, e);
        }

        private void newToolbarButton_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void zoomInMenuItem_Click(object sender, EventArgs e)
        {
            lastMouseRelativePosition.X = (int)(pictureBox.Left + pictureBox.Width) / 2;
            lastMouseRelativePosition.Y = (int)(pictureBox.Top + pictureBox.Height) / 2;
            zoomInContextMenuItem_Click(sender, e);
        }

        private void zoomOutMenuItem_Click(object sender, EventArgs e)
        {
            zoomOutContextMenuItem_Click(sender, e);
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (this.Cursor != Cursors.WaitCursor)
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(this, maxIterations, (int)gamma, intensity);
            optionsForm.ShowDialog(this);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            update(e.Graphics);
        }


        private void zoomInToolbarButton_Click(object sender, EventArgs e)
        {
            zoomInMenuItem_Click(sender, e);
        }

        private void zoomOutToolbarButton_Click(object sender, EventArgs e)
        {
            zoomOutMenuItem_Click(sender, e);
        }

        private void showToolbarMenuItem_Click(object sender, EventArgs e)
        {
            showToolbarMenuItem.Checked = !showToolbarMenuItem.Checked;
            toolbar.Visible = showToolbarMenuItem.Checked;
        }

        private void fullScreenMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox.Visible = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.menu.Visible = false;
            this.toolbar.Visible = false;
            showToolbarMenuItem.Checked = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            this.pictureBox.Height = this.Height;
            this.pictureBox.Width = this.Width;
            canvasHeight = pictureBox.Height;
			canvasWidth = pictureBox.Width;
			FractalsFormResizeEnd(sender,e);
            this.pictureBox.Visible = true;
            
              
            
        }

        private void FractalsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.pictureBox.Visible = false;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                menu.Visible = true;
                this.toolbar.Visible = true;
                showToolbarMenuItem.Checked = true;
                Size = new Size(800, 600);
                int boundWidth = Screen.PrimaryScreen.Bounds.Width;
                int boundHeight = Screen.PrimaryScreen.Bounds.Height;
                int x = boundWidth - this.Width;
                int y = boundHeight - this.Height;
                this.Location = new Point(x / 2, y / 2);
				oldFormSize = this.Size;

                this.TopMost = false;
                this.pictureBox.Visible = true;
            }
        }

        private void resetContextMenuItem_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void englishMenuItem_Click(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentUICulture.Name == "en-US")
                return;
            CultureInfo engCultureInfo = new CultureInfo("");
            Thread.CurrentThread.CurrentUICulture = engCultureInfo;
            Thread.CurrentThread.CurrentCulture = engCultureInfo;
            Controls.Clear();
            InitializeComponent();
            pictureBox.Image = bitmap;
            
        }

        private void serbianMenuItem_Click(object sender, EventArgs e)
        {
            if (CultureInfo.CurrentUICulture.Name == "sr-Latn-CS")
                return;
            CultureInfo engCultureInfo = new CultureInfo("sr-Latn-CS");
            Thread.CurrentThread.CurrentUICulture = engCultureInfo;
            Thread.CurrentThread.CurrentCulture = engCultureInfo;
            Controls.Clear();
            InitializeComponent();
            pictureBox.Image = bitmap;
        }
      
        private void printMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printPreviewMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void printToolbarButton_Click(object sender, EventArgs e)
        {
            printMenuItem_Click(sender, e);
        }

        private void printPreviewToolbarButton_Click(object sender, EventArgs e)
        {
            printPreviewMenuItem_Click(sender, e);
        }

        
        void FractalsFormSizeChanged(object sender, EventArgs e)
        {
        	// TODO

        }
        
        void FractalsFormResizeEnd(object sender, EventArgs e)
        {
        		if (oldFormSize == null || oldFormSize != this.Size) {
        			fractalStack.Clear();
                	canvasWidth = pictureBox.Size.Width;
	                canvasHeight = pictureBox.Size.Height;
	                
	                lastMouseRelativePosition.X = pictureBox.Left+15;
            		lastMouseRelativePosition.Y = pictureBox.Top + pictureBox.Height-15;
            		bitmap = new Bitmap(canvasWidth, canvasHeight, PixelFormat.Format32bppArgb);
            		graphics = Graphics.FromImage(bitmap);
            		pictureBox.Image = bitmap;
            		zoomInContextMenuItem_Click(sender, e);
            		zoomOutContextMenuItem_Click(sender,e);
    	            /*bitmap = new Bitmap(canvasWidth, canvasHeight, PixelFormat.Format32bppArgb);
    	            graphics = Graphics.FromImage(bitmap);
    	            pictureBox.Image = bitmap;
    	            start();	*/
    	            oldFormSize = this.Size;
        		}
    	}
    }
}