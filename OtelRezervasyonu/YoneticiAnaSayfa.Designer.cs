namespace OtelRezervasyonu
{
    partial class YoneticiAnaSayfa
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
            this.Geri = new System.Windows.Forms.Button();
            this.RezIptal = new System.Windows.Forms.Button();
            this.sorgulabut = new System.Windows.Forms.Button();
            this.dataGridViewyonetici = new System.Windows.Forms.DataGridView();
            this.musteriBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.otelRezerveDataSet5 = new OtelRezervasyonu.OtelRezerveDataSet5();
            this.musteriBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.otelRezerveDataSet2 = new OtelRezervasyonu.OtelRezerveDataSet2();
            this.musteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter = new OtelRezervasyonu.OtelRezerveDataSet2TableAdapters.MusteriTableAdapter();
            this.musteriTableAdapter1 = new OtelRezervasyonu.OtelRezerveDataSet5TableAdapters.MusteriTableAdapter();
            this.otelRezerveDataSet10 = new OtelRezervasyonu.OtelRezerveDataSet10();
            this.musteriBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.musteriTableAdapter2 = new OtelRezervasyonu.OtelRezerveDataSet10TableAdapters.MusteriTableAdapter();
            this.numaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tckn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisiSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickergiris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickercikis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewyonetici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // Geri
            // 
            this.Geri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri.Location = new System.Drawing.Point(776, 12);
            this.Geri.Name = "Geri";
            this.Geri.Size = new System.Drawing.Size(61, 35);
            this.Geri.TabIndex = 31;
            this.Geri.Text = "Geri";
            this.Geri.UseVisualStyleBackColor = true;
            this.Geri.Click += new System.EventHandler(this.Geri_Click);
            // 
            // RezIptal
            // 
            this.RezIptal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezIptal.Location = new System.Drawing.Point(632, 61);
            this.RezIptal.Name = "RezIptal";
            this.RezIptal.Size = new System.Drawing.Size(205, 40);
            this.RezIptal.TabIndex = 27;
            this.RezIptal.Text = "Rezervasyonu iptal et";
            this.RezIptal.UseVisualStyleBackColor = true;
            this.RezIptal.Click += new System.EventHandler(this.RezIptal_Click);
            // 
            // sorgulabut
            // 
            this.sorgulabut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sorgulabut.Location = new System.Drawing.Point(379, 21);
            this.sorgulabut.Name = "sorgulabut";
            this.sorgulabut.Size = new System.Drawing.Size(96, 35);
            this.sorgulabut.TabIndex = 26;
            this.sorgulabut.Text = "Sorgula";
            this.sorgulabut.UseVisualStyleBackColor = true;
            this.sorgulabut.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewyonetici
            // 
            this.dataGridViewyonetici.AutoGenerateColumns = false;
            this.dataGridViewyonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewyonetici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numaraDataGridViewTextBoxColumn,
            this.tckn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.giris,
            this.cikis,
            this.odaDataGridViewTextBoxColumn,
            this.kisiSayisiDataGridViewTextBoxColumn});
            this.dataGridViewyonetici.DataSource = this.musteriBindingSource4;
            this.dataGridViewyonetici.Location = new System.Drawing.Point(3, 127);
            this.dataGridViewyonetici.Name = "dataGridViewyonetici";
            this.dataGridViewyonetici.Size = new System.Drawing.Size(844, 150);
            this.dataGridViewyonetici.TabIndex = 32;
            this.dataGridViewyonetici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewyonetici_CellContentClick);
            // 
            // musteriBindingSource3
            // 
            this.musteriBindingSource3.DataMember = "Musteri";
            this.musteriBindingSource3.DataSource = this.otelRezerveDataSet5;
            // 
            // otelRezerveDataSet5
            // 
            this.otelRezerveDataSet5.DataSetName = "OtelRezerveDataSet5";
            this.otelRezerveDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource2
            // 
            this.musteriBindingSource2.DataMember = "Musteri";
            this.musteriBindingSource2.DataSource = this.otelRezerveDataSet2;
            // 
            // otelRezerveDataSet2
            // 
            this.otelRezerveDataSet2.DataSetName = "OtelRezerveDataSet2";
            this.otelRezerveDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource1
            // 
            this.musteriBindingSource1.DataMember = "Musteri";
            // 
            // musteriBindingSource
            // 
            this.musteriBindingSource.DataMember = "Musteri";
            // 
            // musteriTableAdapter
            // 
            this.musteriTableAdapter.ClearBeforeFill = true;
            // 
            // musteriTableAdapter1
            // 
            this.musteriTableAdapter1.ClearBeforeFill = true;
            // 
            // otelRezerveDataSet10
            // 
            this.otelRezerveDataSet10.DataSetName = "OtelRezerveDataSet10";
            this.otelRezerveDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // musteriBindingSource4
            // 
            this.musteriBindingSource4.DataMember = "Musteri";
            this.musteriBindingSource4.DataSource = this.otelRezerveDataSet10;
            // 
            // musteriTableAdapter2
            // 
            this.musteriTableAdapter2.ClearBeforeFill = true;
            // 
            // numaraDataGridViewTextBoxColumn
            // 
            this.numaraDataGridViewTextBoxColumn.DataPropertyName = "numara";
            this.numaraDataGridViewTextBoxColumn.HeaderText = "MusteriID";
            this.numaraDataGridViewTextBoxColumn.Name = "numaraDataGridViewTextBoxColumn";
            this.numaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tckn
            // 
            this.tckn.DataPropertyName = "tckn";
            this.tckn.HeaderText = "TC KimlikNo";
            this.tckn.Name = "tckn";
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // giris
            // 
            this.giris.DataPropertyName = "giris";
            this.giris.HeaderText = "Giriş Tarihi";
            this.giris.Name = "giris";
            // 
            // cikis
            // 
            this.cikis.DataPropertyName = "cikis";
            this.cikis.HeaderText = "Çıkış tarihi";
            this.cikis.Name = "cikis";
            // 
            // odaDataGridViewTextBoxColumn
            // 
            this.odaDataGridViewTextBoxColumn.DataPropertyName = "Oda";
            this.odaDataGridViewTextBoxColumn.HeaderText = "Oda";
            this.odaDataGridViewTextBoxColumn.Name = "odaDataGridViewTextBoxColumn";
            // 
            // kisiSayisiDataGridViewTextBoxColumn
            // 
            this.kisiSayisiDataGridViewTextBoxColumn.DataPropertyName = "KisiSayisi";
            this.kisiSayisiDataGridViewTextBoxColumn.HeaderText = "KisiSayisi";
            this.kisiSayisiDataGridViewTextBoxColumn.Name = "kisiSayisiDataGridViewTextBoxColumn";
            // 
            // dateTimePickergiris
            // 
            this.dateTimePickergiris.Location = new System.Drawing.Point(155, 27);
            this.dateTimePickergiris.Name = "dateTimePickergiris";
            this.dateTimePickergiris.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickergiris.TabIndex = 33;
            // 
            // dateTimePickercikis
            // 
            this.dateTimePickercikis.Location = new System.Drawing.Point(155, 61);
            this.dateTimePickercikis.Name = "dateTimePickercikis";
            this.dateTimePickercikis.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickercikis.TabIndex = 34;
            // 
            // YoneticiAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 295);
            this.Controls.Add(this.dateTimePickercikis);
            this.Controls.Add(this.dateTimePickergiris);
            this.Controls.Add(this.Geri);
            this.Controls.Add(this.RezIptal);
            this.Controls.Add(this.sorgulabut);
            this.Controls.Add(this.dataGridViewyonetici);
            this.Name = "YoneticiAnaSayfa";
            this.Text = "YoneticiAnaSayfa";
            this.Load += new System.EventHandler(this.YoneticiAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewyonetici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otelRezerveDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBindingSource4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource musteriBindingSource;
        private System.Windows.Forms.BindingSource musteriBindingSource1;
        private System.Windows.Forms.Button Geri;
        private System.Windows.Forms.Button RezIptal;
        private System.Windows.Forms.Button sorgulabut;
        private System.Windows.Forms.DataGridView dataGridViewyonetici;
        private OtelRezerveDataSet2 otelRezerveDataSet2;
        private System.Windows.Forms.BindingSource musteriBindingSource2;
        private OtelRezerveDataSet2TableAdapters.MusteriTableAdapter musteriTableAdapter;
        private OtelRezerveDataSet5 otelRezerveDataSet5;
        private System.Windows.Forms.BindingSource musteriBindingSource3;
        private OtelRezerveDataSet5TableAdapters.MusteriTableAdapter musteriTableAdapter1;
        private OtelRezerveDataSet10 otelRezerveDataSet10;
        private System.Windows.Forms.BindingSource musteriBindingSource4;
        private OtelRezerveDataSet10TableAdapters.MusteriTableAdapter musteriTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giris;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kisiSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickergiris;
        private System.Windows.Forms.DateTimePicker dateTimePickercikis;
    }
}