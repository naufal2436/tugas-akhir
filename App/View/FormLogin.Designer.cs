﻿namespace TanamAja.App.View
{
    partial class formLogin
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
            panel1 = new Panel();
            tempatLogin = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Logo_TanamAja;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(590, 1033);
            panel1.TabIndex = 0;
            // 
            // tempatLogin
            // 
            tempatLogin.Dock = DockStyle.Right;
            tempatLogin.Location = new Point(596, 0);
            tempatLogin.Name = "tempatLogin";
            tempatLogin.Size = new Size(1306, 1033);
            tempatLogin.TabIndex = 1;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(tempatLogin);
            Controls.Add(panel1);
            Name = "formLogin";
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel tempatLogin;
    }
}