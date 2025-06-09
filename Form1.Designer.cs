namespace Zad5_SymulatorMikroprocesora
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajInstrukcje = new System.Windows.Forms.Button();
            this.lstProgram = new System.Windows.Forms.ListBox();
            this.btnWykonajCaly = new System.Windows.Forms.Button();
            this.btnWykonajKrokowo = new System.Windows.Forms.Button();
            this.btnZapiszProgram = new System.Windows.Forms.Button();
            this.btnWczytajProgram = new System.Windows.Forms.Button();
            this.lblAX = new System.Windows.Forms.Label();
            this.lblBX = new System.Windows.Forms.Label();
            this.lblCX = new System.Windows.Forms.Label();
            this.lblDX = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(150, 118);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(459, 59);
            this.txtKod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(43, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instrukcje:";
            // 
            // btnDodajInstrukcje
            // 
            this.btnDodajInstrukcje.Location = new System.Drawing.Point(649, 118);
            this.btnDodajInstrukcje.Name = "btnDodajInstrukcje";
            this.btnDodajInstrukcje.Size = new System.Drawing.Size(183, 59);
            this.btnDodajInstrukcje.TabIndex = 2;
            this.btnDodajInstrukcje.Text = "Zapisz instrukcje";
            this.btnDodajInstrukcje.UseVisualStyleBackColor = true;
            this.btnDodajInstrukcje.Click += new System.EventHandler(this.btnDodajInstrukcje_Click_1);
            // 
            // lstProgram
            // 
            this.lstProgram.FormattingEnabled = true;
            this.lstProgram.ItemHeight = 16;
            this.lstProgram.Location = new System.Drawing.Point(996, 118);
            this.lstProgram.Name = "lstProgram";
            this.lstProgram.Size = new System.Drawing.Size(446, 404);
            this.lstProgram.TabIndex = 3;
            // 
            // btnWykonajCaly
            // 
            this.btnWykonajCaly.Location = new System.Drawing.Point(48, 302);
            this.btnWykonajCaly.Name = "btnWykonajCaly";
            this.btnWykonajCaly.Size = new System.Drawing.Size(183, 59);
            this.btnWykonajCaly.TabIndex = 4;
            this.btnWykonajCaly.Text = "Wykonaj program";
            this.btnWykonajCaly.UseVisualStyleBackColor = true;
            this.btnWykonajCaly.Click += new System.EventHandler(this.btnWykonajCaly_Click_1);
            // 
            // btnWykonajKrokowo
            // 
            this.btnWykonajKrokowo.Location = new System.Drawing.Point(369, 302);
            this.btnWykonajKrokowo.Name = "btnWykonajKrokowo";
            this.btnWykonajKrokowo.Size = new System.Drawing.Size(183, 59);
            this.btnWykonajKrokowo.TabIndex = 5;
            this.btnWykonajKrokowo.Text = "Wykonaj krokowo";
            this.btnWykonajKrokowo.UseVisualStyleBackColor = true;
            this.btnWykonajKrokowo.Click += new System.EventHandler(this.btnWykonajKrokowo_Click_1);
            // 
            // btnZapiszProgram
            // 
            this.btnZapiszProgram.Location = new System.Drawing.Point(48, 463);
            this.btnZapiszProgram.Name = "btnZapiszProgram";
            this.btnZapiszProgram.Size = new System.Drawing.Size(183, 59);
            this.btnZapiszProgram.TabIndex = 6;
            this.btnZapiszProgram.Text = "Zapisz program";
            this.btnZapiszProgram.UseVisualStyleBackColor = true;
            this.btnZapiszProgram.Click += new System.EventHandler(this.btnZapiszProgram_Click_1);
            // 
            // btnWczytajProgram
            // 
            this.btnWczytajProgram.Location = new System.Drawing.Point(369, 463);
            this.btnWczytajProgram.Name = "btnWczytajProgram";
            this.btnWczytajProgram.Size = new System.Drawing.Size(183, 59);
            this.btnWczytajProgram.TabIndex = 7;
            this.btnWczytajProgram.Text = "Wczytaj program";
            this.btnWczytajProgram.UseVisualStyleBackColor = true;
            this.btnWczytajProgram.Click += new System.EventHandler(this.btnWczytajProgram_Click_1);
            // 
            // lblAX
            // 
            this.lblAX.AutoSize = true;
            this.lblAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAX.Location = new System.Drawing.Point(731, 256);
            this.lblAX.Name = "lblAX";
            this.lblAX.Size = new System.Drawing.Size(40, 25);
            this.lblAX.TabIndex = 8;
            this.lblAX.Text = "AX";
            // 
            // lblBX
            // 
            this.lblBX.AutoSize = true;
            this.lblBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBX.Location = new System.Drawing.Point(731, 336);
            this.lblBX.Name = "lblBX";
            this.lblBX.Size = new System.Drawing.Size(39, 25);
            this.lblBX.TabIndex = 9;
            this.lblBX.Text = "BX";
            // 
            // lblCX
            // 
            this.lblCX.AutoSize = true;
            this.lblCX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCX.Location = new System.Drawing.Point(731, 409);
            this.lblCX.Name = "lblCX";
            this.lblCX.Size = new System.Drawing.Size(41, 25);
            this.lblCX.TabIndex = 10;
            this.lblCX.Text = "CX";
            // 
            // lblDX
            // 
            this.lblDX.AutoSize = true;
            this.lblDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDX.Location = new System.Drawing.Point(731, 497);
            this.lblDX.Name = "lblDX";
            this.lblDX.Size = new System.Drawing.Size(40, 25);
            this.lblDX.TabIndex = 11;
            this.lblDX.Text = "DX";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1481, 782);
            this.Controls.Add(this.lblDX);
            this.Controls.Add(this.lblCX);
            this.Controls.Add(this.lblBX);
            this.Controls.Add(this.lblAX);
            this.Controls.Add(this.btnWczytajProgram);
            this.Controls.Add(this.btnZapiszProgram);
            this.Controls.Add(this.btnWykonajKrokowo);
            this.Controls.Add(this.btnWykonajCaly);
            this.Controls.Add(this.lstProgram);
            this.Controls.Add(this.btnDodajInstrukcje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKod);
            this.Name = "Form1";
            this.Text = "Symulator mikroprocesora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajInstrukcje;
        private System.Windows.Forms.ListBox lstProgram;
        private System.Windows.Forms.Button btnWykonajCaly;
        private System.Windows.Forms.Button btnWykonajKrokowo;
        private System.Windows.Forms.Button btnZapiszProgram;
        private System.Windows.Forms.Button btnWczytajProgram;
        private System.Windows.Forms.Label lblAX;
        private System.Windows.Forms.Label lblBX;
        private System.Windows.Forms.Label lblCX;
        private System.Windows.Forms.Label lblDX;
    }
}

