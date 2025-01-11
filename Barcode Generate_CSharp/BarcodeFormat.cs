using System;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Barcode_Generate_CSharp
{
    public partial class BarcodeFormat : UserControl
    {
        public BarcodeFormat()
        {
            InitializeComponent();
            LoadBarcodeFormat();
            LoadFont_andFontsize();
            LoadRotation();
            LoadStretch();
            LoadAlignment();
        }
        // ========================= LOAD DATA IN COMBOBOX/TEXTBOX =========================

        private void LoadBarcodeFormat()
        {
            // Get all BarcodeFormat from Zxing library
            var barcodeFormats = Enum.GetValues(typeof(ZXing.BarcodeFormat)).Cast<object>().ToArray();

            cbx_Fomat.Items.AddRange(barcodeFormats);

            // Choose default BarcodeFormat
            if (cbx_Fomat.Items.Count > 0)
            {
                cbx_Fomat.SelectedIndex = 4;
            }
        }

        private void LoadFont_andFontsize()
        {
            using (InstalledFontCollection fontCollection = new InstalledFontCollection())
            {
                // Get all font families
                FontFamily[] fontFamilies = fontCollection.Families;

                // Add font families to ComboBox
                cbx_Font.Items.AddRange(fontFamilies.Select(f => f.Name).ToArray());

                // Get font size
                for (int i = 8; i <= 72; i += 2)
                {
                    cbx_Fontsize.Items.Add(i);
                }

                // Choose default font
                if (cbx_Font.Items.Count > 0)
                {
                    cbx_Font.SelectedIndex = 0;
                }

                // Choose default font size
                if (cbx_Fontsize.Items.Count > 0)
                {
                    cbx_Fontsize.SelectedIndex = 0;
                }
            }
        }

        private void LoadRotation()
        {
            object[] rotations = { 0, 90, 180, 270 };
            cbx_Rotation.Items.AddRange(rotations);

            if (cbx_Rotation.Items.Count > 0)
            {
                cbx_Rotation.SelectedIndex = 0;
            }
        }

        private void LoadStretch()
        {
            string[] stretches = { "Normal", "Compress", "Expand", "Fill" };
            cbx_Stretch.Items.AddRange(stretches);

            if (cbx_Stretch.Items.Count > 0)
            {
                cbx_Stretch.SelectedIndex = 0;
            }
        }

        private void LoadAlignment()
        {
            cbx_Alignment.Items.Clear();

            string[] alignments = { "Left", "Center", "Right", "Justify" };
            cbx_Alignment.Items.AddRange(alignments);

            if (cbx_Alignment.Items.Count > 0)
            {
                cbx_Alignment.SelectedIndex = 1;
            }
        }
        //==========================END===========================================

        //===================GET VALUE FROM COMBOBOX/TEXTBOX======================
        public string GetText()
        {
            return tbx_TitleInput.Text;
        }

        public ZXing.BarcodeFormat GetBarcodeFormat()
        {
            return (ZXing.BarcodeFormat)cbx_Fomat.SelectedItem;
        }

        public string GetFont()
        {
            return cbx_Font.SelectedItem.ToString();
        }

        public int GetFontSize()
        {
            return (int)cbx_Fontsize.SelectedItem;
        }
        public string GetFontName()
        {
            return cbx_Font.SelectedItem.ToString();
        }

        public int GetRotation()
        {
            return (int)cbx_Rotation.SelectedItem;
        }


        public string GetStretch()
        {
            return cbx_Stretch.SelectedItem.ToString();
        }

        public string GetAlignment()
        {
            return cbx_Alignment.SelectedItem.ToString();
        }

        // Get value of Width, Height
        public (int Width, int Height) GetWidthHeight()
        {
            // Check if value of Width and Height is a number then get value
            if (int.TryParse(tbx_Width.Text, out int width) && int.TryParse(tbx_Height.Text, out int height))
            {
                return (width, height);
            }
            MessageBox.Show("Width or Height is not a valid number.");
            return (0, 0); // Return (0, 0) or other valid values when there is an error
        }


        public int GetHeight()
        {
            return int.Parse(tbx_Height.Text);
        }

        public string GetUnit()
        {
            return rbtn_inch.Checked ? "inch" : "cm";
        }
        //========================END=============================================

    }
}
