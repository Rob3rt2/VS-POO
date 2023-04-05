namespace VS_POO
{
    partial class frmvote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtwinner = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtporcent = new System.Windows.Forms.TextBox();
            this.txtvoto = new System.Windows.Forms.TextBox();
            this.lbljs = new System.Windows.Forms.Label();
            this.lblmj = new System.Windows.Forms.Label();
            this.lbljt = new System.Windows.Forms.Label();
            this.lblvoto = new System.Windows.Forms.Label();
            this.lblvenc = new System.Windows.Forms.Label();
            this.lblporc = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btncal = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvolt = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtwinner
            // 
            this.txtwinner.Location = new System.Drawing.Point(323, 155);
            this.txtwinner.Name = "txtwinner";
            this.txtwinner.Size = new System.Drawing.Size(213, 20);
            this.txtwinner.TabIndex = 0;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(323, 286);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(213, 20);
            this.txttotal.TabIndex = 1;
            // 
            // txtporcent
            // 
            this.txtporcent.Location = new System.Drawing.Point(323, 214);
            this.txtporcent.Name = "txtporcent";
            this.txtporcent.Size = new System.Drawing.Size(213, 20);
            this.txtporcent.TabIndex = 2;
            // 
            // txtvoto
            // 
            this.txtvoto.Location = new System.Drawing.Point(323, 92);
            this.txtvoto.Name = "txtvoto";
            this.txtvoto.Size = new System.Drawing.Size(213, 20);
            this.txtvoto.TabIndex = 3;
            // 
            // lbljs
            // 
            this.lbljs.AutoSize = true;
            this.lbljs.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljs.Location = new System.Drawing.Point(157, 45);
            this.lbljs.Name = "lbljs";
            this.lbljs.Size = new System.Drawing.Size(128, 19);
            this.lbljs.TabIndex = 4;
            this.lbljs.Text = "José da Silva - 1";
            this.lbljs.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblmj
            // 
            this.lblmj.AutoSize = true;
            this.lblmj.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmj.Location = new System.Drawing.Point(358, 45);
            this.lblmj.Name = "lblmj";
            this.lblmj.Size = new System.Drawing.Size(137, 19);
            this.lblmj.TabIndex = 5;
            this.lblmj.Text = "Maria Juruma - 2";
            this.lblmj.Click += new System.EventHandler(this.lblmj_Click);
            // 
            // lbljt
            // 
            this.lbljt.AutoSize = true;
            this.lbljt.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljt.Location = new System.Drawing.Point(562, 45);
            this.lbljt.Name = "lbljt";
            this.lbljt.Size = new System.Drawing.Size(131, 19);
            this.lbljt.TabIndex = 6;
            this.lbljt.Text = "João Tapioca - 3";
            // 
            // lblvoto
            // 
            this.lblvoto.AutoSize = true;
            this.lblvoto.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvoto.Location = new System.Drawing.Point(189, 91);
            this.lblvoto.Name = "lblvoto";
            this.lblvoto.Size = new System.Drawing.Size(128, 19);
            this.lblvoto.TabIndex = 7;
            this.lblvoto.Text = "Qual é seu voto?";
            // 
            // lblvenc
            // 
            this.lblvenc.AutoSize = true;
            this.lblvenc.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvenc.Location = new System.Drawing.Point(212, 155);
            this.lblvenc.Name = "lblvenc";
            this.lblvenc.Size = new System.Drawing.Size(105, 19);
            this.lblvenc.TabIndex = 8;
            this.lblvenc.Text = "O vencedor é:";
            // 
            // lblporc
            // 
            this.lblporc.AutoSize = true;
            this.lblporc.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblporc.Location = new System.Drawing.Point(132, 214);
            this.lblporc.Name = "lblporc";
            this.lblporc.Size = new System.Drawing.Size(185, 19);
            this.lblporc.TabIndex = 9;
            this.lblporc.Text = "Pocentagem do vencedor:";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(199, 287);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(118, 19);
            this.lbltotal.TabIndex = 10;
            this.lbltotal.Text = "Total de votos:";
            // 
            // btncal
            // 
            this.btncal.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(576, 85);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(84, 34);
            this.btncal.TabIndex = 11;
            this.btncal.Text = "Votar";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Location = new System.Drawing.Point(362, 359);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(84, 34);
            this.btnlimp.TabIndex = 12;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvolt
            // 
            this.btnvolt.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvolt.Location = new System.Drawing.Point(488, 359);
            this.btnvolt.Name = "btnvolt";
            this.btnvolt.Size = new System.Drawing.Size(84, 34);
            this.btnvolt.TabIndex = 13;
            this.btnvolt.Text = "Voltar";
            this.btnvolt.UseVisualStyleBackColor = true;
            this.btnvolt.Click += new System.EventHandler(this.btnvolt_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(242, 359);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(84, 34);
            this.btncalcular.TabIndex = 14;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // frmvote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnvolt);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblporc);
            this.Controls.Add(this.lblvenc);
            this.Controls.Add(this.lblvoto);
            this.Controls.Add(this.lbljt);
            this.Controls.Add(this.lblmj);
            this.Controls.Add(this.lbljs);
            this.Controls.Add(this.txtvoto);
            this.Controls.Add(this.txtporcent);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtwinner);
            this.Name = "frmvote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Votação";
            this.Load += new System.EventHandler(this.frmvote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtwinner;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtporcent;
        private System.Windows.Forms.TextBox txtvoto;
        private System.Windows.Forms.Label lbljs;
        private System.Windows.Forms.Label lblmj;
        private System.Windows.Forms.Label lbljt;
        private System.Windows.Forms.Label lblvoto;
        private System.Windows.Forms.Label lblvenc;
        private System.Windows.Forms.Label lblporc;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvolt;
        private System.Windows.Forms.Button btncalcular;
    }
}