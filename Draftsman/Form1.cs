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
    }
}
