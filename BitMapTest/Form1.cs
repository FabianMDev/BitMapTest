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
        }

        private Bitmap Bitmap;

        public Dictionary<int, PointF> StartPointCollection = new Dictionary<int, PointF>();

        public int PointCount = 0;

        public PointF CurrientPoint;
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PointF point = new Point(e.X, e.Y);
            PointCount++;
            PointsCount.Text = PointCount.ToString();
            StartPointCollection.Add(StartPointCollection.Count, point);
            checkedListBox1.Items.Add(point);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                int iRND = rnd.Next(0, StartPointCollection.Count);

                PointF newP = ClacPoint(Bitmap, StartPointCollection[iRND], CurrientPoint);
                DrawPoint(Bitmap, newP);
                CurrientPoint = newP;
            }
            pictureBox1.Image = Bitmap;
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
            btm.SetPixel((int)p.X, (int)p.Y, Color.HotPink);

        }

    } 
}