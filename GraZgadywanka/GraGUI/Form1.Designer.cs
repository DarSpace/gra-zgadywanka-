namespace GraGUI
{
    partial class buttonNowaGra
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonPoddajeSie = new System.Windows.Forms.Button();
            this.buttonHistoria = new System.Windows.Forms.Button();
            this.ButtonOProgramie = new System.Windows.Forms.Button();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.textBoxZakresMin = new System.Windows.Forms.TextBox();
            this.textBoxZakresMax = new System.Windows.Forms.TextBox();
            this.labelZakresMin = new System.Windows.Forms.Label();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.groupBoxPropozycja = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPropozycja = new System.Windows.Forms.TextBox();
            this.buttonSprawdz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelOdpowiedz = new System.Windows.Forms.Label();
            this.groupBoxLosowanie.SuspendLayout();
            this.groupBoxPropozycja.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nowa GRA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonPoddajeSie
            // 
            this.buttonPoddajeSie.Location = new System.Drawing.Point(432, 70);
            this.buttonPoddajeSie.Name = "buttonPoddajeSie";
            this.buttonPoddajeSie.Size = new System.Drawing.Size(104, 23);
            this.buttonPoddajeSie.TabIndex = 1;
            this.buttonPoddajeSie.Text = "Poddaje Się";
            this.buttonPoddajeSie.UseVisualStyleBackColor = true;
            this.buttonPoddajeSie.Visible = false;
            // 
            // buttonHistoria
            // 
            this.buttonHistoria.Location = new System.Drawing.Point(39, 520);
            this.buttonHistoria.Name = "buttonHistoria";
            this.buttonHistoria.Size = new System.Drawing.Size(75, 23);
            this.buttonHistoria.TabIndex = 2;
            this.buttonHistoria.Text = "Historia";
            this.buttonHistoria.UseVisualStyleBackColor = true;
            this.buttonHistoria.Visible = false;
            // 
            // ButtonOProgramie
            // 
            this.ButtonOProgramie.Location = new System.Drawing.Point(414, 520);
            this.ButtonOProgramie.Name = "ButtonOProgramie";
            this.ButtonOProgramie.Size = new System.Drawing.Size(122, 23);
            this.ButtonOProgramie.TabIndex = 3;
            this.ButtonOProgramie.Text = "O Programie";
            this.ButtonOProgramie.UseVisualStyleBackColor = true;
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.buttonWylosuj);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresDo);
            this.groupBoxLosowanie.Controls.Add(this.labelZakresMin);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresMax);
            this.groupBoxLosowanie.Controls.Add(this.textBoxZakresMin);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(57, 154);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Size = new System.Drawing.Size(451, 142);
            this.groupBoxLosowanie.TabIndex = 4;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            // 
            // textBoxZakresMin
            // 
            this.textBoxZakresMin.Location = new System.Drawing.Point(90, 36);
            this.textBoxZakresMin.Name = "textBoxZakresMin";
            this.textBoxZakresMin.Size = new System.Drawing.Size(122, 22);
            this.textBoxZakresMin.TabIndex = 0;
            // 
            // textBoxZakresMax
            // 
            this.textBoxZakresMax.Location = new System.Drawing.Point(90, 94);
            this.textBoxZakresMax.Name = "textBoxZakresMax";
            this.textBoxZakresMax.Size = new System.Drawing.Size(122, 22);
            this.textBoxZakresMax.TabIndex = 1;
            // 
            // labelZakresMin
            // 
            this.labelZakresMin.AutoSize = true;
            this.labelZakresMin.Location = new System.Drawing.Point(7, 36);
            this.labelZakresMin.Name = "labelZakresMin";
            this.labelZakresMin.Size = new System.Drawing.Size(79, 17);
            this.labelZakresMin.TabIndex = 2;
            this.labelZakresMin.Text = "Zakres Od:";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(7, 97);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(78, 17);
            this.labelZakresDo.TabIndex = 3;
            this.labelZakresDo.Text = "Zakres Do:";
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(287, 57);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(85, 34);
            this.buttonWylosuj.TabIndex = 4;
            this.buttonWylosuj.Text = "Losuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            this.buttonWylosuj.Click += new System.EventHandler(this.buttonWylosuj_Click);
            // 
            // groupBoxPropozycja
            // 
            this.groupBoxPropozycja.Controls.Add(this.labelOdpowiedz);
            this.groupBoxPropozycja.Controls.Add(this.label2);
            this.groupBoxPropozycja.Controls.Add(this.buttonSprawdz);
            this.groupBoxPropozycja.Controls.Add(this.textBoxPropozycja);
            this.groupBoxPropozycja.Controls.Add(this.label1);
            this.groupBoxPropozycja.Location = new System.Drawing.Point(57, 323);
            this.groupBoxPropozycja.Name = "groupBoxPropozycja";
            this.groupBoxPropozycja.Size = new System.Drawing.Size(451, 138);
            this.groupBoxPropozycja.TabIndex = 5;
            this.groupBoxPropozycja.TabStop = false;
            this.groupBoxPropozycja.Text = "Odgadnij";
            this.groupBoxPropozycja.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Liczba wylosowana, odgadnij ją!";
            // 
            // textBoxPropozycja
            // 
            this.textBoxPropozycja.Location = new System.Drawing.Point(10, 53);
            this.textBoxPropozycja.Name = "textBoxPropozycja";
            this.textBoxPropozycja.Size = new System.Drawing.Size(181, 22);
            this.textBoxPropozycja.TabIndex = 1;
            this.textBoxPropozycja.TextChanged += new System.EventHandler(this.textBoxPropozycja_TextChanged);
            // 
            // buttonSprawdz
            // 
            this.buttonSprawdz.Location = new System.Drawing.Point(287, 52);
            this.buttonSprawdz.Name = "buttonSprawdz";
            this.buttonSprawdz.Size = new System.Drawing.Size(85, 33);
            this.buttonSprawdz.TabIndex = 2;
            this.buttonSprawdz.Text = "Sprawdź";
            this.buttonSprawdz.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // labelOdpowiedz
            // 
            this.labelOdpowiedz.AutoSize = true;
            this.labelOdpowiedz.Location = new System.Drawing.Point(10, 92);
            this.labelOdpowiedz.Name = "labelOdpowiedz";
            this.labelOdpowiedz.Size = new System.Drawing.Size(46, 17);
            this.labelOdpowiedz.TabIndex = 4;
            this.labelOdpowiedz.Text = "label3";
            // 
            // buttonNowaGra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 577);
            this.Controls.Add(this.groupBoxPropozycja);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.ButtonOProgramie);
            this.Controls.Add(this.buttonHistoria);
            this.Controls.Add(this.buttonPoddajeSie);
            this.Controls.Add(this.button1);
            this.Name = "buttonNowaGra";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.groupBoxPropozycja.ResumeLayout(false);
            this.groupBoxPropozycja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPoddajeSie;
        private System.Windows.Forms.Button buttonHistoria;
        private System.Windows.Forms.Button ButtonOProgramie;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresMin;
        private System.Windows.Forms.TextBox textBoxZakresMax;
        private System.Windows.Forms.TextBox textBoxZakresMin;
        private System.Windows.Forms.GroupBox groupBoxPropozycja;
        private System.Windows.Forms.Button buttonSprawdz;
        private System.Windows.Forms.TextBox textBoxPropozycja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOdpowiedz;
        private System.Windows.Forms.Label label2;
    }
}

