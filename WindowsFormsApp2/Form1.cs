using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void table1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.table1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.connectedDataSet);


            Properties.Settings.Default.Save();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'connectedDataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.connectedDataSet.Table1);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void education_Section_CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void table1BindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void template_NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string displayText = textBox1.Text;
            label1.Text = displayText;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void template_NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
