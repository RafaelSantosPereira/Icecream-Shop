namespace M7_ficheiros_progeto_final
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbcaramelo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmorango = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btlimpar = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbextras = new System.Windows.Forms.Label();
            this.cbchocolate = new System.Windows.Forms.CheckBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.btcalcular = new System.Windows.Forms.Button();
            this.cbmorango = new System.Windows.Forms.CheckBox();
            this.lbpreco = new System.Windows.Forms.Label();
            this.cboreo = new System.Windows.Forms.CheckBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbquant = new System.Windows.Forms.Label();
            this.btvoltar = new System.Windows.Forms.Button();
            this.btchocolate = new System.Windows.Forms.Button();
            this.btbaunilha = new System.Windows.Forms.Button();
            this.lbsabores = new System.Windows.Forms.Label();
            this.btpagar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extra2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbeditar = new System.Windows.Forms.Label();
            this.lbeliminar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbprocurar = new System.Windows.Forms.Label();
            this.lbsair = new System.Windows.Forms.Label();
            this.txtprocurar = new System.Windows.Forms.TextBox();
            this.txtajudante = new System.Windows.Forms.TextBox();
            this.btordenar = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.btprocurar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbcaramelo
            // 
            this.cbcaramelo.AutoSize = true;
            this.cbcaramelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcaramelo.Location = new System.Drawing.Point(93, 51);
            this.cbcaramelo.Name = "cbcaramelo";
            this.cbcaramelo.Size = new System.Drawing.Size(101, 24);
            this.cbcaramelo.TabIndex = 0;
            this.cbcaramelo.Text = "caramelo";
            this.cbcaramelo.UseVisualStyleBackColor = true;
            this.cbcaramelo.Visible = false;
            this.cbcaramelo.CheckedChanged += new System.EventHandler(this.cbcaramelo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 253);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btmorango
            // 
            this.btmorango.BackColor = System.Drawing.Color.HotPink;
            this.btmorango.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.GeladoMorango_1;
            this.btmorango.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btmorango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmorango.Location = new System.Drawing.Point(268, 44);
            this.btmorango.Name = "btmorango";
            this.btmorango.Size = new System.Drawing.Size(123, 159);
            this.btmorango.TabIndex = 15;
            this.btmorango.Text = "morango";
            this.btmorango.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btmorango.UseVisualStyleBackColor = false;
            this.btmorango.Click += new System.EventHandler(this.btmorango_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btlimpar);
            this.panel3.Controls.Add(this.txtnome);
            this.panel3.Controls.Add(this.lbextras);
            this.panel3.Controls.Add(this.cbchocolate);
            this.panel3.Controls.Add(this.txtquant);
            this.panel3.Controls.Add(this.cbcaramelo);
            this.panel3.Controls.Add(this.btcalcular);
            this.panel3.Controls.Add(this.cbmorango);
            this.panel3.Controls.Add(this.lbpreco);
            this.panel3.Controls.Add(this.cboreo);
            this.panel3.Controls.Add(this.lbtotal);
            this.panel3.Controls.Add(this.lbnome);
            this.panel3.Controls.Add(this.lbquant);
            this.panel3.Location = new System.Drawing.Point(430, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 235);
            this.panel3.TabIndex = 32;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.ola_6_logo;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(327, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 103);
            this.panel1.TabIndex = 31;
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.Color.HotPink;
            this.btlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.Location = new System.Drawing.Point(372, 184);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(95, 32);
            this.btlimpar.TabIndex = 30;
            this.btlimpar.Text = "limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Visible = false;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(199, 122);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 27;
            this.txtnome.Visible = false;
            // 
            // lbextras
            // 
            this.lbextras.AutoSize = true;
            this.lbextras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbextras.Location = new System.Drawing.Point(60, 10);
            this.lbextras.Name = "lbextras";
            this.lbextras.Size = new System.Drawing.Size(257, 25);
            this.lbextras.TabIndex = 14;
            this.lbextras.Text = "extras - 0.50€ (limite 2)";
            this.lbextras.Visible = false;
            // 
            // cbchocolate
            // 
            this.cbchocolate.AutoSize = true;
            this.cbchocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchocolate.Location = new System.Drawing.Point(94, 82);
            this.cbchocolate.Name = "cbchocolate";
            this.cbchocolate.Size = new System.Drawing.Size(106, 24);
            this.cbchocolate.TabIndex = 15;
            this.cbchocolate.Text = "chocolate";
            this.cbchocolate.UseVisualStyleBackColor = true;
            this.cbchocolate.Visible = false;
            this.cbchocolate.CheckedChanged += new System.EventHandler(this.cbchocolate_CheckedChanged);
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(261, 150);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(100, 20);
            this.txtquant.TabIndex = 29;
            this.txtquant.Visible = false;
            // 
            // btcalcular
            // 
            this.btcalcular.BackColor = System.Drawing.Color.HotPink;
            this.btcalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.Location = new System.Drawing.Point(235, 184);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(126, 32);
            this.btcalcular.TabIndex = 28;
            this.btcalcular.Text = "calcular";
            this.btcalcular.UseVisualStyleBackColor = false;
            this.btcalcular.Visible = false;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // cbmorango
            // 
            this.cbmorango.AutoSize = true;
            this.cbmorango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmorango.Location = new System.Drawing.Point(219, 52);
            this.cbmorango.Name = "cbmorango";
            this.cbmorango.Size = new System.Drawing.Size(98, 24);
            this.cbmorango.TabIndex = 19;
            this.cbmorango.Text = "morango";
            this.cbmorango.UseVisualStyleBackColor = true;
            this.cbmorango.Visible = false;
            this.cbmorango.CheckedChanged += new System.EventHandler(this.cbmorango_CheckedChanged);
            // 
            // lbpreco
            // 
            this.lbpreco.AutoSize = true;
            this.lbpreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpreco.Location = new System.Drawing.Point(159, 188);
            this.lbpreco.Name = "lbpreco";
            this.lbpreco.Size = new System.Drawing.Size(0, 25);
            this.lbpreco.TabIndex = 28;
            // 
            // cboreo
            // 
            this.cboreo.AutoSize = true;
            this.cboreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboreo.Location = new System.Drawing.Point(219, 82);
            this.cboreo.Name = "cboreo";
            this.cboreo.Size = new System.Drawing.Size(64, 24);
            this.cboreo.TabIndex = 20;
            this.cboreo.Text = "oreo";
            this.cboreo.UseVisualStyleBackColor = true;
            this.cboreo.Visible = false;
            this.cboreo.CheckedChanged += new System.EventHandler(this.cboreo_CheckedChanged);
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(88, 188);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(80, 25);
            this.lbtotal.TabIndex = 21;
            this.lbtotal.Text = "total - ";
            this.lbtotal.Visible = false;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(111, 116);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(91, 25);
            this.lbnome.TabIndex = 26;
            this.lbnome.Text = "nome - ";
            this.lbnome.Visible = false;
            // 
            // lbquant
            // 
            this.lbquant.AutoSize = true;
            this.lbquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbquant.Location = new System.Drawing.Point(111, 145);
            this.lbquant.Name = "lbquant";
            this.lbquant.Size = new System.Drawing.Size(151, 25);
            this.lbquant.TabIndex = 23;
            this.lbquant.Text = "quantidade - ";
            this.lbquant.Visible = false;
            // 
            // btvoltar
            // 
            this.btvoltar.BackColor = System.Drawing.Color.HotPink;
            this.btvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btvoltar.Location = new System.Drawing.Point(10, 6);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(81, 32);
            this.btvoltar.TabIndex = 31;
            this.btvoltar.Text = "voltar";
            this.btvoltar.UseVisualStyleBackColor = false;
            this.btvoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btchocolate
            // 
            this.btchocolate.BackColor = System.Drawing.Color.HotPink;
            this.btchocolate.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.GeladoChocolate_2;
            this.btchocolate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btchocolate.FlatAppearance.BorderSize = 0;
            this.btchocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btchocolate.Location = new System.Drawing.Point(10, 44);
            this.btchocolate.Name = "btchocolate";
            this.btchocolate.Size = new System.Drawing.Size(123, 159);
            this.btchocolate.TabIndex = 14;
            this.btchocolate.Text = "chocolate";
            this.btchocolate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btchocolate.UseVisualStyleBackColor = false;
            this.btchocolate.Click += new System.EventHandler(this.btchocolate_Click_1);
            // 
            // btbaunilha
            // 
            this.btbaunilha.BackColor = System.Drawing.Color.HotPink;
            this.btbaunilha.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.GeladoBaunilha_1;
            this.btbaunilha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btbaunilha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbaunilha.Location = new System.Drawing.Point(139, 44);
            this.btbaunilha.Name = "btbaunilha";
            this.btbaunilha.Size = new System.Drawing.Size(123, 159);
            this.btbaunilha.TabIndex = 13;
            this.btbaunilha.Text = "baunilha";
            this.btbaunilha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btbaunilha.UseVisualStyleBackColor = false;
            this.btbaunilha.Click += new System.EventHandler(this.btbaunilha_Click_1);
            // 
            // lbsabores
            // 
            this.lbsabores.AutoSize = true;
            this.lbsabores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsabores.Location = new System.Drawing.Point(144, 0);
            this.lbsabores.Name = "lbsabores";
            this.lbsabores.Size = new System.Drawing.Size(144, 25);
            this.lbsabores.TabIndex = 13;
            this.lbsabores.Text = "sabores - 2€";
            // 
            // btpagar
            // 
            this.btpagar.BackColor = System.Drawing.Color.HotPink;
            this.btpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpagar.Location = new System.Drawing.Point(616, 271);
            this.btpagar.Name = "btpagar";
            this.btpagar.Size = new System.Drawing.Size(274, 54);
            this.btpagar.TabIndex = 22;
            this.btpagar.Text = "Pagar";
            this.btpagar.UseVisualStyleBackColor = false;
            this.btpagar.Visible = false;
            this.btpagar.Click += new System.EventHandler(this.btpagar_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.sabor,
            this.extras,
            this.extra2,
            this.quantidade,
            this.preço});
            this.dgv.Location = new System.Drawing.Point(21, 268);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(556, 217);
            this.dgv.TabIndex = 21;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // sabor
            // 
            this.sabor.HeaderText = "sabor";
            this.sabor.Name = "sabor";
            this.sabor.ReadOnly = true;
            // 
            // extras
            // 
            this.extras.HeaderText = "Extras";
            this.extras.Name = "extras";
            this.extras.ReadOnly = true;
            // 
            // extra2
            // 
            this.extra2.HeaderText = "Extra 2";
            this.extra2.Name = "extra2";
            this.extra2.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 80;
            // 
            // preço
            // 
            this.preço.HeaderText = "Preço";
            this.preço.Name = "preço";
            this.preço.ReadOnly = true;
            this.preço.Width = 70;
            // 
            // lbeditar
            // 
            this.lbeditar.AutoSize = true;
            this.lbeditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeditar.Location = new System.Drawing.Point(624, 397);
            this.lbeditar.Name = "lbeditar";
            this.lbeditar.Size = new System.Drawing.Size(57, 20);
            this.lbeditar.TabIndex = 28;
            this.lbeditar.Text = "Editar";
            // 
            // lbeliminar
            // 
            this.lbeliminar.AutoSize = true;
            this.lbeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeliminar.Location = new System.Drawing.Point(817, 397);
            this.lbeliminar.Name = "lbeliminar";
            this.lbeliminar.Size = new System.Drawing.Size(73, 20);
            this.lbeliminar.TabIndex = 29;
            this.lbeliminar.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(716, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ordenar";
            // 
            // lbprocurar
            // 
            this.lbprocurar.AutoSize = true;
            this.lbprocurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprocurar.Location = new System.Drawing.Point(614, 475);
            this.lbprocurar.Name = "lbprocurar";
            this.lbprocurar.Size = new System.Drawing.Size(77, 20);
            this.lbprocurar.TabIndex = 31;
            this.lbprocurar.Text = "Procurar";
            // 
            // lbsair
            // 
            this.lbsair.AutoSize = true;
            this.lbsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsair.Location = new System.Drawing.Point(832, 475);
            this.lbsair.Name = "lbsair";
            this.lbsair.Size = new System.Drawing.Size(41, 20);
            this.lbsair.TabIndex = 32;
            this.lbsair.Text = "Sair";
            // 
            // txtprocurar
            // 
            this.txtprocurar.Location = new System.Drawing.Point(704, 438);
            this.txtprocurar.Name = "txtprocurar";
            this.txtprocurar.Size = new System.Drawing.Size(100, 20);
            this.txtprocurar.TabIndex = 33;
            // 
            // txtajudante
            // 
            this.txtajudante.Enabled = false;
            this.txtajudante.Location = new System.Drawing.Point(704, 477);
            this.txtajudante.Name = "txtajudante";
            this.txtajudante.Size = new System.Drawing.Size(100, 20);
            this.txtajudante.TabIndex = 34;
            this.txtajudante.Visible = false;
            // 
            // btordenar
            // 
            this.btordenar.BackColor = System.Drawing.Color.HotPink;
            this.btordenar.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources._130898;
            this.btordenar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btordenar.Location = new System.Drawing.Point(715, 336);
            this.btordenar.Name = "btordenar";
            this.btordenar.Size = new System.Drawing.Size(75, 58);
            this.btordenar.TabIndex = 27;
            this.btordenar.UseVisualStyleBackColor = false;
            this.btordenar.Click += new System.EventHandler(this.btordenar_Click);
            // 
            // btsair
            // 
            this.btsair.BackColor = System.Drawing.Color.HotPink;
            this.btsair.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources._1742852_200;
            this.btsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btsair.Location = new System.Drawing.Point(815, 420);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(74, 54);
            this.btsair.TabIndex = 26;
            this.btsair.UseVisualStyleBackColor = false;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // btprocurar
            // 
            this.btprocurar.BackColor = System.Drawing.Color.HotPink;
            this.btprocurar.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.search_icon_png_5;
            this.btprocurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btprocurar.Location = new System.Drawing.Point(616, 420);
            this.btprocurar.Name = "btprocurar";
            this.btprocurar.Size = new System.Drawing.Size(75, 54);
            this.btprocurar.TabIndex = 25;
            this.btprocurar.UseVisualStyleBackColor = false;
            this.btprocurar.Click += new System.EventHandler(this.btprocurar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.BackColor = System.Drawing.Color.HotPink;
            this.bteliminar.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.remove_icon_png_32;
            this.bteliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bteliminar.Location = new System.Drawing.Point(815, 336);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(75, 58);
            this.bteliminar.TabIndex = 23;
            this.bteliminar.UseVisualStyleBackColor = false;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // bteditar
            // 
            this.bteditar.BackColor = System.Drawing.Color.HotPink;
            this.bteditar.BackgroundImage = global::M7_ficheiros_progeto_final.Properties.Resources.edit_new_icon_22;
            this.bteditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bteditar.Location = new System.Drawing.Point(616, 336);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(75, 58);
            this.bteditar.TabIndex = 22;
            this.bteditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btmorango);
            this.panel4.Controls.Add(this.btbaunilha);
            this.panel4.Controls.Add(this.lbsabores);
            this.panel4.Controls.Add(this.btvoltar);
            this.panel4.Controls.Add(this.btchocolate);
            this.panel4.Location = new System.Drawing.Point(21, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 209);
            this.panel4.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(914, 504);
            this.Controls.Add(this.txtajudante);
            this.Controls.Add(this.txtprocurar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbsair);
            this.Controls.Add(this.lbprocurar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbeliminar);
            this.Controls.Add(this.lbeditar);
            this.Controls.Add(this.btordenar);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btprocurar);
            this.Controls.Add(this.btpagar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbcaramelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbextras;
        private System.Windows.Forms.CheckBox cbchocolate;
        private System.Windows.Forms.CheckBox cbmorango;
        private System.Windows.Forms.CheckBox cboreo;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbsabores;
        private System.Windows.Forms.Label lbquant;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btpagar;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btprocurar;
        private System.Windows.Forms.Button btsair;
        private System.Windows.Forms.Button btordenar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn extras;
        private System.Windows.Forms.DataGridViewTextBoxColumn extra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preço;
        private System.Windows.Forms.Label lbpreco;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Label lbeditar;
        private System.Windows.Forms.Label lbeliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbprocurar;
        private System.Windows.Forms.Label lbsair;
        private System.Windows.Forms.Button btvoltar;
        private System.Windows.Forms.TextBox txtprocurar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btmorango;
        private System.Windows.Forms.Button btchocolate;
        private System.Windows.Forms.Button btbaunilha;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.TextBox txtajudante;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
    }
}

