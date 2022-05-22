using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avia
{
    public partial class Form1 : Form
    {
        private DataGridView origrnaldatagrid;
        public classes classes;

        public Form1()
        {
            InitializeComponent();
            origrnaldatagrid = dataGridView1;

        }

        private void button_download_Click(object sender, EventArgs e)
        {
             dataGridView1.Rows.Clear();
            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение
            OleDbDataReader dbReader = null;

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();                                            // открываем соеденение
                string query = "SELECT * FROM Клиенты";                      // строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда
                dbReader = dbCommand.ExecuteReader();                           // считываем данные

                // Проверяем данные
                if (dbReader.HasRows == false)
                {
                    MessageBox.Show("Данные не найдены!", "Ошибка!");
                }
                else
                {
                    // Чтение данных
                    while (dbReader.Read())
                    {
                        // Выводим данные
                        dataGridView1.Rows.Add(dbReader["Кодклиента"], dbReader["Фамилия"], dbReader["Имя"], dbReader["Отчество"], dbReader["ДатаРождения"], dbReader["ДанныеПаспорта"], dbReader["Адрес"], dbReader["Телефон"]);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbReader.Close();
                dbConnection.Close();
            }
            ((Button)sender).Text = "Обновить";
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {

            

            Add_element add_Element = new Add_element(this);
            add_Element.ShowDialog();

            if (classes.name == "null")
            {
                return;
            }
            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb";  // строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);                   // создаем соеденение

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();//открываем соеденение
                string query = "INSERT INTO Клиенты(Фамилия , Имя , Отчество , ДатаРождения , ДанныеПаспорта , Адрес , Телефон) " +
                                   "VALUES ('" + classes.firstName + "', '" + classes.name + "', '" + classes.path + "', " + ("'" + classes.birt.Day + "." + classes.birt.Month + "." + classes.birt.Year + "'") + ", '" + classes.pass + "', '" + classes.address + "', '" + classes.telephone + "')";
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда
                
                // Выполняем запрос
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                    MessageBox.Show("Данные добавлены!", "Внимание!");
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbConnection.Close();

            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            // Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            // Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            string indexCell = dataGridView1.Rows[index].Cells[0].Value.ToString();
            Console.WriteLine(dataGridView1.Rows[index].Cells[2].Value.ToString());
            classes cl = new classes();
            cl.name = dataGridView1.Rows[index].Cells[2].Value.ToString();
            cl.firstName = dataGridView1.Rows[index].Cells[1].Value.ToString();
            cl.path = dataGridView1.Rows[index].Cells[3].Value.ToString();
            Console.WriteLine(dataGridView1.Rows[index].Cells[4].Value.ToString());
            cl.birt = DateTime.Parse(dataGridView1.Rows[index].Cells[4].Value.ToString().Replace(',', '.'));
            cl.pass = dataGridView1.Rows[index].Cells[5].Value.ToString();
            cl.address = dataGridView1.Rows[index].Cells[6].Value.ToString();
            cl.telephone = dataGridView1.Rows[index].Cells[7].Value.ToString();


            Update_element updateElement = new Update_element(this, cl);
            updateElement.ShowDialog();

            if (classes.name == "null")
            {
                return;
            }

            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb";//строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);//создаем соеденение

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();//открываем соеденение
                string query = "UPDATE Клиенты SET Фамилия = '" + classes.firstName + "', Имя = '" + classes.name + "', Отчество= '" + classes.path + "', ДатаРождения=" + ("'" + classes.birt.Day + "." + classes.birt.Month + "." + classes.birt.Year + "'") + ", ДанныеПаспорта='" + classes.pass + "', Адрес='" + classes.address + "', Телефон='" + classes.telephone + "' WHERE Кодклиента = " + indexCell;//строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);//команда

                //Выполняем запрос
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                {
                    MessageBox.Show("Данные изменены!", "Внимание!");
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbConnection.Close();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //Проверим количество выбранных строк
            if (dataGridView1.SelectedRows.Count != 1)
            {
                MessageBox.Show("Выберите одну строку!", "Внимание!");
                return;
            }

            //Запомним выбранную строку
            int index = dataGridView1.SelectedRows[0].Index;

            // Считаем данные
            string id = dataGridView1.Rows[index].Cells[0].Value.ToString();

            // Создаем соеденение
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=data.mdb";  // строка соеденения
            OleDbConnection dbConnection = new OleDbConnection(connectionString);                   // создаем соеденение

            try
            {
                // Выполянем запрос к БД
                dbConnection.Open();                                            // открываем соеденение
                string query = "DELETE FROM Клиенты WHERE Кодклиента = " + id;       // строка запроса
                OleDbCommand dbCommand = new OleDbCommand(query, dbConnection); // команда

                // Выполняем запрос
                if (dbCommand.ExecuteNonQuery() != 1)
                    MessageBox.Show("Ошибка выполнения запроса!", "Ошибка!");
                else
                {
                    MessageBox.Show("Данные удалены!", "Внимание!");
                    // Удаляем данные из таблицы в форме
                    dataGridView1.Rows.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
                MessageBox.Show($"Сообщение: {ex.Message}", "Вызвано исключение!");
            }
            finally
            {
                // Закрываем соеденение с БД
                dbConnection.Close();
            }
        }
    }
}
