namespace coursova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonPass = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTourniquetID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSkiPassID = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPickTariff = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTariffName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonLifts = new System.Windows.Forms.Button();
            this.buttonRevenues = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інтерфейс користувача";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonCheck);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Location = new System.Drawing.Point(5, 204);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(434, 113);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Перевірка залишку ";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(271, 21);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(122, 26);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Перевірити!";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Id скі-пасу";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 24);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDown);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonPass);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBoxTourniquetID);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.comboBoxSkiPassID);
            this.groupBox4.Location = new System.Drawing.Point(5, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(434, 171);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Проходження турнікету";
            // 
            // buttonPass
            // 
            this.buttonPass.Location = new System.Drawing.Point(137, 118);
            this.buttonPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPass.Name = "buttonPass";
            this.buttonPass.Size = new System.Drawing.Size(117, 38);
            this.buttonPass.TabIndex = 4;
            this.buttonPass.Text = "Пройти!";
            this.buttonPass.UseVisualStyleBackColor = true;
            this.buttonPass.Click += new System.EventHandler(this.buttonPass_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id турнікету";
            // 
            // comboBoxTourniquetID
            // 
            this.comboBoxTourniquetID.DropDownHeight = 112;
            this.comboBoxTourniquetID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTourniquetID.FormattingEnabled = true;
            this.comboBoxTourniquetID.IntegralHeight = false;
            this.comboBoxTourniquetID.Location = new System.Drawing.Point(239, 51);
            this.comboBoxTourniquetID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTourniquetID.Name = "comboBoxTourniquetID";
            this.comboBoxTourniquetID.Size = new System.Drawing.Size(140, 23);
            this.comboBoxTourniquetID.TabIndex = 2;
            this.comboBoxTourniquetID.DropDown += new System.EventHandler(this.comboBoxTourniquetID_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id скі-пасу";
            // 
            // comboBoxSkiPassID
            // 
            this.comboBoxSkiPassID.DropDownHeight = 112;
            this.comboBoxSkiPassID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSkiPassID.FormattingEnabled = true;
            this.comboBoxSkiPassID.IntegralHeight = false;
            this.comboBoxSkiPassID.Location = new System.Drawing.Point(18, 51);
            this.comboBoxSkiPassID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSkiPassID.Name = "comboBoxSkiPassID";
            this.comboBoxSkiPassID.Size = new System.Drawing.Size(140, 23);
            this.comboBoxSkiPassID.TabIndex = 0;
            this.comboBoxSkiPassID.DropDown += new System.EventHandler(this.comboBoxSkiPassID_DropDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPrice);
            this.groupBox2.Controls.Add(this.buttonAdd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.buttonPickTariff);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBoxTariffName);
            this.groupBox2.Location = new System.Drawing.Point(460, 9);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(309, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інтерфейс касира";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(97, 110);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(0, 15);
            this.labelPrice.TabIndex = 13;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(96, 147);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 26);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Видати скі-пас";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "До сплати: ";
            // 
            // buttonPickTariff
            // 
            this.buttonPickTariff.Location = new System.Drawing.Point(96, 75);
            this.buttonPickTariff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPickTariff.Name = "buttonPickTariff";
            this.buttonPickTariff.Size = new System.Drawing.Size(122, 26);
            this.buttonPickTariff.TabIndex = 11;
            this.buttonPickTariff.Text = "Обрати";
            this.buttonPickTariff.UseVisualStyleBackColor = true;
            this.buttonPickTariff.Click += new System.EventHandler(this.buttonPickTariff_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Назва тарифу";
            // 
            // comboBoxTariffName
            // 
            this.comboBoxTariffName.FormattingEnabled = true;
            this.comboBoxTariffName.Location = new System.Drawing.Point(113, 32);
            this.comboBoxTariffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTariffName.Name = "comboBoxTariffName";
            this.comboBoxTariffName.Size = new System.Drawing.Size(191, 23);
            this.comboBoxTariffName.TabIndex = 5;
            this.comboBoxTariffName.DropDown += new System.EventHandler(this.comboBoxTariffName_DropDown);
            this.comboBoxTariffName.SelectedIndexChanged += new System.EventHandler(this.comboBoxTariffName_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.buttonLifts);
            this.groupBox3.Controls.Add(this.buttonRevenues);
            this.groupBox3.Location = new System.Drawing.Point(774, 9);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(490, 335);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Інтерфейс статистики";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(454, 206);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonLifts
            // 
            this.buttonLifts.Location = new System.Drawing.Point(288, 32);
            this.buttonLifts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLifts.Name = "buttonLifts";
            this.buttonLifts.Size = new System.Drawing.Size(186, 26);
            this.buttonLifts.TabIndex = 1;
            this.buttonLifts.Text = "Lifts by date and tourniquet";
            this.buttonLifts.UseVisualStyleBackColor = true;
            this.buttonLifts.Click += new System.EventHandler(this.buttonLifts_Click);
            // 
            // buttonRevenues
            // 
            this.buttonRevenues.Location = new System.Drawing.Point(44, 32);
            this.buttonRevenues.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRevenues.Name = "buttonRevenues";
            this.buttonRevenues.Size = new System.Drawing.Size(176, 26);
            this.buttonRevenues.TabIndex = 0;
            this.buttonRevenues.Text = "Revenues by rates";
            this.buttonRevenues.UseVisualStyleBackColor = true;
            this.buttonRevenues.Click += new System.EventHandler(this.buttonRevenues_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 352);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private ComboBox comboBoxSkiPassID;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxTourniquetID;
        private Label label3;
        private ComboBox comboBox1;
        private Button buttonPass;
        private Button buttonCheck;
        private Label label8;
        private ComboBox comboBoxTariffName;
        private Button buttonAdd;
        private Label label9;
        private Button buttonPickTariff;
        private Label labelPrice;
        private DataGridView dataGridView1;
        private Button buttonLifts;
        private Button buttonRevenues;
    }
}