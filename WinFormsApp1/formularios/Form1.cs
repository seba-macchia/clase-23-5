namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Formulario cargando...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Text = "Formulario LISTO...";
        }



        private void checkBoxMostrarCombo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMostrarCombo.Checked == true)
            {
                comboBox1.Visible = true;
            }
            else { comboBox1.Visible = false; }
        }
    }
}