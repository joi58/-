using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Пользователь
{
    public partial class DogovotPredpriytia : Form
    {
        public DogovotPredpriytia()
        {
            InitializeComponent();
        }

        private void dogovorPostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dogovorPostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пользовательDataSet);

        }

        private void DogovotPredpriytia_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пользовательDataSet.DogovorPred". При необходимости она может быть перемещена или удалена.
            this.dogovorPredTableAdapter.Fill(this.пользовательDataSet.DogovorPred);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пользовательDataSet.DogovorPost". При необходимости она может быть перемещена или удалена.

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
