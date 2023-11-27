
namespace Area_of_Circle
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
            this.radius = new System.Windows.Forms.TextBox();
            this.diameter = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.area = new System.Windows.Forms.Button();
            this.areatotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.Location = new System.Drawing.Point(313, 130);
            this.radius.Multiline = true;
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(100, 40);
            this.radius.TabIndex = 0;
            // 
            // diameter
            // 
            this.diameter.Location = new System.Drawing.Point(675, 283);
            this.diameter.Multiline = true;
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(100, 40);
            this.diameter.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(21, 253);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(128, 57);
            this.area.TabIndex = 3;
            this.area.Text = "AREA";
            this.area.UseVisualStyleBackColor = true;
            this.area.Click += new System.EventHandler(this.Area_Click);
            // 
            // areatotal
            // 
            this.areatotal.Location = new System.Drawing.Point(155, 253);
            this.areatotal.Multiline = true;
            this.areatotal.Name = "areatotal";
            this.areatotal.Size = new System.Drawing.Size(109, 57);
            this.areatotal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.areatotal);
            this.Controls.Add(this.area);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.radius);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.TextBox diameter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button area;
        private System.Windows.Forms.TextBox areatotal;
    }
}

