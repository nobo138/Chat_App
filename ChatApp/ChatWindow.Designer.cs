﻿namespace ChatApp
{
    partial class ChatWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindow));
            this.member_gb = new System.Windows.Forms.GroupBox();
            this.member_lv = new System.Windows.Forms.ListView();
            this.group_name_gb = new System.Windows.Forms.GroupBox();
            this.link_file = new System.Windows.Forms.LinkLabel();
            this.chat_lw = new System.Windows.Forms.RichTextBox();
            this.send_pt = new System.Windows.Forms.PictureBox();
            this.exit_pt = new System.Windows.Forms.PictureBox();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.icon_Btn = new System.Windows.Forms.Button();
            this.file_Btn = new System.Windows.Forms.Button();
            this.message_tb = new System.Windows.Forms.TextBox();
            this.member_gb.SuspendLayout();
            this.group_name_gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_pt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pt)).BeginInit();
            this.SuspendLayout();
            // 
            // member_gb
            // 
            this.member_gb.BackColor = System.Drawing.Color.Transparent;
            this.member_gb.Controls.Add(this.member_lv);
            this.member_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_gb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.member_gb.Location = new System.Drawing.Point(13, 34);
            this.member_gb.Name = "member_gb";
            this.member_gb.Size = new System.Drawing.Size(186, 348);
            this.member_gb.TabIndex = 4;
            this.member_gb.TabStop = false;
            this.member_gb.Text = "MEMBER";
            // 
            // member_lv
            // 
            this.member_lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_lv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.member_lv.GridLines = true;
            this.member_lv.HideSelection = false;
            this.member_lv.Location = new System.Drawing.Point(7, 22);
            this.member_lv.Name = "member_lv";
            this.member_lv.Size = new System.Drawing.Size(173, 320);
            this.member_lv.TabIndex = 1;
            this.member_lv.UseCompatibleStateImageBehavior = false;
            this.member_lv.View = System.Windows.Forms.View.List;
            // 
            // group_name_gb
            // 
            this.group_name_gb.BackColor = System.Drawing.Color.Transparent;
            this.group_name_gb.Controls.Add(this.link_file);
            this.group_name_gb.Controls.Add(this.chat_lw);
            this.group_name_gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_name_gb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.group_name_gb.Location = new System.Drawing.Point(228, 4);
            this.group_name_gb.Name = "group_name_gb";
            this.group_name_gb.Size = new System.Drawing.Size(549, 380);
            this.group_name_gb.TabIndex = 5;
            this.group_name_gb.TabStop = false;
            this.group_name_gb.Text = "groupName";
            // 
            // link_file
            // 
            this.link_file.ActiveLinkColor = System.Drawing.Color.White;
            this.link_file.AutoSize = true;
            this.link_file.LinkColor = System.Drawing.Color.White;
            this.link_file.Location = new System.Drawing.Point(23, 90);
            this.link_file.Name = "link_file";
            this.link_file.Size = new System.Drawing.Size(118, 26);
            this.link_file.TabIndex = 1;
            this.link_file.TabStop = true;
            this.link_file.Text = "File_Name";
            this.link_file.Visible = false;
            this.link_file.VisitedLinkColor = System.Drawing.Color.White;
            this.link_file.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // chat_lw
            // 
            this.chat_lw.Location = new System.Drawing.Point(7, 32);
            this.chat_lw.Name = "chat_lw";
            this.chat_lw.ReadOnly = true;
            this.chat_lw.Size = new System.Drawing.Size(536, 340);
            this.chat_lw.TabIndex = 0;
            this.chat_lw.Text = "";
            this.chat_lw.TextChanged += new System.EventHandler(this.chat_lw_TextChanged);
            // 
            // send_pt
            // 
            this.send_pt.BackColor = System.Drawing.Color.Transparent;
            this.send_pt.BackgroundImage = global::ChatApp.Properties.Resources.send1;
            this.send_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.send_pt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_pt.Location = new System.Drawing.Point(734, 387);
            this.send_pt.Name = "send_pt";
            this.send_pt.Size = new System.Drawing.Size(43, 56);
            this.send_pt.TabIndex = 6;
            this.send_pt.TabStop = false;
            this.send_pt.Click += new System.EventHandler(this.sendBt_Click);
            // 
            // exit_pt
            // 
            this.exit_pt.BackColor = System.Drawing.Color.Transparent;
            this.exit_pt.BackgroundImage = global::ChatApp.Properties.Resources.exit;
            this.exit_pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_pt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_pt.Location = new System.Drawing.Point(20, 387);
            this.exit_pt.Name = "exit_pt";
            this.exit_pt.Size = new System.Drawing.Size(57, 62);
            this.exit_pt.TabIndex = 7;
            this.exit_pt.TabStop = false;
            this.exit_pt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // icon_Btn
            // 
            this.icon_Btn.Image = ((System.Drawing.Image)(resources.GetObject("icon_Btn.Image")));
            this.icon_Btn.Location = new System.Drawing.Point(686, 401);
            this.icon_Btn.Name = "icon_Btn";
            this.icon_Btn.Size = new System.Drawing.Size(42, 37);
            this.icon_Btn.TabIndex = 9;
            this.icon_Btn.UseVisualStyleBackColor = true;
            this.icon_Btn.Click += new System.EventHandler(this.icon_Btn_Click);
            // 
            // file_Btn
            // 
            this.file_Btn.Image = ((System.Drawing.Image)(resources.GetObject("file_Btn.Image")));
            this.file_Btn.Location = new System.Drawing.Point(638, 401);
            this.file_Btn.Name = "file_Btn";
            this.file_Btn.Size = new System.Drawing.Size(42, 37);
            this.file_Btn.TabIndex = 10;
            this.file_Btn.UseVisualStyleBackColor = true;
            this.file_Btn.Click += new System.EventHandler(this.file_Btn_Click);
            // 
            // message_tb
            // 
            this.message_tb.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_tb.Location = new System.Drawing.Point(228, 403);
            this.message_tb.Multiline = true;
            this.message_tb.Name = "message_tb";
            this.message_tb.Size = new System.Drawing.Size(399, 35);
            this.message_tb.TabIndex = 0;
            this.message_tb.TextChanged += new System.EventHandler(this.message_tb_TextChanged);
            this.message_tb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.message_tb_KeyDown);
            // 
            // ChatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::ChatApp.Properties.Resources._800;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 499);
            this.ControlBox = false;
            this.Controls.Add(this.file_Btn);
            this.Controls.Add(this.icon_Btn);
            this.Controls.Add(this.message_tb);
            this.Controls.Add(this.exit_pt);
            this.Controls.Add(this.send_pt);
            this.Controls.Add(this.group_name_gb);
            this.Controls.Add(this.member_gb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "HT CHAT - Chat Window";
            this.Load += new System.EventHandler(this.ChatWindow_Load);
            this.member_gb.ResumeLayout(false);
            this.group_name_gb.ResumeLayout(false);
            this.group_name_gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.send_pt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_pt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox member_gb;
        private System.Windows.Forms.ListView member_lv;
        private System.Windows.Forms.GroupBox group_name_gb;
        private System.Windows.Forms.PictureBox send_pt;
        private System.Windows.Forms.PictureBox exit_pt;
        private System.Windows.Forms.RichTextBox chat_lw;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private System.Windows.Forms.Button icon_Btn;
        private System.Windows.Forms.Button file_Btn;
        private System.Windows.Forms.TextBox message_tb;
        private System.Windows.Forms.LinkLabel link_file;
    }
}