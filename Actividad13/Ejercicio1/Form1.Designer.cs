﻿namespace Ejercicio1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(283, 77);
            button1.Name = "button1";
            button1.Size = new Size(117, 65);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Nro Lote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(242, 183);
            button2.Name = "button2";
            button2.Size = new Size(195, 61);
            button2.TabIndex = 1;
            button2.Text = "Agregar Medida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(270, 292);
            button3.Name = "button3";
            button3.Size = new Size(154, 69);
            button3.TabIndex = 2;
            button3.Text = "Ver todas las medidas";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
    }
}
