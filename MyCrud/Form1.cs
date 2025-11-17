using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
