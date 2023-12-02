//подключение необходимых библиотек
//подключение библиотек в С++ имеет вид: #include <...>
// также в С++ можно добавить пространство имен: using namespace std;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//объявление области действий (название взято из названия проекта)
//С++ : stuct To_Do_List{}

namespace To_Do_List
{
    //объявление части класса (а именно функциональной части, 
    //проект Windows Form имеет второй файл с дизайном), класс DailyPlanner наследуется от класса Form
    //В C++: partial ref class DailyPlanner {};

    public partial class DailyPlanner : Form
    {
        //вызов метода одной из библиотек для открытия пользовательского интерфейса
        //C++: public:

        public DailyPlanner()
        {
            InitializeComponent();
        }

        //создание новой таблицы
        //C++: одним из способов создания таблицы с С++ является двумерный массив - например String table[100][100];
        //также можно: Data::DataTable ^table1 = gcnew DataTable();

        DataTable listofTask = new DataTable();

        //создание булевой переменной (только занчение false или true)
        //С++: bool isEditing = false;

        bool isEditing = false;

        //Функция для первого отображения приложение
        //C++: ref class DailyPlanner

        private void DailyPlanner_Load(object sender, EventArgs e)
        {

            //создание необходимых колонок таблицы
            //С++: table1->Columns->Add(gcnew DataColumn("..."));

            listofTask.Columns.Add("Задача");
            listofTask.Columns.Add("Дедлайн");
            listofTask.Columns.Add("Заметки");

            //указание на таблицу с данными
            //C++: dataGridView1->DataSource = table1;

            dataGridViewTask.DataSource = listofTask;
        }

        //создание функции для клика по кнопке "Изменить"
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //изменение булевой переменной для дальнейшего сохранения измененных данных (функция для клика по кнопке "Сохранить")
            //C++: isEditing = true;

            isEditing = true;

            //возврат данных из таблицы в строки вноса данных для изменения

            textBoxTask.Text = listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex].ItemArray[0].ToString();
            textBoxNote.Text = listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex].ItemArray[2].ToString();
        }

        //создание функции для клика по кнопке "Удалить"
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //во избежание ошибок (удаления пустых ячеек) используется try и catch
            //С++: структура try {} catch {} такая же

            try
            {
                //удаление строки с данными

                listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                //вывод имени ошибки
                //C++: cout << "Error: " + ex

                Console.WriteLine("Error: " + ex);
            }
        }

        //функция для клика по кнопке "Сохранить"
        private void buttonSave_Click(object sender, EventArgs e)
        {
            //если булевая переменная = true, значит старые данные заменяются на новые, в противном случае добавляется новая строка данных
            //С++: структура if {} else {} такая же

            if (isEditing)
            {
                //сохранение измененных данных

                listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex]["Задача"] = textBoxTask.Text;

                //To.String("d") реализует дату в формате dd/MM/yyyy
                listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex]["Дедлайн"] = dateTimePicker1.Value.ToString("d");
                listofTask.Rows[dataGridViewTask.CurrentCell.RowIndex]["Заметки"] = textBoxNote.Text;
            }
            else
            {
                //сохранение данных

                listofTask.Rows.Add(textBoxTask.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"), textBoxNote.Text);
            }

            //после сохранения данных строки для ввода очищаются

            textBoxTask.Text = "";
            textBoxNote.Text = "";

            //после сохранения данных календарь возвращает сегодняшнюю дату

            dateTimePicker1.Value = DateTime.Now;

            //после сохранения данных булевая переменная либо меняет значение, либо остается также равной false

            isEditing = false;
        }
    }
}
