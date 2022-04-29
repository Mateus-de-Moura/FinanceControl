using Contas.Apresentacao;

using LOGIN.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Contas
{
    public partial class FrmPrincipal : Form
    {
        LoginDao a = new LoginDao();
        private Panel panel1;
        private Panel painelLogo;
        private Label labelHome;
        private PictureBox pictureBox1;
        public DataGridView GvContas;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button2;
        private Label LblTotal;
        public TextBox txbTtal;
        private Label LblMes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn Situação;
        private Label labeel;
        public PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Button button3;
        private TextBox txtFormatado;
        private PictureBox pictureBox2;
        private Label LblContas;

        public FrmPrincipal()
        {
            
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LblContas = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.painelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.GvContas = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblTotal = new System.Windows.Forms.Label();
            this.txbTtal = new System.Windows.Forms.TextBox();
            this.LblMes = new System.Windows.Forms.Label();
            this.labeel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtFormatado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.painelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.LblContas);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 442);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(14, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 27);
            this.button3.TabIndex = 8;
            this.button3.Text = "Calculadora";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(21, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(103, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // LblContas
            // 
            this.LblContas.AutoSize = true;
            this.LblContas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblContas.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LblContas.Location = new System.Drawing.Point(35, 5);
            this.LblContas.Name = "LblContas";
            this.LblContas.Size = new System.Drawing.Size(71, 20);
            this.LblContas.TabIndex = 3;
            this.LblContas.Text = "Contas ";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calendário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // painelLogo
            // 
            this.painelLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.painelLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.painelLogo.Controls.Add(this.pictureBox1);
            this.painelLogo.Controls.Add(this.labelHome);
            this.painelLogo.Location = new System.Drawing.Point(144, 0);
            this.painelLogo.Name = "painelLogo";
            this.painelLogo.Size = new System.Drawing.Size(794, 34);
            this.painelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelHome.Location = new System.Drawing.Point(372, 12);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(58, 18);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "HOME";
            // 
            // GvContas
            // 
            this.GvContas.AllowUserToAddRows = false;
            this.GvContas.AllowUserToDeleteRows = false;
            this.GvContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GvContas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GvContas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GvContas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GvContas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GvContas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GvContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.dataGridViewTextBoxColumn1,
            this.Valor,
            this.Vencimento,
            this.Situação});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GvContas.DefaultCellStyle = dataGridViewCellStyle2;
            this.GvContas.Location = new System.Drawing.Point(144, 33);
            this.GvContas.MultiSelect = false;
            this.GvContas.Name = "GvContas";
            this.GvContas.ReadOnly = true;
            this.GvContas.RowHeadersVisible = false;
            this.GvContas.RowTemplate.Height = 25;
            this.GvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GvContas.Size = new System.Drawing.Size(784, 373);
            this.GvContas.TabIndex = 2;
            this.GvContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GvContas_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vencimento.HeaderText = "Vencimento";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            // 
            // Situação
            // 
            this.Situação.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Situação.HeaderText = "Situação";
            this.Situação.Name = "Situação";
            this.Situação.ReadOnly = true;
            // 
            // LblTotal
            // 
            this.LblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTotal.ForeColor = System.Drawing.Color.Red;
            this.LblTotal.Location = new System.Drawing.Point(741, 419);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(38, 16);
            this.LblTotal.TabIndex = 6;
            this.LblTotal.Text = "Total";
            // 
            // txbTtal
            // 
            this.txbTtal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTtal.Location = new System.Drawing.Point(785, 414);
            this.txbTtal.Name = "txbTtal";
            this.txbTtal.Size = new System.Drawing.Size(100, 23);
            this.txbTtal.TabIndex = 7;
            // 
            // LblMes
            // 
            this.LblMes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMes.AutoSize = true;
            this.LblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMes.Location = new System.Drawing.Point(223, 416);
            this.LblMes.Name = "LblMes";
            this.LblMes.Size = new System.Drawing.Size(21, 16);
            this.LblMes.TabIndex = 9;
            this.LblMes.Text = " M";
            // 
            // labeel
            // 
            this.labeel.AutoSize = true;
            this.labeel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeel.Location = new System.Drawing.Point(144, 412);
            this.labeel.Name = "labeel";
            this.labeel.Size = new System.Drawing.Size(0, 18);
            this.labeel.TabIndex = 10;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(159, 414);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 11;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(250, 414);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(41, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 12;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // txtFormatado
            // 
            this.txtFormatado.BackColor = System.Drawing.SystemColors.Control;
            this.txtFormatado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFormatado.Location = new System.Drawing.Point(191, 416);
            this.txtFormatado.Name = "txtFormatado";
            this.txtFormatado.Size = new System.Drawing.Size(62, 16);
            this.txtFormatado.TabIndex = 14;
            this.txtFormatado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(891, 414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // FrmPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(930, 441);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtFormatado);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.labeel);
            this.Controls.Add(this.LblMes);
            this.Controls.Add(this.txbTtal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.GvContas);
            this.Controls.Add(this.painelLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.painelLogo.ResumeLayout(false);
            this.painelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GvContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Carregagrid(int mes)
        {                      
            GvContas.Rows.Clear();
            this.GvContas.Columns[0].Visible = false;
            DataTable dat = a.CarregaGrid(mes);
            foreach (DataRow item in dat.Rows)
            {

                GvContas.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                FormataGrid();
            }
            int soma = 0;
            for (int i = 0; i < GvContas.Rows.Count; i++)
            {
                soma += Convert.ToInt32(GvContas.Rows[i].Cells[2].Value);
            }

            foreach (DataGridViewRow row in GvContas.Rows)
            {
                row.Cells[3].Value = Convert.ToDateTime(row.Cells[3].Value).ToString("dd/MM/yyy");
            }
            txbTtal.Text = soma.ToString("#,##0.00");
            GvContas.Columns[0].Width = 50;
            LblMes.Text = Convert.ToString(DateTime.Now.Month);
           
            MesSelecionado();


            //MesSelecionado();
        }
        public void FormataGrid()
        {
            foreach (DataGridViewRow linha in GvContas.Rows)
            {
                if (linha.Cells[4].Value.ToString() == "Pago")
                {
                    linha.DefaultCellStyle.BackColor = Color.LightSeaGreen;
                }
            }
         
        }
        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmCalendario cad = new FrmCalendario();
            cad.ShowDialog();

        }
    
        private void GvContas_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmEditarContas edit = new FrmEditarContas();
            edit.txbId.Text = this.GvContas.CurrentRow.Cells[0].Value.ToString();
            edit.txbDesc.Text = this.GvContas.CurrentRow.Cells[1].Value.ToString();
            edit.tcbVal.Text = this.GvContas.CurrentRow.Cells[2].Value.ToString();
            edit.txbVenc.Text = this.GvContas.CurrentRow.Cells[3].Value.ToString();
            edit.cbmSitu.Text = this.GvContas.CurrentRow.Cells[4].Value.ToString();            
            if (edit.ShowDialog(this) != DialogResult.OK)
            {
                //GvContas.Rows.Clear();
                Carregagrid(Convert.ToInt32(LblMes.Text));
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmCadastro cadastro = new FrmCadastro();
            if (cadastro.ShowDialog(this) != DialogResult.OK)
            {
                GvContas.Rows.Clear();
                Carregagrid(Convert.ToInt32(LblMes.Text));
                GvContas.Refresh();
                GvContas.Update();
            }
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GvContas.Rows.Clear();
            Carregagrid(DateTime.Now.Month);

        }      
       
        private void MesSelecionado()
        {
            if (LblMes.Text == "1")
            {
                txtFormatado.Text = "Janeiro";
            }
            else if (LblMes.Text == "2")
            {
                txtFormatado.Text = "Fevereiro";
            }
            else if (LblMes.Text == "3")
            {
                txtFormatado.Text = "Março";
            }
            else if (LblMes.Text == "4")
            {
                txtFormatado.Text = "Abril";
            }
            else if (LblMes.Text == "5")
            {
                txtFormatado.Text = "Maio";
            }
            else if (LblMes.Text == "6")
            {
                txtFormatado.Text = "Junho";
            }
            else if (LblMes.Text == "7")
            {
                txtFormatado.Text = "Julho";
            }
            else if (LblMes.Text == "8")
            {
                txtFormatado.Text = "Agosto";
            }
            else if (LblMes.Text == "9")
            {
                txtFormatado.Text = "Setembro";
            }
            else if (LblMes.Text == "10")
            {
                txtFormatado.Text = "Outubro";
            }
            else if (LblMes.Text == "11")
            {
                txtFormatado.Text = "Novembro";
            }
            else if (LblMes.Text == "12")
            {
                txtFormatado.Text = "Dezembro";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox7.Enabled = true;

            if (int.Parse(LblMes.Text) >= 2) {
                pictureBox6.Enabled = true;
                txtFormatado.TextAlign = HorizontalAlignment.Center;
                string mes = Convert.ToString(LblMes.Text);
                int Mes = int.Parse(mes) - 1;
                Carregagrid(Mes);
                LblMes.Text = Convert.ToString(Mes);            
                if (Mes <= 0) 
                {
                    LblMes.Text = "12";
                }
                FormataGrid();
                MesSelecionado();
                }
            else 
            {
                pictureBox6.Enabled = false;
            }

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox6.Enabled = true;

            if (int.Parse(LblMes.Text) <= 11) {   
                pictureBox7.Enabled = true;
                string Mes = Convert.ToString(LblMes.Text);
                int mes = int.Parse(Mes) + 1;
                Carregagrid(mes);
                LblMes.Text = Convert.ToString(mes);

                if (mes == 13)
                {
                    LblMes.Text = "1";
                }
                FormataGrid();
                MesSelecionado();
            }
            else
            {
                pictureBox7.Enabled = false;
            }
        }

        private void lblMesFormatado_Click(object sender, EventArgs e)
        {
            MesSelecionado();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.DateTime data = new System.DateTime();
            
        }     
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
           
            
            
            
            
        }
    }
}


