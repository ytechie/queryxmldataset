This utility makes it easy to create serialized XML DataSet's based on SQL queries run against a SQL Server.

  1. Run this program to execute a SQL statement
  1. Copy the resulting XML into a file in your .NET unit test project
  1. Embed the XML file you created
  1. In your test code, load the embedded XML, deserialize it back into a DataSet

**[Screencast available here!](http://s3.ytechie.com/screencasts/QueryXmlDataSet-Screencast/QueryXmlDataSet-Screencast.htm)**

You now have a way to mock a DataSet that would normally be loaded from a database.

How to deserialize the DataTable:
```
		/// <summary>
		///		Reads a <see cref="DataTable"/> from an embedded XML
		///		document that contains the serialized version.
		/// </summary>
		/// <param name="sourceAssembly">
		///		The assembly that contains the embedded file containing
		///		the XML.
		/// </param>
		/// <param name="resourceName">
		///		The qualified name of the resource to load.
		/// </param>
		/// <returns>
		///		The reconstituted <see cref="DataTable"/>.
		/// </returns>
		public static DataTable ReadEmbeddedDataTable(Assembly sourceAssembly, string resourceName)
		{
			using (Stream readStream = sourceAssembly.GetManifestResourceStream(resourceName))
			{
				XmlSerializer xs = new XmlSerializer(typeof(DataSet));
				DataSet ds = (DataSet)xs.Deserialize(readStream);

				return ds.Tables[0];
			}
		}
```

Related Blog Posts:
  * [Initial code available](http://www.ytechie.com/2008/04/net-xml-dataset-generator-from-a-sql-query.html)
  * [Screencast - Unit testing with real DataSets](http://www.ytechie.com/2008/09/screencast-unit-testing-with-real-datasets.html)