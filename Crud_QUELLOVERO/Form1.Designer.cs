namespace Crud_QUELLOVERO
{
    partial class Form1
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
            this.mostra = new System.Windows.Forms.Button();
            this.modifica = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titolo_prodotto
            // 
            this.titolo_prodotto.AutoSize = true;
            this.titolo_prodotto.Location = new System.Drawing.Point(12, 9);
            this.titolo_prodotto.Name = "titolo_prodotto";
            this.titolo_prodotto.Size = new System.Drawing.Size(127, 13);
            this.titolo_prodotto.TabIndex = 0;
            this.titolo_prodotto.Text = "NOME DEL PRODOTTO";
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(15, 25);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(160, 20);
            this.text_nome.TabIndex = 1;
            // 
            // titolo_prezzo
            // 
            this.titolo_prezzo.AutoSize = true;
            this.titolo_prezzo.Location = new System.Drawing.Point(12, 57);
            this.titolo_prezzo.Name = "titolo_prezzo";
            this.titolo_prezzo.Size = new System.Drawing.Size(139, 13);
            this.titolo_prezzo.TabIndex = 2;
            this.titolo_prezzo.Text = "PREZZO DEL PRODOTTO";
            // 
            // text_prezzo
            // 
            this.text_prezzo.Location = new System.Drawing.Point(15, 73);
            this.text_prezzo.Name = "text_prezzo";
            this.text_prezzo.Size = new System.Drawing.Size(160, 20);
            this.text_prezzo.TabIndex = 3;
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(15, 130);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(160, 26);
            this.create.TabIndex = 4;
            this.create.Text = "Aggiungi un prodotto alla lista";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(610, 31);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(178, 407);
            this.lista.TabIndex = 5;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // titolo
            // 
            this.titolo.AutoSize = true;
            this.titolo.Location = new System.Drawing.Point(607, 9);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(29, 13);
            this.titolo.TabIndex = 6;
            this.titolo.Text = "titolo";
            // 
            // ConfermaModifica
            // 
            this.ConfermaModifica.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ConfermaModifica.Location = new System.Drawing.Point(181, 43);
            this.ConfermaModifica.Name = "ConfermaModifica";
            this.ConfermaModifica.Size = new System.Drawing.Size(142, 40);
            this.ConfermaModifica.TabIndex = 7;
            this.ConfermaModifica.Text = "Conferma modifica";
            this.ConfermaModifica.UseVisualStyleBackColor = true;
            this.ConfermaModifica.Click += new System.EventHandler(this.ConfermaModifica_Click);
            // 
            // mostra
            // 
            this.mostra.Location = new System.Drawing.Point(15, 162);
            this.mostra.Name = "mostra";
            this.mostra.Size = new System.Drawing.Size(160, 23);
            this.mostra.TabIndex = 8;
            this.mostra.Text = "Visualizza i prodotti della lista";
            this.mostra.UseVisualStyleBackColor = true;
            this.mostra.Click += new System.EventHandler(this.mostra_Click);
            // 
            // modifica
            // 
            this.modifica.Location = new System.Drawing.Point(15, 191);
            this.modifica.Name = "modifica";
            this.modifica.Size = new System.Drawing.Size(160, 20);
            this.modifica.TabIndex = 9;
            this.modifica.Text = "Modifica un prodotto nella lista";
            this.modifica.UseVisualStyleBackColor = true;
            this.modifica.Click += new System.EventHandler(this.modifica_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(15, 217);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(159, 21);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Elimina un prodotto dalla lista";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.modifica);
            this.Controls.Add(this.mostra);
            this.Controls.Add(this.ConfermaModifica);
            this.Controls.Add(this.titolo);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.create);
            this.Controls.Add(this.text_prezzo);
            this.Controls.Add(this.titolo_prezzo);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.titolo_prodotto);
            this.Name = "Form1";
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
        private System.Windows.Forms.Button mostra;
        private System.Windows.Forms.Button modifica;
        private System.Windows.Forms.Button delete_button;
    }
}

