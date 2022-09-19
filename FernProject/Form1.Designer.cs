namespace FernProject
{
    partial class MainForm
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
            this.ModelView = new System.Windows.Forms.PictureBox();
            this.CheckFern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DaysView = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ModelView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelView
            // 
            this.ModelView.Location = new System.Drawing.Point(360, 32);
            this.ModelView.Name = "ModelView";
            this.ModelView.Size = new System.Drawing.Size(554, 473);
            this.ModelView.TabIndex = 0;
            this.ModelView.TabStop = false;
            // 
            // CheckFern
            // 
            this.CheckFern.BackColor = System.Drawing.Color.LightGray;
            this.CheckFern.FlatAppearance.BorderSize = 0;
            this.CheckFern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckFern.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckFern.Location = new System.Drawing.Point(44, 32);
            this.CheckFern.Name = "CheckFern";
            this.CheckFern.Size = new System.Drawing.Size(264, 81);
            this.CheckFern.TabIndex = 1;
            this.CheckFern.Text = "Вырастить папоротник";
            this.CheckFern.UseVisualStyleBackColor = false;
            this.CheckFern.Click += new System.EventHandler(this.CheckFern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дней";
            // 
            // DaysView
            // 
            this.DaysView.AutoSize = true;
            this.DaysView.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DaysView.Location = new System.Drawing.Point(129, 190);
            this.DaysView.Name = "DaysView";
            this.DaysView.Size = new System.Drawing.Size(27, 32);
            this.DaysView.TabIndex = 3;
            this.DaysView.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(957, 685);
            this.Controls.Add(this.DaysView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CheckFern);
            this.Controls.Add(this.ModelView);
            this.Name = "MainForm";
            this.Text = "FernProject v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.ModelView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ModelView;
        private System.Windows.Forms.Button CheckFern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DaysView;
    }
}

