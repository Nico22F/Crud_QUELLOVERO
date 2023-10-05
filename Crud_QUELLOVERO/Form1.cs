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
using System.IO; // serve per usare streamread e streamwriter
using System.Diagnostics;

namespace Crud_QUELLOVERO
{
    public partial class titolo_ordinamento : Form
    {
        // structure

        public struct prodotto
        {
            public string nome;
            public float prezzo;
        }
        public prodotto[] p = new prodotto[100];
        public int dim;
        public titolo_ordinamento()
        {
            // non mostro alcune label / oggetti
            InitializeComponent();
            dim = 0;
            lista.Visible = false;
            titolo.Visible = false;
            ConfermaModifica.Visible = false;
            ordine.Visible = false;
            titolo_totale.Visible = false;
            prodotto_costoso.Visible = false;
            prodotto_menocostoso.Visible = false;
        }

        // variabili booleane per modificare / eliminare i prodotti

        public bool conferma_modifica = false;
        public bool conferma_elimina = false;
        public string prezzo_tot; // variabile per il prezzo totale 
        public int piucostoso, menocostoso;
        public string[] ordinamento;
        public bool ordinamento_alfabetico = false;

        // funzione per aggiungere i prodotti 

        // mostra prodotti

        public void visualizza(prodotto[] p)
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

        // funzione che fa la somma del prezzo

        public void Somma(ref string somma)
        {
            float sommaa = 0;

            for (int i = 0; i < dim; i++)
            {
                sommaa += p[i].prezzo;
            }
            somma = sommaa.ToString();
        }

        // funzione che trova il prodotto più costoso e meno costoso

        public void PiueMenoCostoso(ref int pcostoso, ref int pmenocostoso) // trova la posizione nello struct
        {
            float x = -999; // variabile per il più costoso
            float y = 999999999; // variabile per il meno costoso
            for (int i = 0; i < dim; i++)
            {
                // più costoso

                if (p[i].prezzo > x)
                {
                    x = p[i].prezzo;
                    pcostoso = i;
                }

                // meno costoso

                if (p[i].prezzo < y)
                {
                    y = p[i].prezzo;
                    pmenocostoso = i;
                }
            }
        }

        // funzione che ordina la lista (non struct) in ordine alfabetico

        public void Alfabetico(ref string[] prodotti)
        {
            prodotti = new string[dim];

            // array con nomi e prezzi (es: matita:5)

            for (int i = 0; i < dim; i++)
            {
                prodotti[i] = (lista.Items[i].ToString()).ToLower(); // metto tutto in minuscolo

            }

            // ordine alfabetico tramite ascii (97<=x=>122)


            string temp; // variabile temporanea
            bool scambi = false;
            do
            {
                scambi = false;

                for (int i = 0, j = 1; j <= prodotti.Length - 1; i++,j++)
                {
                    // x = i e y = j
                    string x = prodotti[i],y = prodotti[j]; // variabili che contengono le stringhe

                    // split nome (da matita:5 --> matita :5)

                    string[]x_array = Split(x);
                    string[]y_array = Split(y);

                    // scompongo tutta la parola in ascii
                    int parolax = 0;
                    for (int a = 0; a < x_array[0].Length; a++)
                    {
                        parolax += (int)(x_array[0])[a];
                    }

                    // scompongo tutta la parola in ascii
                    int parolay = 0;
                    for (int a = 0; a < y_array[0].Length; a++)
                    {
                        parolay += (int)(y_array[0])[a];
                    }

                    if (parolax > parolay) // se è minore vuol dire che è prima della seconda viceversa se è maggiore
                    {
                        temp = prodotti[i];
                        prodotti[i] = prodotti[j];
                        prodotti[j] = temp;
                        scambi = true;
                    }
                    
                }
            }
            while (scambi == true) ;

        }

