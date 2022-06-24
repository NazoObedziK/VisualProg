using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3__SFD_OFD
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private List<Coworker> coworkerObjList;
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var sw = new StreamWriter(sfd.FileName, false))
                    foreach (var item in listBox1.Items)
                        sw.Write(item.ToString() + Environment.NewLine);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            sfd = new SaveFileDialog();



            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.listBox1.Items.Clear();
                var coworkerFile = File.ReadAllLines(ofd.FileName);
                var coworkerList = new List<string>(coworkerFile);
                coworkerObjList = new List<Coworker>();

                for (int i = 0; i < coworkerList.Count; i++)
                {
                    string[] coworkerData = coworkerList[i].Split(' ');
                    coworkerObjList.Add(new Coworker() {
                        Surname = coworkerData[0],
                        Name = coworkerData[1],
                        FathersName = coworkerData[2],
                        BirthDate = DateTime.ParseExact(coworkerData[3], "dd/MM/yyyy", null),
                        Location = coworkerData[4] });
                }

                foreach (var coworker in coworkerObjList)
                    this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
            }
        }
        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.listBox1.Items.Clear();
        //    int year = Convert.ToInt16(textBox1.Text);
        //    var m = coworkerObjList[3].BirthDate.Year;
        //    var coworkers = coworkerObjList.Where(x => x.BirthDate.Year == year).ToList();
        //    foreach (var coworker in coworkers)
        //         this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach (var coworker in coworkerObjList)
                this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.listBox1.Items.Clear();
            List<string> checkedItems = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
                checkedItems.Add(item.ToString());

            if (e.NewValue == CheckState.Checked)
                checkedItems.Add(checkedListBox1.Items[e.Index].ToString());
            else
                checkedItems.Remove(checkedListBox1.Items[e.Index].ToString());


            if (checkedItems.Contains("winter"))
            {
                var m = coworkerObjList[3].BirthDate.Month;
                var coworkers = coworkerObjList.Where(x => x.BirthDate.Month == 12 || x.BirthDate.Month == 1 || x.BirthDate.Month == 2).ToList();

                foreach (var coworker in coworkers)
                    this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
            }
            if (checkedItems.Contains("spring"))
            {
                var m = coworkerObjList[3].BirthDate.Month;
                var coworkers = coworkerObjList.Where(x => x.BirthDate.Month == 3 || x.BirthDate.Month == 4 || x.BirthDate.Month == 5).ToList();

                foreach (var coworker in coworkers)
                    this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
            }
            if (checkedItems.Contains("summer"))
            {
                var m = coworkerObjList[3].BirthDate.Month;
                var coworkers = coworkerObjList.Where(x => x.BirthDate.Month == 6 || x.BirthDate.Month == 7 || x.BirthDate.Month == 8).ToList();

                foreach (var coworker in coworkers)
                    this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
            }
            if (checkedItems.Contains("autumn"))
            {
                var m = coworkerObjList[3].BirthDate.Month;
                var coworkers = coworkerObjList.Where(x => x.BirthDate.Month == 9 || x.BirthDate.Month == 10 || x.BirthDate.Month == 11).ToList();

                foreach (var coworker in coworkers)
                    this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            int year = Convert.ToInt16(textBox1.Text);
            var m = coworkerObjList[3].BirthDate.Year;
            var coworkers = coworkerObjList.Where(x => x.BirthDate.Year == year).ToList();
            foreach (var coworker in coworkers)
                this.listBox1.Items.Add(coworker.Surname + " " + coworker.Name + " " + coworker.FathersName + " " + coworker.BirthDate.ToString("dd/MM/yyyy") + " " + coworker.Location);
        }
    }
    }
