
namespace prKol_ind2_Shaidullin
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vowels_label = new System.Windows.Forms.Label();
            this.consonants_label = new System.Windows.Forms.Label();
            this.next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(451, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гласные";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(528, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Согласные";
            // 
            // vowels_label
            // 
            this.vowels_label.AutoSize = true;
            this.vowels_label.Location = new System.Drawing.Point(169, 283);
            this.vowels_label.Name = "vowels_label";
            this.vowels_label.Size = new System.Drawing.Size(0, 17);
            this.vowels_label.TabIndex = 3;
            // 
            // consonants_label
            // 
            this.consonants_label.AutoSize = true;
            this.consonants_label.Location = new System.Drawing.Point(533, 283);
            this.consonants_label.Name = "consonants_label";
            this.consonants_label.Size = new System.Drawing.Size(0, 17);
            this.consonants_label.TabIndex = 4;
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(548, 53);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(72, 23);
            this.next_button.TabIndex = 5;
            this.next_button.Text = "next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.consonants_label);
            this.Controls.Add(this.vowels_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vowels_label;
        private System.Windows.Forms.Label consonants_label;
        private System.Windows.Forms.Button next_button;
    }
}

