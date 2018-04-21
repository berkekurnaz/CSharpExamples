namespace SozlukUygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnIngilizce = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnTurkce = new DevExpress.XtraEditors.SimpleButton();
            this.BtnHakkinda = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnIngilizce
            // 
            this.BtnIngilizce.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngilizce.Appearance.Options.UseFont = true;
            this.BtnIngilizce.Image = ((System.Drawing.Image)(resources.GetObject("BtnIngilizce.Image")));
            this.BtnIngilizce.Location = new System.Drawing.Point(96, 280);
            this.BtnIngilizce.Name = "BtnIngilizce";
            this.BtnIngilizce.Size = new System.Drawing.Size(394, 95);
            this.BtnIngilizce.TabIndex = 0;
            this.BtnIngilizce.Text = "İngilizce-Türkçe Çeviri Yap";
            this.BtnIngilizce.Click += new System.EventHandler(this.BtnIngilizce_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(137, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(319, 55);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "İngilizce-Türkçe";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(152, 115);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(282, 47);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Sözlük Uygulaması";
            // 
            // BtnTurkce
            // 
            this.BtnTurkce.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTurkce.Appearance.Options.UseFont = true;
            this.BtnTurkce.Image = ((System.Drawing.Image)(resources.GetObject("BtnTurkce.Image")));
            this.BtnTurkce.Location = new System.Drawing.Point(96, 420);
            this.BtnTurkce.Name = "BtnTurkce";
            this.BtnTurkce.Size = new System.Drawing.Size(394, 95);
            this.BtnTurkce.TabIndex = 3;
            this.BtnTurkce.Text = "Türkçe-İngilizce Çeviri Yap";
            this.BtnTurkce.Click += new System.EventHandler(this.BtnTurkce_Click);
            // 
            // BtnHakkinda
            // 
            this.BtnHakkinda.Appearance.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHakkinda.Appearance.Options.UseFont = true;
            this.BtnHakkinda.Image = ((System.Drawing.Image)(resources.GetObject("BtnHakkinda.Image")));
            this.BtnHakkinda.Location = new System.Drawing.Point(96, 560);
            this.BtnHakkinda.Name = "BtnHakkinda";
            this.BtnHakkinda.Size = new System.Drawing.Size(394, 95);
            this.BtnHakkinda.TabIndex = 4;
            this.BtnHakkinda.Text = "Program Hakkında";
            this.BtnHakkinda.Click += new System.EventHandler(this.BtnHakkinda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(591, 692);
            this.Controls.Add(this.BtnHakkinda);
            this.Controls.Add(this.BtnTurkce);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.BtnIngilizce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözlük Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnIngilizce;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnTurkce;
        private DevExpress.XtraEditors.SimpleButton BtnHakkinda;
    }
}

