namespace A_star_navigation
{
    partial class AStarNavigationForm
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdrediRutu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNajkracaRuta = new System.Windows.Forms.TextBox();
            this.btnDohvatiTocke = new System.Windows.Forms.Button();
            this.cmbPocetnaTocka = new System.Windows.Forms.ComboBox();
            this.cmbZavrsnaTocka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(1, 137);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = false;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(1495, 864);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početna točka: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Završna točka: ";
            // 
            // btnOdrediRutu
            // 
            this.btnOdrediRutu.Enabled = false;
            this.btnOdrediRutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdrediRutu.Location = new System.Drawing.Point(480, 33);
            this.btnOdrediRutu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOdrediRutu.Name = "btnOdrediRutu";
            this.btnOdrediRutu.Size = new System.Drawing.Size(152, 96);
            this.btnOdrediRutu.TabIndex = 5;
            this.btnOdrediRutu.Text = "Odredi najkraću rutu";
            this.btnOdrediRutu.UseVisualStyleBackColor = true;
            this.btnOdrediRutu.Click += new System.EventHandler(this.btnOdrediRutu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1248, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.MaximumSize = new System.Drawing.Size(267, 0);
            this.label3.MinimumSize = new System.Drawing.Size(0, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 123);
            this.label3.TabIndex = 6;
            this.label3.Text = "A* algoritam u navigaciji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(683, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Najkraća ruta:";
            // 
            // txtNajkracaRuta
            // 
            this.txtNajkracaRuta.Enabled = false;
            this.txtNajkracaRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNajkracaRuta.Location = new System.Drawing.Point(688, 95);
            this.txtNajkracaRuta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNajkracaRuta.Name = "txtNajkracaRuta";
            this.txtNajkracaRuta.Size = new System.Drawing.Size(285, 30);
            this.txtNajkracaRuta.TabIndex = 8;
            // 
            // btnDohvatiTocke
            // 
            this.btnDohvatiTocke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDohvatiTocke.Location = new System.Drawing.Point(16, 33);
            this.btnDohvatiTocke.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDohvatiTocke.Name = "btnDohvatiTocke";
            this.btnDohvatiTocke.Size = new System.Drawing.Size(152, 96);
            this.btnDohvatiTocke.TabIndex = 9;
            this.btnDohvatiTocke.Text = "Dohvati točke i rute (3 klika dok se sve učita)";
            this.btnDohvatiTocke.UseVisualStyleBackColor = true;
            this.btnDohvatiTocke.Click += new System.EventHandler(this.btnDohvatiTocke_Click);
            // 
            // cmbPocetnaTocka
            // 
            this.cmbPocetnaTocka.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cmbPocetnaTocka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPocetnaTocka.Enabled = false;
            this.cmbPocetnaTocka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPocetnaTocka.FormattingEnabled = true;
            this.cmbPocetnaTocka.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cmbPocetnaTocka.Location = new System.Drawing.Point(347, 33);
            this.cmbPocetnaTocka.Name = "cmbPocetnaTocka";
            this.cmbPocetnaTocka.Size = new System.Drawing.Size(121, 33);
            this.cmbPocetnaTocka.TabIndex = 10;
            // 
            // cmbZavrsnaTocka
            // 
            this.cmbZavrsnaTocka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZavrsnaTocka.Enabled = false;
            this.cmbZavrsnaTocka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZavrsnaTocka.FormattingEnabled = true;
            this.cmbZavrsnaTocka.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J"});
            this.cmbZavrsnaTocka.Location = new System.Drawing.Point(347, 94);
            this.cmbZavrsnaTocka.Name = "cmbZavrsnaTocka";
            this.cmbZavrsnaTocka.Size = new System.Drawing.Size(121, 33);
            this.cmbZavrsnaTocka.TabIndex = 11;
            // 
            // AStarNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 999);
            this.Controls.Add(this.cmbZavrsnaTocka);
            this.Controls.Add(this.cmbPocetnaTocka);
            this.Controls.Add(this.btnDohvatiTocke);
            this.Controls.Add(this.txtNajkracaRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdrediRutu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AStarNavigationForm";
            this.Text = "A* navigation";
            this.Load += new System.EventHandler(this.AStarNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdrediRutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajkracaRuta;
        private System.Windows.Forms.Button btnDohvatiTocke;
        private System.Windows.Forms.ComboBox cmbPocetnaTocka;
        private System.Windows.Forms.ComboBox cmbZavrsnaTocka;
    }
}

