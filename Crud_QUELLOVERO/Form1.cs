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
using System.Reflection;
using System.Runtime.Remoting.Messaging;

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
            text_nome.Visible = false;
            text_prezzo.Visible = false;
            titolo_prezzo.Visible = false;
            titolo_prodotto.Visible = false;
            titolo_dellaModifica.Visible = false;
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

        public void OrdinaAlfabeticamente(ref string[] array)
        {
            // inserisco nell'array gli items della lista

            array = new string[dim];
            bool scambiato;

            for (int i = 0; i < dim; i++)
            {
                array[i] = lista.Items[i].ToString();
            }

            do
            {
                scambiato = false;

                for (int i = 1; i < array.Length; i++)
                {
                    if (string.Compare(array[i - 1], array[i], StringComparison.Ordinal) > 0)
                    {
                        // Scambia le stringhe
                        string temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        scambiato = true;
                    }
                }
            }
            while (scambiato);
        }

        // bottone che aggiunge un prodotto alla lista
        private void create_Click(object sender, EventArgs e)
        {
            //nel caso venga cliccato questo tasto, dopo che le altre "funzionalità" sono state selezionate, esse non funzioneranno

            conferma_elimina = false;
            conferma_modifica = false;

            // input box nome e do while per input corretto
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
                titolo_input = "Aggiungi Prodotto - Prezzo"; esempio = "prezzo prodotto"; frase = "Inserisci il prezzo del prodotto che vuoi aggiungere";
                input_aggiungiprodotto = Interaction.InputBox(frase, titolo_input, esempio);
                float prova_numero = 0; // se la conversione risultasse corretta (questa sotto) la stringa convertita in float finirebbe qua

                // tryparse serve per vedere se la conversione funziona
                if (!float.TryParse((string)input_aggiungiprodotto, out prova_numero))
                {
                    MessageBox.Show("Errore nell'aggiunta del prodotto", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    p[dim].nome = null;
                    errore = true;
                }
                else
                {
                    p[dim].prezzo = prova_numero;
                    dim++;
                }

                if (errore== false)
                {
                    visualizza(p);
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
                else
                {
                    errore = false;
                }
                
           }
           else
           {
                errore = false;
           }

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
        static string[] Split(string stringa, char separatore)
        {
            string[] array = new string[2];
            string frase = "";
            int p = 0;
            for (int i = 0; i < stringa.Length; i++)
            {
                if (stringa[i] == separatore)
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
               if (lista.SelectedIndex < 0) // clicca qualche zona della lista dove non c'è un item
               {
                    MessageBox.Show("Errore nella modifica del prodotto. Clicca un prodotto nella lista", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               }
                else
               {
                    int scelta = lista.SelectedIndex;
                    text_nome.Visible = true;
                    text_prezzo.Visible = true;
                    titolo_prezzo.Visible = true;
                    titolo_prodotto.Visible = true;
                    titolo_dellaModifica.Visible = true;
                    string oggettomodifca = lista.Items[scelta].ToString();
                    char separatore = ':';
                    string[] modificona = Split(oggettomodifca, separatore);
                    text_nome.Text = modificona[0];
                    text_prezzo.Text = modificona[1];
                    ConfermaModifica.Visible = true;
                    nomignolo = text_nome.Text;
                    prezzolo = float.Parse(text_prezzo.Text);
               }
                
            }
            // elimina prodotto
            if (conferma_elimina == true)
            {
                if (lista.SelectedIndex < 0) // in caso l'utente clicchi una zona senza item della lista (controllo)
                {
                    MessageBox.Show("Errore nell'eliminazione del prodotto. Clicca un prodotto nella lista", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
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
                            char separatore = ':';
                            string[] modificona = Split(oggettoDAELIMINARE,separatore);

                            for (int i = 0; i < dim; i++)
                            {
                                if (modificona[0] == p[i].nome)
                                {
                                    for (int j = i, a = j + 1; j < dim; j++, a++)
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
            ConfermaModifica.Visible = false;
            text_nome.Visible = false;
            text_prezzo.Visible = false;
            titolo_prezzo.Visible = false;
            titolo_prodotto.Visible = false;
            titolo_dellaModifica.Visible = false;
            MessageBox.Show("Prodotto Aggiornato!");
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            // se modifica è attivo, allora rendo invisibili gli oggetti

            ConfermaModifica.Visible = false;
            text_nome.Visible = false;
            text_prezzo.Visible = false;
            titolo_prezzo.Visible = false;
            titolo_prodotto.Visible = false;
            titolo_dellaModifica.Visible = false;

            // mostro quello che mi serve

            lista.Visible = true;
            conferma_elimina = true;
            conferma_modifica = false;
            MessageBox.Show("Procedi con l'eliminazione del prodotto! (per continuare clicca il nome del prodotto che vuoi eliminare nella lista prodotti)");
        }

        private void salva_file_Click(object sender, EventArgs e)
        {
            if(dim == 0) // lista vuota
            {
                MessageBox.Show("Errore durante il salvataggio su file della lista. Per poter salvare la lista su file, bisogna avere almeno un prodotto nella lista", "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                // scrittura file

                StreamWriter scrivi = new StreamWriter("lista.csv");
                scrivi.WriteLine("NOME;PREZZO");

                // scrivo tutti i prezzi e nomi

                for(int i = 0; i < dim;i++)
                {
                    scrivi.WriteLine($"{p[i].nome};{p[i].prezzo}");
                }

                scrivi.Close(); // finito di copiare su file csv
                // serve per trovare il percorso del file
                string percorsoFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "lista.csv");

                MessageBox.Show($"File csv creato! Il file si trova in: {percorsoFile}");
            }
        }

        private void lettura_file_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Presta attenzione, per piacere, il file da importare deve essere scritto nel seguente modo:\n\nNomeProdotto;PrezzoProdotto\nNomeProdotto2;PrezzoProdotto2", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            OpenFileDialog file_lettura = new OpenFileDialog(); // inizializza importazione
            DialogResult result = file_lettura.ShowDialog(); // apre i fili (nel pc)
            string file = file_lettura.FileName; // percorso del file

            // inserimento dati nella struct
            StreamReader sr = new StreamReader(file); // inizializzo la lettura del file

            dim = 0;
            string[] array_temporaneo = new string[2];
            string riga;
            riga = sr.ReadLine();

            while (riga != null)
            {
                // aggiungo i prodotti alla lista e allo struct
                char separatore = ';';
                array_temporaneo = Split(riga, separatore);
                p[dim].nome = array_temporaneo[0];
                p[dim].prezzo = float.Parse(array_temporaneo[1]);
                dim++;
                riga = sr.ReadLine();
            }

            sr.Close();

            // tutti gli aggiornamenti

            visualizza(p);
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
            MessageBox.Show("Lista importata con successo!");

        }

        // bottone per ordinare 
        private void ordina_Click(object sender, EventArgs e)
        {
           
            // se non è già ordinato
            if (ordinamento_alfabetico == false)
            {
                OrdinaAlfabeticamente(ref ordinamento);
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
