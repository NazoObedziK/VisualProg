using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab2
{
    public partial class Main : Form
    {
        string path = "";

        DataView dataView = new DataView();

        public string Path { get => path;
            set { 
                if(path != value)
                {
                    path = value;
                    OnPathChange(new PathChangeEventArgs(path));
                }
            }
        }

        public event PathChangeDelegate PathChange;

        protected virtual void OnPathChange(PathChangeEventArgs e)
        {
            PathChange?.Invoke(this, e);
        }
        public Main()
        {
            InitializeComponent();
            PathChange += Main_PathChange;
        }

        private void Main_PathChange(object sender, PathChangeEventArgs e)
        {
            saveToolStripMenuItem.Enabled = saveToolStripMenuItem.Enabled = !string.IsNullOrEmpty(e.Value);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileOk += openFileDialog_FileOk;
            openFileDialog.Filter = "tab data|*.tab";
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            Path = (sender as OpenFileDialog).FileName;
            using (FileStream fileStream = new FileStream(Path, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                DataTable dataTable = binaryFormatter.Deserialize(fileStream) as DataTable;
                if (DBNull.Value.Equals(dataTable.Rows[0][0]))
                {
                    radioButtonExplicit.Checked = true;
                    radioButtonImplicit.Checked = false;
                } else
                {
                    radioButtonExplicit.Checked = false;
                    radioButtonImplicit.Checked = true;
                }
                tabDataTable.Rows.Clear();
                foreach (DataRow item in dataTable.Rows)
                {
                    tabDataTable.ImportRow(item);
                }
                chart1.DataBind();
                if (radioButtonExplicit.Checked)
                {
                    textBoxA.Text = tabDataTable.AsEnumerable().Select(row => row.Field<double>("x")).Min().ToString();
                    textBoxB.Text = tabDataTable.AsEnumerable().Select(row => row.Field<double>("x")).Max().ToString();
                    textBoxN.Text = tabDataTable.Rows.Count.ToString();
                } else
                {
                    textBoxA.Text = tabDataTable.AsEnumerable().Select(row => row.Field<double>("t")).Min().ToString();
                    textBoxB.Text = tabDataTable.AsEnumerable().Select(row => row.Field<double>("t")).Max().ToString();
                    textBoxN.Text = tabDataTable.Rows.Count.ToString();
                }
                textBoxMin.Text = Math.Round(tabDataTable.AsEnumerable().Select(row => row.Field<double>("y")).Min(), 3).ToString();
                textBoxMax.Text = Math.Round(tabDataTable.AsEnumerable().Select(row => row.Field<double>("y")).Max(), 3).ToString();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, tabDataTable);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            radioButtonExplicit.Checked = true;
            Path = "";
            saveToolStripMenuItem.Enabled = false;
            dataView.Table = tabDataTable;
            bindingSource1.DataSource = dataView;
        }



        private bool checkFields()
        {
            if (radioButtonExplicit.Checked)
                return (textBoxA.Text.Trim() != "" && textBoxB.Text.Trim() != "" && textBoxN.Text.Trim() != "");
            else
                return (textBoxA.Text.Trim() != "" && textBoxB.Text.Trim() != "" && textBoxN.Text.Trim() != "");
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z)
                e.SuppressKeyPress = true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
                e.Handled = true;
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '.' || e.KeyChar == '-'))
                e.Handled = true;
        }
        private void textBoxInt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '\b' || e.KeyChar == '-'))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                if (radioButtonExplicit.Checked)
                {
                    if (radioButton1.Checked)
                    {
                        TabFunc.TabExplicitFunc(tabDataTable,
                        Convert.ToDouble(textBoxA.Text),
                        Convert.ToDouble(textBoxB.Text),
                        Convert.ToInt32(textBoxN.Text)
                        );
                    }

                    if (radioButton2.Checked)
                    {
                        TabFunc.TabExplicitFuncx(tabDataTable,
                        Convert.ToDouble(textBoxA.Text),
                        Convert.ToDouble(textBoxB.Text),
                        Convert.ToInt32(textBoxN.Text)
                        );
                    }

                    if (radioButton3.Checked)
                    {
                        TabFunc.TabExplicitFuncy(tabDataTable,
                        Convert.ToDouble(textBoxA.Text),
                        Convert.ToDouble(textBoxB.Text),
                        Convert.ToInt32(textBoxN.Text)
                        );
                    }
                }
                else
                {
                    TabFunc.TabImplicitFunc(tabDataTable,
                                            Convert.ToDouble(textBoxA.Text),
                                            Convert.ToDouble(textBoxB.Text),
                                            Convert.ToInt32(textBoxN.Text)
                                            );
                }
                chart1.DataBind();
                textBoxMin.Text = Math.Round(tabDataTable.AsEnumerable().Select(row => row.Field<double>("y")).Min(), 3).ToString();
                textBoxMax.Text = Math.Round(tabDataTable.AsEnumerable().Select(row => row.Field<double>("y")).Max(), 3).ToString();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "tab data|*.tab";
            saveFileDialog.FileOk += SaveFileDialog_FileOk;
            saveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            using (FileStream fileStream = new FileStream((sender as SaveFileDialog).FileName, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, tabDataTable);
            }
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm filterForm = new FilterForm();
            if(filterForm.ShowDialog() == DialogResult.OK)
            {
                if (radioButtonExplicit.Checked)
                {
                    bindingSource1.Filter = $"x>={filterForm.A} AND x<={filterForm.B}";
                } else
                {
                    bindingSource1.Filter = $"t>={filterForm.A} AND t<={filterForm.B}";
                }
            } else
            {
                bindingSource1.RemoveFilter();
            }
            chart1.DataBind();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
            chart1.DataBind();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
