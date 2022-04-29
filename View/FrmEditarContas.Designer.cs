
namespace Contas.Apresentacao
{
    partial class FrmEditarContas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarContas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmSitu = new System.Windows.Forms.ComboBox();
            this.txbId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbVenc = new System.Windows.Forms.TextBox();
            this.tcbVal = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lblSitu = new System.Windows.Forms.Label();
            this.lblVenc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.cbmSitu);
            this.groupBox1.Controls.Add(this.txbId);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txbVenc);
            this.groupBox1.Controls.Add(this.tcbVal);
            this.groupBox1.Controls.Add(this.txbDesc);
            this.groupBox1.Controls.Add(this.lblSitu);
            this.groupBox1.Controls.Add(this.lblVenc);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblDescri);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar";
            // 
            // cbmSitu
            // 
            this.cbmSitu.FormattingEnabled = true;
            this.cbmSitu.Items.AddRange(new object[] {
            "Pago",
            "A vencer"});
            this.cbmSitu.Location = new System.Drawing.Point(82, 177);
            this.cbmSitu.Name = "cbmSitu";
            this.cbmSitu.Size = new System.Drawing.Size(231, 23);
            this.cbmSitu.TabIndex = 12;
            this.cbmSitu.Text = "Selecione";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(82, 31);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(100, 23);
            this.txbId.TabIndex = 11;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(7, 39);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 16);
            this.lblId.TabIndex = 10;
            this.lblId.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 227);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txbVenc
            // 
            this.txbVenc.Location = new System.Drawing.Point(82, 139);
            this.txbVenc.Name = "txbVenc";
            this.txbVenc.Size = new System.Drawing.Size(231, 23);
            this.txbVenc.TabIndex = 6;
            // 
            // tcbVal
            // 
            this.tcbVal.Location = new System.Drawing.Point(82, 102);
            this.tcbVal.Name = "tcbVal";
            this.tcbVal.Size = new System.Drawing.Size(231, 23);
            this.tcbVal.TabIndex = 5;
            // 
            // txbDesc
            // 
            this.txbDesc.Location = new System.Drawing.Point(82, 69);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.Size = new System.Drawing.Size(231, 23);
            this.txbDesc.TabIndex = 4;
            // 
            // lblSitu
            // 
            this.lblSitu.AutoSize = true;
            this.lblSitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSitu.ForeColor = System.Drawing.Color.Black;
            this.lblSitu.Location = new System.Drawing.Point(6, 179);
            this.lblSitu.Name = "lblSitu";
            this.lblSitu.Size = new System.Drawing.Size(60, 16);
            this.lblSitu.TabIndex = 3;
            this.lblSitu.Text = "Situação";
            // 
            // lblVenc
            // 
            this.lblVenc.AutoSize = true;
            this.lblVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVenc.ForeColor = System.Drawing.Color.Black;
            this.lblVenc.Location = new System.Drawing.Point(6, 142);
            this.lblVenc.Name = "lblVenc";
            this.lblVenc.Size = new System.Drawing.Size(78, 16);
            this.lblVenc.TabIndex = 2;
            this.lblVenc.Text = "Vencimento";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(6, 104);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(39, 16);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescri.ForeColor = System.Drawing.Color.Black;
            this.lblDescri.Location = new System.Drawing.Point(6, 72);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(69, 16);
            this.lblDescri.TabIndex = 0;
            this.lblDescri.Text = "Descrição";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(344, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FrmEditarContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 297);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditarContas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar contas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSitu;
        private System.Windows.Forms.Label lblVenc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblId;
        public System.Windows.Forms.TextBox txbId;
        public System.Windows.Forms.TextBox txbDesc;
        public System.Windows.Forms.TextBox tcbVal;
        public System.Windows.Forms.TextBox txbVenc;
        public System.Windows.Forms.ComboBox cbmSitu;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}