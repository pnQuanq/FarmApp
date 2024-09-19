using System;
using System.Windows.Forms;
using FarmApp.BusinessLogicLayer;
using FarmApp_21521349.Models;

namespace FarmApp.PresentationLayer
{
    public partial class MainForm : Form
    {
        private Label label1;
        private Label label2;
        private TextBox txtCowCount;
        private TextBox txtSheepCount;
        private Label sheep_label;
        private TextBox txtGoatCount;
        private Label goat_label;
        private Button btn_input;
        private Button button1;
        private TextBox txtResult;
        private Label label5;
        private AnimalService _animalService;

        public MainForm()
        {
            InitializeComponent();
            _animalService = new AnimalService();
        }

        private void btnAddAnimals_Click(object sender, EventArgs e)
        {
            int cowCount = int.Parse(txtCowCount.Text);
            int sheepCount = int.Parse(txtSheepCount.Text);
            int goatCount = int.Parse(txtGoatCount.Text);

            _animalService.AddAnimals(new Cow { Quantity = cowCount });
            _animalService.AddAnimals(new Sheep { Quantity = sheepCount });
            _animalService.AddAnimals(new Goat { Quantity = goatCount });

            MessageBox.Show("Đã thêm gia súc vào cơ sở dữ liệu!");
        }

        private void btnMilkAndBirth_Click(object sender, EventArgs e)
        {
            _animalService.ProcessMilkAndBirths();
            MessageBox.Show("Đã xử lý sinh con và cho sữa!");
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            var animals = _animalService.GetAnimals();
            foreach (var animal in animals)
            {
                txtResult.Text += $"{animal.Type}: {animal.Quantity} con, {animal.TotalMilk} lít sữa, {animal.TotalBirths} lần sinh\n";
            }
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCowCount = new System.Windows.Forms.TextBox();
            this.txtSheepCount = new System.Windows.Forms.TextBox();
            this.sheep_label = new System.Windows.Forms.Label();
            this.txtGoatCount = new System.Windows.Forms.TextBox();
            this.goat_label = new System.Windows.Forms.Label();
            this.btn_input = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bò";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng gia súc ban đầu";
            // 
            // txtCowCount
            // 
            this.txtCowCount.Location = new System.Drawing.Point(61, 47);
            this.txtCowCount.Name = "txtCowCount";
            this.txtCowCount.Size = new System.Drawing.Size(114, 22);
            this.txtCowCount.TabIndex = 2;
            // 
            // txtSheepCount
            // 
            this.txtSheepCount.Location = new System.Drawing.Point(61, 75);
            this.txtSheepCount.Name = "txtSheepCount";
            this.txtSheepCount.Size = new System.Drawing.Size(114, 22);
            this.txtSheepCount.TabIndex = 4;
            // 
            // sheep_label
            // 
            this.sheep_label.AutoSize = true;
            this.sheep_label.Location = new System.Drawing.Point(31, 78);
            this.sheep_label.Name = "sheep_label";
            this.sheep_label.Size = new System.Drawing.Size(30, 16);
            this.sheep_label.TabIndex = 3;
            this.sheep_label.Text = "Cừu";
            this.sheep_label.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGoatCount
            // 
            this.txtGoatCount.Location = new System.Drawing.Point(61, 103);
            this.txtGoatCount.Name = "txtGoatCount";
            this.txtGoatCount.Size = new System.Drawing.Size(114, 22);
            this.txtGoatCount.TabIndex = 6;
            // 
            // goat_label
            // 
            this.goat_label.AutoSize = true;
            this.goat_label.Location = new System.Drawing.Point(31, 106);
            this.goat_label.Name = "goat_label";
            this.goat_label.Size = new System.Drawing.Size(25, 16);
            this.goat_label.TabIndex = 5;
            this.goat_label.Text = "Dê";
            this.goat_label.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(61, 143);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(75, 23);
            this.btn_input.TabIndex = 7;
            this.btn_input.Text = "Xác nhận";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btnAddAnimals_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xác nhận";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnViewStats_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(368, 50);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(201, 87);
            this.txtResult.TabIndex = 10;
            this.txtResult.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng gia súc sau một lứa sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(814, 537);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txtGoatCount);
            this.Controls.Add(this.goat_label);
            this.Controls.Add(this.txtSheepCount);
            this.Controls.Add(this.sheep_label);
            this.Controls.Add(this.txtCowCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
