using ConsumidorApis.Service;

namespace ConsumidorApis
{
    public partial class Form1 : Form
    {
        private readonly ApiService apiService;

        public Form1()
        {
            InitializeComponent();
            apiService = new ApiService();
        }
        private async void BtnMostrar_Click(object sender, EventArgs e)
        {
            var success = await apiService.LoginAsync("admin", "123");

            if (success)
            {
                MessageBox.Show("Login exitoso!");
                var pokemons = await apiService.GetCarsAsync();
                dataGridView.DataSource = pokemons;
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas");
            }
        }
    }

}
