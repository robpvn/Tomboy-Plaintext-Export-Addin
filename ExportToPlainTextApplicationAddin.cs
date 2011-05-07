
using System;
using System.IO;
using Tomboy;
using Mono.Unix;

namespace Tomboy.ExportToPlainText
{


	public class ExportToPlainTextApplicationAddin : ExportAllApplicationAddin
	{
			
		protected override void setNames ()
		{
			export_file_suffix = "txt";
			export_type_full_name = Catalog.GetString ("Plain Text Files");
		}
		
		/// <summary>
		/// Exports a single Note to HTML in a specified location. Returns an error text
		/// if something goes wrong, otherwise null is returned.
		/// </summary>
		public override void ExportSingleNote (Note note, 
		                                string output_path)
		{
			Logger.Debug (Catalog.GetString("Exporting Note '{0}' to '{1}'..."), note.Title, output_path);

			StreamWriter writer = null;


			try {
				// FIXME: Warn about file existing.  Allow overwrite.
				File.Delete (output_path);
			} catch {
			}

			writer = new StreamWriter (output_path);
			
			writer.Write(note.TextContent);
	

			if (writer != null)
				writer.Close ();

			return;
		}
	}
	
	
}
