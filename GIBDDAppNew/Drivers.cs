using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDDAppNew
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDatabaseDataSet.Car". При необходимости она может быть перемещена или удалена.
            this.carTableAdapter.Fill(this.driversDatabaseDataSet.Car);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDatabaseDataSet.License". При необходимости она может быть перемещена или удалена.
            this.licenseTableAdapter.Fill(this.driversDatabaseDataSet.License);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "driversDatabaseDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.driversDatabaseDataSet.Driver);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.driversDatabaseDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            driverDataGridView.Rows.RemoveAt(driverDataGridView.CurrentRow.Index);
        }
}
