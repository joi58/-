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
    public partial class DogovorAutoForm : Form
    {
        public DogovorAutoForm()
        {
            InitializeComponent();
        }

        private void dogovorAutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dogovorAutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пользовательDataSet);

        }

        private void DogovorAutoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пользовательDataSet.DogovorAuto". При необходимости она может быть перемещена или удалена.
            this.dogovorAutoTableAdapter.Fill(this.пользовательDataSet.DogovorAuto);
            

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void dogovorAutoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
