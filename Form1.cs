using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M7_ficheiros_progeto_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public struct info
        {
            public string nome;
            public int quantidade;
            public string sabor;
            public string extra1;
            public string extra2;            
            public double preco_gelado;           
        }
        List<info> lista = new List<info>();
        info gelados;
        string caminho = "ficheiro.txt";       
        double preco = 2;
        int indexsbcho;
        int indexsbbaunilha;
        int indexsbmorango;
        int indexc = 0;
        int indexcho = 0;
        int indexmor = 0;
        int indexoreo = 0;
        int indexbteditar = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists("ficheiro.txt") == false)
            {
                FileStream ficheiro = new FileStream("ficheiro.txt", FileMode.Create, FileAccess.Write);
                ficheiro.Close();
            }
            else
                mostrar_grelha();

        }
        

        private void btchocolate_Click_1(object sender, EventArgs e)
        {
            btbaunilha.Visible = false;
            btmorango.Visible = false;
            indexsbcho++;
            ativar();
            AtivarEnabled();
            btpagar.Visible = false;
           
        }

        private void btbaunilha_Click_1(object sender, EventArgs e)
        {
            btchocolate.Visible = false;
            btmorango.Visible = false;
            indexsbbaunilha++;
            ativar();
            AtivarEnabled();
            btpagar.Visible = false;
           
        }

        private void btmorango_Click_1(object sender, EventArgs e)
        {
            btbaunilha.Visible = false;
            btchocolate.Visible = false;
            indexsbmorango++;
            ativar();
            AtivarEnabled();
            btpagar.Visible = false;
            
        }
       
        private void validacoes()
        {
            //validaçoes checkbox
            if (cbcaramelo.Checked == true && cbchocolate.Checked == false && cbmorango.Checked == false && cboreo.Checked == false)
            {
                gelados.extra1 = cbcaramelo.Text;
                gelados.extra2 = "";
            }
            if (cbcaramelo.Checked == true && cbchocolate.Checked == true)
            {
                gelados.extra1 = cbcaramelo.Text;
                gelados.extra2 = cbchocolate.Text;
            }
            if (cbcaramelo.Checked == true && cbmorango.Checked == true)
            {
                gelados.extra1 = cbcaramelo.Text;
                gelados.extra2 = cbmorango.Text;
            }
            if (cbcaramelo.Checked == true && cboreo.Checked == true)
            {
                gelados.extra1 = cbcaramelo.Text;
                gelados.extra2 = cboreo.Text;
            }
            
            if (cbchocolate.Checked == true && cbcaramelo.Checked == false && cbmorango.Checked == false && cboreo.Checked == false)
            {
                gelados.extra1 = cbchocolate.Text;
                gelados.extra2 = "";
            }            
            if (cbchocolate.Checked == true && cbmorango.Checked == true)
            {
                gelados.extra1 = cbchocolate.Text;
                gelados.extra2 = cbmorango.Text;
            }
            if (cbchocolate.Checked == true && cboreo.Checked == true)
            {
                gelados.extra1 = cbchocolate.Text;
                gelados.extra2 = cboreo.Text;
            }
            if (cbmorango.Checked == true && cbchocolate.Checked == false && cbcaramelo.Checked == false && cboreo.Checked == false)
            {
                gelados.extra1 = cbmorango.Text;
                gelados.extra2 = "";
            }        
            if (cbmorango.Checked == true && cboreo.Checked == true)
            {
                gelados.extra1 = cbmorango.Text;
                gelados.extra2 = cboreo.Text;
            }
            if (cboreo.Checked == true && cbmorango.Checked == false && cbchocolate.Checked == false && cbcaramelo.Checked == false)
            {
                gelados.extra1 = cboreo.Text;
                gelados.extra2 = "";
            }
            if ((indexc + indexcho + indexmor + indexoreo) == 0)
            {
                gelados.extra1 = "";
                gelados.extra2 = "";
            }

        }
        private void inserir()
        {                       
            FileStream ficheiro = new FileStream(caminho, FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(ficheiro);
            bool validar_quant = int.TryParse(txtquant.Text, out gelados.quantidade);
            if (validar_quant == true && txtnome.Text != "")
            {
                validacoes();
                if (indexsbcho > 0)
                {
                    gelados.sabor = btchocolate.Text;
                }
                if (indexsbbaunilha > 0)
                {
                    gelados.sabor = btbaunilha.Text;
                }
                if (indexsbmorango > 0)
                {
                    gelados.sabor = btmorango.Text;
                }
                gelados.nome = txtnome.Text;
                gelados.quantidade = int.Parse(txtquant.Text);
                gelados.preco_gelado = preco;

                sw.WriteLine(gelados.nome);
                sw.WriteLine(gelados.sabor);
                sw.WriteLine(gelados.extra1);
                sw.WriteLine(gelados.extra2);
                sw.WriteLine(gelados.quantidade);
                sw.WriteLine(gelados.preco_gelado);

                sw.Close();
            }        
        }

        private void escrever_ficheiro_na_lista()
        {
            FileStream ficheiro = new FileStream(caminho, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(ficheiro);
            lista.Clear();
            while (sr.Peek() > -1)
            {
                gelados.nome = sr.ReadLine();
                gelados.sabor = sr.ReadLine();
                gelados.extra1 = sr.ReadLine();
                gelados.extra2 = sr.ReadLine();
                gelados.quantidade = int.Parse(sr.ReadLine());
                gelados.preco_gelado = double.Parse(sr.ReadLine());

                lista.Add(gelados);
            }
            sr.Close();
        }
        private void escrever_lista_no_ficheiro()
        {
            FileStream ficheiro = new FileStream(caminho, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(ficheiro);

            foreach (info g in lista)
            {
                sw.WriteLine(g.nome);
                sw.WriteLine(g.sabor);
                sw.WriteLine(g.extra1);
                sw.WriteLine(g.extra2);
                sw.WriteLine(g.quantidade);
                sw.WriteLine(g.preco_gelado);
            }
            sw.Close();
        }
        private void mostrar_grelha()
        {   
            dgv.Rows.Clear();
            escrever_ficheiro_na_lista();
            foreach (info icecream in lista)
            {
                dgv.Rows.Add(icecream.nome, icecream.sabor, icecream.extra1, icecream.extra2, icecream.quantidade, icecream.preco_gelado + "€");
            }     
        }
        private void cbcaramelo_CheckedChanged(object sender, EventArgs e)
        {
                checar(cbcaramelo);
                indexc++;
                             
        }
        private void cbchocolate_CheckedChanged(object sender, EventArgs e)
        {
                checar(cbchocolate);
                indexcho++;                      
        }
        private void cbmorango_CheckedChanged(object sender, EventArgs e)
        {           
                checar(cbmorango);
                indexmor++;           
        }
        private void cboreo_CheckedChanged(object sender, EventArgs e)
        {
                checar(cboreo);
                indexoreo++;                     
        }
        int index;
        private void checar(CheckBox cbox)
        {

            if (cbox.Checked == true)
            {
                index++;
            }
            else
                index--;
            //se o index for maior que 2, as checkbex que nao estiverem checadas vao ser desabilitadas
            //se pessoa desativer uma checkbox que checou anterioremente o index vai ser menos que dois, entao todas as checkbox serao abilitadas
            if (index >= 2)
            {
                foreach(var v in panel3.Controls.OfType<CheckBox>())
                {
                    if (v.Checked != true)
                    {
                        v.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (var v in panel3.Controls.OfType<CheckBox>())
                {
                    v.Enabled = true;
                }
            }
        }
        private void btpagar_Click(object sender, EventArgs e)
        {
            lista.Clear();           
            bool jaexiste = false;
            bool validar_quant = int.TryParse(txtquant.Text, out gelados.quantidade);
            if (validar_quant == true && txtnome.Text != "")
            {
                escrever_ficheiro_na_lista();
                foreach (info gl in lista)
                {
                    if (indexbteditar > 0)
                    {
                        jaexiste = true;
                        info gela = new info();
                        //validações
                        if (cbcaramelo.Checked == true && cbchocolate.Checked == false && cbmorango.Checked == false && cboreo.Checked == false)
                        {
                            gela.extra1 = cbcaramelo.Text;
                        }
                        if (cbcaramelo.Checked == true && cbchocolate.Checked == true)
                        {
                            gela.extra1 = cbcaramelo.Text;
                            gela.extra2 = cbchocolate.Text;
                        }
                        if (cbcaramelo.Checked == true && cbmorango.Checked == true)
                        {
                            gela.extra1 = cbcaramelo.Text;
                            gela.extra2 = cbmorango.Text;
                        }
                        if (cbcaramelo.Checked == true && cboreo.Checked == true)
                        {
                            gela.extra1 = cbcaramelo.Text;
                            gela.extra2 = cboreo.Text;
                        }
                        if (cbchocolate.Checked == true && cbcaramelo.Checked == false && cbmorango.Checked == false && cboreo.Checked == false)
                        {
                            gela.extra1 = cbchocolate.Text;
                            gela.extra2 = "";
                        }                        
                        if (cbchocolate.Checked == true && cbmorango.Checked == true)
                        {
                            gela.extra1 = cbchocolate.Text;
                            gela.extra2 = cbmorango.Text;
                        }
                        if (cbchocolate.Checked == true && cboreo.Checked == true)
                        {
                            gela.extra1 = cbchocolate.Text;
                            gela.extra2 = cboreo.Text;
                        }
                        if (cbmorango.Checked == true && cbchocolate.Checked == false && cbcaramelo.Checked == false && cboreo.Checked == false)
                        {
                            gela.extra1 = cbmorango.Text;
                            gela.extra2 = "";
                        }
                        if (cbmorango.Checked == true && cboreo.Checked == true)
                        {
                            gela.extra1 = cbmorango.Text;
                            gela.extra2 = cboreo.Text;
                        }
                        if (cboreo.Checked == true && cbmorango.Checked == false && cbchocolate.Checked == false && cbcaramelo.Checked == false)
                        {
                            gela.extra1 = cboreo.Text;
                            gela.extra2 = "";
                        }
                        if ((indexc + indexcho + indexmor + indexoreo) == 0)
                        {
                            gela.extra1 = "";
                            gela.extra2 = "";
                        }
                        gela.quantidade = int.Parse(txtquant.Text);
                        gela.preco_gelado = preco;
                        gela.nome = txtnome.Text;
                        if(indexsbcho > 0)
                        {
                            gela.sabor = btchocolate.Text;
                        }
                        if (indexsbbaunilha > 0)
                        {
                            gela.sabor = btbaunilha.Text;
                        }
                        if(indexsbmorango > 0)
                        {
                            gela.sabor = btmorango.Text;
                        }
                        if (dgv.Rows.Count > 0)
                        {
                            int linha = dgv.CurrentRow.Index;
                            lista[linha] = gela;
                            escrever_lista_no_ficheiro();
                            break;
                        }
                    }                                                      
                }
                if (jaexiste == false)
                {
                    inserir();
                }
                mostrar_grelha();
                limpar();
            }
            else
                MessageBox.Show("preencha todos os campos,introduza apenas numeros inteiros na area quantidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                      


            btbaunilha.Visible = true;
            btchocolate.Visible = true;
            btmorango.Visible = true;
            desativar();
            cbcaramelo.Enabled = true;
            cbchocolate.Enabled = true;
            cbmorango.Enabled = true;
            cboreo.Enabled = true;
            cbcaramelo.Checked = false;
            cbchocolate.Checked = false;
            cbmorango.Checked = false;
            cboreo.Checked = false;
            txtnome.Enabled = true;
            indexc = 0;
            indexcho = 0;
            indexmor = 0;
            indexoreo = 0;
            indexsbmorango = 0;
            indexsbcho = 0;
            indexsbbaunilha= 0;
            lbpreco.Text = "";
            indexbteditar = 0;
            btpagar.Visible = false;
            
        }
        

        private void btcalcular_Click(object sender, EventArgs e)
        {
                //caso o index da checkbox seja par a checkbox nao esta checada caso contrario está checada 
                // ex :
                // 1º click - index = 1 check
                // 2º click - index = 2 not check
                // 3º click - index = 3 check
                // 4º click - index = 4 not check
                bool validar_quant = int.TryParse(txtquant.Text, out gelados.quantidade);
                if (validar_quant == true && txtnome.Text != "")
                {
                    if (indexc % 2 == 0)
                    {
                        indexc = 0;
                    }
                    else
                        indexc = 1;
                    if (indexcho % 2 == 0)
                    {
                        indexcho = 0;
                    }
                    else
                        indexcho = 1;

                    if (indexmor % 2 == 0)
                    {
                        indexmor = 0;
                    }
                    else
                        indexmor = 1;

                    if (indexoreo % 2 == 0)
                    {
                        indexoreo = 0;
                    }
                    else
                        indexoreo = 1;


                    if ((indexc + indexcho + indexmor + indexoreo) == 1)
                    {
                        preco = 2.50;
                        preco = preco * gelados.quantidade;
                        lbpreco.Text = (preco + "€").ToString();
                    }
                    else if ((indexc + indexcho + indexmor + indexoreo) == 2)
                    {
                        preco = 3;
                        preco = preco * gelados.quantidade;
                        lbpreco.Text = (preco + "€").ToString();
                    }
                    else if ((indexc + indexcho + indexmor + indexoreo) == 0)
                    {
                        preco = 2;
                        preco = preco * gelados.quantidade;
                        lbpreco.Text = (preco + "€").ToString();
                    }
                }
                else
                    MessageBox.Show("preencha todos os campos,introduza apenas numeros inteiros na area quantidade", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                btpagar.Visible = true;               
        }
        private void bteditar_Click(object sender, EventArgs e)
        {
            //este botão vai inserir as coisas nas checkbox, selecionar as checkboxes e clicar nos botoes que estiverem na linha escolhida
            if (dgv.Rows.Count > 0)
            {
                int linha = dgv.CurrentRow.Index;
                txtnome.Text = dgv[0, linha].Value.ToString();
                txtquant.Text = dgv[4, linha].Value.ToString();
                txtajudante.Text = dgv[1, linha].Value.ToString();
                if(txtajudante.Text == btchocolate.Text)
                {
                    btchocolate_Click_1(null,null);
                }
                else if (txtajudante.Text == btbaunilha.Text)
                {
                    btbaunilha_Click_1(null,null);
                }
                else if (txtajudante.Text == btmorango.Text)
                {
                    btmorango_Click_1(null,null);
                }
                txtajudante.Text  = dgv[2, linha].Value.ToString();
                if(txtajudante.Text == cbchocolate.Text)
                {
                    cbchocolate.Checked = true;
                }
                else if (txtajudante.Text == cbcaramelo.Text)
                {
                    cbcaramelo.Checked = true;
                }
                else if (txtajudante.Text == cbmorango.Text)
                {
                    cbmorango.Checked = true;
                }
                else if (txtajudante.Text == cboreo.Text)
                {
                    cboreo.Checked = true;
                }
                txtajudante.Clear();
                txtajudante.Text = dgv[3, linha].Value.ToString();
                if (txtajudante.Text == cbchocolate.Text)
                {
                    cbchocolate.Checked = true;
                }
                else if (txtajudante.Text == cbcaramelo.Text)
                {
                    cbcaramelo.Checked = true;
                }
                else if (txtajudante.Text == cbmorango.Text)
                {
                    cbmorango.Checked = true;
                }
                else if (txtajudante.Text == cboreo.Text)
                {
                    cboreo.Checked = true;
                }

                txtajudante.Clear();
                            
            }
            else
                MessageBox.Show("sem elementos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            indexbteditar++;
            ativar();
        }

        private void bteliminar_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                if (MessageBox.Show("deseja mesmo eliminar?","aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int linha = dgv.CurrentRow.Index;
                    escrever_ficheiro_na_lista();
                    lista.RemoveAt(linha);
                    escrever_lista_no_ficheiro();
                    mostrar_grelha();
                    dgv.ClearSelection();
                    desativar();
                    foreach (var v in panel4.Controls.OfType<Button>()) { v.Visible = true; }
                    limpar();
                    indexbteditar = 0;
                }               
            }
            else
                MessageBox.Show("sem elementos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void limpar()
        {
            txtnome.Clear();
            txtquant.Clear();
            cbchocolate.Checked = false;
            cbcaramelo.Checked = false;
            cbmorango.Checked = false;
            cboreo.Checked = false;
        }

        private void btordenar_Click(object sender, EventArgs e)
        {
            if (File.Exists(caminho))
            {
                escrever_ficheiro_na_lista();
                lista.Sort((x, y) => x.preco_gelado.CompareTo(y.preco_gelado));
                escrever_lista_no_ficheiro();
                mostrar_grelha();
                desativar();
                foreach (var v in panel4.Controls.OfType<Button>()) { v.Visible = true; }
                indexbteditar = 0;
                limpar();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btchocolate.Visible = true;
            btmorango.Visible = true;
            btbaunilha.Visible = true;
            indexsbbaunilha = 0;
            indexsbcho = 0;
            indexsbmorango = 0;
            desativar();
        }

        private void ativar()
        {
            foreach (var v in panel3.Controls.OfType<Label>()) { v.Visible = true; }
            foreach (var v in panel3.Controls.OfType<CheckBox>()) { v.Visible = true; }
            foreach (var v in panel3.Controls.OfType<TextBox>()) { v.Visible = true; }
            foreach (var v in panel3.Controls.OfType<Button>()) { v.Visible = true; }
        }
        private void desativar()
        {
            foreach (var v in panel3.Controls.OfType<Label>()) { v.Visible = false; }
            foreach (var v in panel3.Controls.OfType<CheckBox>()) { v.Visible = false; }
            foreach (var v in panel3.Controls.OfType<TextBox>()) { v.Visible = false; }
            foreach (var v in panel3.Controls.OfType<Button>()) { v.Visible = false; }
        }
        private void DesativarEnabled()
        {
            foreach (var v in panel3.Controls.OfType<Label>()) { v.Enabled = false; }
            foreach (var v in panel3.Controls.OfType<CheckBox>()) { v.Enabled = false; }
            foreach (var v in panel3.Controls.OfType<TextBox>()) { v.Enabled = false; }
            foreach (var v in panel3.Controls.OfType<Button>()) { v.Enabled = false; }
        }
        private void AtivarEnabled()
        {
            foreach (var v in panel3.Controls.OfType<Label>()) { v.Enabled = true; }
            foreach (var v in panel3.Controls.OfType<CheckBox>()) { v.Enabled = true; }
            foreach (var v in panel3.Controls.OfType<TextBox>()) { v.Enabled = true; }
            foreach (var v in panel3.Controls.OfType<Button>()) { v.Enabled = true; }
        }

        private void btprocurar_Click(object sender, EventArgs e)
        {
            string pesquisar = txtprocurar.Text.ToLower();
            dgv.ClearSelection();
            // vai precorrer a datagredview e ver se existe o nome da pessoa la dentro e selecionar o index.
            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[0].Value.ToString().ToLower().Equals(pesquisar))
                        {

                            row.Selected = true;
                            break;
                        }

                    }
                }
            }
            else
                MessageBox.Show("sem elementos", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btsair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("quer mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
