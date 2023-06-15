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
    public partial class DogovorPostForm : Form
    {
        public DogovorPostForm()
        {
            InitializeComponent();
        }

        private void dogovorPostBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dogovorPostBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.пользовательDataSet);
          
        }

        private void DogovorPostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пользовательDataSet.DovorPostP". При необходимости она может быть перемещена или удалена.
            this.dovorPostPTableAdapter.Fill(this.пользовательDataSet.DovorPostP);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "пользовательDataSet.DogovorPost". При необходимости она может быть перемещена или удалена.
            this.dogovorPostTableAdapter.Fill(this.пользовательDataSet.DogovorPost);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
