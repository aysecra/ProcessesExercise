
namespace _171180038_ayse_karatas
{
    partial class Form_Processes
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
            this.LstBox_Processes = new System.Windows.Forms.ListBox();
            this.menu_ProcessOperations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menu_ThreadAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_MemoryAmount = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ProcessorPerc = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_KillProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.LstBox_MesageBox = new System.Windows.Forms.ListBox();
            this.Lbl_Processes = new System.Windows.Forms.Label();
            this.Lbl_MessageBox = new System.Windows.Forms.Label();
            this.menu_ProcessOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstBox_Processes
            // 
            this.LstBox_Processes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstBox_Processes.FormattingEnabled = true;
            this.LstBox_Processes.ItemHeight = 18;
            this.LstBox_Processes.Location = new System.Drawing.Point(34, 48);
            this.LstBox_Processes.Name = "LstBox_Processes";
            this.LstBox_Processes.Size = new System.Drawing.Size(500, 256);
            this.LstBox_Processes.TabIndex = 0;
            this.LstBox_Processes.SelectedIndexChanged += new System.EventHandler(this.LstBox_Processes_SelectedIndexChanged);
            this.LstBox_Processes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LstBox_Processes_MouseDown);
            // 
            // menu_ProcessOperations
            // 
            this.menu_ProcessOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_ProcessOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ThreadAmount,
            this.menu_MemoryAmount,
            this.menu_ProcessorPerc,
            this.menu_KillProcess});
            this.menu_ProcessOperations.Name = "menu_ProcessOperations";
            this.menu_ProcessOperations.Size = new System.Drawing.Size(179, 100);
            // 
            // menu_ThreadAmount
            // 
            this.menu_ThreadAmount.Name = "menu_ThreadAmount";
            this.menu_ThreadAmount.Size = new System.Drawing.Size(178, 24);
            this.menu_ThreadAmount.Text = "Thread Sayısı";
            this.menu_ThreadAmount.Click += new System.EventHandler(this.menu_ThreadAmount_Click);
            // 
            // menu_MemoryAmount
            // 
            this.menu_MemoryAmount.Name = "menu_MemoryAmount";
            this.menu_MemoryAmount.Size = new System.Drawing.Size(178, 24);
            this.menu_MemoryAmount.Text = "Bellek Miktarı";
            this.menu_MemoryAmount.Click += new System.EventHandler(this.menu_MemoryAmount_Click);
            // 
            // menu_ProcessorPerc
            // 
            this.menu_ProcessorPerc.Name = "menu_ProcessorPerc";
            this.menu_ProcessorPerc.Size = new System.Drawing.Size(178, 24);
            this.menu_ProcessorPerc.Text = "İşlemci Yüzdesi";
            this.menu_ProcessorPerc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.menu_ProcessorPerc.Click += new System.EventHandler(this.menu_ProcessorPerc_Click);
            // 
            // menu_KillProcess
            // 
            this.menu_KillProcess.Name = "menu_KillProcess";
            this.menu_KillProcess.Size = new System.Drawing.Size(178, 24);
            this.menu_KillProcess.Text = "Prosesi Öldür";
            this.menu_KillProcess.Click += new System.EventHandler(this.menu_KillProcess_Click);
            // 
            // LstBox_MesageBox
            // 
            this.LstBox_MesageBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstBox_MesageBox.FormattingEnabled = true;
            this.LstBox_MesageBox.ItemHeight = 18;
            this.LstBox_MesageBox.Location = new System.Drawing.Point(34, 365);
            this.LstBox_MesageBox.Name = "LstBox_MesageBox";
            this.LstBox_MesageBox.Size = new System.Drawing.Size(500, 166);
            this.LstBox_MesageBox.TabIndex = 1;
            // 
            // Lbl_Processes
            // 
            this.Lbl_Processes.AutoSize = true;
            this.Lbl_Processes.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_Processes.Location = new System.Drawing.Point(30, 22);
            this.Lbl_Processes.Name = "Lbl_Processes";
            this.Lbl_Processes.Size = new System.Drawing.Size(145, 23);
            this.Lbl_Processes.TabIndex = 2;
            this.Lbl_Processes.Text = "Çalışan Prosesler";
            // 
            // Lbl_MessageBox
            // 
            this.Lbl_MessageBox.AutoSize = true;
            this.Lbl_MessageBox.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_MessageBox.Location = new System.Drawing.Point(30, 339);
            this.Lbl_MessageBox.Name = "Lbl_MessageBox";
            this.Lbl_MessageBox.Size = new System.Drawing.Size(118, 23);
            this.Lbl_MessageBox.TabIndex = 3;
            this.Lbl_MessageBox.Text = "Mesaj Kutusu";
            // 
            // Form_Processes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.Lbl_MessageBox);
            this.Controls.Add(this.Lbl_Processes);
            this.Controls.Add(this.LstBox_MesageBox);
            this.Controls.Add(this.LstBox_Processes);
            this.Name = "Form_Processes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CENG309 İşletim Sistemleri - Final Projesi";
            this.Load += new System.EventHandler(this.Form_Processes_Load);
            this.menu_ProcessOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBox_Processes;
        private System.Windows.Forms.ListBox LstBox_MesageBox;
        private System.Windows.Forms.Label Lbl_Processes;
        private System.Windows.Forms.Label Lbl_MessageBox;
        private System.Windows.Forms.ContextMenuStrip menu_ProcessOperations;
        private System.Windows.Forms.ToolStripMenuItem menu_ThreadAmount;
        private System.Windows.Forms.ToolStripMenuItem menu_MemoryAmount;
        private System.Windows.Forms.ToolStripMenuItem menu_ProcessorPerc;
        private System.Windows.Forms.ToolStripMenuItem menu_KillProcess;
    }
}

