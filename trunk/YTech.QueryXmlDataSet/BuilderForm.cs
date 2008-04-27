using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace YTech.QueryXmlDataSet
{
	public partial class BuilderForm : Form
	{
		public BuilderForm()
		{
			InitializeComponent();
		}

		private void cmdExecuteQuery_Click(object sender, EventArgs e)
		{
			cmdExecuteQuery.Text = "Querying...";
			cmdExecuteQuery.Enabled = false;

			string connString =
				string.Format("Server={0};Database={1};Uid={2};Pwd={3};", txtDatabaseServer.Text, txtDatabase.Text,
				              txtDatabaseUser.Text, txtDatabasePassword.Text);

			SqlConnection dbConn = new SqlConnection(connString);

			SqlCommand cmd = dbConn.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = txtDatabaseQuery.Text;

			SqlDataAdapter sda = new SqlDataAdapter(cmd);
			DataSet ds = new DataSet();
			sda.Fill(ds);

			showSerializedDataSet(ds);

			cmdExecuteQuery.Text = "Execute";
			cmdExecuteQuery.Enabled = true;
		}

		private void showSerializedDataSet(DataSet ds)
		{
			XmlSerializer ser;
			StringWriter sw;
			StringBuilder sb;

			ser = new XmlSerializer(typeof (DataSet));
			sb = new StringBuilder();
			sw = new StringWriter(sb);
			ser.Serialize(sw, ds);

			txtResults.Text = sb.ToString();
		}

		private void cmdCopy_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(txtResults.Text);
		}
	}
}