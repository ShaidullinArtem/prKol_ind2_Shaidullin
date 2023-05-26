
namespace prKol_ind2_Shaidullin
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
            this.negotive_label = new System.Windows.Forms.Label();
            this.positive_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // negotive_label
            // 
            this.negotive_label.AutoSize = true;
            this.negotive_label.Location = new System.Drawing.Point(467, 312);
            this.negotive_label.Name = "negotive_label";
            this.negotive_label.Size = new System.Drawing.Size(0, 17);
            this.negotive_label.TabIndex = 9;
            // 
            // positive_label
            // 
            this.positive_label.AutoSize = true;
            this.positive_label.Location = new System.Drawing.Point(167, 312);
            this.positive_label.Name = "positive_label";
            this.positive_label.Size = new System.Drawing.Size(0, 17);
            this.positive_label.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(454, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Отрицательные";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(165, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Положительные";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 72);
            this.button1.TabIndex = 5;
            this.button1.Text = "Загрузить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(170, 78);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(72, 23);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.negotive_label);
            this.Controls.Add(this.positive_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label negotive_label;
        private System.Windows.Forms.Label positive_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back_button;
    }
}