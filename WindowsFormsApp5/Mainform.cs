using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp5
{
    public partial class MainForm : Form
    {
        readonly int[] _vatVerifyArray = { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 }; //Ten metód daje paramtry dla obliczenia

        const int DevideNumber = 10; //staly dzielnik

        /// <code>
        /// Metód dła wyliczenia kontrolnej liczby
        /// </sumowanie>
        /// <param name="vat">pesel</param>
        /// <znaczenieobliczenia></mnoznik>
        private int CalculateArray(string vat) 
        {
            int result = 0;

            for (int i = 0; i < _vatVerifyArray.Length; i++)
            {
                int number = (int)char.GetNumericValue(vat[i]);
                result += _vatVerifyArray[i] * number;
            }

            return result;
        }

        /// nadanie danych z innego elementu
        /// <param name="vat"></reszta_dzielenia>
        /// <sprawdzenie_liczby_koncowej></cyfra_kontrolna>
        private bool VerifyVat(string vat)
        {
            int controlNumber = CalculateArray(vat);

            int controlNumberDividedByTen = controlNumber % DevideNumber;

            return controlNumberDividedByTen == (int)char.GetNumericValue(vat[vat.Length - 1]);
        }

        private Timer timer;
        private SplashScreen splash;

        public MainForm()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            this.Visible = false;

            splash = new SplashScreen();
            splash.Show();
            splash.Closed += Splash_Closed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Splash_Closed(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            this.Visible = true;
        }


        /// dobra
        /// "zla" waryfikacja
        /// usuniencie informacji z pola
       
        private void textBoxVAT_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVAT.TextLength == 11)
            {
                if (VerifyVat(textBoxVAT.Text))
                {
                    lblResult.Text = @"Verify";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = @"Not Verify";
                    lblResult.ForeColor = Color.Red;
                }

                btnClear.Focus();
            }
        }


        // ograniczenie dla tego,zebys mozna bylo uzywac tylko liczby.
        private void textBoxVAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
        //fokusowanie na klawisze clear po sprawdzeniu pesel.
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            textBoxVAT.Clear();
            textBoxVAT.Focus();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            lblResult.Text = "";
            textBoxVAT.Focus();
        }
    }
}
