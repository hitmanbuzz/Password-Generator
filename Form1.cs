using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string capital_eng = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string small_eng = "abcdefghijklmnopqrstuvwxyz";
        const string capital_ru = "АБЦДЕФГЧИЙКЛМНОПЯРСТУВШХЫЗ";
        const string small_ru = "абцдефгчийклмнопярстувшхыз";
        const string number = "123456789";
        const string symbols = ";!#$%&'()*+,-./:;<=>@[]^_`{}~";

        private void generate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Password_Generator(Convert.ToInt32(pass_length_textbox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void symbol_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (symbol_checkbox.Checked)
            {
                MessageBox.Show("Symbol Checkbox have been checked");
                symbols_textbox.Text = symbols.ToString();
            }
        }

        public void Password_Generator(int pass_len)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder final_result = new StringBuilder();
            Random rand = new Random();
            for (int i = 0; i < pass_len; i++)
            {
                if (capital_eng_checkbox.Checked)
                {
                    result.Append(capital_eng[rand.Next(capital_eng.Length)]);
                }
                if (small_eng_checkbox.Checked)
                {
                    result.Append(small_eng[rand.Next(capital_eng.Length)]);
                }
                if (captial_ru_checkbox.Checked)
                {
                    result.Append(capital_ru[rand.Next(capital_eng.Length)]);
                }
                if (small_ru_checkbox.Checked)
                {
                    result.Append(small_ru[rand.Next(capital_eng.Length)]);
                }
                if (number_checkbox.Checked)
                {
                    result.Append(number[rand.Next(number.Length)]);
                }
                if (symbol_checkbox.Checked)
                {
                    result.Append(symbols_textbox.Text[rand.Next(symbols_textbox.Text.Length)]);
                }
                final_result.Append(result.ToString()[rand.Next(result.ToString().Length)]);
                result_textbox.Text = final_result.ToString();
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            result_textbox.Clear();
        }
    }
}