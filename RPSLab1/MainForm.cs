using System;
using System.Windows.Forms;

namespace RPSLab1
{
    public partial class MainForm : Form
    {
        InfoForm showInfoForm = null;
         
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
            if (!ManualInputRadioButton.Checked && !RandomInputRadioButton.Checked
                && !FileInputRadioButton.Checked)
            {
                SizeOfArrayUpDown.Enabled = false;
                ManualInputTextBox.Enabled = false;
                ManualInputButton.Enabled = false;
                ChooseInputFile.Enabled = false;
                //Настройка доступа к элементам интерфейса при запуске программы
            }
        }

        double[] dataArray; //Массив, в который будут записываться данные
        private void ManualInputButton_Click(object sender, EventArgs e) 
            // Нажатие клавиши "ввести" при ручном вводе исходных данных 
        {
            bool incorrectInputMade = false; //Переменная для перехода к рассмотрению случая некорректного ввода
            IncorrectDataWarningLabel.Visible = false;
            try
            {
                //Процесс записи данных в массив из текстового поля интерфейса
                string dataString = ManualInputTextBox.Text; 
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++; 
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                dataArray = new double[withoutSpacesDataString.Length];
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    dataArray[i] = Convert.ToDouble(withoutSpacesDataString[i]);
                }
            }
            catch (Exception ex)
            {
                //Ход действий при некорректном вводе
                MessageBox.Show(ex.Message, "Ошибка ввода");
                incorrectInputMade = true;
            }
            if (incorrectInputMade == true)
            {
                IncorrectDataWarningLabel.Visible = true;
                SortButton.Enabled = false;
                DataTextBox.Text = null;
            }
            else
            {
                //Вывод данных в текстовое поле
                SortButton.Enabled = true;
                DataTextBox.Text = null;
                for (int i = 0; i < dataArray.Length; i++)
                {
                    DataTextBox.Text = DataTextBox.Text + ' ' + dataArray[i];
                }
            }
            
        }

        private void SortButton_Click(object sender, EventArgs e)
            //Нажатие клавиши "Сортировать" 
        {
            SortedDataTextBox.Text = null; 
            if (ManualInputRadioButton.Checked == true) //Ручной ввод данных
            {
                double[] sortedArray = new double[dataArray.Length];
                ArrayWorking arraySortObject = new ArrayWorking();
                sortedArray = arraySortObject.Sorting(dataArray); //Сортировка массива
                // Вывод отсортированного массива
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    SortedDataTextBox.Text = SortedDataTextBox.Text + ' ' + sortedArray[i];
                }
            }
            else if (RandomInputRadioButton.Checked == true) //Случайное заполнение данных 
            {
                DataTextBox.Text = null;
                ArrayWorking arrayRandomObject = new ArrayWorking();
                int sizeArray = Convert.ToInt32(SizeOfArrayUpDown.Text);//Считывание количества элементов в массиве
                double[] randomArray = new double[sizeArray];
                randomArray = arrayRandomObject.RandomArray(sizeArray);//Случайное заполнение данных
                for (int i = 0; i < randomArray.Length; i++)
                {
                    DataTextBox.Text = DataTextBox.Text + ' ' + randomArray[i]; //Вывод исходных данных
                }
                randomArray = arrayRandomObject.Sorting(randomArray); //Сортировка массива
                //Вывод отсортированного массива
                for (int i = 0; i < randomArray.Length; i++)
                {
                    SortedDataTextBox.Text = SortedDataTextBox.Text + ' ' + randomArray[i];
                }
            }
            else if (FileInputRadioButton.Checked == true) //Ввод исходных данных из файла
            {
                ArrayWorking arrayFileObject = new ArrayWorking();
                SortedDataTextBox.Text = null;
                fileArray = arrayFileObject.Sorting(fileArray); //Сортировка массива
                //Вывод отсортированного массива
                for (int i = 0; i < fileArray.Length; i++)
                {
                    SortedDataTextBox.Text = SortedDataTextBox.Text + ' ' + fileArray[i];
                }
            }
        }

        private void InformationToolStripMenuItem_Click(object sender, EventArgs e) //Вывод справочного окна
        {
            //Вызов формы и запрет на открытие множества одинаковых окон
            if (showInfoForm == null || showInfoForm.IsDisposed) 
            { 
                showInfoForm = new InfoForm(); 
                showInfoForm.Show(); 
            }
            else 
            { 
                showInfoForm.Show(); 
                showInfoForm.Focus(); 
            }
        }


        private void ManualInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Доступ на интерфейсе при выборе кнопки ручного ввода
            SortButton.Enabled = false;
            SizeOfArrayUpDown.Enabled = false;
            ManualInputTextBox.Enabled = true;
            ManualInputButton.Enabled = true;
            ChooseInputFile.Enabled = false;
        }

        private void RandomInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Доступ на интерфейсе при выборе кнопки случайного заполнения
            SortButton.Enabled = true;
            ManualInputButton.Enabled = false;
            SizeOfArrayUpDown.Enabled = true;
            ManualInputTextBox.Enabled = false;
            DataTextBox.Text = null;
            ChooseInputFile.Enabled = false;
        }

        private void FileInputRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Доступ на интерфейсе при выборе кнопки ввода из файла
            SizeOfArrayUpDown.Enabled = false;
            ManualInputTextBox.Enabled = false;
            ManualInputButton.Enabled = false;
            ChooseInputFile.Enabled = true;
        }

        double[] fileArray; //Массив для заполнения из файла
        private void ChooseInputFile_Click(object sender, EventArgs e) //Нажатие кнопки выбора файла 
        {
            IncorrectDataWarningLabel.Visible = false;
            bool incorrectInputMade = false; //Переменная для перехода к рассмотрению случая некорректного ввода
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return; //Случай с отменой выбора файла
                else
                {
                    string filename = openFileDialog1.FileName; //Выбор файла
                    //Процесс заполнения массива из файла
                    string fileText = System.IO.File.ReadAllText(filename); //Считывание из файла
                    string[] splittedText = fileText.Split(' ');
                    int zero = 0;
                    int countsSpaces = zero;
                    for (int i = 0; i < splittedText.Length; i++)
                    {
                        if (splittedText[i] != "")
                        {
                            countsSpaces++;
                        }
                    }
                    if (countsSpaces == zero)
                    {
                        MessageBox.Show("Исходные данные в файле отсутствуют", "Внимание!");
                        return;
                    }
                    string[] splittedWOSpaces = new string[countsSpaces];
                    int j = 0;
                    for (int i = 0; i < splittedText.Length; i++)
                    {
                        if (splittedText[i] != "")
                        {
                            splittedWOSpaces[j] = splittedText[i];
                            j++;
                        }
                    }
                    fileArray = new double[splittedWOSpaces.Length];
                    for (int i = 0; i < splittedWOSpaces.Length; i++)
                    {
                        fileArray[i] = Convert.ToDouble(splittedWOSpaces[i]);
                    }
                    MessageBox.Show("Файл открыт", "Открытие файла");
                }
            }
            catch (Exception ex)
            {
                //Случай некорректного ввода из файла
                MessageBox.Show("Ошибка ввода: \n" + ex.Message);
                incorrectInputMade = true;
            }
            if (incorrectInputMade == true)
            {
                IncorrectDataWarningLabel.Visible = true;
                SortButton.Enabled = false;
                DataTextBox.Text = null;
            }
            else
            {
                DataTextBox.Text = null;
                SortButton.Enabled = true;
                //Вывод исходных данных
                for (int i = 0; i < fileArray.Length; i++)
                {
                    DataTextBox.Text = DataTextBox.Text + ' ' + fileArray[i];
                }
            }
        }

        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e) 
            //Сохранение исходных данных в файл
        {
            if (DataTextBox.Text != "") //Проверка наличия исходных данных
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return; //Случай с отменой выбора файла
                string saveFilename = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(saveFilename, DataTextBox.Text); //Сохранение в файл
                MessageBox.Show("Файл сохранен", "Файл");
            }
            else
                MessageBox.Show("Исходные данные отсутствуют", "Файл");
        }

        private void SaveResultToolStripMenuItem_Click(object sender, EventArgs e)
            //Сохранение результата в файл
        {
            if (DataTextBox.Text != "" && SortedDataTextBox.Text != "") //Проверка наличия результата 
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return; //Случай с отменой выбора файла
                string saveFilename = saveFileDialog1.FileName;
                //Сохранение в файл
                System.IO.File.WriteAllText(saveFilename, "Исходные данные: \n" +
                    DataTextBox.Text + "\nОтсортированный массив: \n" + SortedDataTextBox.Text); 
                MessageBox.Show("Файл сохранен", "Файл");
            }
            else
                MessageBox.Show("Результат программы отсутствует", "Файл");
        }
    }
}
