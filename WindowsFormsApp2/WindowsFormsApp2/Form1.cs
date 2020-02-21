using EnumsNET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        List<string> lista = new List<string>();
        StreamWriter arquivo;

        public Form1()
        {
            InitializeComponent();

        }

        private void Carregalista()
        {
            string[] linha = File.ReadAllLines($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}");
            for (int i = 0; i < linha.Length; i++)
            {
                lista.Add(linha[i]);
            }

            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            foreach (var item in lista)
            {

                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item.ToString());

                }
                else
                {

                }
            }




            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();

        }


        private void Cadastra_Click(object sender, EventArgs e)
        {

            lista.Add(Nome.Text);

            Nome.Text = "";
            listBox1.BeginUpdate();
            // Loop through and add 50 items to the ListBox.
            foreach (var item in lista)
            {

                if (!listBox1.Items.Contains(item))
                {
                    listBox1.Items.Add(item.ToString());

                }
                else
                {

                }
            }




            // Allow the ListBox to repaint and display the new items.
            listBox1.EndUpdate();


            File.WriteAllLines($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}", (String[])listBox1.Items.Cast<string>().ToArray());




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Tag = this;
            //form2.Show(this);
            //Hide();
            var list = listBox1.Items;


            if (list.Count < 1)
            {
                var lis = lista.Count;
                lista.RemoveRange(0, lis);
                resultado.Hide();
                File.Delete($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}");
                CriaArquivo(list);

                MessageBox.Show("Cadastre Nomes para Sortear", "Lista Vazia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sort = Sorteio(list);

                listBox1.BeginUpdate();

                resultado.Text = @"Ganhador: " + sort;


                resultado.Show();
                list.Remove(sort);

                listBox1.EndUpdate();
                File.WriteAllLines($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}", (String[])listBox1.Items.Cast<string>().ToArray());
            }
        }

        public StreamWriter CriaArquivo(ListBox.ObjectCollection Lista)
        {


            StreamWriter arquivo = new StreamWriter($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}");
            Console.WriteLine("Numero De Participantes:\n");

            foreach (var item in Lista)
            {
                arquivo.WriteLine(item);

            }

            arquivo.Close();

            return arquivo;
        }
        //public StreamWriter CriaArquivoConfig()
        //{


        //    StreamWriter arquivo = new StreamWriter(@"C:\Sorteio\config.con");
        //    arquivo.Close();
        //    return arquivo;
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

            resultado.Hide();
            string path = Diretorio.Pasta;
            SorteioList.Items.Add(Sorteios.Sorteio1);
            SorteioList.Items.Add(Sorteios.Sorteio2);
            SorteioList.SelectedItem = SorteioList.Items[0];
            // Determine whether the directory exists.
            if (Directory.Exists(path))
            {
                Console.WriteLine("That path exists already.");
                VerificaArquivo();
            }
            else
            {

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                VerificaArquivo();

                // Delete the directory.

            }







        }

        private void VerificaArquivo()
        {
            resultado.Hide();

            switch (SorteioList.SelectedIndex)
            {
                case 0:
                    Diretorio.ArquivoSelecionado = Diretorio.Arquivos.First();
                    break;
                case 1:
                    Diretorio.ArquivoSelecionado = Diretorio.Arquivos.Last();
                    break;
            }


            if (!File.Exists($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}"))
            {
                arquivo = CriaArquivo(listBox1.Items);
                Carregalista();

            }
            else
            {
                Carregalista();

            }
            if (Nome.Text == null || Nome.Text == "")
            {
                Cadastra.Enabled = false;
            }


        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            if (Nome.Text == null || Nome.Text == "")
            {
                Cadastra.Enabled = false;
            }
            else
            {
                Cadastra.Enabled = true;
            }
        }


        public string Sorteio(ListBox.ObjectCollection Lista)
        {


            Random rnd = new Random();
            int num = rnd.Next(Lista.Count);
            return Lista[num].ToString();


        }
        private void ApagaLista(ListBox.ObjectCollection Lista)
        {
            String[] myArr = (String[])Lista.Cast<string>().ToArray();


            File.WriteAllLines($@"{Diretorio.Pasta}\{Diretorio.ArquivoSelecionado}", myArr);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            listBox1.Items.Clear();
            listBox1.EndUpdate();
            lista.Clear();
            VerificaArquivo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    enum Sorteios
    {
        [Description("Sorteio 1")]
        Sorteio1 = 0,
        [Description("Sorteio 2")]
        Sorteio2 = 1
    }
    public class Diretorio
    {
        public static List<string> Arquivos = new List<string> { "Sorteio1.txt", "Sorteio2.txt" };
        public static string ArquivoSelecionado = Arquivos.First();
        public static string Pasta = @"C:\Sorteio";
    }
}
