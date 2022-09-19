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
            ((System.ComponentModel.ISupportInitialize)(this.ModelView)).BeginInit();
            this.SuspendLayout();
            // 
            // ModelView
            // 
            this.ModelView.Location = new System.Drawing.Point(391, 12);
            this.ModelView.Name = "ModelView";
            this.ModelView.Size = new System.Drawing.Size(554, 493);
            this.ModelView.TabIndex = 0;
            this.ModelView.TabStop = false;
            // 
            // CheckFern
            // 
            this.CheckFern.Location = new System.Drawing.Point(52, 42);
            this.CheckFern.Name = "CheckFern";
            this.CheckFern.Size = new System.Drawing.Size(264, 81);
            this.CheckFern.TabIndex = 1;
            this.CheckFern.Text = "button1";
            this.CheckFern.UseVisualStyleBackColor = true;
            this.CheckFern.Click += new System.EventHandler(this.CheckFern_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 685);
            this.Controls.Add(this.CheckFern);
            this.Controls.Add(this.ModelView);
            this.Name = "MainForm";
            this.Text = "FernProject v0.1";
            ((System.ComponentModel.ISupportInitialize)(this.ModelView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ModelView;
        private System.Windows.Forms.Button CheckFern;
    }
}

