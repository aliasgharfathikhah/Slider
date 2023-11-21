using System.Security.Cryptography;

namespace Slider
{
    public partial class Form1 : Form
    {

        List<string> picherlist = new List<string>();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public string newPicher(bool plasormaiz)
        {

            if (plasormaiz == true)
            {

                if (count + 1 > picherlist.Count() - 1)
                {
                    count = 0;
                    return picherlist[0];
                }
                else
                {
                    count++;
                    return picherlist[count];
                }
            }
            else
            {

                if (count == 0)
                {
                    count = picherlist.Count() - 1;
                    return picherlist[picherlist.Count() - 1];
                }
                else
                {
                    count--;
                    return picherlist[count];
                }
            }

        }

        private void pictureBoxAddImg_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Title = "Browse image for slider";
            OpenFileDialog.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG";
            OpenFileDialog.InitialDirectory = @"C:\";
            OpenFileDialog.Multiselect = true;

            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBefore.Visible = true;
                pictureBoxNext.Visible = true;
                pictureBoxZoomin.Visible = true;
                pictureBoxZoomOut.Visible = true;
                labelNext.Visible = true;
                labelBefore.Visible = true;
                pictureBoxImag.Visible = true;

                string[] files = OpenFileDialog.FileNames;
                foreach (string file in files)
                {
                    
                    picherlist.Add(file);
                    
                }
                pictureBoxImag.Image = Image.FromFile(picherlist[0]);
                timer1.Enabled = true;

            }
        }

        private void pictureBoxZoomin_Click(object sender, EventArgs e)
        {
            pictureBoxImag.Width += 50;
            pictureBoxImag.Height += 50;
        }

        private void pictureBoxZoomOut_Click(object sender, EventArgs e)
        {
            pictureBoxImag.Width -= 50;
            pictureBoxImag.Height -= 50;
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            pictureBoxImag.Width = 535;
            pictureBoxImag.Height = 403;
            pictureBoxImag.Image = Image.FromFile(newPicher(true));
        }

        private void pictureBoxBefore_Click(object sender, EventArgs e)
        {
            pictureBoxImag.Width = 535;
            pictureBoxImag.Height = 403;
            pictureBoxImag.Image = Image.FromFile(newPicher(false));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxImag.Image = Image.FromFile(newPicher(true));
        }
    }
}