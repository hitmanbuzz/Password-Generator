namespace PasswordGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pass_length_textbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            symbols_textbox = new TextBox();
            symbol_checkbox = new CheckBox();
            number_checkbox = new CheckBox();
            small_ru_checkbox = new CheckBox();
            captial_ru_checkbox = new CheckBox();
            small_eng_checkbox = new CheckBox();
            capital_eng_checkbox = new CheckBox();
            panel2 = new Panel();
            clear_btn = new Button();
            result_textbox = new RichTextBox();
            generate_btn = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(pass_length_textbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(symbols_textbox);
            panel1.Controls.Add(symbol_checkbox);
            panel1.Controls.Add(number_checkbox);
            panel1.Controls.Add(small_ru_checkbox);
            panel1.Controls.Add(captial_ru_checkbox);
            panel1.Controls.Add(small_eng_checkbox);
            panel1.Controls.Add(capital_eng_checkbox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 326);
            panel1.TabIndex = 0;
            // 
            // pass_length_textbox
            // 
            pass_length_textbox.Location = new Point(6, 250);
            pass_length_textbox.Name = "pass_length_textbox";
            pass_length_textbox.Size = new Size(153, 23);
            pass_length_textbox.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 230);
            label2.Name = "label2";
            label2.Size = new Size(112, 17);
            label2.TabIndex = 8;
            label2.Text = "Password Length";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 276);
            label1.Name = "label1";
            label1.Size = new Size(59, 17);
            label1.TabIndex = 7;
            label1.Text = "Symbols";
            // 
            // symbols_textbox
            // 
            symbols_textbox.Location = new Point(4, 296);
            symbols_textbox.Name = "symbols_textbox";
            symbols_textbox.Size = new Size(153, 23);
            symbols_textbox.TabIndex = 6;
            // 
            // symbol_checkbox
            // 
            symbol_checkbox.AutoSize = true;
            symbol_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            symbol_checkbox.Location = new Point(21, 196);
            symbol_checkbox.Name = "symbol_checkbox";
            symbol_checkbox.Size = new Size(81, 23);
            symbol_checkbox.TabIndex = 5;
            symbol_checkbox.Text = "Symbols";
            symbol_checkbox.UseVisualStyleBackColor = true;
            symbol_checkbox.CheckedChanged += symbol_checkbox_CheckedChanged;
            // 
            // number_checkbox
            // 
            number_checkbox.AutoSize = true;
            number_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            number_checkbox.Location = new Point(21, 158);
            number_checkbox.Name = "number_checkbox";
            number_checkbox.Size = new Size(85, 23);
            number_checkbox.TabIndex = 4;
            number_checkbox.Text = "Numbers";
            number_checkbox.UseVisualStyleBackColor = true;
            // 
            // small_ru_checkbox
            // 
            small_ru_checkbox.AutoSize = true;
            small_ru_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            small_ru_checkbox.Location = new Point(21, 118);
            small_ru_checkbox.Name = "small_ru_checkbox";
            small_ru_checkbox.Size = new Size(115, 23);
            small_ru_checkbox.TabIndex = 3;
            small_ru_checkbox.Text = "Small Russian";
            small_ru_checkbox.UseVisualStyleBackColor = true;
            // 
            // captial_ru_checkbox
            // 
            captial_ru_checkbox.AutoSize = true;
            captial_ru_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            captial_ru_checkbox.Location = new Point(21, 79);
            captial_ru_checkbox.Name = "captial_ru_checkbox";
            captial_ru_checkbox.Size = new Size(124, 23);
            captial_ru_checkbox.TabIndex = 2;
            captial_ru_checkbox.Text = "Capital Russian";
            captial_ru_checkbox.UseVisualStyleBackColor = true;
            // 
            // small_eng_checkbox
            // 
            small_eng_checkbox.AutoSize = true;
            small_eng_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            small_eng_checkbox.Location = new Point(21, 41);
            small_eng_checkbox.Name = "small_eng_checkbox";
            small_eng_checkbox.Size = new Size(112, 23);
            small_eng_checkbox.TabIndex = 1;
            small_eng_checkbox.Text = "Small English";
            small_eng_checkbox.UseVisualStyleBackColor = true;
            // 
            // capital_eng_checkbox
            // 
            capital_eng_checkbox.AutoSize = true;
            capital_eng_checkbox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            capital_eng_checkbox.Location = new Point(21, 3);
            capital_eng_checkbox.Name = "capital_eng_checkbox";
            capital_eng_checkbox.Size = new Size(121, 23);
            capital_eng_checkbox.TabIndex = 0;
            capital_eng_checkbox.Text = "Captial English";
            capital_eng_checkbox.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(clear_btn);
            panel2.Controls.Add(result_textbox);
            panel2.Controls.Add(generate_btn);
            panel2.Location = new Point(207, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 326);
            panel2.TabIndex = 1;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(70, 295);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(75, 23);
            clear_btn.TabIndex = 3;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // result_textbox
            // 
            result_textbox.Location = new Point(3, 3);
            result_textbox.Name = "result_textbox";
            result_textbox.Size = new Size(267, 279);
            result_textbox.TabIndex = 2;
            result_textbox.Text = "";
            // 
            // generate_btn
            // 
            generate_btn.Location = new Point(151, 295);
            generate_btn.Name = "generate_btn";
            generate_btn.Size = new Size(75, 23);
            generate_btn.TabIndex = 1;
            generate_btn.Text = "Generate";
            generate_btn.UseVisualStyleBackColor = true;
            generate_btn.Click += generate_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(492, 350);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CheckBox capital_eng_checkbox;
        private CheckBox symbol_checkbox;
        private CheckBox number_checkbox;
        private CheckBox small_ru_checkbox;
        private CheckBox captial_ru_checkbox;
        private CheckBox small_eng_checkbox;
        private TextBox symbols_textbox;
        private Label label1;
        private Button generate_btn;
        private RichTextBox result_textbox;
        private TextBox pass_length_textbox;
        private Label label2;
        private Button clear_btn;
    }
}