        // bottone che aggiunge un prodotto alla lista
        private void create_Click(object sender, EventArgs e)
        {
            // input box nome e do while per input corretto
            bool uscita = false;
            bool errore = false; // nel caso l'utente esca quando inserisce il nome oppure lascia il campo vuoto, non verrà chiesto il prezzo

            string titolo_input = "Aggiungi Prodotto - NOME", esempio = "nome prodotto", frase = "Inserisci il nome del prodotto che vuoi aggiungere";
            object input_aggiungiprodotto = Interaction.InputBox(frase, titolo_input, esempio);

            if ((string)input_aggiungiprodotto == "") // user esce o lascia il campo vuoto
            {
                MessageBox.Show("Errore nell'aggiunta del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errore = true;
            }
            else
            {
                p[dim].nome = (string)input_aggiungiprodotto;
            }

            // input box prezzo

            // do-while per il prezzo

           if (errore == false)
           {
                do
                {
                    uscita = false;
                    titolo_input = "Aggiungi Prodotto - Prezzo"; esempio = "prezzo prodotto"; frase = "Inserisci il prezzo del prodotto che vuoi aggiungere";
                    input_aggiungiprodotto = Interaction.InputBox(frase, titolo_input, esempio);


                    if ((string)input_aggiungiprodotto == "" || (int)input_aggiungiprodotto >= 65 || (int)input_aggiungiprodotto <= 122) // user esce o lascia il campo vuoto
                    {
                        MessageBox.Show("Errore nell'aggiunta del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        p[dim].nome = null;
                        
                    }
                    else
                    {
                        p[dim].prezzo = (float)input_aggiungiprodotto;
                        dim++;
                        uscita = true;
                    }

                }
                while (uscita == false);
           }
           else
           {
                errore = false;
           }

            // controllo input prezzo

            // mostro la lista e i vari titoli

            lista.Visible = true;
            prelista.Visible = false;
            titolo.Visible = true;
            ordine.Visible = true;
            titolo_totale.Visible = true;
            // aggiorno il prezzo totale
            Somma(ref prezzo_tot);
            titolo_totale.Text = $"Totale prezzo: {prezzo_tot}€";
            // aggiorno il prodotto più costoso e meno costoso
            PiueMenoCostoso(ref piucostoso, ref menocostoso);
            prodotto_costoso.Text = $"Prodotto più costoso: {p[piucostoso].nome} ({p[piucostoso].prezzo}€)";
            prodotto_menocostoso.Text = $"Prodotto meno costoso: {p[menocostoso].nome} ({p[menocostoso].prezzo}€)";
            prodotto_costoso.Visible = true;
            prodotto_menocostoso.Visible = true;
            // conferma aggiunta prodotto
            MessageBox.Show("Prodotto Aggiunto!");

        }

        // bottone che modifica un prodotto
        private void modifica_Click(object sender, EventArgs e)
        {
            // mostra lista prodotti

            lista.Visible = true;
            conferma_modifica = true;
            conferma_elimina = false; // può essere attivata una sola funzione
            MessageBox.Show("Procedi con la modifica del prodotto da lei selezionato (per continuare clicca il nome del prodotto che vuoi modificare nella lista prodotti)");

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
            // controllo che se clicco una zona vuota della lista, non dia errore

            // modifica prodotto

            if (conferma_modifica == true)
            {
                int scelta = lista.SelectedIndex;
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

                        // aggiorno il prezzo totale
                        Somma(ref prezzo_tot);
                        titolo_totale.Text = $"Totale prezzo: {prezzo_tot}€";


                        // aggiorno il prodotto più costoso e meno costoso
                        PiueMenoCostoso(ref piucostoso, ref menocostoso);
                        prodotto_costoso.Text = $"Prodotto più costoso: {p[piucostoso].nome} ({p[piucostoso].prezzo}€)";
                        prodotto_menocostoso.Text = $"Prodotto meno costoso: {p[menocostoso].nome} ({p[menocostoso].prezzo}€)";
                        prodotto_costoso.Visible = true;
                        prodotto_menocostoso.Visible = true;

                        // se non ci sono più prodotti, tolgo la lista e i vari label e mostro il label "non ci sono prodotti"

                        if (lista.Items.Count == 0)
                        {
                            lista.Visible = false;
                            titolo.Visible = false;
                            ordine.Visible = false;
                            prodotto_costoso.Visible = false;
                            prodotto_menocostoso.Visible = false;
                            titolo_totale.Visible = false;
                            prelista.Visible = true;
                        }

                        // prodotto eliminato (msgbox)

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
            // aggiorno il prezzo totale
            Somma(ref prezzo_tot);
            titolo_totale.Text = $"Totale prezzo: {prezzo_tot}€";
            // aggiorno il prodotto più costoso e meno costoso
            PiueMenoCostoso(ref piucostoso, ref menocostoso);
            prodotto_costoso.Text = $"Prodotto più costoso: {p[piucostoso].nome} ({p[piucostoso].prezzo}€)";
            prodotto_menocostoso.Text = $"Prodotto meno costoso: {p[menocostoso].nome} ({p[menocostoso].prezzo}€)";
            prodotto_costoso.Visible = true;
            prodotto_menocostoso.Visible = true;
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

        // bottone per ordinare 
        private void ordina_Click(object sender, EventArgs e)
        {
           
            // se non è già ordinato
            if (ordinamento_alfabetico == false)
            {
                Alfabetico(ref ordinamento);
                lista.Items.Clear();
                for (int i = 0; i < ordinamento.Length; i++)
                {
                    lista.Items.Add(ordinamento[i]);
                }
                ordine.Text = "Ordine alfabetico: SI";
                ordinamento_alfabetico = true;
            }
            else // se è già ordinato
            {
                lista.Items.Clear();
                ordine.Text = "Ordine alfabetico: NO";
                visualizza(p);
                ordinamento_alfabetico = false;
            }
        }
    }
}
