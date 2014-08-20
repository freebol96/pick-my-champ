namespace PickMyChamp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent ()
        {
            this.result = new System.Windows.Forms.TextBox();
            this.ShuffleTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(136, 96);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(311, 20);
            this.result.TabIndex = 0;
            // 
            // ShuffleTrigger
            // 
            this.ShuffleTrigger.Location = new System.Drawing.Point(182, 122);
            this.ShuffleTrigger.Name = "ShuffleTrigger";
            this.ShuffleTrigger.Size = new System.Drawing.Size(208, 23);
            this.ShuffleTrigger.TabIndex = 1;
            this.ShuffleTrigger.Text = "Pick me a champ!";
            this.ShuffleTrigger.UseVisualStyleBackColor = true;
            this.ShuffleTrigger.Click += SelectChampion;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 535);
            this.Controls.Add(this.ShuffleTrigger);
            this.Controls.Add(this.result);
            this.Name = "Form1";
            this.Text = "Random Champion Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button ShuffleTrigger;
    }
}

