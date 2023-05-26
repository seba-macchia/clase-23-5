namespace WinFormsApp1
{
    partial class Form1
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
            button1 = new Button();
            checkBoxMostrarCombo = new CheckBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBoxTituloFormulario = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(313, 272);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(130, 51);
            button1.TabIndex = 0;
            button1.Text = "Presionar\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBoxMostrarCombo
            // 
            checkBoxMostrarCombo.AutoSize = true;
            checkBoxMostrarCombo.Checked = true;
            checkBoxMostrarCombo.CheckState = CheckState.Checked;
            checkBoxMostrarCombo.Location = new Point(62, 210);
            checkBoxMostrarCombo.Name = "checkBoxMostrarCombo";
            checkBoxMostrarCombo.Size = new Size(135, 24);
            checkBoxMostrarCombo.TabIndex = 1;
            checkBoxMostrarCombo.Text = "Mostrar Combo";
            checkBoxMostrarCombo.UseVisualStyleBackColor = true;
            checkBoxMostrarCombo.CheckedChanged += checkBoxMostrarCombo_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Opcion 1", "Opcion 2", "Opcion 3" });
            comboBox1.Location = new Point(228, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "-Seleccione una Opción-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 58);
            label1.Name = "label1";
            label1.Size = new Size(213, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el titulo del Formulario";
            // 
            // textBoxTituloFormulario
            // 
            textBoxTituloFormulario.Location = new Point(375, 51);
            textBoxTituloFormulario.Name = "textBoxTituloFormulario";
            textBoxTituloFormulario.Size = new Size(125, 27);
            textBoxTituloFormulario.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(textBoxTituloFormulario);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(checkBoxMostrarCombo);
            Controls.Add(button1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBoxMostrarCombo;
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBoxTituloFormulario;
    }
}