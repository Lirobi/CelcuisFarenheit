namespace CelcuisFarenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtCelcius_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFarenheit_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRaz_Click(object sender, EventArgs e)
        {
            txtCelcius.Text = "0";
            txtFarenheit.Text = "32";
        }

        private void rdbCelcuisVersFarenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCelcuisVersFarenheit.Checked == true)
            {
                if (txtCelcius.Text != String.Empty)
                {
                    txtFarenheit.Text = ((double.Parse(txtCelcius.Text) * 1.8) + 32).ToString();
                }
                else
                {
                    MessageBox.Show("Aucune température n'est renseignée dans la case Degrés Celcius");
                }
            }

                
        }

        private void rdbFarenheitVersCelcius_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbFarenheitVersCelcius.Checked == true)
            {
                if (txtFarenheit.Text != String.Empty)
                {
                    txtCelcius.Text = ((double.Parse(txtFarenheit.Text) - 32) * (9 / 5)).ToString();
                }
                else
                {
                    MessageBox.Show("Aucune température n'est renseignée dans la case Degrés Farenheit");
                }
            }
                
        }

        private void txtCelcius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtFarenheit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }
    }
}