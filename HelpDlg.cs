using System;
using System.Drawing;
using System.Windows.Forms;



namespace mosaic
{
    // Класс диалогового окна помощи пользователю
    public partial class HelpDlg : Form
    {
        public HelpDlg()
        {
            InitializeComponent();
        }

        public Image ImageDuplicate = null;

        // Загрузка картинки на форму посредством PictureBox.
        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = ImageDuplicate;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
