namespace WindowsFormsApp1
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
            this.Go_Check = new System.Windows.Forms.Button();
            this.Grab_Path = new System.Windows.Forms.TextBox();
            this.Read_Image = new System.Windows.Forms.PictureBox();
            this.Found_dog = new System.Windows.Forms.CheckBox();
            this.Found_cat = new System.Windows.Forms.CheckBox();
            this.Found_bird = new System.Windows.Forms.CheckBox();
            this.Output_Label = new System.Windows.Forms.Label();
            this.View_output = new System.Windows.Forms.Label();
            this.Check_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Read_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Go_Check
            // 
            this.Go_Check.Location = new System.Drawing.Point(330, 38);
            this.Go_Check.Name = "Go_Check";
            this.Go_Check.Size = new System.Drawing.Size(75, 23);
            this.Go_Check.TabIndex = 0;
            this.Go_Check.Text = "Path";
            this.Go_Check.UseVisualStyleBackColor = true;
            this.Go_Check.Click += new System.EventHandler(this.Go_Check_Click);
            // 
            // Grab_Path
            // 
            this.Grab_Path.Location = new System.Drawing.Point(32, 39);
            this.Grab_Path.Name = "Grab_Path";
            this.Grab_Path.Size = new System.Drawing.Size(279, 20);
            this.Grab_Path.TabIndex = 1;
            this.Grab_Path.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // Read_Image
            // 
            this.Read_Image.Location = new System.Drawing.Point(32, 76);
            this.Read_Image.Name = "Read_Image";
            this.Read_Image.Size = new System.Drawing.Size(279, 140);
            this.Read_Image.TabIndex = 2;
            this.Read_Image.TabStop = false;
            // 
            // Found_dog
            // 
            this.Found_dog.AutoSize = true;
            this.Found_dog.Location = new System.Drawing.Point(346, 109);
            this.Found_dog.Name = "Found_dog";
            this.Found_dog.Size = new System.Drawing.Size(79, 17);
            this.Found_dog.TabIndex = 3;
            this.Found_dog.Text = "Found Dog";
            this.Found_dog.UseVisualStyleBackColor = true;
            this.Found_dog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Found_cat
            // 
            this.Found_cat.AutoSize = true;
            this.Found_cat.Location = new System.Drawing.Point(346, 133);
            this.Found_cat.Name = "Found_cat";
            this.Found_cat.Size = new System.Drawing.Size(75, 17);
            this.Found_cat.TabIndex = 4;
            this.Found_cat.Text = "Found Cat";
            this.Found_cat.UseVisualStyleBackColor = true;
            // 
            // Found_bird
            // 
            this.Found_bird.AutoSize = true;
            this.Found_bird.Location = new System.Drawing.Point(346, 157);
            this.Found_bird.Name = "Found_bird";
            this.Found_bird.Size = new System.Drawing.Size(77, 17);
            this.Found_bird.TabIndex = 5;
            this.Found_bird.Text = "Found Bird";
            this.Found_bird.UseVisualStyleBackColor = true;
            this.Found_bird.CheckedChanged += new System.EventHandler(this.Found_bird_CheckedChanged);
            // 
            // Output_Label
            // 
            this.Output_Label.AutoSize = true;
            this.Output_Label.Location = new System.Drawing.Point(147, 229);
            this.Output_Label.Name = "Output_Label";
            this.Output_Label.Size = new System.Drawing.Size(39, 13);
            this.Output_Label.TabIndex = 7;
            this.Output_Label.Text = "Output";
            this.Output_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // View_output
            // 
            this.View_output.AutoSize = true;
            this.View_output.Location = new System.Drawing.Point(100, 254);
            this.View_output.Name = "View_output";
            this.View_output.Size = new System.Drawing.Size(139, 13);
            this.View_output.TabIndex = 8;
            this.View_output.Text = "WATCH ME FOR OUTPUT\r\n";
            this.View_output.Click += new System.EventHandler(this.View_output_Click);
            // 
            // Check_button
            // 
            this.Check_button.Location = new System.Drawing.Point(330, 244);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(75, 23);
            this.Check_button.TabIndex = 9;
            this.Check_button.Text = "Check";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the file path of a picture you want to analyze";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(507, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.View_output);
            this.Controls.Add(this.Output_Label);
            this.Controls.Add(this.Found_bird);
            this.Controls.Add(this.Found_cat);
            this.Controls.Add(this.Found_dog);
            this.Controls.Add(this.Read_Image);
            this.Controls.Add(this.Grab_Path);
            this.Controls.Add(this.Go_Check);
            this.Name = "Form1";
            this.Text = "Animal Identifier";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Read_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Go_Check;
        private System.Windows.Forms.TextBox Grab_Path;
        private System.Windows.Forms.PictureBox Read_Image;
        private System.Windows.Forms.CheckBox Found_dog;
        private System.Windows.Forms.CheckBox Found_cat;
        private System.Windows.Forms.CheckBox Found_bird;
        private System.Windows.Forms.Label Output_Label;
        private System.Windows.Forms.Label View_output;
        private System.Windows.Forms.Button Check_button;
        private System.Windows.Forms.Label label1;
    }
}

