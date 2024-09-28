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


        }

        private void drdlMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            System.Windows.Forms.UserControl selectedControl = null;
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
                panel1.Controls.Add(selectedControl);
                int xPos = (panel1.Width - selectedControl.Width) / 2;
                int yPos = (panel1.Height - selectedControl.Height) / 2;

                // Set the UserControl's location to the calculated center position
                selectedControl.Location = new Point(xPos, yPos);
            }

        }

    }
}
