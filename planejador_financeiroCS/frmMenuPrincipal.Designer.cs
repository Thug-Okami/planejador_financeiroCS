namespace planejador_financeiroCS
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDomingo = new Label();
            lblSegunda = new Label();
            lblTerca = new Label();
            lblQuarta = new Label();
            lblQuinta = new Label();
            lblSexta = new Label();
            lblSabado = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblMes = new Label();
            btnBack = new Button();
            btnNext = new Button();
            btnMensal = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDomingo
            // 
            lblDomingo.AutoSize = true;
            lblDomingo.Location = new Point(705, 159);
            lblDomingo.Name = "lblDomingo";
            lblDomingo.Size = new Size(57, 15);
            lblDomingo.TabIndex = 1;
            lblDomingo.Text = "Domingo";
            // 
            // lblSegunda
            // 
            lblSegunda.AutoSize = true;
            lblSegunda.Location = new Point(40, 159);
            lblSegunda.Name = "lblSegunda";
            lblSegunda.Size = new Size(53, 15);
            lblSegunda.TabIndex = 2;
            lblSegunda.Text = "Segunda";
            // 
            // lblTerca
            // 
            lblTerca.AutoSize = true;
            lblTerca.Location = new Point(150, 159);
            lblTerca.Name = "lblTerca";
            lblTerca.Size = new Size(34, 15);
            lblTerca.TabIndex = 3;
            lblTerca.Text = "Terça";
            // 
            // lblQuarta
            // 
            lblQuarta.AutoSize = true;
            lblQuarta.Location = new Point(270, 159);
            lblQuarta.Name = "lblQuarta";
            lblQuarta.Size = new Size(43, 15);
            lblQuarta.TabIndex = 4;
            lblQuarta.Text = "Quarta";
            // 
            // lblQuinta
            // 
            lblQuinta.AutoSize = true;
            lblQuinta.Location = new Point(375, 159);
            lblQuinta.Name = "lblQuinta";
            lblQuinta.Size = new Size(43, 15);
            lblQuinta.TabIndex = 5;
            lblQuinta.Text = "Quinta";
            // 
            // lblSexta
            // 
            lblSexta.AutoSize = true;
            lblSexta.Location = new Point(484, 159);
            lblSexta.Name = "lblSexta";
            lblSexta.Size = new Size(35, 15);
            lblSexta.TabIndex = 6;
            lblSexta.Text = "Sexta";
            // 
            // lblSabado
            // 
            lblSabado.AutoSize = true;
            lblSabado.Location = new Point(600, 159);
            lblSabado.Name = "lblSabado";
            lblSabado.Size = new Size(46, 15);
            lblSabado.TabIndex = 7;
            lblSabado.Text = "Sabado";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(12, 186);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 363);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(334, 9);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 8;
            lblMes.Text = "Mês";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(3, 150);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 9;
            btnBack.Text = "Voltar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(129, 150);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 10;
            btnNext.Text = "Avançar";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnMensal
            // 
            btnMensal.Location = new Point(61, 237);
            btnMensal.Name = "btnMensal";
            btnMensal.Size = new Size(75, 23);
            btnMensal.TabIndex = 11;
            btnMensal.Text = "Mensal";
            btnMensal.UseVisualStyleBackColor = true;
            btnMensal.Click += btnMensal_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMensal);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(btnNext);
            panel1.Location = new Point(791, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 544);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 208);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 311);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 12;
            label1.Text = "Eventos";
            // 
            // button1
            // 
            button1.Location = new Point(41, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1000, 561);
            Controls.Add(panel1);
            Controls.Add(lblMes);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblSabado);
            Controls.Add(lblSexta);
            Controls.Add(lblQuinta);
            Controls.Add(lblQuarta);
            Controls.Add(lblTerca);
            Controls.Add(lblSegunda);
            Controls.Add(lblDomingo);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            Load += frmMenuPrincipal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDomingo;
        private Label lblSegunda;
        private Label lblTerca;
        private Label lblQuarta;
        private Label lblQuinta;
        private Label lblSexta;
        private Label lblSabado;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblMes;
        private Button btnBack;
        private Button btnNext;
        private Button btnMensal;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button button1;
    }
}
