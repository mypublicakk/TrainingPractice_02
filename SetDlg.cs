using System;
using System.Windows.Forms;


namespace mosaic
{
    // Класс диалогового окна настроек программы
    public partial class SetDlg : Form
    {
        public SetDlg()
        {
            InitializeComponent();
        }

        public int numRect = 4;

        //Загрузка предыдущих настроек.
        private void SetDlg_Load(object sender, EventArgs e)
        {

            switch (numRect)
            {
                case 3:
                    radioButton_3x3.Checked = true;
                    break;
                case 4:
                    radioButton_4x4.Checked = true;
                    break;
                case 5:
                    radioButton_5x5.Checked = true;
                    break;
                case 6:
                    radioButton_6x6.Checked = true;
                    break;
            }
        }

        //Изменение настроек программы.
        private void radioButton_3x3_CheckedChanged(object sender, EventArgs e)
        {
            switch (sender)
            {
                case RadioButton r when r == radioButton_3x3:
                    numRect = 3;
                    break;
                case RadioButton r when r == radioButton_4x4:
                    numRect = 4;
                    break;
                case RadioButton r when r == radioButton_5x5:
                    numRect = 5;
                    break;
                case RadioButton r when r == radioButton_6x6:
                    numRect = 6;
                    break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
