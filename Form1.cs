namespace YacoPila
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CenterToScreen(); // Centra el formulario en la pantalla
            this.MaximizeBox = false; // Deshabilita la maximización

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Calcule la posición horizontal para centrar el Label
            int centerX = (this.ClientSize.Width - labelCreator.Width) / 2;

            // Establezca la posición horizontal del Label
            labelCreator.Left = centerX;
        }


        private void BtnView_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario que contiene el DataGridView
            StockPilas newForm = new StockPilas();

            // Mostrar el nuevo formulario
            newForm.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario que contiene el DataGridView
            Form3 newForm = new Form3();

            // Mostrar el nuevo formulario
            newForm.Show();
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario que contiene el DataGridView
            Form4 newForm = new Form4();

            // Mostrar el nuevo formulario
            newForm.Show();
        }


    }
}