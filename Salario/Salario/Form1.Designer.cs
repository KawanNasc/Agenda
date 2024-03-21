namespace Salario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnReajustar = new System.Windows.Forms.Button();
            this.rdbDesigner = new System.Windows.Forms.RadioButton();
            this.txtNm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rdbProgramador = new System.Windows.Forms.RadioButton();
            this.rdbDevWeb = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // btnReajustar
            // 
            this.btnReajustar.Location = new System.Drawing.Point(303, 257);
            this.btnReajustar.Name = "btnReajustar";
            this.btnReajustar.Size = new System.Drawing.Size(75, 23);
            this.btnReajustar.TabIndex = 1;
            this.btnReajustar.Text = "Reajustar";
            this.btnReajustar.UseVisualStyleBackColor = true;
            this.btnReajustar.Click += new System.EventHandler(this.btnReajustar_Click);
            // 
            // rdbDesigner
            // 
            this.rdbDesigner.AutoSize = true;
            this.rdbDesigner.Location = new System.Drawing.Point(243, 225);
            this.rdbDesigner.Name = "rdbDesigner";
            this.rdbDesigner.Size = new System.Drawing.Size(67, 17);
            this.rdbDesigner.TabIndex = 2;
            this.rdbDesigner.TabStop = true;
            this.rdbDesigner.Text = "Designer";
            this.rdbDesigner.UseVisualStyleBackColor = true;
            // 
            // txtNm
            // 
            this.txtNm.Location = new System.Drawing.Point(340, 142);
            this.txtNm.Name = "txtNm";
            this.txtNm.Size = new System.Drawing.Size(100, 20);
            this.txtNm.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Salário";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(412, 262);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(340, 176);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // rdbProgramador
            // 
            this.rdbProgramador.AutoSize = true;
            this.rdbProgramador.Location = new System.Drawing.Point(330, 225);
            this.rdbProgramador.Name = "rdbProgramador";
            this.rdbProgramador.Size = new System.Drawing.Size(85, 17);
            this.rdbProgramador.TabIndex = 2;
            this.rdbProgramador.TabStop = true;
            this.rdbProgramador.Text = "Programador";
            this.rdbProgramador.UseVisualStyleBackColor = true;
            // 
            // rdbDevWeb
            // 
            this.rdbDevWeb.AutoSize = true;
            this.rdbDevWeb.Location = new System.Drawing.Point(443, 225);
            this.rdbDevWeb.Name = "rdbDevWeb";
            this.rdbDevWeb.Size = new System.Drawing.Size(123, 17);
            this.rdbDevWeb.TabIndex = 2;
            this.rdbDevWeb.TabStop = true;
            this.rdbDevWeb.Text = "Desenvolvedor Web";
            this.rdbDevWeb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtNm);
            this.Controls.Add(this.rdbDevWeb);
            this.Controls.Add(this.rdbProgramador);
            this.Controls.Add(this.rdbDesigner);
            this.Controls.Add(this.btnReajustar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReajustar;
        private System.Windows.Forms.RadioButton rdbDesigner;
        private System.Windows.Forms.TextBox txtNm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rdbProgramador;
        private System.Windows.Forms.RadioButton rdbDevWeb;
    }
}

