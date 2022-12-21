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
            this.txtPocetnaTocka = new System.Windows.Forms.TextBox();
            this.txtZavrsnaTocka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOdrediRutu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNajkracaRuta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(1, 111);
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
            this.map.Size = new System.Drawing.Size(925, 497);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Početna točka: ";
            // 
            // txtPocetnaTocka
            // 
            this.txtPocetnaTocka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPocetnaTocka.Location = new System.Drawing.Point(137, 17);
            this.txtPocetnaTocka.Name = "txtPocetnaTocka";
            this.txtPocetnaTocka.Size = new System.Drawing.Size(78, 26);
            this.txtPocetnaTocka.TabIndex = 2;
            // 
            // txtZavrsnaTocka
            // 
            this.txtZavrsnaTocka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZavrsnaTocka.Location = new System.Drawing.Point(137, 67);
            this.txtZavrsnaTocka.Name = "txtZavrsnaTocka";
            this.txtZavrsnaTocka.Size = new System.Drawing.Size(78, 26);
            this.txtZavrsnaTocka.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Završna točka: ";
            // 
            // btnOdrediRutu
            // 
            this.btnOdrediRutu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdrediRutu.Location = new System.Drawing.Point(236, 17);
            this.btnOdrediRutu.Name = "btnOdrediRutu";
            this.btnOdrediRutu.Size = new System.Drawing.Size(114, 78);
            this.btnOdrediRutu.TabIndex = 5;
            this.btnOdrediRutu.Text = "Odredi najkraću rutu";
            this.btnOdrediRutu.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(724, 23);
            this.label3.MaximumSize = new System.Drawing.Size(200, 0);
            this.label3.MinimumSize = new System.Drawing.Size(0, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 100);
            this.label3.TabIndex = 6;
            this.label3.Text = "A* algoritam u navigaciji";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Najkraća ruta:";
            // 
            // txtNajkracaRuta
            // 
            this.txtNajkracaRuta.Enabled = false;
            this.txtNajkracaRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNajkracaRuta.Location = new System.Drawing.Point(392, 67);
            this.txtNajkracaRuta.Name = "txtNajkracaRuta";
            this.txtNajkracaRuta.Size = new System.Drawing.Size(234, 26);
            this.txtNajkracaRuta.TabIndex = 8;
            // 
            // AStarNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 609);
            this.Controls.Add(this.txtNajkracaRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOdrediRutu);
            this.Controls.Add(this.txtZavrsnaTocka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPocetnaTocka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.map);
            this.Name = "AStarNavigationForm";
            this.Text = "A* navigation";
            this.Load += new System.EventHandler(this.AStarNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPocetnaTocka;
        private System.Windows.Forms.TextBox txtZavrsnaTocka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOdrediRutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNajkracaRuta;
    }
}

