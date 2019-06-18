﻿using System;
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
            string[] linha = File.ReadAllLines(@"C:\t\teste.txt");
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

          
                File.WriteAllLines(@"C:\t\teste.txt", (String[])listBox1.Items.Cast<string>().ToArray());
          
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Tag = this;
            //form2.Show(this);
            //Hide();
            var list = listBox1.Items;
           

            if(list.Count < 1)
            {

                File.Delete(@"C:\t\teste.txt");
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
                File.WriteAllLines(@"C:\t\teste.txt", (String[])listBox1.Items.Cast<string>().ToArray());
            }
        }

        public StreamWriter CriaArquivo(ListBox.ObjectCollection Lista)
        {
         

            StreamWriter arquivo = new StreamWriter(@"C:\t\teste.txt");
            Console.WriteLine("Numero De Participantes:\n");
           
            foreach (var item in Lista)
            {
                arquivo.WriteLine(item);

            }

            arquivo.Close();

            return arquivo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultado.Hide();
            string path = @"C:\t";
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("That path exists already.");
                    if (!File.Exists(@"C:\t\teste.txt"))
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
                else
                {

                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                    // Delete the directory.
                    di.Delete();
                    Console.WriteLine("The directory was deleted successfully.");
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


        public static string Sorteio(ListBox.ObjectCollection Lista)
        {


            Random rnd = new Random();
            int num = rnd.Next(Lista.Count);
            return Lista[num].ToString();


        }
        private static void ApagaLista(ListBox.ObjectCollection Lista)
        {
            String[] myArr = (String[])Lista.Cast<string>().ToArray();


            File.WriteAllLines(@"C:\t\teste.txt", myArr);
        }
    }
   
}