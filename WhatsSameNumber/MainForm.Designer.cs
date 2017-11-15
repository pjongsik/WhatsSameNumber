using WhatsSameNumber.Controls;
namespace WhatsSameNumber
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlNotice = new System.Windows.Forms.Panel();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnReCreate = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNotice
            // 
            this.pnlNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotice.Controls.Add(this.txtLength);
            this.pnlNotice.Controls.Add(this.txtGap);
            this.pnlNotice.Controls.Add(this.txtWidth);
            this.pnlNotice.Controls.Add(this.btnReCreate);
            this.pnlNotice.Controls.Add(this.btnStart);
            this.pnlNotice.Controls.Add(this.lbTime);
            this.pnlNotice.Controls.Add(this.label5);
            this.pnlNotice.Controls.Add(this.label4);
            this.pnlNotice.Controls.Add(this.lbLevel);
            this.pnlNotice.Controls.Add(this.label2);
            this.pnlNotice.Controls.Add(this.label3);
            this.pnlNotice.Controls.Add(this.label1);
            this.pnlNotice.Location = new System.Drawing.Point(341, 12);
            this.pnlNotice.Name = "pnlNotice";
            this.pnlNotice.Size = new System.Drawing.Size(148, 291);
            this.pnlNotice.TabIndex = 0;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(69, 163);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(64, 21);
            this.txtLength.TabIndex = 4;
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(69, 136);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(64, 21);
            this.txtGap.TabIndex = 3;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(69, 109);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(64, 21);
            this.txtWidth.TabIndex = 2;
            // 
            // btnReCreate
            // 
            this.btnReCreate.Location = new System.Drawing.Point(18, 200);
            this.btnReCreate.Name = "btnReCreate";
            this.btnReCreate.Size = new System.Drawing.Size(115, 23);
            this.btnReCreate.TabIndex = 5;
            this.btnReCreate.Text = "ReCreating";
            this.btnReCreate.UseVisualStyleBackColor = true;
            this.btnReCreate.Click += new System.EventHandler(this.btnReCreate_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(68, 15);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(55, 12);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00.000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Length : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gap : ";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Location = new System.Drawing.Point(69, 39);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(11, 12);
            this.lbLevel.TabIndex = 0;
            this.lbLevel.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Width : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Level : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 391);
            this.Controls.Add(this.pnlNotice);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlNotice.ResumeLayout(false);
            this.pnlNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNotice;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReCreate;
    }
}

