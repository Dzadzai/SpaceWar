namespace SpaceWar
{
    partial class FormMainGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainGame));
            this.pictureBoxMyShip = new System.Windows.Forms.PictureBox();
            this.pictureBoxEnemyShip = new System.Windows.Forms.PictureBox();
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMyShip
            // 
            this.pictureBoxMyShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyShip.BackgroundImage")));
            this.pictureBoxMyShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxMyShip.Location = new System.Drawing.Point(308, 294);
            this.pictureBoxMyShip.Name = "pictureBoxMyShip";
            this.pictureBoxMyShip.Size = new System.Drawing.Size(140, 118);
            this.pictureBoxMyShip.TabIndex = 1;
            this.pictureBoxMyShip.TabStop = false;
            // 
            // pictureBoxEnemyShip
            // 
            this.pictureBoxEnemyShip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnemyShip.BackgroundImage")));
            this.pictureBoxEnemyShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxEnemyShip.Location = new System.Drawing.Point(330, 12);
            this.pictureBoxEnemyShip.Name = "pictureBoxEnemyShip";
            this.pictureBoxEnemyShip.Size = new System.Drawing.Size(92, 102);
            this.pictureBoxEnemyShip.TabIndex = 2;
            this.pictureBoxEnemyShip.TabStop = false;
            // 
            // timerEnemy
            // 
            this.timerEnemy.Enabled = true;
            this.timerEnemy.Interval = 1;
            this.timerEnemy.Tick += new System.EventHandler(this.timerEnemy_Tick);
            // 
            // FormMainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxEnemyShip);
            this.Controls.Add(this.pictureBoxMyShip);
            this.Name = "FormMainGame";
            this.Text = "Космические войны";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnemyShip)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMyShip;
        private System.Windows.Forms.PictureBox pictureBoxEnemyShip;
        private System.Windows.Forms.Timer timerEnemy;
    }
}

