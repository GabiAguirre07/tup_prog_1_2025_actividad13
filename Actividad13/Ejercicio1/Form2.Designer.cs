namespace Ejercicio1
{
    partial class Form2
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
            label1 = new Label();
            tbValor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 169);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 0;
            label1.Text = "Valor:";
            // 
            // tbValor
            // 
            tbValor.Location = new Point(245, 176);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(100, 23);
            tbValor.TabIndex = 1;
            tbValor.TextChanged += tbValor_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(160, 236);
            button1.Name = "button1";
            button1.Size = new Size(107, 40);
            button1.TabIndex = 2;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(312, 236);
            button2.Name = "button2";
            button2.Size = new Size(98, 40);
            button2.TabIndex = 3;
            button2.Text = "Acept";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbValor);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        public TextBox tbValor;
    }
}