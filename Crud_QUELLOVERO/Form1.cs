using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Crud_QUELLOVERO
{
    public partial class Form1 : Form
    {
        // structure

        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p = new prodotto[100];
        public int dim;
        public Form1()
        {
            InitializeComponent();
            dim = 0;
            lista.Visible = false;
            titolo.Visible = false;
            ConfermaModifica.Visible = false;
        }

        // variabili booleane per modificare / eliminare i prodotti

        public bool conferma_modifica = false;
        public bool conferma_elimina = false;

        // funzione per aggiungere i prodotti 

        // mostra prodotti

        public void visualizza(prodotto[] pp)
        {
            lista.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                lista.Items.Add(prodString(p[i]));
            }
        }

        // funzione che scrive la stringa
        public string prodString(prodotto p)
        {
            return $"{p.nome}:{p.prezzo}";
        }

        // bottone che aggiunge un prodotto alla lista
        private void create_Click(object sender, EventArgs e)
        {
            // mostrare anche le text box solo se cliccato
            // controllo input corretto


            p[dim].nome = text_nome.Text;
            p[dim].prezzo = float.Parse(text_prezzo.Text);
            dim++;
            visualizza(p);
            text_nome.Text = "";
            text_prezzo.Text = "";
            MessageBox.Show("Prodotto Aggiunto!");

        }
        // bottone che mostra gli elementi della lista (mostra direttamente la lista)
        private void mostra_Click(object sender, EventArgs e)
        {
            if (lista.Visible == false)
            {
                lista.Visible = true;
                titolo.Visible = true;
            }
            else
            {
                lista.Visible = false;
                titolo.Visible = false;
            }
        }

        // bottone che modifica un prodotto
        private void modifica_Click(object sender, EventArgs e)
        {
            // mostra lista prodotti

            lista.Visible = true;
            conferma_modifica = true;
            conferma_elimina = false; // può essere attivata una sola funzione
        }

        // split
        static string[] Split(string stringa)
        {
            string[] array = new string[2];
            string frase = "";
            int p = 0;
            for (int i = 0; i < stringa.Length; i++)
            {
                if (stringa[i] == ':')
                {
                    array[p] = frase; p++; frase = "";
                }
                else
                {
                    frase += stringa[i];
                }
                if (i == stringa.Length - 1)
                {
                    array[p] = frase;
                }
            }
            return array;
        }

        string nomignolo;
        float prezzolo;

        // modificare / eliminare un prodotto
        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            // modifica prodotto

            if (conferma_modifica == true)
            {
                int scelta = lista.SelectedIndex;
                MessageBox.Show("Procedi con la modifica del prodotto da lei selezionato (per continuare clicca il nome del prodotto che vuoi modificare nella lista prodotti)");
                string oggettomodifca = lista.Items[scelta].ToString();
                string[] modificona = Split(oggettomodifca);
                text_nome.Text = modificona[0];
                text_prezzo.Text = modificona[1];
                ConfermaModifica.Visible = true;
                nomignolo = text_nome.Text;
                prezzolo = float.Parse(text_prezzo.Text);
            }
            // elimina prodotto
            if (conferma_elimina == true)
            {
                // messagebox con input per confermare la scelta
                int scelta = lista.SelectedIndex;
                string oggettoDAELIMINARE = lista.Items[scelta].ToString();
                // messaggio                                                        // titolo
                DialogResult inputbox = MessageBox.Show($"Vuoi eliminare il prodotto selezionato? ({oggettoDAELIMINARE})", "ELIMINAZIONE PRODOTTI", MessageBoxButtons.YesNo);
                switch (inputbox)
                {
                    // se l'utente ha cliccato di si
                    case DialogResult.Yes:
                        // eliminazione prodotto dalla struct
                        lista.Items.Clear();
                        string[] modificona = Split(oggettoDAELIMINARE);

                        for (int i = 0; i < dim; i++)
                        {
                            if (modificona[0] == p[i].nome)
                            {
                                for (int j = i, a =j+1; j < dim; j++, a++)
                                {
                                    p[j].nome = p[a].nome;
                                    p[j].prezzo = p[a].prezzo;
                                   
                                }
                                dim--;
                                break;
                            }
                        }

                        // elimino lo spazio aggiuntivo con resize

                        Array.Resize(ref p, p.Length - 1);

                        // riaggiorno la lista

                        visualizza(p);

                        MessageBox.Show("Prodotto eliminato con succcesso");

                        break;
                    // se l'utente ha cliccato no
                    case DialogResult.No:
                        break;
                }
            }
        }

        private void ConfermaModifica_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dim; i++)
            {
                if (p[i].nome == nomignolo)
                {
                    p[i].prezzo = float.Parse(text_prezzo.Text);
                    p[i].nome = text_nome.Text;
                    break;
                }
            }
            visualizza(p);
            text_nome.Text = "";
            text_prezzo.Text = "";
            MessageBox.Show("Prodotto Aggiornato!");
            ConfermaModifica.Visible = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            lista.Visible = true;
            conferma_elimina = true;
            conferma_modifica = false;
            MessageBox.Show("Procedi con l'eliminazione del prodotto! (per continuare clicca il nome del prodotto che vuoi eliminare nella lista prodotti)");
        }
    }
}
