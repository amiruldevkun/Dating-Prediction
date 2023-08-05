using Dating_Prediction;

namespace GuiImplentation
{
    public class Vars {
        public string? t;
    }
    public partial class Form1 : Form
    {
        //readonly string name = Vars.t;
        public Form1(string name)
        {
            InitializeComponent();
            name = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatingMenu Dm = new DatingMenu();

            Dm.Show();
            
           
        }
    }
}