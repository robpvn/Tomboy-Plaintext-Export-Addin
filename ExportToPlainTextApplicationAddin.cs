using System;
using System.IO;
using Tomboy;
using Mono.Unix;

namespace Tomboy.ExportToPlainText
{
	public class ExportToPlainTextApplicationAddin : ExportAllApplicationAddin
	{

		protected override void SetNames ()
		{
			export_file_suffix = "txt";
			export_type_pretty_name = Catalog.GetString ("Plain Text Files");
		}

		public override void ExportSingleNote (Note note, 
													string output_folder)
		{
			string output_path = output_folder + SanitizeNoteTitle (note.Title)
				+ "." + export_file_suffix;

			Logger.Debug (Catalog.GetString("Exporting Note '{0}' to '{1}'..."),
							note.Title, output_path);

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
