namespace YTech.QueryXmlDataSet
{
	partial class BuilderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private readonly System.ComponentModel.IContainer components = null;

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
			this.label1 = new System.Windows.Forms.Label();
			this.tabs = new System.Windows.Forms.TabControl();
			this.databaseTab = new System.Windows.Forms.TabPage();
			this.cmdCopy = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cmdExecuteQuery = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDatabaseQuery = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDatabasePassword = new System.Windows.Forms.TextBox();
			this.txtDatabaseUser = new System.Windows.Forms.TextBox();
			this.txtDatabaseServer = new System.Windows.Forms.TextBox();
			this.tabs.SuspendLayout();
			this.databaseTab.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "This form allows you to build a serialized \r\nDataSet from a database stored proce" +
					"dure call.";
			// 
			// tabs
			// 
			this.tabs.Controls.Add(this.databaseTab);
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Location = new System.Drawing.Point(0, 0);
			this.tabs.Name = "tabs";
			this.tabs.SelectedIndex = 0;
			this.tabs.Size = new System.Drawing.Size(749, 581);
			this.tabs.TabIndex = 1;
			// 
			// databaseTab
			// 
			this.databaseTab.Controls.Add(this.cmdCopy);
			this.databaseTab.Controls.Add(this.label7);
			this.databaseTab.Controls.Add(this.txtResults);
			this.databaseTab.Controls.Add(this.txtDatabase);
			this.databaseTab.Controls.Add(this.label6);
			this.databaseTab.Controls.Add(this.cmdExecuteQuery);
			this.databaseTab.Controls.Add(this.label5);
			this.databaseTab.Controls.Add(this.txtDatabaseQuery);
			this.databaseTab.Controls.Add(this.label4);
			this.databaseTab.Controls.Add(this.label3);
			this.databaseTab.Controls.Add(this.label2);
			this.databaseTab.Controls.Add(this.txtDatabasePassword);
			this.databaseTab.Controls.Add(this.txtDatabaseUser);
			this.databaseTab.Controls.Add(this.txtDatabaseServer);
			this.databaseTab.Controls.Add(this.label1);
			this.databaseTab.Location = new System.Drawing.Point(4, 22);
			this.databaseTab.Name = "databaseTab";
			this.databaseTab.Padding = new System.Windows.Forms.Padding(3);
			this.databaseTab.Size = new System.Drawing.Size(741, 555);
			this.databaseTab.TabIndex = 0;
			this.databaseTab.Text = "Database";
			this.databaseTab.UseVisualStyleBackColor = true;
			// 
			// cmdCopy
			// 
			this.cmdCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdCopy.Location = new System.Drawing.Point(627, 526);
			this.cmdCopy.Name = "cmdCopy";
			this.cmdCopy.Size = new System.Drawing.Size(106, 23);
			this.cmdCopy.TabIndex = 14;
			this.cmdCopy.Text = "Copy To Clipboard";
			this.cmdCopy.UseVisualStyleBackColor = true;
			this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 347);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Results:";
			// 
			// txtResults
			// 
			this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtResults.Location = new System.Drawing.Point(6, 363);
			this.txtResults.Multiline = true;
			this.txtResults.Name = "txtResults";
			this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResults.Size = new System.Drawing.Size(727, 159);
			this.txtResults.TabIndex = 12;
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(129, 133);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(165, 20);
			this.txtDatabase.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(67, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Database:";
			// 
			// cmdExecuteQuery
			// 
			this.cmdExecuteQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdExecuteQuery.Location = new System.Drawing.Point(658, 308);
			this.cmdExecuteQuery.Name = "cmdExecuteQuery";
			this.cmdExecuteQuery.Size = new System.Drawing.Size(75, 23);
			this.cmdExecuteQuery.TabIndex = 9;
			this.cmdExecuteQuery.Text = "Execute";
			this.cmdExecuteQuery.UseVisualStyleBackColor = true;
			this.cmdExecuteQuery.Click += new System.EventHandler(this.cmdExecuteQuery_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(85, 162);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Query:";
			// 
			// txtDatabaseQuery
			// 
			this.txtDatabaseQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDatabaseQuery.Location = new System.Drawing.Point(129, 159);
			this.txtDatabaseQuery.Multiline = true;
			this.txtDatabaseQuery.Name = "txtDatabaseQuery";
			this.txtDatabaseQuery.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDatabaseQuery.Size = new System.Drawing.Size(604, 143);
			this.txtDatabaseQuery.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(67, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(65, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(82, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Server:";
			// 
			// txtDatabasePassword
			// 
			this.txtDatabasePassword.Location = new System.Drawing.Point(129, 107);
			this.txtDatabasePassword.Name = "txtDatabasePassword";
			this.txtDatabasePassword.PasswordChar = '*';
			this.txtDatabasePassword.Size = new System.Drawing.Size(165, 20);
			this.txtDatabasePassword.TabIndex = 3;
			// 
			// txtDatabaseUser
			// 
			this.txtDatabaseUser.Location = new System.Drawing.Point(129, 81);
			this.txtDatabaseUser.Name = "txtDatabaseUser";
			this.txtDatabaseUser.Size = new System.Drawing.Size(165, 20);
			this.txtDatabaseUser.TabIndex = 2;
			// 
			// txtDatabaseServer
			// 
			this.txtDatabaseServer.Location = new System.Drawing.Point(129, 55);
			this.txtDatabaseServer.Name = "txtDatabaseServer";
			this.txtDatabaseServer.Size = new System.Drawing.Size(165, 20);
			this.txtDatabaseServer.TabIndex = 1;
			// 
			// BuilderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 581);
			this.Controls.Add(this.tabs);
			this.Name = "BuilderForm";
			this.Text = "BuilderForm";
			this.tabs.ResumeLayout(false);
			this.databaseTab.ResumeLayout(false);
			this.databaseTab.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabs;
		private System.Windows.Forms.TabPage databaseTab;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDatabasePassword;
		private System.Windows.Forms.TextBox txtDatabaseUser;
		private System.Windows.Forms.TextBox txtDatabaseServer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDatabaseQuery;
		private System.Windows.Forms.Button cmdExecuteQuery;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.TextBox txtDatabase;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button cmdCopy;
	}
}