namespace VS_POO
{
    partial class frmtabu
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
            this.lblnum = new System.Windows.Forms.Label();
            this.lbltabu = new System.Windows.Forms.Label();
            this.btnwhile = new System.Windows.Forms.Button();
            this.btndowhile = new System.Windows.Forms.Button();
            this.btnfor = new System.Windows.Forms.Button();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttabu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnum.Location = new System.Drawing.Point(234, 64);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(137, 19);
            this.lblnum.TabIndex = 0;
            this.lblnum.Text = "Digite um número:";
            // 
            // lbltabu
            // 
            this.lbltabu.AutoSize = true;
            this.lbltabu.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltabu.Location = new System.Drawing.Point(170, 121);
            this.lbltabu.Name = "lbltabu";
            this.lbltabu.Size = new System.Drawing.Size(201, 19);
            this.lbltabu.TabIndex = 1;
            this.lbltabu.Text = "A tabuada desse número é:";
            // 
            // btnwhile
            // 
            this.btnwhile.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwhile.Location = new System.Drawing.Point(238, 265);
            this.btnwhile.Name = "btnwhile";
            this.btnwhile.Size = new System.Drawing.Size(89, 34);
            this.btnwhile.TabIndex = 2;
            this.btnwhile.Text = "while";
            this.btnwhile.UseVisualStyleBackColor = true;
            this.btnwhile.Click += new System.EventHandler(this.btnwhile_Click);
            // 
            // btndowhile
            // 
            this.btndowhile.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndowhile.Location = new System.Drawing.Point(343, 265);
            this.btndowhile.Name = "btndowhile";
            this.btndowhile.Size = new System.Drawing.Size(89, 34);
            this.btndowhile.TabIndex = 3;
            this.btndowhile.Text = "do...while";
            this.btndowhile.UseVisualStyleBackColor = true;
            this.btndowhile.Click += new System.EventHandler(this.btndowhile_Click);
            // 
            // btnfor
            // 
            this.btnfor.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfor.Location = new System.Drawing.Point(447, 267);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(89, 32);
            this.btnfor.TabIndex = 4;
            this.btnfor.Text = "for";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(204, 243);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(381, 19);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Botões para calcular diferentes tipos de repetições:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(389, 305);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(147, 27);
            this.btnvoltar.TabIndex = 6;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Location = new System.Drawing.Point(230, 305);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(153, 27);
            this.btnlimp.TabIndex = 7;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(377, 63);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(302, 20);
            this.txtnum.TabIndex = 8;
            // 
            // txttabu
            // 
            this.txttabu.Enabled = false;
            this.txttabu.Location = new System.Drawing.Point(377, 121);
            this.txttabu.Name = "txttabu";
            this.txttabu.Size = new System.Drawing.Size(302, 20);
            this.txttabu.TabIndex = 9;
            // 
            // frmtabu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttabu);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.btndowhile);
            this.Controls.Add(this.btnwhile);
            this.Controls.Add(this.lbltabu);
            this.Controls.Add(this.lblnum);
            this.Name = "frmtabu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lbltabu;
        private System.Windows.Forms.Button btnwhile;
        private System.Windows.Forms.Button btndowhile;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttabu;
    }
}