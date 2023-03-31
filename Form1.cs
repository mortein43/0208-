namespace _0208_шифр_Цезаря
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string abc = "АаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЮюЯяЬь’'?! -АаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЮюЯяЬь’'?! -";        
            string res = "";
            string input = textBox1.Text;
            string inputChoice = textBox2.Text;
            int choice;
            if (inputChoice.Length == 0 || input.Length == 0)
            {
                label5.Text = "Ви ввели некоректні дані.";
                choice = 1;
            } else
            {
                choice = int.Parse(inputChoice);
            }
            
            for (int i = 0; i<input.Length; i++)
            {
                for (int j = 0; j<abc.Length; j++)
                {
                    if (input[i] == abc[j])
                    {
                        char x = abc[j+choice];
                        res = res.Insert(i, x.ToString());
                        break;
                    }
                }
            }
            label1.Text = res;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string abc = "АаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЮюЯяЬь’'?! -АаБбВвГгҐґДдЕеЄєЖжЗзИиІіЇїЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЮюЯяЬь’'?! -";
            string res = "";
            string input = label1.Text;
            string inputChoice = textBox2.Text;
            int choice;
            if (inputChoice.Length == 0 || input.Length == 0)
            {
                label5.Text = "Ви ввели некоректні дані.";
                choice = 1;
            }
            else
            {
                choice = int.Parse(inputChoice);
            }
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = abc.Length-1; j != 0; j--)
                {
                    if (input[i] == abc[j])
                    {
                        char x = abc[j - choice];
                        res = res.Insert(i, x.ToString());
                        break;
                    }
                }
            }
            label2.Text = res;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}