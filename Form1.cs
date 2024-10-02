using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonCalculateSalaryClick(object sender, EventArgs e)
        {

            if (!this.ValidateForm())
            {
                return;
            }


            double rate, worked, result;
            rate = Convert.ToDouble(textBoxRate.Text);
            worked = Convert.ToDouble(textBoxWorked.Text);

            result = rate * worked;

            textBoxSalary.Text = result.ToString();

            MessageBox.Show(
                $"Работник {textBoxSurname.Text} {textBoxName.Text} {textBoxPatronymic.Text}\nВыплатить {textBoxSalary.Text}",
                "Отчёт",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }

        private void handleOk(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void handleCancel(object sender, EventArgs e)
        {
            textBoxSurname.Clear();
            textBoxName.Clear();
            textBoxPatronymic.Clear();
            textBoxRate.Clear();
            textBoxWorked.Clear();
            textBoxSalary.Clear();

        }

        private void handleSaveToFile(object sender, EventArgs e)
        {
            if (!this.ValidateForm(true))
                return;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.Title = "Сохранить файл";
                saveFileDialog.FileName = $"employee_data_{this.GenerateHash()}.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath, append: true))
                        {
                            writer.WriteLine("Фамилия: " + textBoxSurname.Text);
                            writer.WriteLine("Имя: " + textBoxName.Text);
                            writer.WriteLine("Отчество: " + textBoxPatronymic.Text);
                            writer.WriteLine("Ставка: " + textBoxRate.Text);
                            writer.WriteLine("Отработанные часы: " + textBoxWorked.Text);
                            writer.WriteLine("Зарплата: " + textBoxSalary.Text);
                            writer.WriteLine("-----------");
                        }

                        MessageBox.Show("Данные успешно сохранены в файл", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private bool ValidateForm(bool strict = false)
        {
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                MessageBox.Show("Поле 'Фамилия' не может быть пустым");
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Поле 'Имя' не может быть пустым");
                return false;
            }

            if (!double.TryParse(textBoxRate.Text, out _))
            {
                MessageBox.Show($"В поле {labelRate.Text} введено некорректное значение");
                return false;
            }
            if (!double.TryParse(textBoxWorked.Text, out _))
            {
                MessageBox.Show($"В поле {labelWorked.Text} введено некорректное значение");

                return false;
            }

            if (strict && !double.TryParse(textBoxSalary.Text, out _))
            {
                MessageBox.Show($"Не подсчитана зарплата");
                return false;
            }

            return true;
        }

        private string GenerateHash()
        {
            Guid randomGuid = Guid.NewGuid();
            return randomGuid.ToString("N");
        }

    }
}
