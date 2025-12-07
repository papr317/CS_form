using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace MyCrud
{
    public partial class Form1 : Form
    {
        string UserId;

        public Form1()
        {
            InitializeComponent();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            var result = DB.pStudentSearch(tbLnameSearch.Text);
            gvStudent.DataSource = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gvStudent.AutoGenerateColumns = false;
        }

        private void gvStudent_SelectionChanged(object sender, EventArgs e)
        {
            if ((sender as DataGridView).SelectedRows.Count > 0)
            {
                UserId = (sender as DataGridView).SelectedCells[0].Value.ToString();
                Text = UserId;
                var model = DB.pGetStudentById(UserId);
                tbFname.Text = model.fname;
                tbLname.Text = model.lname;
                dtBirthDate.Value = model.birthdate;
                cbGender.SelectedIndex = Convert.ToInt32(model.gender);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            DB.pStudentAddOrEdit(new StudentAddOrEditModel
            {
                id = "0",
                birthdate = dtBirthDate.Value,
                fname = tbFname.Text,
                lname = tbLname.Text,
                gender = cbGender.SelectedIndex.ToString()
            });
            var result = DB.pStudentSearch(tbLnameSearch.Text);
            gvStudent.DataSource = result;
        }

        private void btUpd_Click(object sender, EventArgs e)
        {
            DB.pStudentAddOrEdit(new StudentAddOrEditModel
            {
                id = UserId,
                birthdate = dtBirthDate.Value,
                fname = tbFname.Text,
                lname = tbLname.Text,
                gender = cbGender.SelectedIndex.ToString()
            });
            var result = DB.pStudentSearch(tbLnameSearch.Text);
            gvStudent.DataSource = result;
        }

        private void miAdd_Click(object sender, EventArgs e)
        {
            fmDialog fmadd = new fmDialog("add", "0");
            DialogResult dr = fmadd.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                fmadd.Close();
            }
            else if (dr == DialogResult.OK)
            {
                var result = DB.pStudentSearch(tbLnameSearch.Text);
                gvStudent.DataSource = result;
            }
        }

        private void miEdit_Click(object sender, EventArgs e)
        {
            fmDialog fmadd = new fmDialog("edit", UserId);
            DialogResult dr = fmadd.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                fmadd.Close();
            }
            else if (dr == DialogResult.OK)
            {
                var result = DB.pStudentSearch(tbLnameSearch.Text);
                gvStudent.DataSource = result;
            }
        }

        private void miDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Удалить " + gvStudent.SelectedCells[1].Value.ToString() + "?",
                                   "Удаление!",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                DB.pStudentDel(UserId);
                var result = DB.pStudentSearch(tbLnameSearch.Text);
                gvStudent.DataSource = result;
            }
        }

        /// <summary>
        /// Обработчик изменения выбора в ComboBox для выбора вида отчета (Excel или CSV).
        /// </summary>
        private void cbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включаем кнопку, если выбран любой формат (Excel или CSV)
            if (cbReportType.SelectedIndex == 0 || cbReportType.SelectedIndex == 1)
            {
                btReport.Enabled = true;
            }
            else
            {
                btReport.Enabled = false;
            }
        }

        /// <summary>
        /// Обработчик клика по кнопке "Отчет". Запускает экспорт в выбранный формат.
        /// </summary>
        private void btReport_Click(object sender, EventArgs e)
        {
            // Проверка, что формат выбран
            if (cbReportType.SelectedIndex < 0)
            {
                MessageBox.Show("Пожалуйста, выберите формат отчета (Excel или CSV).", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Настройка диалога сохранения (SaveFileDialog)
            if (cbReportType.SelectedIndex == 0) // Excel
            {
                sdReport.Filter = "Excel files (*.xlsx)|*.xlsx";
                sdReport.Title = "Сохранить отчет в Excel";
                sdReport.FileName = "Report.xlsx";
            }
            else // CSV (cbReportType.SelectedIndex == 1)
            {
                sdReport.Filter = "CSV files (*.csv)|*.csv";
                sdReport.Title = "Сохранить отчет в CSV";
                sdReport.FileName = "Report.csv";
            }

            // 2. Отображение диалога сохранения
            if (sdReport.ShowDialog() == DialogResult.OK)
            {
                string filePath = sdReport.FileName;

                // Получение данных (делаем это один раз)
                DataTable dt = DB.pStudentSearchDT(tbLnameSearch.Text);

                // 3. Вызов соответствующего метода экспорта
                if (cbReportType.SelectedIndex == 0) // Excel
                {
                    ExportToExcel(dt, filePath);
                }
                else // CSV
                {
                    ExportToCsv(dt, filePath);
                }

                // 4. Открытие сохраненного файла
                try
                {
                    Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось открыть файл. Ошибка: {ex.Message}", "Ошибка открытия", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// Экспорт данных в формат Excel (.xlsx) с использованием ClosedXML.

        private void ExportToExcel(DataTable dt, string filePath)
        {
            try
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var sheet = wb.AddWorksheet(dt, "Student Report");
                    sheet.Columns().AdjustToContents(); // Автоматическая настройка ширины столбцов
                    wb.SaveAs(filePath);
                    MessageBox.Show($"Отчет успешно сохранен в Excel: {Path.GetFileName(filePath)}", "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте в Excel: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// Экспорт данных в формат CSV (.csv) с использованием StreamWriter.
        private void ExportToCsv(DataTable dt, string filePath)
        {
            // Используем запятую в качестве разделителя, так как UTF-8 лучше сочетается с запятыми.
            // разделитель 
            string separator = ";";

            try
            {

                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8))
                {

                    // 1. Запись заголовков столбцов
                    IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                    sw.WriteLine(string.Join(separator, columnNames));

                    // 2. Запись данных строк
                    foreach (DataRow row in dt.Rows)
                    {
                        // Оборачиваем значения в кавычки (""), если они содержат разделитель или кавычки
                        IEnumerable<string> fields = row.ItemArray.Select(field =>
                        {
                            string value = field.ToString();
                            // Замена внутренних кавычек на двойные кавычки и оборачивание в кавычки
                            return string.Concat("\"", value.Replace("\"", "\"\""), "\"");
                        });
                        sw.WriteLine(string.Join(separator, fields));
                    }
                }
                MessageBox.Show($"Отчет успешно сохранен в CSV (UTF-8): {Path.GetFileName(filePath)}", "Экспорт завершен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при экспорте в CSV: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //пример кнопки из файла  app.config
        private void bt_hello_Click(object sender, EventArgs e)
        {
            // Выводим значение "hello" из класса DB
            MessageBox.Show(DB.hello, "Сообщение из App.config");

            // (Необязательно) Устанавливаем заголовок формы равным "привет"
            // Text = DB.hello; 
        }
    }
}