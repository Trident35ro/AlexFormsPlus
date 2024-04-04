using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlexFormsPlus
{
    public partial class Form4 : Form
    {
        // Store the list of points
        private readonly PointF[] points = new PointF[100];
        private int pointCount = 0;
        private float zoomFactor = 1.0f;

        public Form4()
        {
            InitializeComponent();
            InitializeAxes();
            pictureBox1.MouseWheel += PictureBox_MouseWheel;
        }

        private void InitializeAxes()
        {
            // No need to create a new PictureBox, you can use the existing one on the form
            pictureBox1.Paint += PictureBox_Paint;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            // Draw the axes
            DrawAxes(e.Graphics);

            // Draw the points
            foreach (PointF point in points)
            {
                if (point != PointF.Empty)
                {
                    DrawPoint(e.Graphics, point);
                }
            }

            // Draw axis labels
            DrawAxisLabels(e.Graphics);
        }

        private void DrawAxes(Graphics g)
        {
            // Define the size and location of the axes
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            int xAxisYPos = height / 2; // Position of x-axis on y-axis
            int yAxisXPos = width / 2; // Position of y-axis on x-axis

            // Calculate the step size for the tick marks and labels based on the zoom factor
            float xStepSize = Math.Max(1, 10 / zoomFactor); // Adjust the min step size as needed
            float yStepSize = Math.Max(1, 10 / zoomFactor); // Adjust the min step size as needed

            // Draw x-axis
            g.DrawLine(Pens.Black, 0, xAxisYPos, width, xAxisYPos);
            // Draw x-axis tick marks and labels starting from 10
            for (float i = 10 - yAxisXPos; i <= width - yAxisXPos; i += xStepSize)
            {
                int x = yAxisXPos + (int)(i * zoomFactor);
                if (x >= 0 && x <= width) // Ensure the tick mark is within the bounds of the PictureBox
                {
                    g.DrawLine(Pens.Black, x, xAxisYPos - 5, x, xAxisYPos + 5);
                    g.DrawString(Math.Round(i).ToString(), this.Font, Brushes.Black, new PointF(x, xAxisYPos + 5));
                }
            }

            // Draw y-axis
            g.DrawLine(Pens.Black, yAxisXPos, 0, yAxisXPos, height);
            // Draw y-axis tick marks and labels starting from 10
            for (float i = 10 - xAxisYPos; i <= height - xAxisYPos; i += yStepSize)
            {
                int y = xAxisYPos - (int)(i * zoomFactor);
                if (y >= 0 && y <= height) // Ensure the tick mark is within the bounds of the PictureBox
                {
                    g.DrawLine(Pens.Black, yAxisXPos - 5, y, yAxisXPos + 5, y);
                    g.DrawString(Math.Round(i).ToString(), this.Font, Brushes.Black, new PointF(yAxisXPos + 5, y));
                }
            }

            // Draw "0" for both x-axis and y-axis
            g.DrawString("0", this.Font, Brushes.Black, new PointF(yAxisXPos + 5, xAxisYPos + 5));
        }

        private void DrawPoint(Graphics g, PointF point)
        {
            // Calculate the position of the point on the PictureBox
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            int yAxisXPos = width / 2; // Position of y-axis on x-axis
            int xAxisYPos = height / 2; // Position of x-axis on y-axis
            float x = yAxisXPos + point.X * zoomFactor;
            float y = xAxisYPos - point.Y * zoomFactor; // Invert y because y increases downward

            // Draw the point
            g.FillEllipse(Brushes.Red, x - 3, y - 3, 6, 6);
        }

        private void DrawAxisLabels(Graphics g)
        {
            // Define the size and location of the axes
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            int xAxisYPos = height / 2; // Position of x-axis on y-axis
            int yAxisXPos = width / 2; // Position of y-axis on x-axis
            int axisLabelOffset = 10;

            // Draw x-axis label
            g.DrawString("X", this.Font, Brushes.Black, new PointF(width - axisLabelOffset, xAxisYPos - axisLabelOffset));

            // Draw y-axis label
            g.DrawString("Y", this.Font, Brushes.Black, new PointF(yAxisXPos + axisLabelOffset, 0));
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            // Adjust the zoom factor based on the mouse wheel delta
            const float zoomChange = 0.1f;
            if (e.Delta > 0)
            {
                // Zoom in
                zoomFactor += zoomChange;
            }
            else
            {
                // Zoom out, ensuring zoom factor doesn't become negative
                zoomFactor = Math.Max(zoomFactor - zoomChange, 0.1f);
            }

            // Refresh the PictureBox to apply the zoom
            pictureBox1.Refresh();
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            // Parse the input coordinates
            if (float.TryParse(txtX.Text, out float x) && float.TryParse(txtY.Text, out float y))
            {
                // Add the point to the array
                points[pointCount] = new PointF(x, y);
                pointCount++;

                // Redraw the PictureBox
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Please enter valid coordinates.");
            }
        }
    }
}
