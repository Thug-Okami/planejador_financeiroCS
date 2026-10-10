namespace planejador_financeiroCS
{
    partial class EventoForm
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
            textBox1 = new TextBox();
            textBoxNome = new TextBox();
            checkBoxRecurring = new CheckBox();
            lblData = new Label();
            lblEvento = new Label();
            btnSalvar = new Button();
            lblValor = new Label();
            textBoxValor = new TextBox();
            comboBoxTipo = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 0;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(35, 96);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(210, 23);
            textBoxNome.TabIndex = 1;
            // 
            // checkBoxRecurring
            // 
            checkBoxRecurring.AutoSize = true;
            checkBoxRecurring.Location = new Point(35, 248);
            checkBoxRecurring.Name = "checkBoxRecurring";
            checkBoxRecurring.Size = new Size(124, 19);
            checkBoxRecurring.TabIndex = 2;
            checkBoxRecurring.Text = "Recorrente mensal";
            checkBoxRecurring.UseVisualStyleBackColor = true;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(35, 18);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 2;
            lblData.Text = "Data";
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Location = new Point(35, 78);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(99, 15);
            lblEvento.TabIndex = 3;
            lblEvento.Text = "Nome do Evento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(170, 281);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(35, 133);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 5;
            lblValor.Text = "Valor";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(35, 151);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(210, 23);
            textBoxValor.TabIndex = 6;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Receita", "Despesa" });
            comboBoxTipo.Location = new Point(35, 201);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 23);
            comboBoxTipo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 183);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 9;
            label1.Text = "Tipo";
            // 
            // EventoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 316);
            Controls.Add(label1);
            Controls.Add(comboBoxTipo);
            Controls.Add(textBoxValor);
            Controls.Add(lblValor);
            Controls.Add(btnSalvar);
            Controls.Add(lblEvento);
            Controls.Add(lblData);
            Controls.Add(checkBoxRecurring);
            Controls.Add(textBoxNome);
            Controls.Add(textBox1);
            Name = "EventoForm";
            Text = "EventoForm";
            Load += EventoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBoxNome;
        private Label lblData;
        private Label lblEvento;
        private Button btnSalvar;
        private CheckBox checkBoxRecurring;
        private Label lblValor;
        private TextBox textBoxValor;
        private ComboBox comboBoxTipo;
        private Label label1;
    }
}