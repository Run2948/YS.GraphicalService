namespace windowServer
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.btnGetStatus = new System.Windows.Forms.Button();
            this.btnStartOrEnd = new System.Windows.Forms.Button();
            this.btnInstallOrUninstall = new System.Windows.Forms.Button();
            this.lbl_statusTip = new System.Windows.Forms.Label();
            this.lbl_serviceTip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMain.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.lblMsg);
            this.gbMain.Controls.Add(this.lblServiceName);
            this.gbMain.Controls.Add(this.btnGetStatus);
            this.gbMain.Controls.Add(this.btnStartOrEnd);
            this.gbMain.Controls.Add(this.btnInstallOrUninstall);
            this.gbMain.Controls.Add(this.lbl_statusTip);
            this.gbMain.Controls.Add(this.lbl_serviceTip);
            this.gbMain.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gbMain.Location = new System.Drawing.Point(12, 19);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(678, 200);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "操作";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.Location = new System.Drawing.Point(192, 159);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(69, 19);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "lblMsg";
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServiceName.ForeColor = System.Drawing.Color.Blue;
            this.lblServiceName.Location = new System.Drawing.Point(192, 36);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(149, 19);
            this.lblServiceName.TabIndex = 4;
            this.lblServiceName.Text = "lblServiceName";
            // 
            // btnGetStatus
            // 
            this.btnGetStatus.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetStatus.Location = new System.Drawing.Point(495, 83);
            this.btnGetStatus.Name = "btnGetStatus";
            this.btnGetStatus.Size = new System.Drawing.Size(100, 33);
            this.btnGetStatus.TabIndex = 3;
            this.btnGetStatus.Text = "获取状态";
            this.btnGetStatus.UseVisualStyleBackColor = true;
            this.btnGetStatus.Click += new System.EventHandler(this.btnGetStatus_Click);
            // 
            // btnStartOrEnd
            // 
            this.btnStartOrEnd.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartOrEnd.Location = new System.Drawing.Point(301, 83);
            this.btnStartOrEnd.Name = "btnStartOrEnd";
            this.btnStartOrEnd.Size = new System.Drawing.Size(100, 33);
            this.btnStartOrEnd.TabIndex = 2;
            this.btnStartOrEnd.Text = "启动服务";
            this.btnStartOrEnd.UseVisualStyleBackColor = true;
            this.btnStartOrEnd.Click += new System.EventHandler(this.btnStartOrEnd_Click);
            // 
            // btnInstallOrUninstall
            // 
            this.btnInstallOrUninstall.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInstallOrUninstall.Location = new System.Drawing.Point(107, 83);
            this.btnInstallOrUninstall.Name = "btnInstallOrUninstall";
            this.btnInstallOrUninstall.Size = new System.Drawing.Size(100, 33);
            this.btnInstallOrUninstall.TabIndex = 1;
            this.btnInstallOrUninstall.Text = "安装服务";
            this.btnInstallOrUninstall.UseVisualStyleBackColor = true;
            this.btnInstallOrUninstall.Click += new System.EventHandler(this.btnInstallOrUninstall_Click);
            // 
            // lbl_statusTip
            // 
            this.lbl_statusTip.AutoSize = true;
            this.lbl_statusTip.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_statusTip.Location = new System.Drawing.Point(55, 159);
            this.lbl_statusTip.Name = "lbl_statusTip";
            this.lbl_statusTip.Size = new System.Drawing.Size(95, 19);
            this.lbl_statusTip.TabIndex = 0;
            this.lbl_statusTip.Text = "服务状态-";
            // 
            // lbl_serviceTip
            // 
            this.lbl_serviceTip.AutoSize = true;
            this.lbl_serviceTip.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_serviceTip.Location = new System.Drawing.Point(55, 36);
            this.lbl_serviceTip.Name = "lbl_serviceTip";
            this.lbl_serviceTip.Size = new System.Drawing.Size(95, 19);
            this.lbl_serviceTip.TabIndex = 0;
            this.lbl_serviceTip.Text = "服务名称-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(43, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "注意：如果不能安装服务，请右键，以管理员身份运行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(43, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "      执行安装前，请先卸载以前的版本，再安装新的版本";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主界面ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // 主界面ToolStripMenuItem
            // 
            this.主界面ToolStripMenuItem.Name = "主界面ToolStripMenuItem";
            this.主界面ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.主界面ToolStripMenuItem.Text = "主界面";
            this.主界面ToolStripMenuItem.Click += new System.EventHandler(this.主界面ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMain);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "服务管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Label lbl_statusTip;
        private System.Windows.Forms.Label lbl_serviceTip;
        private System.Windows.Forms.Button btnGetStatus;
        private System.Windows.Forms.Button btnStartOrEnd;
        private System.Windows.Forms.Button btnInstallOrUninstall;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

