using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Windows_FormsApp_01
{
    public partial class Form1 : Form
    {
        private Panel overlayPanel;
        public Form1()
        {
            InitializeComponent();
            SetBackgroundImage();
            CustomizeForm();
        }

        private void SetBackgroundImage()
        {
            this.BackgroundImage = Image.FromFile(@"C:\\Users\\FDT-CDTI\\Pictures\\img01.jfif"); // เปลี่ยนชื่อไฟล์ตามที่คุณใช้งานจริง
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // สร้าง overlay panel เพื่อไล่ระดับความมืด
            overlayPanel = new Panel();
            overlayPanel.Dock = DockStyle.Fill;
            overlayPanel.BackColor = Color.FromArgb(150, 0, 0, 0); // สีดำโปร่งใส 150/255
            this.Controls.Add(overlayPanel);
            overlayPanel.SendToBack();
        }
        private void CustomizeForm()
        {
            // สีพื้นหลังของฟอร์ม
            this.BackColor = Color.FromArgb(24, 26, 33);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Font หลัก
            Font mainFont = new Font("Segoe UI", 10);
            Color labelColor = Color.White;
            Color textBoxBack = Color.FromArgb(40, 42, 54);
            Color textBoxFore = Color.White;

            // Label 1
            label1.ForeColor = labelColor;
            label1.Font = mainFont;

            // TextBox1
            textBox1.BackColor = textBoxBack;
            textBox1.ForeColor = textBoxFore;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = mainFont;

            // Label 2
            label2.ForeColor = labelColor;
            label2.Font = mainFont;

            // DateTimePicker
            dateTimePicker1.Font = mainFont;
            dateTimePicker1.CalendarMonthBackground = textBoxBack;
            dateTimePicker1.CalendarForeColor = textBoxFore;
            dateTimePicker1.BackColor = textBoxBack;
            dateTimePicker1.ForeColor = textBoxFore;

            // Label 3
            label3.ForeColor = labelColor;
            label3.Font = mainFont;

            // ComboBox
            comboBox1.BackColor = textBoxBack;
            comboBox1.ForeColor = textBoxFore;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.Font = mainFont;

            // Button1 (ยืนยันการจอง)
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Font = mainFont;

            // Button2 (ล้างข้อมูล)
            button2.BackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.ForeColor = Color.White;
            button2.Font = mainFont;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string room = comboBox1.SelectedItem?.ToString() ?? "";

            MessageBox.Show($"คุณ {name} ได้จอง {room} ในวันที่ {date}", "ยืนยันการจอง", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
