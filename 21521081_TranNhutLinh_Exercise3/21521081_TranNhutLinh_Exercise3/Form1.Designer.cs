namespace _21521081_TranNhutLinh_Exercise3
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
            this.txtRoomChatH1 = new System.Windows.Forms.Label();
            this.txtRoomChatH2 = new System.Windows.Forms.Label();
            this.btnServer = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRoomChatH1
            // 
            this.txtRoomChatH1.AutoSize = true;
            this.txtRoomChatH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomChatH1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtRoomChatH1.Location = new System.Drawing.Point(247, 56);
            this.txtRoomChatH1.Name = "txtRoomChatH1";
            this.txtRoomChatH1.Size = new System.Drawing.Size(283, 51);
            this.txtRoomChatH1.TabIndex = 0;
            this.txtRoomChatH1.Text = "CHAT ROOM";
            this.txtRoomChatH1.UseMnemonic = false;
            this.txtRoomChatH1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtRoomChatH2
            // 
            this.txtRoomChatH2.AutoSize = true;
            this.txtRoomChatH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomChatH2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.txtRoomChatH2.Location = new System.Drawing.Point(285, 108);
            this.txtRoomChatH2.Name = "txtRoomChatH2";
            this.txtRoomChatH2.Size = new System.Drawing.Size(208, 25);
            this.txtRoomChatH2.TabIndex = 1;
            this.txtRoomChatH2.Text = "please choose the role";
            this.txtRoomChatH2.UseMnemonic = false;
            this.txtRoomChatH2.Click += new System.EventHandler(this.txtRoomChatH2_Click);
            // 
            // btnServer
            // 
            this.btnServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnServer.Location = new System.Drawing.Point(90, 210);
            this.btnServer.Name = "btnServer";
            this.btnServer.Size = new System.Drawing.Size(186, 73);
            this.btnServer.TabIndex = 2;
            this.btnServer.Text = "Server";
            this.btnServer.UseVisualStyleBackColor = true;
            this.btnServer.Click += new System.EventHandler(this.btnServer_Click);
            // 
            // btnClient
            // 
            this.btnClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClient.Location = new System.Drawing.Point(518, 210);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(186, 73);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(695, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnServer);
            this.Controls.Add(this.txtRoomChatH2);
            this.Controls.Add(this.txtRoomChatH1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRoomChatH1;
        private System.Windows.Forms.Label txtRoomChatH2;
        private System.Windows.Forms.Button btnServer;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnExit;
    }
}

