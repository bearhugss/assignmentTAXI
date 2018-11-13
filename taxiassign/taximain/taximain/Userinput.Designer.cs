namespace taximain
{
    partial class Userinput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userinput));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btentertime = new System.Windows.Forms.Button();
            this.cbmin = new System.Windows.Forms.ComboBox();
            this.cbhr = new System.Windows.Forms.ComboBox();
            this.rbam = new System.Windows.Forms.RadioButton();
            this.rbpm = new System.Windows.Forms.RadioButton();
            this.tbtime = new System.Windows.Forms.TextBox();
            this.tbkilometers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbfareamount = new System.Windows.Forms.TextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpassengername = new System.Windows.Forms.TextBox();
            this.tbpassengerid = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Total kilometers travelled:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(412, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSENGER/User Input DATA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Time :";
            // 
            // btentertime
            // 
            this.btentertime.ForeColor = System.Drawing.Color.DarkBlue;
            this.btentertime.Location = new System.Drawing.Point(186, 301);
            this.btentertime.Name = "btentertime";
            this.btentertime.Size = new System.Drawing.Size(121, 23);
            this.btentertime.TabIndex = 7;
            this.btentertime.Text = "Enter Time";
            this.btentertime.UseVisualStyleBackColor = true;
            this.btentertime.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbmin
            // 
            this.cbmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmin.FormattingEnabled = true;
            this.cbmin.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45",
            "59"});
            this.cbmin.Location = new System.Drawing.Point(313, 258);
            this.cbmin.Name = "cbmin";
            this.cbmin.Size = new System.Drawing.Size(121, 24);
            this.cbmin.TabIndex = 10;
            // 
            // cbhr
            // 
            this.cbhr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhr.FormattingEnabled = true;
            this.cbhr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbhr.Location = new System.Drawing.Point(186, 257);
            this.cbhr.Name = "cbhr";
            this.cbhr.Size = new System.Drawing.Size(121, 24);
            this.cbhr.TabIndex = 11;
            // 
            // rbam
            // 
            this.rbam.AutoSize = true;
            this.rbam.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbam.Location = new System.Drawing.Point(440, 261);
            this.rbam.Name = "rbam";
            this.rbam.Size = new System.Drawing.Size(49, 21);
            this.rbam.TabIndex = 12;
            this.rbam.TabStop = true;
            this.rbam.Text = "AM";
            this.rbam.UseVisualStyleBackColor = true;
            // 
            // rbpm
            // 
            this.rbpm.AutoSize = true;
            this.rbpm.ForeColor = System.Drawing.Color.Cornsilk;
            this.rbpm.Location = new System.Drawing.Point(495, 261);
            this.rbpm.Name = "rbpm";
            this.rbpm.Size = new System.Drawing.Size(49, 21);
            this.rbpm.TabIndex = 13;
            this.rbpm.TabStop = true;
            this.rbpm.Text = "PM";
            this.rbpm.UseVisualStyleBackColor = true;
            this.rbpm.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tbtime
            // 
            this.tbtime.Location = new System.Drawing.Point(291, 354);
            this.tbtime.Name = "tbtime";
            this.tbtime.Size = new System.Drawing.Size(121, 22);
            this.tbtime.TabIndex = 14;
            // 
            // tbkilometers
            // 
            this.tbkilometers.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbkilometers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbkilometers.Location = new System.Drawing.Point(383, 207);
            this.tbkilometers.Name = "tbkilometers";
            this.tbkilometers.Size = new System.Drawing.Size(100, 22);
            this.tbkilometers.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your Entered Time is :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estimated Fare Amount:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(418, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Estimated Fare amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbfareamount
            // 
            this.tbfareamount.Location = new System.Drawing.Point(291, 439);
            this.tbfareamount.Name = "tbfareamount";
            this.tbfareamount.Size = new System.Drawing.Size(111, 22);
            this.tbfareamount.TabIndex = 19;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 23);
            this.label6.TabIndex = 20;
            this.label6.Text = "Click to see Estimated Fare Amount ->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Enter Passenger ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 23);
            this.label8.TabIndex = 22;
            this.label8.Text = "Enter Passenger Name:";
            // 
            // tbpassengername
            // 
            this.tbpassengername.Location = new System.Drawing.Point(291, 152);
            this.tbpassengername.Name = "tbpassengername";
            this.tbpassengername.Size = new System.Drawing.Size(100, 22);
            this.tbpassengername.TabIndex = 23;
            // 
            // tbpassengerid
            // 
            this.tbpassengerid.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbpassengerid.Location = new System.Drawing.Point(291, 103);
            this.tbpassengerid.Name = "tbpassengerid";
            this.tbpassengerid.Size = new System.Drawing.Size(100, 22);
            this.tbpassengerid.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(783, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 101);
            this.button3.TabIndex = 26;
            this.button3.Text = "Upload Details to DATABASE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(836, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 45);
            this.button2.TabIndex = 27;
            this.button2.Text = "Go Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Userinput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1004, 510);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbpassengerid);
            this.Controls.Add(this.tbpassengername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbfareamount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbkilometers);
            this.Controls.Add(this.tbtime);
            this.Controls.Add(this.rbpm);
            this.Controls.Add(this.rbam);
            this.Controls.Add(this.cbhr);
            this.Controls.Add(this.cbmin);
            this.Controls.Add(this.btentertime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Userinput";
            this.Text = "Userinput";
            this.Load += new System.EventHandler(this.Userinput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btentertime;
        private System.Windows.Forms.ComboBox cbmin;
        private System.Windows.Forms.ComboBox cbhr;
        private System.Windows.Forms.RadioButton rbam;
        private System.Windows.Forms.RadioButton rbpm;
        private System.Windows.Forms.TextBox tbtime;
        private System.Windows.Forms.TextBox tbkilometers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbfareamount;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbpassengername;
        private System.Windows.Forms.TextBox tbpassengerid;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}