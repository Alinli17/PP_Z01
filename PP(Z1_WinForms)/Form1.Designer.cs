namespace PP_Z1_WinForms_
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
            this.Zadanie_1_1 = new System.Windows.Forms.GroupBox();
            this.Zadanie_1_2 = new System.Windows.Forms.GroupBox();
            this.V = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.rez = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.TextBox();
            this.rez2 = new System.Windows.Forms.Label();
            this.Verity = new System.Windows.Forms.Button();
            this.Zadanie_1_1.SuspendLayout();
            this.Zadanie_1_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Zadanie_1_1
            // 
            this.Zadanie_1_1.Controls.Add(this.rez);
            this.Zadanie_1_1.Controls.Add(this.Find);
            this.Zadanie_1_1.Controls.Add(this.a);
            this.Zadanie_1_1.Controls.Add(this.Volume);
            this.Zadanie_1_1.Controls.Add(this.V);
            this.Zadanie_1_1.Location = new System.Drawing.Point(12, 12);
            this.Zadanie_1_1.Name = "Zadanie_1_1";
            this.Zadanie_1_1.Size = new System.Drawing.Size(261, 151);
            this.Zadanie_1_1.TabIndex = 0;
            this.Zadanie_1_1.TabStop = false;
            this.Zadanie_1_1.Text = "Задание 1";
            // 
            // Zadanie_1_2
            // 
            this.Zadanie_1_2.Controls.Add(this.Verity);
            this.Zadanie_1_2.Controls.Add(this.rez2);
            this.Zadanie_1_2.Controls.Add(this.Number);
            this.Zadanie_1_2.Controls.Add(this.Num);
            this.Zadanie_1_2.Location = new System.Drawing.Point(279, 12);
            this.Zadanie_1_2.Name = "Zadanie_1_2";
            this.Zadanie_1_2.Size = new System.Drawing.Size(317, 151);
            this.Zadanie_1_2.TabIndex = 0;
            this.Zadanie_1_2.TabStop = false;
            this.Zadanie_1_2.Text = "Задание 2";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(6, 31);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(112, 17);
            this.V.TabIndex = 1;
            this.V.Text = "Объём куба (v):";
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(124, 31);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(131, 22);
            this.Volume.TabIndex = 2;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(6, 64);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(87, 17);
            this.a.TabIndex = 3;
            this.a.Text = "Ребро куба:";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(84, 93);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(93, 36);
            this.Find.TabIndex = 1;
            this.Find.Text = "Найти";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // rez
            // 
            this.rez.AutoSize = true;
            this.rez.Location = new System.Drawing.Point(121, 64);
            this.rez.Name = "rez";
            this.rez.Size = new System.Drawing.Size(0, 17);
            this.rez.TabIndex = 1;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(6, 31);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(188, 17);
            this.Num.TabIndex = 0;
            this.Num.Text = "Введите 2-хзначное число:";
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(200, 31);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(111, 22);
            this.Number.TabIndex = 1;
            // 
            // rez2
            // 
            this.rez2.AutoSize = true;
            this.rez2.Location = new System.Drawing.Point(6, 64);
            this.rez2.Name = "rez2";
            this.rez2.Size = new System.Drawing.Size(0, 17);
            this.rez2.TabIndex = 2;
            // 
            // Verity
            // 
            this.Verity.Location = new System.Drawing.Point(119, 93);
            this.Verity.Name = "Verity";
            this.Verity.Size = new System.Drawing.Size(93, 36);
            this.Verity.TabIndex = 1;
            this.Verity.Text = "Проверить";
            this.Verity.UseVisualStyleBackColor = true;
            this.Verity.Click += new System.EventHandler(this.Verity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 173);
            this.Controls.Add(this.Zadanie_1_2);
            this.Controls.Add(this.Zadanie_1_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Zadanie_1_1.ResumeLayout(false);
            this.Zadanie_1_1.PerformLayout();
            this.Zadanie_1_2.ResumeLayout(false);
            this.Zadanie_1_2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Zadanie_1_1;
        private System.Windows.Forms.Label rez;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.TextBox Volume;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.GroupBox Zadanie_1_2;
        private System.Windows.Forms.Button Verity;
        private System.Windows.Forms.Label rez2;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label Num;
    }
}

