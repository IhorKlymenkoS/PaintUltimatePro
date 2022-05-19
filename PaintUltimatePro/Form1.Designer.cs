
namespace PaintUltimatePro
{
    partial class PaintUltimatePro
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Brush = new System.Windows.Forms.Label();
            this.Colour = new System.Windows.Forms.Label();
            this.brushBox = new System.Windows.Forms.ComboBox();
            this.colourBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(527, 450);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp_22);
            // 
            // Brush
            // 
            this.Brush.AutoSize = true;
            this.Brush.Location = new System.Drawing.Point(571, 34);
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(34, 13);
            this.Brush.TabIndex = 1;
            this.Brush.Text = "Brush";
            this.Brush.Click += new System.EventHandler(this.label1_Click);
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(571, 86);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(37, 13);
            this.Colour.TabIndex = 2;
            this.Colour.Text = "Colour";
            this.Colour.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // brushBox
            // 
            this.brushBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brushBox.FormattingEnabled = true;
            this.brushBox.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.brushBox.Location = new System.Drawing.Point(574, 50);
            this.brushBox.Name = "brushBox";
            this.brushBox.Size = new System.Drawing.Size(121, 21);
            this.brushBox.TabIndex = 3;
            this.brushBox.SelectedIndexChanged += new System.EventHandler(this.brushBox_SelectedIndexChanged);
            // 
            // colourBox
            // 
            this.colourBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colourBox.FormattingEnabled = true;
            this.colourBox.Items.AddRange(new object[] {
            "Black",
            "Red",
            "Blue"});
            this.colourBox.Location = new System.Drawing.Point(574, 102);
            this.colourBox.Name = "colourBox";
            this.colourBox.Size = new System.Drawing.Size(121, 21);
            this.colourBox.TabIndex = 4;
            // 
            // PaintUltimatePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colourBox);
            this.Controls.Add(this.brushBox);
            this.Controls.Add(this.Colour);
            this.Controls.Add(this.Brush);
            this.Controls.Add(this.pictureBox);
            this.Name = "PaintUltimatePro";
            this.Text = "PaintUltimatePro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label Brush;
        private System.Windows.Forms.Label Colour;
        private System.Windows.Forms.ComboBox brushBox;
        private System.Windows.Forms.ComboBox colourBox;
    }
}

