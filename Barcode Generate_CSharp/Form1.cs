using System;
using System.Drawing;
using System.Windows.Forms;

namespace Barcode_Generate_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Show User Control PrintSetting in Panel panelPrint
            pnlPrint.Controls.Clear();
            PrintSetting printSetting = new PrintSetting();
            pnlPrint.Controls.Add(printSetting);
            //---------------------------------------------------

            // Show User Control BarcodeFormat in Panel pnlBarcodeFormat
            pnlBarcodeFormat.Controls.Clear();
            BarcodeFormat barcodeFormat = new BarcodeFormat();
            pnlBarcodeFormat.Controls.Add(barcodeFormat);

        }

        private void drdlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnl_Input.Controls.Clear();
            UserControl selectedControl = null;
            if (drdlMode.SelectedIndex == 0)
            {
                selectedControl = new Text_Input();
            }
            else
            {
                selectedControl = new Spreadsheet_Input();
            }

            if (selectedControl != null)
            {
                pnl_Input.Controls.Add(selectedControl);
                int xPos = (pnl_Input.Width - selectedControl.Width) / 2;
                int yPos = (pnl_Input.Height - selectedControl.Height) / 2;

                // Set the UserControl's location to the calculated center position
                selectedControl.Location = new Point(xPos, yPos);
            }

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                // Get value from UserControl Text_Input
                    string text = ((Text_Input)pnl_Input.Controls[0]).GetInputText();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
