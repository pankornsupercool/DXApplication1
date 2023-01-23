using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        List<TenorService> tenorServices= new List<TenorService>();
        DataAccess db = new DataAccess();
        public Form1()
        {
            InitializeComponent();
            init();
            initListBox();
        }

        void init()
        {
            //string[] cycle = { "Day", "Week", "Month", "Year" };
            List<Category> list = new List<Category>
            {
                new Category(){Type = "Day"},
                new Category(){Type = "Week"},
                new Category(){Type = "Month"},
                new Category(){Type = "Year"}
            };

            _lookUpEdit1.Properties.DataSource = list;
            _lookUpEdit1.Properties.ValueMember = "Type";
            _lookUpEdit1.Properties.DisplayMember = _lookUpEdit1.Properties.ValueMember;

            _lookUpEdit2.Properties.DataSource = list;
            _lookUpEdit2.Properties.ValueMember = "Type";
            _lookUpEdit2.Properties.DisplayMember = _lookUpEdit1.Properties.ValueMember;



        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var text = _radioGroup1.Properties.Items[_radioGroup1.SelectedIndex].Description;
            //MessageBox.Show(text);
            //MessageBox.Show(radioGroup1.SelectedIndex.ToString());

            //_textBox2.Text = _radioGroup1.Properties.Items[_radioGroup1.SelectedIndex].ToString();
            switch (_radioGroup1.Properties.Items[_radioGroup1.SelectedIndex].Value.ToString())
            {
                case "N":
                    _textBox2.Clear(); _textBox3.Clear(); _textBox2.Enabled = true; _textBox3.Enabled = true; break;

                case "0":
                    _textBox2.Text = "0"; _textBox3.Text = "0"; _textBox2.Enabled = false; _textBox3.Enabled = false; break;

                case "1":
                    _textBox2.Text = "1"; _textBox3.Text = "1"; _textBox2.Enabled = false; _textBox3.Enabled = false; break;

                case "2":
                    _textBox2.Text = "2"; _textBox3.Text = "2"; _textBox2.Enabled = false; _textBox3.Enabled = false; break;


                    _textBox2.Text = _radioGroup1.Properties.Items[_radioGroup1.SelectedIndex].Value.ToString();
                    _textBox3.Text = _radioGroup1.Properties.Items[_radioGroup1.SelectedIndex].Value.ToString();
            }
        }

        void initListBox()
        {
            tenorServices = db.GetAllData();
            _listBoxControl1.DataSource= tenorServices;
            _listBoxControl1.ValueMember = "FullInfo";
            _listBoxControl1.DisplayMember = _listBoxControl1.ValueMember;
        }

        public class Category
        {
            public string Type { get; set; }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
