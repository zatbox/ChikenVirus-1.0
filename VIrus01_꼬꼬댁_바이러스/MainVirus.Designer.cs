namespace VIrus01_꼬꼬댁_바이러스
{
    partial class MainVirus
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
            this.components = new System.ComponentModel.Container();
            this.CursorEffect = new System.Diagnostics.Process();
            this.CursorEffectTimer = new System.Windows.Forms.Timer(this.components);
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CursorEffect
            // 
            this.CursorEffect.StartInfo.Domain = "";
            this.CursorEffect.StartInfo.LoadUserProfile = false;
            this.CursorEffect.StartInfo.Password = null;
            this.CursorEffect.StartInfo.StandardErrorEncoding = null;
            this.CursorEffect.StartInfo.StandardOutputEncoding = null;
            this.CursorEffect.StartInfo.UserName = "";
            this.CursorEffect.SynchronizingObject = this;
            // 
            // CursorEffectTimer
            // 
            this.CursorEffectTimer.Interval = 1;
            this.CursorEffectTimer.Tick += new System.EventHandler(this.CursorEffectTimer_Tick);
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 1000;
            this.msgTimer.Tick += new System.EventHandler(this.msgTimer_Tick);
            // 
            // MainVirus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 422);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainVirus";
            this.Text = "MainVirus";
            this.Load += new System.EventHandler(this.MainVirus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.Process CursorEffect;
        private System.Windows.Forms.Timer CursorEffectTimer;
        private System.Windows.Forms.Timer msgTimer;
    }
}