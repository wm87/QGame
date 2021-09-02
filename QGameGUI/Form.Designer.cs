
namespace QGameGUI
{
    partial class Quiz
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCat = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDifficulty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFrage = new System.Windows.Forms.TextBox();
            this.lblFrage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAnwortAuswahl = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLoesung = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRichtig = new System.Windows.Forms.RichTextBox();
            this.txtFalsch = new System.Windows.Forms.RichTextBox();
            this.btnHighscore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCat
            // 
            this.txtCat.BackColor = System.Drawing.SystemColors.Info;
            this.txtCat.Location = new System.Drawing.Point(138, 60);
            this.txtCat.Name = "txtCat";
            this.txtCat.Size = new System.Drawing.Size(390, 20);
            this.txtCat.TabIndex = 0;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(372, 248);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(453, 248);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategorie";
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Info;
            this.txtURL.Location = new System.Drawing.Point(138, 34);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(390, 20);
            this.txtURL.TabIndex = 4;
            this.txtURL.Text = "https://opentdb.com/api.php?amount=10&type=multiple";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "URL";
            // 
            // txtDifficulty
            // 
            this.txtDifficulty.BackColor = System.Drawing.SystemColors.Info;
            this.txtDifficulty.Location = new System.Drawing.Point(138, 86);
            this.txtDifficulty.Name = "txtDifficulty";
            this.txtDifficulty.Size = new System.Drawing.Size(167, 20);
            this.txtDifficulty.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Schwierigkeit";
            // 
            // txtFrage
            // 
            this.txtFrage.BackColor = System.Drawing.SystemColors.Info;
            this.txtFrage.Location = new System.Drawing.Point(138, 112);
            this.txtFrage.Multiline = true;
            this.txtFrage.Name = "txtFrage";
            this.txtFrage.Size = new System.Drawing.Size(390, 54);
            this.txtFrage.TabIndex = 8;
            // 
            // lblFrage
            // 
            this.lblFrage.AutoSize = true;
            this.lblFrage.Location = new System.Drawing.Point(49, 136);
            this.lblFrage.Name = "lblFrage";
            this.lblFrage.Size = new System.Drawing.Size(34, 13);
            this.lblFrage.TabIndex = 9;
            this.lblFrage.Text = "Frage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Auswahl";
            // 
            // pnlAnwortAuswahl
            // 
            this.pnlAnwortAuswahl.BackColor = System.Drawing.SystemColors.Info;
            this.pnlAnwortAuswahl.Location = new System.Drawing.Point(138, 172);
            this.pnlAnwortAuswahl.Name = "pnlAnwortAuswahl";
            this.pnlAnwortAuswahl.Size = new System.Drawing.Size(390, 60);
            this.pnlAnwortAuswahl.TabIndex = 10;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(49, 14);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(29, 13);
            this.User.TabIndex = 12;
            this.User.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.SystemColors.Info;
            this.txtUser.Location = new System.Drawing.Point(138, 11);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(390, 20);
            this.txtUser.TabIndex = 13;
            // 
            // txtLoesung
            // 
            this.txtLoesung.BackColor = System.Drawing.SystemColors.Info;
            this.txtLoesung.Location = new System.Drawing.Point(138, 248);
            this.txtLoesung.Name = "txtLoesung";
            this.txtLoesung.Size = new System.Drawing.Size(228, 20);
            this.txtLoesung.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Lösung";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.SystemColors.Info;
            this.txtResult.Location = new System.Drawing.Point(138, 278);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(390, 20);
            this.txtResult.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ergebnis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Richtige Antworten";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Falsche Antworten";
            // 
            // txtRichtig
            // 
            this.txtRichtig.BackColor = System.Drawing.SystemColors.Info;
            this.txtRichtig.Location = new System.Drawing.Point(138, 321);
            this.txtRichtig.Name = "txtRichtig";
            this.txtRichtig.Size = new System.Drawing.Size(167, 121);
            this.txtRichtig.TabIndex = 24;
            this.txtRichtig.Text = "";
            // 
            // txtFalsch
            // 
            this.txtFalsch.BackColor = System.Drawing.SystemColors.Info;
            this.txtFalsch.Location = new System.Drawing.Point(311, 321);
            this.txtFalsch.Name = "txtFalsch";
            this.txtFalsch.Size = new System.Drawing.Size(217, 121);
            this.txtFalsch.TabIndex = 25;
            this.txtFalsch.Text = "";
            // 
            // btnHighscore
            // 
            this.btnHighscore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHighscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighscore.Location = new System.Drawing.Point(12, 399);
            this.btnHighscore.Name = "btnHighscore";
            this.btnHighscore.Size = new System.Drawing.Size(120, 43);
            this.btnHighscore.TabIndex = 27;
            this.btnHighscore.Text = "in Highscore übernehmen";
            this.btnHighscore.UseVisualStyleBackColor = false;
            this.btnHighscore.Click += new System.EventHandler(this.btnHighscore_Click);
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(540, 454);
            this.Controls.Add(this.btnHighscore);
            this.Controls.Add(this.txtFalsch);
            this.Controls.Add(this.txtRichtig);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoesung);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlAnwortAuswahl);
            this.Controls.Add(this.lblFrage);
            this.Controls.Add(this.txtFrage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.txtCat);
            this.Name = "Quiz";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCat;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFrage;
        private System.Windows.Forms.Label lblFrage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlAnwortAuswahl;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtLoesung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtRichtig;
        private System.Windows.Forms.RichTextBox txtFalsch;
        private System.Windows.Forms.Button btnHighscore;
    }
}

