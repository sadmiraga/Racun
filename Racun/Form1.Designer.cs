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
            this.vrstaRacunaSelectedButton = new System.Windows.Forms.Button();
            this.ustvariButton = new System.Windows.Forms.Button();
            this.poslovni = new System.Windows.Forms.GroupBox();
            this.inputTipPodjetja = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.inputNazivPodjetja = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.valutni = new System.Windows.Forms.GroupBox();
            this.inputPrimarnaValuta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addValutaButton = new System.Windows.Forms.Button();
            this.inputValuta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.seznamValutList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.osebni = new System.Windows.Forms.GroupBox();
            this.inputObrestnaMera = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.varcevalniCheckBox = new System.Windows.Forms.CheckBox();
            this.stanjeLabel = new System.Windows.Forms.Label();
            this.dvigGroupBox = new System.Windows.Forms.GroupBox();
            this.dvigButton = new System.Windows.Forms.Button();
            this.inputDvig = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pologGroupBox = new System.Windows.Forms.GroupBox();
            this.pologButton = new System.Windows.Forms.Button();
            this.inputPolog = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.osebniFunctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.povecajObrestnoMeroButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.prihranekButton = new System.Windows.Forms.Button();
            this.inputPrihranek = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.valutniFunctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.zamenjajValutoButton = new System.Windows.Forms.Button();
            this.inputTecaj = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.poslovniFunctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.likvidnoButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.poslovni.SuspendLayout();
            this.valutni.SuspendLayout();
            this.osebni.SuspendLayout();
            this.dvigGroupBox.SuspendLayout();
            this.pologGroupBox.SuspendLayout();
            this.osebniFunctionsGroupBox.SuspendLayout();
            this.valutniFunctionsGroupBox.SuspendLayout();
            this.poslovniFunctionsGroupBox.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.ustvariButton);
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
            // ustvariButton
            // 
            this.ustvariButton.Location = new System.Drawing.Point(12, 518);
            this.ustvariButton.Name = "ustvariButton";
            this.ustvariButton.Size = new System.Drawing.Size(354, 33);
            this.ustvariButton.TabIndex = 13;
            this.ustvariButton.Text = "Ustvari";
            this.ustvariButton.UseVisualStyleBackColor = true;
            this.ustvariButton.Visible = false;
            this.ustvariButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // poslovni
            // 
            this.poslovni.Controls.Add(this.inputTipPodjetja);
            this.poslovni.Controls.Add(this.label10);
            this.poslovni.Controls.Add(this.inputNazivPodjetja);
            this.poslovni.Controls.Add(this.label9);
            this.poslovni.Location = new System.Drawing.Point(12, 412);
            this.poslovni.Name = "poslovni";
            this.poslovni.Size = new System.Drawing.Size(354, 100);
            this.poslovni.TabIndex = 12;
            this.poslovni.TabStop = false;
            this.poslovni.Text = "Poslovni račun";
            this.poslovni.Visible = false;
            // 
            // inputTipPodjetja
            // 
            this.inputTipPodjetja.FormattingEnabled = true;
            this.inputTipPodjetja.Items.AddRange(new object[] {
            "s.p.",
            "d.o.o.",
            "d.d.",
            "d.n.o."});
            this.inputTipPodjetja.Location = new System.Drawing.Point(113, 62);
            this.inputTipPodjetja.Name = "inputTipPodjetja";
            this.inputTipPodjetja.Size = new System.Drawing.Size(178, 24);
            this.inputTipPodjetja.TabIndex = 13;
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
            // inputNazivPodjetja
            // 
            this.inputNazivPodjetja.Location = new System.Drawing.Point(115, 25);
            this.inputNazivPodjetja.Name = "inputNazivPodjetja";
            this.inputNazivPodjetja.Size = new System.Drawing.Size(176, 22);
            this.inputNazivPodjetja.TabIndex = 13;
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
            this.valutni.Controls.Add(this.inputPrimarnaValuta);
            this.valutni.Controls.Add(this.label8);
            this.valutni.Controls.Add(this.addValutaButton);
            this.valutni.Controls.Add(this.inputValuta);
            this.valutni.Controls.Add(this.label7);
            this.valutni.Controls.Add(this.seznamValutList);
            this.valutni.Controls.Add(this.label6);
            this.valutni.Location = new System.Drawing.Point(12, 249);
            this.valutni.Name = "valutni";
            this.valutni.Size = new System.Drawing.Size(354, 145);
            this.valutni.TabIndex = 11;
            this.valutni.TabStop = false;
            this.valutni.Text = "Valutni račun";
            this.valutni.Visible = false;
            // 
            // inputPrimarnaValuta
            // 
            this.inputPrimarnaValuta.FormattingEnabled = true;
            this.inputPrimarnaValuta.Location = new System.Drawing.Point(160, 115);
            this.inputPrimarnaValuta.Name = "inputPrimarnaValuta";
            this.inputPrimarnaValuta.Size = new System.Drawing.Size(169, 24);
            this.inputPrimarnaValuta.TabIndex = 12;
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
            // addValutaButton
            // 
            this.addValutaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addValutaButton.Location = new System.Drawing.Point(169, 43);
            this.addValutaButton.Name = "addValutaButton";
            this.addValutaButton.Size = new System.Drawing.Size(148, 27);
            this.addValutaButton.TabIndex = 4;
            this.addValutaButton.Text = "dodaj na seznam";
            this.addValutaButton.UseVisualStyleBackColor = true;
            this.addValutaButton.Click += new System.EventHandler(this.addValutaButton_Click);
            // 
            // inputValuta
            // 
            this.inputValuta.Location = new System.Drawing.Point(230, 15);
            this.inputValuta.Name = "inputValuta";
            this.inputValuta.Size = new System.Drawing.Size(87, 22);
            this.inputValuta.TabIndex = 3;
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
            // seznamValutList
            // 
            this.seznamValutList.FormattingEnabled = true;
            this.seznamValutList.ItemHeight = 16;
            this.seznamValutList.Location = new System.Drawing.Point(15, 51);
            this.seznamValutList.Name = "seznamValutList";
            this.seznamValutList.Size = new System.Drawing.Size(120, 84);
            this.seznamValutList.TabIndex = 1;
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
            this.osebni.Controls.Add(this.inputObrestnaMera);
            this.osebni.Controls.Add(this.label1);
            this.osebni.Controls.Add(this.varcevalniCheckBox);
            this.osebni.Location = new System.Drawing.Point(12, 150);
            this.osebni.Name = "osebni";
            this.osebni.Size = new System.Drawing.Size(354, 84);
            this.osebni.TabIndex = 10;
            this.osebni.TabStop = false;
            this.osebni.Text = "Osebni racun";
            this.osebni.Visible = false;
            // 
            // inputObrestnaMera
            // 
            this.inputObrestnaMera.Location = new System.Drawing.Point(251, 36);
            this.inputObrestnaMera.Name = "inputObrestnaMera";
            this.inputObrestnaMera.Size = new System.Drawing.Size(87, 22);
            this.inputObrestnaMera.TabIndex = 2;
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
            // varcevalniCheckBox
            // 
            this.varcevalniCheckBox.AutoSize = true;
            this.varcevalniCheckBox.Location = new System.Drawing.Point(16, 36);
            this.varcevalniCheckBox.Name = "varcevalniCheckBox";
            this.varcevalniCheckBox.Size = new System.Drawing.Size(96, 21);
            this.varcevalniCheckBox.TabIndex = 0;
            this.varcevalniCheckBox.Text = "Varčevalni";
            this.varcevalniCheckBox.UseVisualStyleBackColor = true;
            // 
            // stanjeLabel
            // 
            this.stanjeLabel.AutoSize = true;
            this.stanjeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stanjeLabel.Location = new System.Drawing.Point(770, 49);
            this.stanjeLabel.Name = "stanjeLabel";
            this.stanjeLabel.Size = new System.Drawing.Size(60, 18);
            this.stanjeLabel.TabIndex = 10;
            this.stanjeLabel.Text = "Stanje:";
            // 
            // dvigGroupBox
            // 
            this.dvigGroupBox.Controls.Add(this.dvigButton);
            this.dvigGroupBox.Controls.Add(this.inputDvig);
            this.dvigGroupBox.Controls.Add(this.label12);
            this.dvigGroupBox.Location = new System.Drawing.Point(450, 35);
            this.dvigGroupBox.Name = "dvigGroupBox";
            this.dvigGroupBox.Size = new System.Drawing.Size(281, 107);
            this.dvigGroupBox.TabIndex = 11;
            this.dvigGroupBox.TabStop = false;
            this.dvigGroupBox.Text = "Dvig";
            this.dvigGroupBox.Visible = false;
            // 
            // dvigButton
            // 
            this.dvigButton.Location = new System.Drawing.Point(67, 74);
            this.dvigButton.Name = "dvigButton";
            this.dvigButton.Size = new System.Drawing.Size(176, 25);
            this.dvigButton.TabIndex = 14;
            this.dvigButton.Text = "Dvig";
            this.dvigButton.UseVisualStyleBackColor = true;
            this.dvigButton.Click += new System.EventHandler(this.dvigButton_Click);
            // 
            // inputDvig
            // 
            this.inputDvig.Location = new System.Drawing.Point(67, 36);
            this.inputDvig.Name = "inputDvig";
            this.inputDvig.Size = new System.Drawing.Size(176, 22);
            this.inputDvig.TabIndex = 5;
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
            // pologGroupBox
            // 
            this.pologGroupBox.Controls.Add(this.pologButton);
            this.pologGroupBox.Controls.Add(this.inputPolog);
            this.pologGroupBox.Controls.Add(this.label13);
            this.pologGroupBox.Location = new System.Drawing.Point(450, 160);
            this.pologGroupBox.Name = "pologGroupBox";
            this.pologGroupBox.Size = new System.Drawing.Size(281, 136);
            this.pologGroupBox.TabIndex = 12;
            this.pologGroupBox.TabStop = false;
            this.pologGroupBox.Text = "Polog";
            this.pologGroupBox.Visible = false;
            // 
            // pologButton
            // 
            this.pologButton.Location = new System.Drawing.Point(67, 70);
            this.pologButton.Name = "pologButton";
            this.pologButton.Size = new System.Drawing.Size(176, 25);
            this.pologButton.TabIndex = 17;
            this.pologButton.Text = "Polog";
            this.pologButton.UseVisualStyleBackColor = true;
            this.pologButton.Click += new System.EventHandler(this.pologButton_Click);
            // 
            // inputPolog
            // 
            this.inputPolog.Location = new System.Drawing.Point(67, 33);
            this.inputPolog.Name = "inputPolog";
            this.inputPolog.Size = new System.Drawing.Size(176, 22);
            this.inputPolog.TabIndex = 16;
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
            // osebniFunctionsGroupBox
            // 
            this.osebniFunctionsGroupBox.Controls.Add(this.povecajObrestnoMeroButton);
            this.osebniFunctionsGroupBox.Controls.Add(this.label15);
            this.osebniFunctionsGroupBox.Controls.Add(this.prihranekButton);
            this.osebniFunctionsGroupBox.Controls.Add(this.inputPrihranek);
            this.osebniFunctionsGroupBox.Controls.Add(this.label14);
            this.osebniFunctionsGroupBox.Location = new System.Drawing.Point(450, 305);
            this.osebniFunctionsGroupBox.Name = "osebniFunctionsGroupBox";
            this.osebniFunctionsGroupBox.Size = new System.Drawing.Size(281, 149);
            this.osebniFunctionsGroupBox.TabIndex = 13;
            this.osebniFunctionsGroupBox.TabStop = false;
            this.osebniFunctionsGroupBox.Text = "Osebni račun";
            this.osebniFunctionsGroupBox.Visible = false;
            // 
            // povecajObrestnoMeroButton
            // 
            this.povecajObrestnoMeroButton.Location = new System.Drawing.Point(136, 101);
            this.povecajObrestnoMeroButton.Name = "povecajObrestnoMeroButton";
            this.povecajObrestnoMeroButton.Size = new System.Drawing.Size(117, 25);
            this.povecajObrestnoMeroButton.TabIndex = 20;
            this.povecajObrestnoMeroButton.Text = "Povečaj";
            this.povecajObrestnoMeroButton.UseVisualStyleBackColor = true;
            this.povecajObrestnoMeroButton.Click += new System.EventHandler(this.povecajObrestnoMeroButton_Click);
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
            // prihranekButton
            // 
            this.prihranekButton.Location = new System.Drawing.Point(136, 67);
            this.prihranekButton.Name = "prihranekButton";
            this.prihranekButton.Size = new System.Drawing.Size(117, 25);
            this.prihranekButton.TabIndex = 18;
            this.prihranekButton.Text = "Prihranek";
            this.prihranekButton.UseVisualStyleBackColor = true;
            this.prihranekButton.Click += new System.EventHandler(this.prihranekButton_Click);
            // 
            // inputPrihranek
            // 
            this.inputPrihranek.Location = new System.Drawing.Point(9, 70);
            this.inputPrihranek.Name = "inputPrihranek";
            this.inputPrihranek.Size = new System.Drawing.Size(111, 22);
            this.inputPrihranek.TabIndex = 15;
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
            // valutniFunctionsGroupBox
            // 
            this.valutniFunctionsGroupBox.Controls.Add(this.zamenjajValutoButton);
            this.valutniFunctionsGroupBox.Controls.Add(this.inputTecaj);
            this.valutniFunctionsGroupBox.Controls.Add(this.label16);
            this.valutniFunctionsGroupBox.Location = new System.Drawing.Point(450, 465);
            this.valutniFunctionsGroupBox.Name = "valutniFunctionsGroupBox";
            this.valutniFunctionsGroupBox.Size = new System.Drawing.Size(281, 111);
            this.valutniFunctionsGroupBox.TabIndex = 14;
            this.valutniFunctionsGroupBox.TabStop = false;
            this.valutniFunctionsGroupBox.Text = "Valutni račun";
            this.valutniFunctionsGroupBox.Visible = false;
            // 
            // zamenjajValutoButton
            // 
            this.zamenjajValutoButton.Location = new System.Drawing.Point(136, 61);
            this.zamenjajValutoButton.Name = "zamenjajValutoButton";
            this.zamenjajValutoButton.Size = new System.Drawing.Size(117, 25);
            this.zamenjajValutoButton.TabIndex = 21;
            this.zamenjajValutoButton.Text = "Zamenjaj valuto";
            this.zamenjajValutoButton.UseVisualStyleBackColor = true;
            this.zamenjajValutoButton.Click += new System.EventHandler(this.zamenjajValutoButton_Click);
            // 
            // inputTecaj
            // 
            this.inputTecaj.Location = new System.Drawing.Point(9, 62);
            this.inputTecaj.Name = "inputTecaj";
            this.inputTecaj.Size = new System.Drawing.Size(111, 22);
            this.inputTecaj.TabIndex = 21;
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
            // poslovniFunctionsGroupBox
            // 
            this.poslovniFunctionsGroupBox.Controls.Add(this.likvidnoButton);
            this.poslovniFunctionsGroupBox.Location = new System.Drawing.Point(762, 123);
            this.poslovniFunctionsGroupBox.Name = "poslovniFunctionsGroupBox";
            this.poslovniFunctionsGroupBox.Size = new System.Drawing.Size(117, 136);
            this.poslovniFunctionsGroupBox.TabIndex = 15;
            this.poslovniFunctionsGroupBox.TabStop = false;
            this.poslovniFunctionsGroupBox.Text = "Poslovni račun";
            this.poslovniFunctionsGroupBox.Visible = false;
            // 
            // likvidnoButton
            // 
            this.likvidnoButton.Location = new System.Drawing.Point(20, 36);
            this.likvidnoButton.Name = "likvidnoButton";
            this.likvidnoButton.Size = new System.Drawing.Size(75, 74);
            this.likvidnoButton.TabIndex = 0;
            this.likvidnoButton.Text = "Podjetje likvidno?";
            this.likvidnoButton.UseVisualStyleBackColor = true;
            this.likvidnoButton.Click += new System.EventHandler(this.likvidnoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 600);
            this.Controls.Add(this.poslovniFunctionsGroupBox);
            this.Controls.Add(this.valutniFunctionsGroupBox);
            this.Controls.Add(this.osebniFunctionsGroupBox);
            this.Controls.Add(this.pologGroupBox);
            this.Controls.Add(this.dvigGroupBox);
            this.Controls.Add(this.stanjeLabel);
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
            this.dvigGroupBox.ResumeLayout(false);
            this.dvigGroupBox.PerformLayout();
            this.pologGroupBox.ResumeLayout(false);
            this.pologGroupBox.PerformLayout();
            this.osebniFunctionsGroupBox.ResumeLayout(false);
            this.osebniFunctionsGroupBox.PerformLayout();
            this.valutniFunctionsGroupBox.ResumeLayout(false);
            this.valutniFunctionsGroupBox.PerformLayout();
            this.poslovniFunctionsGroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button ustvariButton;
        private System.Windows.Forms.GroupBox poslovni;
        private System.Windows.Forms.ComboBox inputTipPodjetja;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputNazivPodjetja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox valutni;
        private System.Windows.Forms.ComboBox inputPrimarnaValuta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addValutaButton;
        private System.Windows.Forms.TextBox inputValuta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox seznamValutList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox osebni;
        private System.Windows.Forms.TextBox inputObrestnaMera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox varcevalniCheckBox;
        private System.Windows.Forms.Label stanjeLabel;
        private System.Windows.Forms.GroupBox dvigGroupBox;
        private System.Windows.Forms.Button dvigButton;
        private System.Windows.Forms.TextBox inputDvig;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox pologGroupBox;
        private System.Windows.Forms.Button pologButton;
        private System.Windows.Forms.TextBox inputPolog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox osebniFunctionsGroupBox;
        private System.Windows.Forms.TextBox inputPrihranek;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button povecajObrestnoMeroButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button prihranekButton;
        private System.Windows.Forms.GroupBox valutniFunctionsGroupBox;
        private System.Windows.Forms.Button zamenjajValutoButton;
        private System.Windows.Forms.TextBox inputTecaj;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox poslovniFunctionsGroupBox;
        private System.Windows.Forms.Button likvidnoButton;
        private System.Windows.Forms.Button vrstaRacunaSelectedButton;
    }
}

