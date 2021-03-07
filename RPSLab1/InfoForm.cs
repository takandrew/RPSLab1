using System;
using System.Windows.Forms;

namespace RPSLab1
{
    public partial class InfoForm : Form
    {
        public InfoForm() //Справочное окно
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
        }

        private void button1_Click(object sender, EventArgs e) //Кнопка "Вернуться" 
        {
            this.Close();
        }

    }
}
