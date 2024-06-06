using System.Runtime.Intrinsics.Arm;

namespace Draftsman
{
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }

        Thread th1;
        Thread th2;
        Thread th3;
        Random rdm;

        private void Board_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            th1 = new Thread(RectangleThread);
            th1.Start();
        }
        private void btnTriangle_Click(object sender, EventArgs e)
        {
            th2 = new Thread(TriangleThread);
            th2.Start();
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            th3 = new Thread(CircleThread);
            th3.Start();
        }

        public void RectangleThread()
        {
            Random rdm = new Random();
            for (int i = 0; i < 100; i++)
            {
                int size = rdm.Next(5, 50);
                int x = rdm.Next(0, Width - size);
                int y = rdm.Next(0, Height - size);

                Color randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawRectangle(pen, new Rectangle(x, y, size, size));
                }

                size = rdm.Next(5, 50);
                x = rdm.Next(0, Width - size);
                y = rdm.Next(0, Height - size);

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawRectangle(pen, new Rectangle(x, y, size, size));
                }

                size = rdm.Next(5, 50);
                x = rdm.Next(0, Width - size);
                y = rdm.Next(0, Height - size);

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawRectangle(pen, new Rectangle(x, y, size, size));
                }

                Thread.Sleep(100);
            }

            MessageBox.Show("Completed rectangle");
        }
        public void TriangleThread()
        {
            Random rdm = new Random();
            for (int i = 0; i < 100; i++)
            {
                int size = rdm.Next(20, 50);
                Point p1 = new Point(rdm.Next(size, Width - size), rdm.Next(size, Height - size));
                Point p2 = new Point(p1.X + size, p1.Y);
                Point p3 = new Point(p1.X + (size / 2), p1.Y - (int)(Math.Sqrt(3) / 2 * size));

                Color randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawPolygon(pen, new Point[] { p1, p2, p3 });
                }

                size = rdm.Next(20, 50);
                Point p4 = new Point(rdm.Next(size, Width - size), rdm.Next(size, Height - size));
                Point p5 = new Point(p4.X + size, p4.Y);
                Point p6 = new Point(p4.X + (size / 2), p4.Y - (int)(Math.Sqrt(3) / 2 * size));

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawPolygon(pen, new Point[] { p4, p5, p6 });
                }

                size = rdm.Next(20, 50);
                Point p7 = new Point(rdm.Next(size, Width - size), rdm.Next(size, Height - size));
                Point p8 = new Point(p7.X + size, p7.Y);
                Point p9 = new Point(p7.X + (size / 2), p7.Y - (int)(Math.Sqrt(3) / 2 * size));

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawPolygon(pen, new Point[] { p7, p8, p9 });
                }

                Thread.Sleep(100);
            }

            MessageBox.Show("Completed triangle");
        }
        public void CircleThread()
        {
            Random rdm = new Random();
            for (int i = 0; i < 100; i++)
            {
                int size = rdm.Next(5, 50);
                int x = rdm.Next(0, Width - size);
                int y = rdm.Next(0, Height - size);

                Color randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawEllipse(pen, x, y, size, size);
                }

                size = rdm.Next(5, 50);
                x = rdm.Next(0, Width - size);
                y = rdm.Next(0, Height - size);

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawEllipse(pen, x, y, size, size);
                }

                size = rdm.Next(5, 50);
                x = rdm.Next(0, Width - size);
                y = rdm.Next(0, Height - size);

                randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
                using (Pen pen = new Pen(randomColor, 4))
                {
                    CreateGraphics().DrawEllipse(pen, x, y, size, size);
                }

                Thread.Sleep(100);
            }

            MessageBox.Show("Completed circle");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.Clear(DefaultBackColor);
        }
    }
}
