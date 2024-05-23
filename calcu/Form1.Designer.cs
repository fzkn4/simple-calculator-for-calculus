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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            result = new Label();
            input = new Guna.UI2.WinForms.Guna2TextBox();
            calculate = new Guna.UI2.WinForms.Guna2Button();
            statement = new Label();
            valueOfX = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // result
            // 
            result.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Bold, GraphicsUnit.Point);
            result.ForeColor = Color.FromArgb(255, 193, 7);
            result.Location = new Point(18, 67);
            result.Name = "result";
            result.Size = new Size(322, 73);
            result.TabIndex = 0;
            result.Text = "0";
            result.TextAlign = ContentAlignment.BottomRight;
            // 
            // input
            // 
            input.Animated = true;
            input.BorderColor = Color.FromArgb(255, 193, 7);
            input.BorderRadius = 6;
            input.CustomizableEdges = customizableEdges7;
            input.DefaultText = "";
            input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            input.FillColor = Color.FromArgb(52, 58, 64);
            input.FocusedState.BorderColor = Color.FromArgb(255, 193, 7);
            input.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = Color.FromArgb(255, 193, 7);
            input.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            input.Location = new Point(27, 163);
            input.Name = "input";
            input.PasswordChar = '\0';
            input.PlaceholderText = "";
            input.SelectedText = "";
            input.ShadowDecoration.CustomizableEdges = customizableEdges8;
            input.Size = new Size(296, 36);
            input.TabIndex = 1;
            // 
            // calculate
            // 
            calculate.Animated = true;
            calculate.BorderColor = Color.FromArgb(255, 193, 7);
            calculate.BorderRadius = 6;
            calculate.BorderThickness = 1;
            calculate.CustomizableEdges = customizableEdges9;
            calculate.DisabledState.BorderColor = Color.DarkGray;
            calculate.DisabledState.CustomBorderColor = Color.DarkGray;
            calculate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            calculate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            calculate.FillColor = Color.FromArgb(255, 193, 7);
            calculate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            calculate.ForeColor = Color.FromArgb(52, 58, 64);
            calculate.HoverState.BorderColor = Color.FromArgb(255, 193, 7);
            calculate.HoverState.FillColor = Color.FromArgb(52, 58, 64);
            calculate.HoverState.ForeColor = Color.FromArgb(255, 193, 7);
            calculate.Location = new Point(199, 221);
            calculate.Name = "calculate";
            calculate.PressedColor = Color.White;
            calculate.PressedDepth = 20;
            calculate.ShadowDecoration.CustomizableEdges = customizableEdges10;
            calculate.Size = new Size(124, 36);
            calculate.TabIndex = 2;
            calculate.Text = "Calculate";
            calculate.Click += calculate_Click;
            // 
            // statement
            // 
            statement.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point);
            statement.ForeColor = Color.FromArgb(255, 193, 7);
            statement.Location = new Point(119, 29);
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
            valueOfX.CustomizableEdges = customizableEdges11;
            valueOfX.DefaultText = "";
            valueOfX.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            valueOfX.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            valueOfX.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            valueOfX.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            valueOfX.FillColor = Color.FromArgb(52, 58, 64);
            valueOfX.FocusedState.BorderColor = Color.FromArgb(255, 193, 7);
            valueOfX.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            valueOfX.ForeColor = Color.FromArgb(255, 193, 7);
            valueOfX.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            valueOfX.Location = new Point(27, 221);
            valueOfX.Name = "valueOfX";
            valueOfX.PasswordChar = '\0';
            valueOfX.PlaceholderText = "";
            valueOfX.SelectedText = "";
            valueOfX.ShadowDecoration.CustomizableEdges = customizableEdges12;
            valueOfX.Size = new Size(148, 36);
            valueOfX.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 193, 7);
            label1.Location = new Point(39, 155);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Input ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft New Tai Lue", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(255, 193, 7);
            label3.Location = new Point(39, 213);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 6;
            label3.Text = "X value";
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft New Tai Lue", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(255, 193, 7);
            label4.Location = new Point(27, 23);
            label4.Name = "label4";
            label4.Size = new Size(57, 53);
            label4.TabIndex = 7;
            label4.Text = "f(x)";
            label4.TextAlign = ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(52, 58, 64);
            ClientSize = new Size(352, 288);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(valueOfX);
            Controls.Add(statement);
            Controls.Add(calculate);
            Controls.Add(input);
            Controls.Add(result);
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
    }
}
