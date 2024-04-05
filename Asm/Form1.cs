using Microsoft.VisualBasic.Logging;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Asm
{
    public partial class ShowInformation : Form
    {
        public ShowInformation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textID.Text = selectedRow.Cells["txID"].Value.ToString();
                textName.Text = selectedRow.Cells["txName"].Value.ToString();
                comboBoxTypeCustomer.Text = selectedRow.Cells["txTypeCustomer"].Value.ToString();
                textLastMonth.Text = selectedRow.Cells["txLastMonthWaterReading"].Value.ToString();
                textThisMonth.Text = selectedRow.Cells["txThisMonthWaterReading"].Value.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void buttonExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            string LastMonthReading = textLastMonth.Text;
            if (string.IsNullOrEmpty(LastMonthReading))
            {
                MessageBox.Show("Please enter your Last month water reading", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string LastThisReading = textThisMonth.Text;
            if (string.IsNullOrEmpty(LastThisReading))
            {
                MessageBox.Show("Please enter your This month water reading", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string id = textID.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter your ID", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string name = textName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (comboBoxTypeCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a type customer.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double.TryParse(textLastMonth.Text, out double lastMonthReading);
            double.TryParse(textThisMonth.Text, out double thisMonthReading);

            double waterUsage = thisMonthReading - lastMonthReading;
            string customerType = comboBoxTypeCustomer.SelectedItem?.ToString();
            double waterBill = 0;
            switch (customerType)
            {
                case "Household customer":
                    if (waterUsage > 0 && waterUsage <= 10)
                        waterBill = (waterUsage * 5973);
                    else if (waterUsage > 10 && waterUsage <= 20)
                        waterBill = (waterUsage * 7052);
                    else if (waterUsage > 20 && waterUsage <= 30)
                        waterBill = (waterUsage * 8699);
                    else if (waterUsage > 30)
                        waterBill = (waterUsage * 15929);
                    else
                        MessageBox.Show("Invaild value ", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case "Administrative agency, public services":
                    waterBill = (waterUsage * 9955);
                    break;
                case "Production units":
                    waterBill = (waterUsage * 11615);
                    break;
                case "Business services":
                    waterBill = (waterUsage * 22068);
                    break;
                default:
                    MessageBox.Show("Please select a customer type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            double VAT = (waterBill * 10 / 100);
            double WaterBillWithVAT = waterBill + VAT;
            dataGridView1.Rows.Add(
           textID.Text,
           textName.Text,
           comboBoxTypeCustomer.Text,
           textLastMonth.Text,
           textThisMonth.Text,
           waterUsage.ToString(),
           VAT.ToString(),
           WaterBillWithVAT.ToString("C"));

            ClearInputs();
        }
        private void ClearInputs()
        {
            textID.Clear();
            textName.Clear();
            comboBoxTypeCustomer.SelectedIndex = -1;
            textLastMonth.Clear();
            textThisMonth.Clear();
        }
        private void buttonDelete(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonEdit(object sender, EventArgs e)
        {
           
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            buttonAdd(sender, e);
        }
        private void buttonLogout(object sender, EventArgs e)
        {
            this.Hide();
            login logout = new login();
            logout.Show();
        }
        private void buttonSort(object sender, EventArgs e)
        {
            string sort = comboBoxSort.SelectedItem?.ToString();
            switch (sort)
            {
                case "ID":
                    dataGridView1.Sort(dataGridView1.Columns["txID"], ListSortDirection.Ascending);
                    break;
                case "Name":
                    dataGridView1.Sort(dataGridView1.Columns["txName"], ListSortDirection.Ascending);
                    break;
                case "Type Customer":
                    dataGridView1.Sort(dataGridView1.Columns["txTypeCustomer"], ListSortDirection.Ascending);
                    break;
                case "Water Consume":
                    dataGridView1.Sort(dataGridView1.Columns["txWaterConsume"], ListSortDirection.Ascending);
                    break;
                case "VAT":
                    dataGridView1.Sort(dataGridView1.Columns["txVAT"], ListSortDirection.Ascending);
                    break;
                case "Water Bill":
                    dataGridView1.Sort(dataGridView1.Columns["txWaterBill"], ListSortDirection.Ascending);
                    break;
                default:
                    MessageBox.Show("Please select a sort.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textLastMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textThisMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}