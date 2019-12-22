namespace InterfaceInfoSelect
{
    partial class New_Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Form0));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Picture_By_ID = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(750, 401);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Picture_By_ID
            // 
            this.Picture_By_ID.Location = new System.Drawing.Point(185, 422);
            this.Picture_By_ID.Name = "Picture_By_ID";
            this.Picture_By_ID.Size = new System.Drawing.Size(96, 23);
            this.Picture_By_ID.TabIndex = 1;
            this.Picture_By_ID.Text = "Show Picture";
            this.Picture_By_ID.UseVisualStyleBackColor = true;
            this.Picture_By_ID.Click += new System.EventHandler(this.Picture_By_ID_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // ID_Box
            // 
            this.ID_Box.Location = new System.Drawing.Point(53, 424);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.Size = new System.Drawing.Size(100, 20);
            this.ID_Box.TabIndex = 3;
            // 
            // New_Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(776, 457);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Picture_By_ID);
            this.Controls.Add(this.richTextBox1);
            this.Name = "New_Form0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Form0";
            this.Load += new System.EventHandler(this.New_Form0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Picture_By_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID_Box;
    }
}