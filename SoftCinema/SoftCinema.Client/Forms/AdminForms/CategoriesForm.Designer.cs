﻿namespace SoftCinema.Client.Forms.AdminForms
{
    partial class CategoriesForm
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
            this.CategoriesList = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoriesList
            // 
            this.CategoriesList.DropDownHeight = 100;
            this.CategoriesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoriesList.FormattingEnabled = true;
            this.CategoriesList.IntegralHeight = false;
            this.CategoriesList.Location = new System.Drawing.Point(306, 145);
            this.CategoriesList.Name = "CategoriesList";
            this.CategoriesList.Size = new System.Drawing.Size(393, 39);
            this.CategoriesList.TabIndex = 0;
            this.CategoriesList.SelectedIndexChanged += new System.EventHandler(this.CategoriesList_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryLabel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.CategoryLabel.Location = new System.Drawing.Point(299, 98);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(558, 55);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Select a Category to Edit";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(306, 298);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(302, 38);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back to Admin Menu";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add a New Category";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1038, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CategoriesList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoriesForm";
            this.Text = "CategoriesForm";
            this.Load += new System.EventHandler(this.CategoriesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoriesList;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button1;
    }
}