namespace W_H_Optimizer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.textBox_homeofficeTage = new System.Windows.Forms.TextBox();
            this.textBox_officeTage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_stundenProMonatBVHomeoffice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textbox_effektivHomeofficeAnteil = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textbox_stundenImMonat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown_arbeitstageImMonat = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInfo = new System.Windows.Forms.ToolStripButton();
            this.numericUpDown_stundenProTagOffice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_stundenProTagHomeoffice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown__GLZAbbauUrlaubTage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1_feiertage = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown__stundenMonatNachBV = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_homeofficeAnteil = new System.Windows.Forms.NumericUpDown();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox_totalHomeofficeTage = new System.Windows.Forms.TextBox();
            this.textBox_totalOfficeTage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_officeStunden = new System.Windows.Forms.TextBox();
            this.textBox_homeofficeStunden = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arbeitstageImMonat)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stundenProTagOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stundenProTagHomeoffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown__GLZAbbauUrlaubTage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_feiertage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown__stundenMonatNachBV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_homeofficeAnteil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arbeitstage im Monat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stunden pro Tag im Office";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(545, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "W@H Anteil nach BV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(363, 415);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 6;
            this.btn_Calculate.Text = "Berechnen";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // textBox_homeofficeTage
            // 
            this.textBox_homeofficeTage.Location = new System.Drawing.Point(688, 361);
            this.textBox_homeofficeTage.Name = "textBox_homeofficeTage";
            this.textBox_homeofficeTage.ReadOnly = true;
            this.textBox_homeofficeTage.Size = new System.Drawing.Size(100, 20);
            this.textBox_homeofficeTage.TabIndex = 8;
            // 
            // textBox_officeTage
            // 
            this.textBox_officeTage.Location = new System.Drawing.Point(688, 409);
            this.textBox_officeTage.Name = "textBox_officeTage";
            this.textBox_officeTage.ReadOnly = true;
            this.textBox_officeTage.Size = new System.Drawing.Size(100, 20);
            this.textBox_officeTage.TabIndex = 9;
            this.textBox_officeTage.TextChanged += new System.EventHandler(this.textBox_officeTage_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tage im Homeoffice";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(703, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tage im Office";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stunden pro Tag im Homeoffice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(431, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stunden im Monat nach W@H BV";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(653, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Verfügbare W@H Stunden pro Monat";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textbox_stundenProMonatBVHomeoffice
            // 
            this.textbox_stundenProMonatBVHomeoffice.Location = new System.Drawing.Point(669, 97);
            this.textbox_stundenProMonatBVHomeoffice.Name = "textbox_stundenProMonatBVHomeoffice";
            this.textbox_stundenProMonatBVHomeoffice.ReadOnly = true;
            this.textbox_stundenProMonatBVHomeoffice.Size = new System.Drawing.Size(67, 20);
            this.textbox_stundenProMonatBVHomeoffice.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(52, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 42);
            this.label11.TabIndex = 21;
            this.label11.Text = "GLZ-Abbau/Urlaub/Abwesenheits Tage im Monat";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(53, 396);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Feiertage im Monat";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 296);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Effektiv im Homeoffice";
            // 
            // textbox_effektivHomeofficeAnteil
            // 
            this.textbox_effektivHomeofficeAnteil.Location = new System.Drawing.Point(578, 312);
            this.textbox_effektivHomeofficeAnteil.Name = "textbox_effektivHomeofficeAnteil";
            this.textbox_effektivHomeofficeAnteil.ReadOnly = true;
            this.textbox_effektivHomeofficeAnteil.Size = new System.Drawing.Size(45, 20);
            this.textbox_effektivHomeofficeAnteil.TabIndex = 29;
            this.textbox_effektivHomeofficeAnteil.TextChanged += new System.EventHandler(this.textbox_effektivHomeofficeAnteil_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(629, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "%";
            // 
            // textbox_stundenImMonat
            // 
            this.textbox_stundenImMonat.Location = new System.Drawing.Point(194, 94);
            this.textbox_stundenImMonat.Name = "textbox_stundenImMonat";
            this.textbox_stundenImMonat.ReadOnly = true;
            this.textbox_stundenImMonat.Size = new System.Drawing.Size(100, 20);
            this.textbox_stundenImMonat.TabIndex = 33;
            this.textbox_stundenImMonat.TextChanged += new System.EventHandler(this.textbox_stundenImMonat_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(191, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 32;
            this.label17.Text = "Stunden im Monat";
            // 
            // numericUpDown_arbeitstageImMonat
            // 
            this.numericUpDown_arbeitstageImMonat.Location = new System.Drawing.Point(49, 95);
            this.numericUpDown_arbeitstageImMonat.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_arbeitstageImMonat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_arbeitstageImMonat.Name = "numericUpDown_arbeitstageImMonat";
            this.numericUpDown_arbeitstageImMonat.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_arbeitstageImMonat.TabIndex = 34;
            this.numericUpDown_arbeitstageImMonat.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonInfo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInfo.Name = "toolStripButtonInfo";
            this.toolStripButtonInfo.Size = new System.Drawing.Size(32, 22);
            this.toolStripButtonInfo.Text = "Info";
            this.toolStripButtonInfo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // numericUpDown_stundenProTagOffice
            // 
            this.numericUpDown_stundenProTagOffice.Location = new System.Drawing.Point(52, 217);
            this.numericUpDown_stundenProTagOffice.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_stundenProTagOffice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stundenProTagOffice.Name = "numericUpDown_stundenProTagOffice";
            this.numericUpDown_stundenProTagOffice.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_stundenProTagOffice.TabIndex = 36;
            this.numericUpDown_stundenProTagOffice.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_stundenProTagHomeoffice
            // 
            this.numericUpDown_stundenProTagHomeoffice.Location = new System.Drawing.Point(49, 156);
            this.numericUpDown_stundenProTagHomeoffice.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_stundenProTagHomeoffice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_stundenProTagHomeoffice.Name = "numericUpDown_stundenProTagHomeoffice";
            this.numericUpDown_stundenProTagHomeoffice.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown_stundenProTagHomeoffice.TabIndex = 37;
            this.numericUpDown_stundenProTagHomeoffice.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // numericUpDown__GLZAbbauUrlaubTage
            // 
            this.numericUpDown__GLZAbbauUrlaubTage.Enabled = false;
            this.numericUpDown__GLZAbbauUrlaubTage.Location = new System.Drawing.Point(52, 364);
            this.numericUpDown__GLZAbbauUrlaubTage.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown__GLZAbbauUrlaubTage.Name = "numericUpDown__GLZAbbauUrlaubTage";
            this.numericUpDown__GLZAbbauUrlaubTage.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown__GLZAbbauUrlaubTage.TabIndex = 38;
            this.numericUpDown__GLZAbbauUrlaubTage.Visible = false;
            this.numericUpDown__GLZAbbauUrlaubTage.ValueChanged += new System.EventHandler(this.numericUpDown__GLZAbbauTage_ValueChanged);
            // 
            // numericUpDown1_feiertage
            // 
            this.numericUpDown1_feiertage.Enabled = false;
            this.numericUpDown1_feiertage.Location = new System.Drawing.Point(52, 413);
            this.numericUpDown1_feiertage.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown1_feiertage.Name = "numericUpDown1_feiertage";
            this.numericUpDown1_feiertage.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1_feiertage.TabIndex = 39;
            this.numericUpDown1_feiertage.Visible = false;
            // 
            // numericUpDown__stundenMonatNachBV
            // 
            this.numericUpDown__stundenMonatNachBV.Location = new System.Drawing.Point(458, 97);
            this.numericUpDown__stundenMonatNachBV.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown__stundenMonatNachBV.Name = "numericUpDown__stundenMonatNachBV";
            this.numericUpDown__stundenMonatNachBV.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown__stundenMonatNachBV.TabIndex = 40;
            this.numericUpDown__stundenMonatNachBV.Value = new decimal(new int[] {
            173,
            0,
            0,
            0});
            // 
            // numericUpDown_homeofficeAnteil
            // 
            this.numericUpDown_homeofficeAnteil.Location = new System.Drawing.Point(551, 94);
            this.numericUpDown_homeofficeAnteil.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_homeofficeAnteil.Name = "numericUpDown_homeofficeAnteil";
            this.numericUpDown_homeofficeAnteil.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_homeofficeAnteil.TabIndex = 41;
            this.numericUpDown_homeofficeAnteil.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(220, 140);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 42;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBox_totalHomeofficeTage
            // 
            this.textBox_totalHomeofficeTage.Enabled = false;
            this.textBox_totalHomeofficeTage.Location = new System.Drawing.Point(158, 364);
            this.textBox_totalHomeofficeTage.Name = "textBox_totalHomeofficeTage";
            this.textBox_totalHomeofficeTage.Size = new System.Drawing.Size(100, 20);
            this.textBox_totalHomeofficeTage.TabIndex = 43;
            this.textBox_totalHomeofficeTage.Visible = false;
            // 
            // textBox_totalOfficeTage
            // 
            this.textBox_totalOfficeTage.Enabled = false;
            this.textBox_totalOfficeTage.Location = new System.Drawing.Point(158, 412);
            this.textBox_totalOfficeTage.Name = "textBox_totalOfficeTage";
            this.textBox_totalOfficeTage.Size = new System.Drawing.Size(100, 20);
            this.textBox_totalOfficeTage.TabIndex = 44;
            this.textBox_totalOfficeTage.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Stunden im Office";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(555, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Stunden im Homeoffice";
            // 
            // textBox_officeStunden
            // 
            this.textBox_officeStunden.Location = new System.Drawing.Point(557, 409);
            this.textBox_officeStunden.Name = "textBox_officeStunden";
            this.textBox_officeStunden.ReadOnly = true;
            this.textBox_officeStunden.Size = new System.Drawing.Size(100, 20);
            this.textBox_officeStunden.TabIndex = 46;
            // 
            // textBox_homeofficeStunden
            // 
            this.textBox_homeofficeStunden.Location = new System.Drawing.Point(557, 361);
            this.textBox_homeofficeStunden.Name = "textBox_homeofficeStunden";
            this.textBox_homeofficeStunden.ReadOnly = true;
            this.textBox_homeofficeStunden.Size = new System.Drawing.Size(100, 20);
            this.textBox_homeofficeStunden.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(666, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "=";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(666, 412);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_officeStunden);
            this.Controls.Add(this.textBox_homeofficeStunden);
            this.Controls.Add(this.textBox_totalOfficeTage);
            this.Controls.Add(this.textBox_totalHomeofficeTage);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericUpDown_homeofficeAnteil);
            this.Controls.Add(this.numericUpDown__stundenMonatNachBV);
            this.Controls.Add(this.numericUpDown1_feiertage);
            this.Controls.Add(this.numericUpDown__GLZAbbauUrlaubTage);
            this.Controls.Add(this.numericUpDown_stundenProTagHomeoffice);
            this.Controls.Add(this.numericUpDown_stundenProTagOffice);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.numericUpDown_arbeitstageImMonat);
            this.Controls.Add(this.textbox_stundenImMonat);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textbox_effektivHomeofficeAnteil);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textbox_stundenProMonatBVHomeoffice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_officeTage);
            this.Controls.Add(this.textBox_homeofficeTage);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "W@H Optimizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_arbeitstageImMonat)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stundenProTagOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stundenProTagHomeoffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown__GLZAbbauUrlaubTage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_feiertage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown__stundenMonatNachBV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_homeofficeAnteil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox textBox_homeofficeTage;
        private System.Windows.Forms.TextBox textBox_officeTage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_stundenProMonatBVHomeoffice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textbox_effektivHomeofficeAnteil;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textbox_stundenImMonat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown_arbeitstageImMonat;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfo;
        private System.Windows.Forms.NumericUpDown numericUpDown_stundenProTagOffice;
        private System.Windows.Forms.NumericUpDown numericUpDown_stundenProTagHomeoffice;
        private System.Windows.Forms.NumericUpDown numericUpDown__GLZAbbauUrlaubTage;
        private System.Windows.Forms.NumericUpDown numericUpDown1_feiertage;
        private System.Windows.Forms.NumericUpDown numericUpDown__stundenMonatNachBV;
        private System.Windows.Forms.NumericUpDown numericUpDown_homeofficeAnteil;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox_totalHomeofficeTage;
        private System.Windows.Forms.TextBox textBox_totalOfficeTage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_officeStunden;
        private System.Windows.Forms.TextBox textBox_homeofficeStunden;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
    }
}

