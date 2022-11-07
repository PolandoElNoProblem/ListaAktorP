namespace lufenMachen
{
    partial class LISTA
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Tytul", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Rez", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("DP", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("GR", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LISTA));
            this.tyt = new System.Windows.Forms.Label();
            this.rez1 = new System.Windows.Forms.Label();
            this.GR1 = new System.Windows.Forms.Label();
            this.DP1 = new System.Windows.Forms.Label();
            this.Tytul2 = new System.Windows.Forms.TextBox();
            this.Rez2 = new System.Windows.Forms.TextBox();
            this.GR3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Tytuł = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rez = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńWybraneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Dodaj = new System.Windows.Forms.Button();
            this.Zap = new System.Windows.Forms.Button();
            this.Zam = new System.Windows.Forms.Button();
            this.dp2 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tyt
            // 
            this.tyt.AutoSize = true;
            this.tyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tyt.Location = new System.Drawing.Point(28, 22);
            this.tyt.Name = "tyt";
            this.tyt.Size = new System.Drawing.Size(37, 13);
            this.tyt.TabIndex = 0;
            this.tyt.Text = "Tytuł";
            // 
            // rez1
            // 
            this.rez1.AutoSize = true;
            this.rez1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rez1.Location = new System.Drawing.Point(28, 54);
            this.rez1.Name = "rez1";
            this.rez1.Size = new System.Drawing.Size(52, 13);
            this.rez1.TabIndex = 1;
            this.rez1.Text = "Reżyser";
            // 
            // GR1
            // 
            this.GR1.AutoSize = true;
            this.GR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GR1.Location = new System.Drawing.Point(302, 57);
            this.GR1.Name = "GR1";
            this.GR1.Size = new System.Drawing.Size(81, 13);
            this.GR1.TabIndex = 2;
            this.GR1.Text = "Główna Rola";
            // 
            // DP1
            // 
            this.DP1.AutoSize = true;
            this.DP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DP1.Location = new System.Drawing.Point(297, 23);
            this.DP1.Name = "DP1";
            this.DP1.Size = new System.Drawing.Size(86, 13);
            this.DP1.TabIndex = 3;
            this.DP1.Text = "Data Premiery";
            // 
            // Tytul2
            // 
            this.Tytul2.Location = new System.Drawing.Point(90, 16);
            this.Tytul2.Name = "Tytul2";
            this.Tytul2.Size = new System.Drawing.Size(122, 20);
            this.Tytul2.TabIndex = 4;
            this.Tytul2.TextChanged += new System.EventHandler(this.Tytul2_TextChanged);
            // 
            // Rez2
            // 
            this.Rez2.Location = new System.Drawing.Point(90, 54);
            this.Rez2.Name = "Rez2";
            this.Rez2.Size = new System.Drawing.Size(122, 20);
            this.Rez2.TabIndex = 5;
            // 
            // GR3
            // 
            this.GR3.Location = new System.Drawing.Point(396, 48);
            this.GR3.Name = "GR3";
            this.GR3.Size = new System.Drawing.Size(120, 20);
            this.GR3.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Tytuł,
            this.Rez,
            this.DP,
            this.GR});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewGroup1.Header = "Tytul";
            listViewGroup1.Name = "Tytuł";
            listViewGroup2.Header = "Rez";
            listViewGroup2.Name = "Reżyser";
            listViewGroup3.Header = "DP";
            listViewGroup3.Name = "DataPremiery";
            listViewGroup4.Header = "GR";
            listViewGroup4.Name = "GłównaRola";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4});
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(31, 110);
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(485, 286);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Tytuł
            // 
            this.Tytuł.Text = "Tytuł";
            this.Tytuł.Width = 182;
            // 
            // Rez
            // 
            this.Rez.Text = "Reżyser";
            this.Rez.Width = 110;
            // 
            // DP
            // 
            this.DP.Text = "DataPremiery";
            this.DP.Width = 84;
            // 
            // GR
            // 
            this.GR.Text = "GłównaRola";
            this.GR.Width = 107;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńWybraneToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // usuńWybraneToolStripMenuItem
            // 
            this.usuńWybraneToolStripMenuItem.Name = "usuńWybraneToolStripMenuItem";
            this.usuńWybraneToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.usuńWybraneToolStripMenuItem.Text = "Usuń wybrane";
            this.usuńWybraneToolStripMenuItem.Click += new System.EventHandler(this.usuńWybraneToolStripMenuItem_Click);
            // 
            // Dodaj
            // 
            this.Dodaj.Location = new System.Drawing.Point(441, 81);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 23);
            this.Dodaj.TabIndex = 10;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Zap
            // 
            this.Zap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zap.Location = new System.Drawing.Point(348, 414);
            this.Zap.Name = "Zap";
            this.Zap.Size = new System.Drawing.Size(75, 23);
            this.Zap.TabIndex = 11;
            this.Zap.Text = "Zapisz";
            this.Zap.UseVisualStyleBackColor = true;
            this.Zap.Click += new System.EventHandler(this.Zap_Click);
            // 
            // Zam
            // 
            this.Zam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Zam.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Zam.Location = new System.Drawing.Point(441, 414);
            this.Zam.Name = "Zam";
            this.Zam.Size = new System.Drawing.Size(75, 23);
            this.Zam.TabIndex = 12;
            this.Zam.Text = "Zamknij";
            this.Zam.UseVisualStyleBackColor = true;
            this.Zam.Click += new System.EventHandler(this.Zam_Click);
            // 
            // dp2
            // 
            this.dp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp2.Location = new System.Drawing.Point(398, 22);
            this.dp2.Name = "dp2";
            this.dp2.Size = new System.Drawing.Size(118, 20);
            this.dp2.TabIndex = 13;
            this.dp2.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LISTA
            // 
            this.AcceptButton = this.Dodaj;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Zam;
            this.ClientSize = new System.Drawing.Size(543, 449);
            this.Controls.Add(this.dp2);
            this.Controls.Add(this.Zam);
            this.Controls.Add(this.Zap);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GR3);
            this.Controls.Add(this.Rez2);
            this.Controls.Add(this.Tytul2);
            this.Controls.Add(this.DP1);
            this.Controls.Add(this.GR1);
            this.Controls.Add(this.rez1);
            this.Controls.Add(this.tyt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LISTA";
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tyt;
        private System.Windows.Forms.Label rez1;
        private System.Windows.Forms.Label GR1;
        private System.Windows.Forms.Label DP1;
        private System.Windows.Forms.TextBox Tytul2;
        private System.Windows.Forms.TextBox Rez2;
        private System.Windows.Forms.TextBox GR3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuńWybraneToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Tytuł;
        private System.Windows.Forms.ColumnHeader Rez;
        private System.Windows.Forms.ColumnHeader DP;
        private System.Windows.Forms.ColumnHeader GR;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Dodaj;
        private System.Windows.Forms.Button Zap;
        private System.Windows.Forms.Button Zam;
        private System.Windows.Forms.DateTimePicker dp2;
    }
}

