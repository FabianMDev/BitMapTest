namespace BitMapTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();

        }

        private void init()
        {
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            checkedListBox1.Items.Clear();
            StartPointCollection.Clear();
            PointCount = 0;
            PointsCount.Text = "0";
            pictureBox1.Image = Bitmap;
        }

        private Bitmap Bitmap;

        public Dictionary<int, PointF> StartPointCollection = new Dictionary<int, PointF>();

        public int PointCount = 0;

        public PointF CurrientPoint;
        public bool canGoToSameSpotAgain;
        public bool simulationAnimated;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PointF point = new Point(e.X, e.Y);
            PointCount++;
            PointsCount.Text = PointCount.ToString();
            StartPointCollection.Add(StartPointCollection.Count, point);
            checkedListBox1.Items.Add(point);
            Bitmap.SetPixel(e.X, e.Y, PointColor);
            pictureBox1.Image= Bitmap;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int lastRNDnum = 0;
            var nupSave = numericUpDown1.Value;

            for (int i = 0; i < nupSave; i++)
            {
                int iRND = rnd.Next(0, StartPointCollection.Count);
                
                if(!(lastRNDnum == iRND && canGoToSameSpotAgain == true)) { 
                PointF newP = ClacPoint(Bitmap, StartPointCollection[iRND], CurrientPoint);
                DrawPoint(Bitmap, newP);
                CurrientPoint = newP;
                lastRNDnum = iRND;
                    if (simulationAnimated && i % 100 == 0) animation(100);
                    
                }
            }
            pictureBox1.Image = Bitmap;
            numericUpDown1.Value = nupSave;
        }

        private void animation(int value)
        {
            numericUpDown1.Value -= value;
            numericUpDown1.Update();
            pictureBox1.Image = Bitmap;
            pictureBox1.Update();
        }

        private PointF ClacPoint(Bitmap btm, PointF pTo, PointF pCur)
        {
            PointF pbetween = new PointF(pTo.X, pCur.Y);
            float Xnew = ((pTo.X + pCur.X) / 2);
            float Ynew = ((pTo.Y + pCur.Y) / 2);

            return new PointF(Xnew, Ynew);
        }

        private void DrawPoint(Bitmap btm, PointF p)
        {
            if (p.X > btm.Width - 1) p.X = btm.Width - 1;
            if (p.Y > btm.Height - 1) p.Y = btm.Height - 1;
            btm.SetPixel((int)p.X, (int)p.Y, DotColor);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void buttonResetBM_Click(object sender, EventArgs e)
        {
            Bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = Bitmap;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //for(int i = 0;i < StartPointCollection.Count;i++)
            //{
            //    if ((PointF) checkedListBox1.CheckedItems[i] == StartPointCollection[i]) 
            //    {
            //        checkedListBox1.Items.Remove(StartPointCollection[i]);
            //        StartPointCollection.Remove(i);
            //        PointCount--;
            //    } 
            //}
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            canGoToSameSpotAgain = checkBox1.Checked;
        }

        private void checkBoxAnimation_CheckedChanged(object sender, EventArgs e)
        {
            simulationAnimated = checkBoxAnimation.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Clear();
            StartPointCollection.Clear();
            PointCount = 0;
            PointsCount.Text = "0";
        }

        private void buttonColorBackground_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            pictureBox1.BackColor = colorDialog.Color;
        }
        public Color DotColor = Color.Black;
        private void buttonColorDots_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            DotColor = colorDialog.Color;
        }
        public Color PointColor = Color.Red;
        private void buttonColorPoints_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            PointColor = colorDialog.Color;
        }
    } 
}