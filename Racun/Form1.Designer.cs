namespace Racun
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputStanje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputLimit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputVrstaRacuna = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.poslovni = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.valutni = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.osebni = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.vrstaRacunaSelectedButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.poslovni.SuspendLayout();
            this.valutni.SuspendLayout();
            this.osebni.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lastnik (ime priimek)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(153, 33);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(150, 22);
            this.inputName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "stanje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputStanje
            // 
            this.inputStanje.Location = new System.Drawing.Point(61, 67);
            this.inputStanje.Name = "inputStanje";
            this.inputStanje.Size = new System.Drawing.Size(78, 22);
            this.inputStanje.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "limit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputLimit
            // 
            this.inputLimit.Location = new System.Drawing.Point(197, 70);
            this.inputLimit.Name = "inputLimit";
            this.inputLimit.Size = new System.Drawing.Size(106, 22);
            this.inputLimit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vrsta računa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inputVrstaRacuna
            // 
            this.inputVrstaRacuna.FormattingEnabled = true;
            this.inputVrstaRacuna.Items.AddRange(new object[] {
            "Osebni",
            "Valutni",
            "Poslovni"});
            this.inputVrstaRacuna.Location = new System.Drawing.Point(104, 106);
            this.inputVrstaRacuna.Name = "inputVrstaRacuna";
            this.inputVrstaRacuna.Size = new System.Drawing.Size(199, 24);
            this.inputVrstaRacuna.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vrstaRacunaSelectedButton);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.poslovni);
            this.groupBox1.Controls.Add(this.valutni);
            this.groupBox1.Controls.Add(this.osebni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.inputVrstaRacuna);
            this.groupBox1.Controls.Add(this.inputName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.inputLimit);
            this.groupBox1.Controls.Add(this.inputStanje);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(39, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 563);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ustvari racun";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ustvari";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // poslovni
            // 
            this.poslovni.Controls.Add(this.comboBox3);
            this.poslovni.Controls.Add(this.label10);
            this.poslovni.Controls.Add(this.textBox6);
            this.poslovni.Controls.Add(this.label9);
            this.poslovni.Location = new System.Drawing.Point(12, 412);
            this.poslovni.Name = "poslovni";
            this.poslovni.Size = new System.Drawing.Size(354, 100);
            this.poslovni.TabIndex = 12;
            this.poslovni.TabStop = false;
            this.poslovni.Text = "Poslovni račun";
            this.poslovni.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "s.p.",
            "d.o.o.",
            "d.d.",
            "d.n.o."});
            this.comboBox3.Location = new System.Drawing.Point(113, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(178, 24);
            this.comboBox3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Tip podjedja";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(176, 22);
            this.textBox6.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Naziv podjetja";
            // 
            // valutni
            // 
            this.valutni.Controls.Add(this.comboBox2);
            this.valutni.Controls.Add(this.label8);
            this.valutni.Controls.Add(this.button1);
            this.valutni.Controls.Add(this.textBox5);
            this.valutni.Controls.Add(this.label7);
            this.valutni.Controls.Add(this.listBox1);
            this.valutni.Controls.Add(this.label6);
            this.valutni.Location = new System.Drawing.Point(12, 249);
            this.valutni.Name = "valutni";
            this.valutni.Size = new System.Drawing.Size(354, 145);
            this.valutni.TabIndex = 11;
            this.valutni.TabStop = false;
            this.valutni.Text = "Valutni račun";
            this.valutni.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Osebni",
            "Valutni",
            "Poslovni"});
            this.comboBox2.Location = new System.Drawing.Point(160, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 24);
            this.comboBox2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "primarna valuta";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "dodaj na seznam";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(230, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(87, 22);
            this.textBox5.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Valuta";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Seznam valut";
            // 
            // osebni
            // 
            this.osebni.Controls.Add(this.textBox4);
            this.osebni.Controls.Add(this.label1);
            this.osebni.Controls.Add(this.checkBox1);
            this.osebni.Location = new System.Drawing.Point(12, 150);
            this.osebni.Name = "osebni";
            this.osebni.Size = new System.Drawing.Size(354, 84);
            this.osebni.TabIndex = 10;
            this.osebni.TabStop = false;
            this.osebni.Text = "Osebni racun";
            this.osebni.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(251, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(87, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obrestna mera";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 36);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Varčevalni";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(770, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 29);
            this.label11.TabIndex = 10;
            this.label11.Text = "Stanje:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(450, 35);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 107);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dvig";
            this.groupBox5.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "Dvig";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(67, 36);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(176, 22);
            this.textBox7.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Znesek";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button4);
            this.groupBox6.Controls.Add(this.textBox8);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(450, 160);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 136);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Polog";
            this.groupBox6.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 25);
            this.button4.TabIndex = 17;
            this.button4.Text = "Polog";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(67, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(176, 22);
            this.textBox8.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 38);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Znesek";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button6);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.button5);
            this.groupBox7.Controls.Add(this.textBox9);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Location = new System.Drawing.Point(450, 305);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(281, 149);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Osebni račun";
            this.groupBox7.Visible = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(136, 101);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 25);
            this.button6.TabIndex = 20;
            this.button6.Text = "Povečaj";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Obr. mera:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(136, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "Prihranek";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(9, 70);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(111, 22);
            this.textBox9.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Povprečno mesečno stanje";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.button7);
            this.groupBox8.Controls.Add(this.textBox10);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Location = new System.Drawing.Point(450, 465);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(281, 111);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Valutni račun";
            this.groupBox8.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(136, 61);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 25);
            this.button7.TabIndex = 21;
            this.button7.Text = "Zamenjaj valuto";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(9, 62);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(111, 22);
            this.textBox10.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 17);
            this.label16.TabIndex = 21;
            this.label16.Text = "Menjalni tečaj";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button8);
            this.groupBox9.Location = new System.Drawing.Point(762, 123);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(117, 136);
            this.groupBox9.TabIndex = 15;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Poslovni račun";
            this.groupBox9.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(20, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 74);
            this.button8.TabIndex = 0;
            this.button8.Text = "Podjetje likvidno?";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // vrstaRacunaSelectedButton
            // 
            this.vrstaRacunaSelectedButton.Location = new System.Drawing.Point(323, 36);
            this.vrstaRacunaSelectedButton.Name = "vrstaRacunaSelectedButton";
            this.vrstaRacunaSelectedButton.Size = new System.Drawing.Size(27, 94);
            this.vrstaRacunaSelectedButton.TabIndex = 14;
            this.vrstaRacunaSelectedButton.Text = "ok";
            this.vrstaRacunaSelectedButton.UseVisualStyleBackColor = true;
            this.vrstaRacunaSelectedButton.Click += new System.EventHandler(this.vrstaRacunaSelectedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 600);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Upravljanje racunov";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.poslovni.ResumeLayout(false);
            this.poslovni.PerformLayout();
            this.valutni.ResumeLayout(false);
            this.valutni.PerformLayout();
            this.osebni.ResumeLayout(false);
            this.osebni.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputStanje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputLimit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputVrstaRacuna;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox poslovni;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox valutni;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox osebni;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button vrstaRacunaSelectedButton;
    }
}

