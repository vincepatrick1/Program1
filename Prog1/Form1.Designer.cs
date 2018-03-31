namespace Prog1
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
            this.sqFtLabel = new System.Windows.Forms.Label();
            this.coatsLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.totalSqFtLabel = new System.Windows.Forms.Label();
            this.gallonsLabel = new System.Windows.Forms.Label();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.paintCostLabel = new System.Windows.Forms.Label();
            this.laborCostLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.squareFtTextBox = new System.Windows.Forms.TextBox();
            this.coatsTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.sqFtTotalLabel = new System.Windows.Forms.Label();
            this.gallonsUsedLabel = new System.Windows.Forms.Label();
            this.laborHrsLabel = new System.Windows.Forms.Label();
            this.costPaintLabel = new System.Windows.Forms.Label();
            this.costLaborLabel = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sqFtLabel
            // 
            this.sqFtLabel.AutoSize = true;
            this.sqFtLabel.Location = new System.Drawing.Point(115, 26);
            this.sqFtLabel.Name = "sqFtLabel";
            this.sqFtLabel.Size = new System.Drawing.Size(68, 13);
            this.sqFtLabel.TabIndex = 0;
            this.sqFtLabel.Text = "Sqaure Feet:";
            // 
            // coatsLabel
            // 
            this.coatsLabel.AutoSize = true;
            this.coatsLabel.Location = new System.Drawing.Point(97, 61);
            this.coatsLabel.Name = "coatsLabel";
            this.coatsLabel.Size = new System.Drawing.Size(89, 13);
            this.coatsLabel.TabIndex = 1;
            this.coatsLabel.Text = "Number of Coats:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(101, 99);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(82, 13);
            this.costLabel.TabIndex = 2;
            this.costLabel.Text = "Cost per Gallon:";
            // 
            // totalSqFtLabel
            // 
            this.totalSqFtLabel.AutoSize = true;
            this.totalSqFtLabel.Location = new System.Drawing.Point(-1, 191);
            this.totalSqFtLabel.Name = "totalSqFtLabel";
            this.totalSqFtLabel.Size = new System.Drawing.Size(95, 13);
            this.totalSqFtLabel.TabIndex = 3;
            this.totalSqFtLabel.Text = "Total Sqaure Feet:";
            // 
            // gallonsLabel
            // 
            this.gallonsLabel.AutoSize = true;
            this.gallonsLabel.Location = new System.Drawing.Point(238, 191);
            this.gallonsLabel.Name = "gallonsLabel";
            this.gallonsLabel.Size = new System.Drawing.Size(45, 13);
            this.gallonsLabel.TabIndex = 4;
            this.gallonsLabel.Text = "Gallons:";
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(14, 236);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(80, 13);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "Hours of Labor:";
            // 
            // paintCostLabel
            // 
            this.paintCostLabel.AutoSize = true;
            this.paintCostLabel.Location = new System.Drawing.Point(213, 237);
            this.paintCostLabel.Name = "paintCostLabel";
            this.paintCostLabel.Size = new System.Drawing.Size(70, 13);
            this.paintCostLabel.TabIndex = 6;
            this.paintCostLabel.Text = "Cost of Paint:";
            // 
            // laborCostLabel
            // 
            this.laborCostLabel.AutoSize = true;
            this.laborCostLabel.Location = new System.Drawing.Point(21, 281);
            this.laborCostLabel.Name = "laborCostLabel";
            this.laborCostLabel.Size = new System.Drawing.Size(73, 13);
            this.laborCostLabel.TabIndex = 7;
            this.laborCostLabel.Text = "Cost of Labor:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(225, 282);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(58, 13);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total Cost:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(171, 138);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 36);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // squareFtTextBox
            // 
            this.squareFtTextBox.Location = new System.Drawing.Point(192, 23);
            this.squareFtTextBox.Name = "squareFtTextBox";
            this.squareFtTextBox.Size = new System.Drawing.Size(100, 20);
            this.squareFtTextBox.TabIndex = 10;
            // 
            // coatsTextBox
            // 
            this.coatsTextBox.Location = new System.Drawing.Point(192, 58);
            this.coatsTextBox.Name = "coatsTextBox";
            this.coatsTextBox.Size = new System.Drawing.Size(100, 20);
            this.coatsTextBox.TabIndex = 11;
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(192, 96);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(100, 20);
            this.costTextBox.TabIndex = 12;
            // 
            // sqFtTotalLabel
            // 
            this.sqFtTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqFtTotalLabel.Location = new System.Drawing.Point(100, 190);
            this.sqFtTotalLabel.Name = "sqFtTotalLabel";
            this.sqFtTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.sqFtTotalLabel.TabIndex = 13;
            // 
            // gallonsUsedLabel
            // 
            this.gallonsUsedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gallonsUsedLabel.Location = new System.Drawing.Point(289, 188);
            this.gallonsUsedLabel.Name = "gallonsUsedLabel";
            this.gallonsUsedLabel.Size = new System.Drawing.Size(100, 25);
            this.gallonsUsedLabel.TabIndex = 14;
            // 
            // laborHrsLabel
            // 
            this.laborHrsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laborHrsLabel.Location = new System.Drawing.Point(100, 235);
            this.laborHrsLabel.Name = "laborHrsLabel";
            this.laborHrsLabel.Size = new System.Drawing.Size(100, 23);
            this.laborHrsLabel.TabIndex = 15;
            // 
            // costPaintLabel
            // 
            this.costPaintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPaintLabel.Location = new System.Drawing.Point(289, 236);
            this.costPaintLabel.Name = "costPaintLabel";
            this.costPaintLabel.Size = new System.Drawing.Size(100, 23);
            this.costPaintLabel.TabIndex = 16;
            // 
            // costLaborLabel
            // 
            this.costLaborLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costLaborLabel.Location = new System.Drawing.Point(100, 280);
            this.costLaborLabel.Name = "costLaborLabel";
            this.costLaborLabel.Size = new System.Drawing.Size(100, 23);
            this.costLaborLabel.TabIndex = 17;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostLabel.Location = new System.Drawing.Point(289, 281);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(100, 23);
            this.totalCostLabel.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 331);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.costLaborLabel);
            this.Controls.Add(this.costPaintLabel);
            this.Controls.Add(this.laborHrsLabel);
            this.Controls.Add(this.gallonsUsedLabel);
            this.Controls.Add(this.sqFtTotalLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.coatsTextBox);
            this.Controls.Add(this.squareFtTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.laborCostLabel);
            this.Controls.Add(this.paintCostLabel);
            this.Controls.Add(this.hoursLabel);
            this.Controls.Add(this.gallonsLabel);
            this.Controls.Add(this.totalSqFtLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.coatsLabel);
            this.Controls.Add(this.sqFtLabel);
            this.Name = "Form1";
            this.Text = "Program 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sqFtLabel;
        private System.Windows.Forms.Label coatsLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label totalSqFtLabel;
        private System.Windows.Forms.Label gallonsLabel;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label paintCostLabel;
        private System.Windows.Forms.Label laborCostLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox squareFtTextBox;
        private System.Windows.Forms.TextBox coatsTextBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label sqFtTotalLabel;
        private System.Windows.Forms.Label gallonsUsedLabel;
        private System.Windows.Forms.Label laborHrsLabel;
        private System.Windows.Forms.Label costPaintLabel;
        private System.Windows.Forms.Label costLaborLabel;
        private System.Windows.Forms.Label totalCostLabel;
    }
}

