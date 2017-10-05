namespace GuipsSheet
{
    partial class CharacterSheetHelper
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
            this.saveButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.strengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dexterityUpDown = new System.Windows.Forms.NumericUpDown();
            this.intelligenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.strengthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(85, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(94, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            this.nameInput.Tag = "sometag";
            this.nameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(19, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // strengthUpDown
            // 
            this.strengthUpDown.Location = new System.Drawing.Point(94, 73);
            this.strengthUpDown.Name = "strengthUpDown";
            this.strengthUpDown.Size = new System.Drawing.Size(120, 20);
            this.strengthUpDown.TabIndex = 3;
            this.strengthUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.strengthUpDown.ValueChanged += new System.EventHandler(this.strengthUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Strength";
            // 
            // dexterityUpDown
            // 
            this.dexterityUpDown.Location = new System.Drawing.Point(94, 99);
            this.dexterityUpDown.Name = "dexterityUpDown";
            this.dexterityUpDown.Size = new System.Drawing.Size(120, 20);
            this.dexterityUpDown.TabIndex = 5;
            this.dexterityUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.dexterityUpDown.ValueChanged += new System.EventHandler(this.dexterityUpDown_ValueChanged);
            // 
            // intelligenceUpDown
            // 
            this.intelligenceUpDown.Location = new System.Drawing.Point(94, 125);
            this.intelligenceUpDown.Name = "intelligenceUpDown";
            this.intelligenceUpDown.Size = new System.Drawing.Size(120, 20);
            this.intelligenceUpDown.TabIndex = 6;
            this.intelligenceUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intelligenceUpDown.ValueChanged += new System.EventHandler(this.intelligenceUpDown_ValueChanged);
            // 
            // healthUpDown
            // 
            this.healthUpDown.Location = new System.Drawing.Point(94, 151);
            this.healthUpDown.Name = "healthUpDown";
            this.healthUpDown.Size = new System.Drawing.Size(120, 20);
            this.healthUpDown.TabIndex = 7;
            this.healthUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.healthUpDown.ValueChanged += new System.EventHandler(this.healthUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Intelligence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Health";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total attribute points: 50";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Attribute points remaining: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CharacterSheetHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.healthUpDown);
            this.Controls.Add(this.intelligenceUpDown);
            this.Controls.Add(this.dexterityUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.strengthUpDown);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.saveButton);
            this.Name = "CharacterSheetHelper";
            this.Text = "Gurps Character Sheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.strengthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexterityUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intelligenceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown strengthUpDown;
        private System.Windows.Forms.NumericUpDown dexterityUpDown;
        private System.Windows.Forms.NumericUpDown intelligenceUpDown;
        private System.Windows.Forms.NumericUpDown healthUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

