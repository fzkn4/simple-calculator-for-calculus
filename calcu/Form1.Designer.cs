namespace calcu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            result = new Label();
            input = new Guna.UI2.WinForms.Guna2TextBox();
            calculate = new Guna.UI2.WinForms.Guna2Button();
            statement = new Label();
            valueOfX = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            copy_to_clipboard = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // result
            // 
            result.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = Color.FromArgb(255, 193, 7);
            result.Location = new Point(27, 67);
            result.Name = "result";
            result.Size = new Size(306, 73);
            result.TabIndex = 0;
            result.Text = "0";
            result.TextAlign = ContentAlignment.BottomRight;
            // 
            // input
            // 
            input.Animated = true;
            input.BorderColor = Color.FromArgb(255, 193, 7);
            input.BorderRadius = 6;
            input.BorderThickness = 2;
            input.CustomizableEdges = customizableEdges1;
            input.DefaultText = "";
            input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            input.FillColor = Color.FromArgb(52, 58, 64);
            input.FocusedState.BorderColor = Color.IndianRed;
            input.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = Color.FromArgb(255, 193, 7);
            input.HoverState.BorderColor = Color.IndianRed;
            input.Location = new Point(27, 163);
            input.Name = "input";
            input.PasswordChar = '\0';
            input.PlaceholderText = "";
            input.SelectedText = "";
            input.ShadowDecoration.CustomizableEdges = customizableEdges2;
            input.Size = new Size(331, 36);
            input.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.Animated = true;
            calculate.BorderColor = Color.FromArgb(255, 193, 7);
            calculate.BorderRadius = 6;
            calculate.BorderThickness = 2;
            calculate.CustomizableEdges = customizableEdges3;
            calculate.DisabledState.BorderColor = Color.DarkGray;
            calculate.DisabledState.CustomBorderColor = Color.DarkGray;
            calculate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            calculate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            calculate.FillColor = Color.FromArgb(255, 193, 7);
            calculate.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point);
            calculate.ForeColor = Color.FromArgb(52, 58, 64);
            calculate.HoverState.BorderColor = Color.FromArgb(255, 193, 7);
            calculate.HoverState.FillColor = Color.FromArgb(52, 58, 64);
            calculate.HoverState.ForeColor = Color.FromArgb(255, 193, 7);
            calculate.Location = new Point(199, 221);
            calculate.Name = "calculate";
            calculate.PressedColor = Color.White;
            calculate.PressedDepth = 20;
            calculate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            calculate.Size = new Size(159, 36);
            calculate.TabIndex = 2;
            calculate.Text = "Calculate";
            calculate.Click += calculate_Click;
            // 
            // statement
            // 
            statement.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point);
            statement.ForeColor = Color.FromArgb(255, 193, 7);
            statement.Location = new Point(108, 29);
            statement.Name = "statement";
            statement.Size = new Size(221, 53);
            statement.TabIndex = 3;
            statement.Text = "0";
            statement.TextAlign = ContentAlignment.BottomRight;
            // 
            // valueOfX
            // 
            valueOfX.Animated = true;
            valueOfX.BorderColor = Color.FromArgb(255, 193, 7);
            valueOfX.BorderRadius = 6;
            valueOfX.BorderThickness = 2;
            valueOfX.CustomizableEdges = customizableEdges5;
            valueOfX.DefaultText = "";
            valueOfX.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            valueOfX.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            valueOfX.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            valueOfX.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            valueOfX.FillColor = Color.FromArgb(52, 58, 64);
            valueOfX.FocusedState.BorderColor = Color.IndianRed;
            valueOfX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            valueOfX.ForeColor = Color.FromArgb(255, 193, 7);
            valueOfX.HoverState.BorderColor = Color.IndianRed;
            valueOfX.Location = new Point(27, 221);
            valueOfX.Name = "valueOfX";
            valueOfX.PasswordChar = '\0';
            valueOfX.PlaceholderText = "";
            valueOfX.SelectedText = "";
            valueOfX.ShadowDecoration.CustomizableEdges = customizableEdges6;
            valueOfX.Size = new Size(148, 36);
            valueOfX.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Location = new Point(39, 155);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 5;
            label1.Text = "Input ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 193, 7);
            label3.Location = new Point(39, 213);
            label3.Name = "label3";
            label3.Size = new Size(49, 17);
            label3.TabIndex = 6;
            label3.Text = "X value";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 193, 7);
            label4.Location = new Point(19, 23);
            label4.Name = "label4";
            label4.Size = new Size(57, 53);
            label4.TabIndex = 7;
            label4.Text = "f(x)";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // copy_to_clipboard
            // 
            copy_to_clipboard.Animated = true;
            copy_to_clipboard.BorderColor = Color.Empty;
            copy_to_clipboard.BorderRadius = 6;
            copy_to_clipboard.BorderThickness = 1;
            copy_to_clipboard.CustomizableEdges = customizableEdges7;
            copy_to_clipboard.DisabledState.BorderColor = Color.FromArgb(52, 58, 64);
            copy_to_clipboard.DisabledState.FillColor = Color.FromArgb(52, 58, 64);
            copy_to_clipboard.DisabledState.Image = (Image)resources.GetObject("resource.Image");
            copy_to_clipboard.FillColor = Color.FromArgb(52, 58, 64);
            copy_to_clipboard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            copy_to_clipboard.ForeColor = Color.FromArgb(52, 58, 64);
            copy_to_clipboard.HoverState.FillColor = Color.FromArgb(52, 58, 64);
            copy_to_clipboard.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            copy_to_clipboard.Image = (Image)resources.GetObject("copy_to_clipboard.Image");
            copy_to_clipboard.ImageSize = new Size(16, 16);
            copy_to_clipboard.Location = new Point(334, 52);
            copy_to_clipboard.Name = "copy_to_clipboard";
            copy_to_clipboard.PressedColor = Color.White;
            copy_to_clipboard.PressedDepth = 20;
            copy_to_clipboard.ShadowDecoration.CustomizableEdges = customizableEdges8;
            copy_to_clipboard.Size = new Size(23, 28);
            copy_to_clipboard.TabIndex = 8;
            copy_to_clipboard.Click += copy_to_clipboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(387, 288);
            Controls.Add(copy_to_clipboard);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(valueOfX);
            Controls.Add(statement);
            Controls.Add(calculate);
            Controls.Add(input);
            Controls.Add(result);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcushit ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label result;
        private Guna.UI2.WinForms.Guna2TextBox input;
        private Guna.UI2.WinForms.Guna2Button calculate;
        private Label statement;
        private Guna.UI2.WinForms.Guna2TextBox valueOfX;
        private Label label1;
        private Label label3;
        private Label label4;
        private Guna.UI2.WinForms.Guna2Button copy_to_clipboard;
    }
}
