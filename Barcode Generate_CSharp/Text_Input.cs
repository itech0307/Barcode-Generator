using System.ComponentModel;
using System.Windows.Forms;

namespace Barcode_Generate_CSharp
{
    public partial class Text_Input : UserControl
    {
        public Text_Input()
        {
            InitializeComponent();
        }

        private void tbx_Input_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_Input.Text))
            {
                e.Cancel = true;
                tbx_Input.Focus();
                // create a ToolTip and associate it with the Form container.
                ToolTip tt = new ToolTip();
                // Set up the ToolTip text for the Button and Checkbox.
                tt.SetToolTip(tbx_Input, "Please enter the text");
                tbx_Input.BorderColorDisabled = System.Drawing.Color.Red;

            }
        }

        // when type in the textbox, border tbx_Input will be changed to blue
        private void tbx_Input_TextChanged(object sender, System.EventArgs e)
        {
            tbx_Input.BorderColorDisabled = System.Drawing.Color.Blue;
        }

        // Get value from textbox
        public string GetInputText()
        {
            return tbx_Input.Text;
        }

    }

}
