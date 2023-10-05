namespace Crud_QUELLOVERO
{
    partial class titolo_ordinamento
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.titolo_prodotto = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.titolo_prezzo = new System.Windows.Forms.Label();
            this.text_prezzo = new System.Windows.Forms.TextBox();
            this.create = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.titolo = new System.Windows.Forms.Label();
            this.ConfermaModifica = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.ordina = new System.Windows.Forms.Button();
            this.ordine = new System.Windows.Forms.Label();
            this.titolo_totale = new System.Windows.Forms.Label();
            this.prelista = new System.Windows.Forms.Label();
            this.prodotto_costoso = new System.Windows.Forms.Label();
            this.prodotto_menocostoso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titolo_prodotto
            // 
            this.titolo_prodotto.AutoSize = true;
            this.titolo_prodotto.Location = new System.Drawing.Point(16, 11);
            this.titolo_prodotto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titolo_prodotto.Name = "titolo_prodotto";
            this.titolo_prodotto.Size = new System.Drawing.Size(156, 16);
            this.titolo_prodotto.TabIndex = 0;
            this.titolo_prodotto.Text = "NOME DEL PRODOTTO";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(20, 31);
            this.text_nome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(212, 22);
            this.text_nome.TabIndex = 1;
            // 
            // titolo_prezzo
            // 
            this.titolo_prezzo.AutoSize = true;
            this.titolo_prezzo.Location = new System.Drawing.Point(16, 70);
            this.titolo_prezzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titolo_prezzo.Name = "titolo_prezzo";
            this.titolo_prezzo.Size = new System.Drawing.Size(170, 16);
            this.titolo_prezzo.TabIndex = 2;
            this.titolo_prezzo.Text = "PREZZO DEL PRODOTTO";
            // 
            // text_prezzo
            // 
            this.text_prezzo.Location = new System.Drawing.Point(20, 90);
            this.text_prezzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_prezzo.Name = "text_prezzo";
            this.text_prezzo.Size = new System.Drawing.Size(212, 22);
            this.text_prezzo.TabIndex = 3;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(20, 195);
            this.create.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(213, 32);
            this.create.TabIndex = 4;
            this.create.Text = "Aggiungi un prodotto alla lista";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 16;
            this.lista.Location = new System.Drawing.Point(813, 38);
            this.lista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(236, 404);
            this.lista.TabIndex = 5;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // titolo
            // 
            this.titolo.AutoSize = true;
            this.titolo.Location = new System.Drawing.Point(809, 11);
            this.titolo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(53, 16);
            this.titolo.TabIndex = 6;
            this.titolo.Text = "Prodotti";
            // 
            // ConfermaModifica
            // 
            this.ConfermaModifica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConfermaModifica.Location = new System.Drawing.Point(241, 53);
            this.ConfermaModifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfermaModifica.Name = "ConfermaModifica";
            this.ConfermaModifica.Size = new System.Drawing.Size(189, 49);
            this.ConfermaModifica.TabIndex = 7;
            this.ConfermaModifica.Text = "Conferma modifica";
            this.ConfermaModifica.UseVisualStyleBackColor = true;
            this.ConfermaModifica.Click += new System.EventHandler(this.ConfermaModifica_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(20, 235);
            this.modifica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(213, 25);
            this.modifica.TabIndex = 9;
            this.modifica.Text = "Modifica un prodotto nella lista";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(20, 267);
            this.delete_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(212, 26);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Elimina un prodotto dalla lista";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // ordina
            // 
            this.ordina.Location = new System.Drawing.Point(20, 300);
            this.ordina.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ordina.Name = "ordina";
            this.ordina.Size = new System.Drawing.Size(213, 25);
            this.ordina.TabIndex = 11;
            this.ordina.Text = " Ordina in modo alfabetico";
            this.ordina.UseVisualStyleBackColor = true;
            this.ordina.Click += new System.EventHandler(this.ordina_Click);
            // 
            // ordine
            // 
            this.ordine.AutoSize = true;
            this.ordine.Location = new System.Drawing.Point(908, 11);
            this.ordine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ordine.Name = "ordine";
            this.ordine.Size = new System.Drawing.Size(133, 16);
            this.ordine.TabIndex = 12;
            this.ordine.Text = "ordine alfabetico: NO";
            // 
            // titolo_totale
            // 
            this.titolo_totale.AutoSize = true;
            this.titolo_totale.Location = new System.Drawing.Point(810, 456);
            this.titolo_totale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titolo_totale.Name = "titolo_totale";
            this.titolo_totale.Size = new System.Drawing.Size(92, 16);
            this.titolo_totale.TabIndex = 13;
            this.titolo_totale.Text = "Totale prezzo:";
            // 
            // prelista
            // 
            this.prelista.AutoSize = true;
            this.prelista.Location = new System.Drawing.Point(495, 239);
            this.prelista.Name = "prelista";
            this.prelista.Size = new System.Drawing.Size(430, 16);
            this.prelista.TabIndex = 14;
            this.prelista.Text = "Mhm. sembra non esserci nessun prodotto.. Prova ad aggiungerne uno!";
            // 
            // prodotto_costoso
            // 
            this.prodotto_costoso.AutoSize = true;
            this.prodotto_costoso.Location = new System.Drawing.Point(810, 481);
            this.prodotto_costoso.Name = "prodotto_costoso";
            this.prodotto_costoso.Size = new System.Drawing.Size(133, 16);
            this.prodotto_costoso.TabIndex = 15;
            this.prodotto_costoso.Text = "Prodotto più costoso:";
            // 
            // prodotto_menocostoso
            // 
            this.prodotto_menocostoso.AutoSize = true;
            this.prodotto_menocostoso.Location = new System.Drawing.Point(810, 507);
            this.prodotto_menocostoso.Name = "prodotto_menocostoso";
            this.prodotto_menocostoso.Size = new System.Drawing.Size(149, 16);
            this.prodotto_menocostoso.TabIndex = 16;
            this.prodotto_menocostoso.Text = "Prodotto meno costoso:";
            // 
            // titolo_ordinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.prodotto_menocostoso);
            this.Controls.Add(this.prodotto_costoso);
            this.Controls.Add(this.prelista);
            this.Controls.Add(this.titolo_totale);
            this.Controls.Add(this.ordine);
            this.Controls.Add(this.ordina);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.ConfermaModifica);
            this.Controls.Add(this.titolo);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.create);
            this.Controls.Add(this.text_prezzo);
            this.Controls.Add(this.titolo_prezzo);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.titolo_prodotto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "titolo_ordinamento";
            this.Text = "Finestra22F";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titolo_prodotto;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label titolo_prezzo;
        private System.Windows.Forms.TextBox text_prezzo;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label titolo;
        private System.Windows.Forms.Button ConfermaModifica;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button ordina;
        private System.Windows.Forms.Label ordine;
        private System.Windows.Forms.Label titolo_totale;
        private System.Windows.Forms.Label prelista;
        private System.Windows.Forms.Label prodotto_costoso;
        private System.Windows.Forms.Label prodotto_menocostoso;
    }
}

