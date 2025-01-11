namespace Barcode_Generate_CSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBarcodeFormat = new System.Windows.Forms.Panel();
            this.btnGenerate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnl_Input = new System.Windows.Forms.Panel();
            this.drdlMode = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pnlBarcodeFormat
            // 
            this.pnlBarcodeFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlBarcodeFormat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.pnlBarcodeFormat, 2);
            this.pnlBarcodeFormat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBarcodeFormat.Location = new System.Drawing.Point(3, 352);
            this.pnlBarcodeFormat.Name = "pnlBarcodeFormat";
            this.pnlBarcodeFormat.Size = new System.Drawing.Size(542, 190);
            this.pnlBarcodeFormat.TabIndex = 10;
            // 
            // btnGenerate
            // 
            this.btnGenerate.AllowAnimations = true;
            this.btnGenerate.AllowMouseEffects = true;
            this.btnGenerate.AllowToggling = false;
            this.btnGenerate.AnimationSpeed = 200;
            this.btnGenerate.AutoGenerateColors = false;
            this.btnGenerate.AutoRoundBorders = false;
            this.btnGenerate.AutoSizeLeftIcon = true;
            this.btnGenerate.AutoSizeRightIcon = true;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerate.BackgroundImage")));
            this.btnGenerate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenerate.ButtonText = "GENERATE";
            this.btnGenerate.ButtonTextMarginLeft = 0;
            this.btnGenerate.ColorContrastOnClick = 45;
            this.btnGenerate.ColorContrastOnHover = 45;
            this.tableLayoutPanel1.SetColumnSpan(this.btnGenerate, 2);
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnGenerate.CustomizableEdges = borderEdges1;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerate.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerate.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerate.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnGenerate.IconMarginLeft = 11;
            this.btnGenerate.IconPadding = 10;
            this.btnGenerate.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerate.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnGenerate.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnGenerate.IconSize = 25;
            this.btnGenerate.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.IdleBorderRadius = 4;
            this.btnGenerate.IdleBorderThickness = 1;
            this.btnGenerate.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.IdleIconLeftImage = null;
            this.btnGenerate.IdleIconRightImage = null;
            this.btnGenerate.IndicateFocus = false;
            this.btnGenerate.Location = new System.Drawing.Point(3, 285);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnGenerate.OnDisabledState.BorderRadius = 4;
            this.btnGenerate.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenerate.OnDisabledState.BorderThickness = 1;
            this.btnGenerate.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnGenerate.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnGenerate.OnDisabledState.IconLeftImage = null;
            this.btnGenerate.OnDisabledState.IconRightImage = null;
            this.btnGenerate.onHoverState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerate.onHoverState.BorderRadius = 4;
            this.btnGenerate.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenerate.onHoverState.BorderThickness = 1;
            this.btnGenerate.onHoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnGenerate.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.onHoverState.IconLeftImage = null;
            this.btnGenerate.onHoverState.IconRightImage = null;
            this.btnGenerate.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.OnIdleState.BorderRadius = 4;
            this.btnGenerate.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenerate.OnIdleState.BorderThickness = 1;
            this.btnGenerate.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnIdleState.IconLeftImage = null;
            this.btnGenerate.OnIdleState.IconRightImage = null;
            this.btnGenerate.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerate.OnPressedState.BorderRadius = 4;
            this.btnGenerate.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnGenerate.OnPressedState.BorderThickness = 1;
            this.btnGenerate.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnGenerate.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnPressedState.IconLeftImage = null;
            this.btnGenerate.OnPressedState.IconRightImage = null;
            this.btnGenerate.Size = new System.Drawing.Size(542, 61);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerate.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.TextMarginLeft = 0;
            this.btnGenerate.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnGenerate.UseDefaultRadiusAndThickness = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pnl_Input
            // 
            this.pnl_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Input.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.SetColumnSpan(this.pnl_Input, 2);
            this.pnl_Input.Location = new System.Drawing.Point(3, 38);
            this.pnl_Input.Name = "pnl_Input";
            this.pnl_Input.Size = new System.Drawing.Size(542, 239);
            this.pnl_Input.TabIndex = 9;
            // 
            // drdlMode
            // 
            this.drdlMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.drdlMode.BackColor = System.Drawing.Color.Transparent;
            this.drdlMode.BackgroundColor = System.Drawing.Color.White;
            this.drdlMode.BorderColor = System.Drawing.Color.Silver;
            this.drdlMode.BorderRadius = 3;
            this.drdlMode.Color = System.Drawing.Color.Silver;
            this.drdlMode.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.drdlMode.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drdlMode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.drdlMode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.drdlMode.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.drdlMode.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.drdlMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.drdlMode.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.drdlMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drdlMode.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drdlMode.FillDropDown = true;
            this.drdlMode.FillIndicator = false;
            this.drdlMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drdlMode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.drdlMode.ForeColor = System.Drawing.Color.Black;
            this.drdlMode.FormattingEnabled = true;
            this.drdlMode.Icon = null;
            this.drdlMode.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drdlMode.IndicatorColor = System.Drawing.Color.DarkGray;
            this.drdlMode.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.drdlMode.IndicatorThickness = 2;
            this.drdlMode.IsDropdownOpened = false;
            this.drdlMode.ItemBackColor = System.Drawing.Color.White;
            this.drdlMode.ItemBorderColor = System.Drawing.Color.White;
            this.drdlMode.ItemForeColor = System.Drawing.Color.Black;
            this.drdlMode.ItemHeight = 20;
            this.drdlMode.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.drdlMode.ItemHighLightForeColor = System.Drawing.Color.White;
            this.drdlMode.Items.AddRange(new object[] {
            "Single Line Text",
            "Excel/.txt"});
            this.drdlMode.ItemTopMargin = 3;
            this.drdlMode.Location = new System.Drawing.Point(97, 4);
            this.drdlMode.Name = "drdlMode";
            this.drdlMode.Size = new System.Drawing.Size(154, 26);
            this.drdlMode.TabIndex = 7;
            this.drdlMode.Text = "Single Line Text";
            this.drdlMode.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.drdlMode.TextLeftMargin = 5;
            this.drdlMode.SelectedIndexChanged += new System.EventHandler(this.drdlMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose Mode:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.drdlMode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Input, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBarcodeFormat, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pnlPrint, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1104, 637);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pnlPrint
            // 
            this.pnlPrint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlPrint.Location = new System.Drawing.Point(551, 3);
            this.pnlPrint.Name = "pnlPrint";
            this.tableLayoutPanel1.SetRowSpan(this.pnlPrint, 4);
            this.pnlPrint.Size = new System.Drawing.Size(553, 539);
            this.pnlPrint.TabIndex = 12;
            // 
            // panel5
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
            this.panel5.Location = new System.Drawing.Point(3, 548);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1101, 85);
            this.panel5.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 664);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlBarcodeFormat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown drdlMode;
        private System.Windows.Forms.Panel pnl_Input;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnGenerate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

