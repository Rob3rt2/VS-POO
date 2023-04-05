namespace VS_POO
{
    partial class frmcomb
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
            this.lblcomb = new System.Windows.Forms.Label();
            this.lblquant = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txtcomb = new System.Windows.Forms.TextBox();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btncal = new System.Windows.Forms.Button();
            this.btnlimp = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcomb
            // 
            this.lblcomb.AutoSize = true;
            this.lblcomb.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomb.Location = new System.Drawing.Point(116, 95);
            this.lblcomb.Name = "lblcomb";
            this.lblcomb.Size = new System.Drawing.Size(212, 19);
            this.lblcomb.TabIndex = 0;
            this.lblcomb.Text = "Digite o tipo de combustível:";
            // 
            // lblquant
            // 
            this.lblquant.AutoSize = true;
            this.lblquant.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquant.Location = new System.Drawing.Point(64, 147);
            this.lblquant.Name = "lblquant";
            this.lblquant.Size = new System.Drawing.Size(264, 19);
            this.lblquant.TabIndex = 1;
            this.lblquant.Text = "Digite a quantidade de combustível:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Ink Free", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(147, 200);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(181, 19);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "O valor a ser pago é de:";
            // 
            // txtcomb
            // 
            this.txtcomb.Location = new System.Drawing.Point(346, 95);
            this.txtcomb.Name = "txtcomb";
            this.txtcomb.Size = new System.Drawing.Size(247, 20);
            this.txtcomb.TabIndex = 3;
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(346, 147);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(247, 20);
            this.txtquant.TabIndex = 4;
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(346, 200);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(247, 20);
            this.txtresult.TabIndex = 5;
            // 
            // btncal
            // 
            this.btncal.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.Location = new System.Drawing.Point(242, 266);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(86, 33);
            this.btncal.TabIndex = 6;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = true;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnlimp
            // 
            this.btnlimp.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimp.Location = new System.Drawing.Point(346, 267);
            this.btnlimp.Name = "btnlimp";
            this.btnlimp.Size = new System.Drawing.Size(86, 32);
            this.btnlimp.TabIndex = 7;
            this.btnlimp.Text = "Limpar";
            this.btnlimp.UseVisualStyleBackColor = true;
            this.btnlimp.Click += new System.EventHandler(this.btnlimp_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(458, 267);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(82, 33);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmcomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimp);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.txtcomb);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblquant);
            this.Controls.Add(this.lblcomb);
            this.Name = "frmcomb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustíveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcomb;
        private System.Windows.Forms.Label lblquant;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txtcomb;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnlimp;
        private System.Windows.Forms.Button btnvoltar;
    }
}