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
            this.titolo_dellaModifica = new System.Windows.Forms.Label();
            this.salva_file = new System.Windows.Forms.Button();
            this.sconto = new System.Windows.Forms.Button();
            this.lettura_file = new System.Windows.Forms.Button();
            this.percentuali = new System.Windows.Forms.ComboBox();
            this.TITOLO22F = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titolo_prodotto
            // 
            this.titolo_prodotto.AutoSize = true;
            this.titolo_prodotto.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo_prodotto.ForeColor = System.Drawing.Color.MediumOrchid;
            this.titolo_prodotto.Location = new System.Drawing.Point(10, 398);
            this.titolo_prodotto.Name = "titolo_prodotto";
            this.titolo_prodotto.Size = new System.Drawing.Size(176, 15);
            this.titolo_prodotto.TabIndex = 0;
            this.titolo_prodotto.Text = "NOME DEL PRODOTTO";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(9, 422);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(160, 20);
            this.text_nome.TabIndex = 1;
            // 
            // titolo_prezzo
            // 
            this.titolo_prezzo.AutoSize = true;
            this.titolo_prezzo.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo_prezzo.ForeColor = System.Drawing.Color.MediumOrchid;
            this.titolo_prezzo.Location = new System.Drawing.Point(10, 325);
            this.titolo_prezzo.Name = "titolo_prezzo";
            this.titolo_prezzo.Size = new System.Drawing.Size(191, 15);
            this.titolo_prezzo.TabIndex = 2;
            this.titolo_prezzo.Text = "PREZZO DEL PRODOTTO";
            // 
            // text_prezzo
            // 
            this.text_prezzo.Location = new System.Drawing.Point(10, 341);
            this.text_prezzo.Name = "text_prezzo";
            this.text_prezzo.Size = new System.Drawing.Size(160, 20);
            this.text_prezzo.TabIndex = 3;
            // 
            // create
            // 
            this.create.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.create.Location = new System.Drawing.Point(7, 105);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(160, 44);
            this.create.TabIndex = 4;
            this.create.Text = "Aggiungi un prodotto alla lista";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(596, 50);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(178, 329);
            this.lista.TabIndex = 5;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // titolo
            // 
            this.titolo.AutoSize = true;
            this.titolo.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo.ForeColor = System.Drawing.Color.MediumBlue;
            this.titolo.Location = new System.Drawing.Point(594, 33);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(52, 14);
            this.titolo.TabIndex = 6;
            this.titolo.Text = "Prodotti";
            // 
            // ConfermaModifica
            // 
            this.ConfermaModifica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConfermaModifica.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfermaModifica.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ConfermaModifica.Location = new System.Drawing.Point(200, 371);
            this.ConfermaModifica.Name = "ConfermaModifica";
            this.ConfermaModifica.Size = new System.Drawing.Size(178, 40);
            this.ConfermaModifica.TabIndex = 7;
            this.ConfermaModifica.Text = "Conferma modifica";
            this.ConfermaModifica.UseVisualStyleBackColor = true;
            this.ConfermaModifica.Click += new System.EventHandler(this.ConfermaModifica_Click);
            // 
            // modifica
            // 
            this.modifica.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifica.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.modifica.Location = new System.Drawing.Point(7, 155);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(160, 52);
            this.modifica.TabIndex = 9;
            this.modifica.Text = "Modifica un prodotto presente nella lista";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.delete_button.Location = new System.Drawing.Point(7, 214);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(159, 58);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Elimina un prodotto dalla lista";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // ordina
            // 
            this.ordina.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordina.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ordina.Location = new System.Drawing.Point(173, 155);
            this.ordina.Name = "ordina";
            this.ordina.Size = new System.Drawing.Size(155, 52);
            this.ordina.TabIndex = 11;
            this.ordina.Text = " Ordina in modo alfabetico";
            this.ordina.UseVisualStyleBackColor = true;
            this.ordina.Click += new System.EventHandler(this.ordina_Click);
            // 
            // ordine
            // 
            this.ordine.AutoSize = true;
            this.ordine.Font = new System.Drawing.Font("Poor Richard", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordine.ForeColor = System.Drawing.Color.MediumBlue;
            this.ordine.Location = new System.Drawing.Point(673, 33);
            this.ordine.Name = "ordine";
            this.ordine.Size = new System.Drawing.Size(127, 14);
            this.ordine.TabIndex = 12;
            this.ordine.Text = "ordine alfabetico: NO";
            // 
            // titolo_totale
            // 
            this.titolo_totale.AutoSize = true;
            this.titolo_totale.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo_totale.ForeColor = System.Drawing.Color.MediumBlue;
            this.titolo_totale.Location = new System.Drawing.Point(594, 381);
            this.titolo_totale.Name = "titolo_totale";
            this.titolo_totale.Size = new System.Drawing.Size(89, 17);
            this.titolo_totale.TabIndex = 13;
            this.titolo_totale.Text = "Totale prezzo:";
            // 
            // prelista
            // 
            this.prelista.AutoSize = true;
            this.prelista.Font = new System.Drawing.Font("OCR A Extended", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prelista.Location = new System.Drawing.Point(334, 197);
            this.prelista.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prelista.Name = "prelista";
            this.prelista.Size = new System.Drawing.Size(541, 12);
            this.prelista.TabIndex = 14;
            this.prelista.Text = "Mhm. sembra non esserci nessun prodotto.. Prova ad aggiungerne uno!";
            // 
            // prodotto_costoso
            // 
            this.prodotto_costoso.AutoSize = true;
            this.prodotto_costoso.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodotto_costoso.ForeColor = System.Drawing.Color.MediumBlue;
            this.prodotto_costoso.Location = new System.Drawing.Point(594, 409);
            this.prodotto_costoso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodotto_costoso.Name = "prodotto_costoso";
            this.prodotto_costoso.Size = new System.Drawing.Size(133, 17);
            this.prodotto_costoso.TabIndex = 15;
            this.prodotto_costoso.Text = "Prodotto più costoso:";
            // 
            // prodotto_menocostoso
            // 
            this.prodotto_menocostoso.AutoSize = true;
            this.prodotto_menocostoso.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodotto_menocostoso.ForeColor = System.Drawing.Color.MediumBlue;
            this.prodotto_menocostoso.Location = new System.Drawing.Point(594, 430);
            this.prodotto_menocostoso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodotto_menocostoso.Name = "prodotto_menocostoso";
            this.prodotto_menocostoso.Size = new System.Drawing.Size(145, 17);
            this.prodotto_menocostoso.TabIndex = 16;
            this.prodotto_menocostoso.Text = "Prodotto meno costoso:";
            // 
            // titolo_dellaModifica
            // 
            this.titolo_dellaModifica.AutoSize = true;
            this.titolo_dellaModifica.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo_dellaModifica.ForeColor = System.Drawing.Color.MediumOrchid;
            this.titolo_dellaModifica.Location = new System.Drawing.Point(197, 344);
            this.titolo_dellaModifica.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titolo_dellaModifica.Name = "titolo_dellaModifica";
            this.titolo_dellaModifica.Size = new System.Drawing.Size(208, 15);
            this.titolo_dellaModifica.TabIndex = 17;
            this.titolo_dellaModifica.Text = "MODIFICA DEL PRODOTTO";
            // 
            // salva_file
            // 
            this.salva_file.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salva_file.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.salva_file.Location = new System.Drawing.Point(173, 214);
            this.salva_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.salva_file.Name = "salva_file";
            this.salva_file.Size = new System.Drawing.Size(154, 30);
            this.salva_file.TabIndex = 18;
            this.salva_file.Text = "Salva lista su un file csv";
            this.salva_file.UseVisualStyleBackColor = true;
            this.salva_file.Click += new System.EventHandler(this.salva_file_Click);
            // 
            // sconto
            // 
            this.sconto.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sconto.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.sconto.Location = new System.Drawing.Point(173, 103);
            this.sconto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sconto.Name = "sconto";
            this.sconto.Size = new System.Drawing.Size(154, 47);
            this.sconto.TabIndex = 19;
            this.sconto.Text = "Aggiungi o togli la percentuale dal prezzo totale";
            this.sconto.UseVisualStyleBackColor = true;
            this.sconto.Click += new System.EventHandler(this.sconto_Click);
            // 
            // lettura_file
            // 
            this.lettura_file.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettura_file.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lettura_file.Location = new System.Drawing.Point(173, 249);
            this.lettura_file.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lettura_file.Name = "lettura_file";
            this.lettura_file.Size = new System.Drawing.Size(153, 24);
            this.lettura_file.TabIndex = 20;
            this.lettura_file.Text = "importa lista";
            this.lettura_file.UseVisualStyleBackColor = true;
            this.lettura_file.Click += new System.EventHandler(this.lettura_file_Click);
            // 
            // percentuali
            // 
            this.percentuali.FormattingEnabled = true;
            this.percentuali.Items.AddRange(new object[] {
            "aggiungi",
            "sottrai"});
            this.percentuali.Location = new System.Drawing.Point(332, 112);
            this.percentuali.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.percentuali.Name = "percentuali";
            this.percentuali.Size = new System.Drawing.Size(134, 21);
            this.percentuali.TabIndex = 21;
            this.percentuali.SelectedIndexChanged += new System.EventHandler(this.percentuali_SelectedIndexChanged);
            // 
            // TITOLO22F
            // 
            this.TITOLO22F.AutoSize = true;
            this.TITOLO22F.Font = new System.Drawing.Font("MV Boli", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITOLO22F.ForeColor = System.Drawing.Color.Firebrick;
            this.TITOLO22F.Location = new System.Drawing.Point(4, 7);
            this.TITOLO22F.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TITOLO22F.Name = "TITOLO22F";
            this.TITOLO22F.Size = new System.Drawing.Size(878, 20);
            this.TITOLO22F.TabIndex = 22;
            this.TITOLO22F.Text = "BENVENUTO NELLA PAGINA DEI PRODOTTI22F! SELEZIONA UNA FUNZIONE PER MODIFICARE LA " +
    "LISTA";
            // 
            // titolo_ordinamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TITOLO22F);
            this.Controls.Add(this.percentuali);
            this.Controls.Add(this.lettura_file);
            this.Controls.Add(this.sconto);
            this.Controls.Add(this.salva_file);
            this.Controls.Add(this.titolo_dellaModifica);
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
        private System.Windows.Forms.Label titolo_dellaModifica;
        private System.Windows.Forms.Button salva_file;
        private System.Windows.Forms.Button sconto;
        private System.Windows.Forms.Button lettura_file;
        private System.Windows.Forms.ComboBox percentuali;
        private System.Windows.Forms.Label TITOLO22F;
    }
}

