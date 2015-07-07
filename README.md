# Tomboy-Plaintext-Export-Addin

The Plaintext export add-in for Tomboy Notes allows you to export
all your notes or a selected notebook to plain .txt files, using the export functions introduced in Tomboy 1.7.1 on Linux and 1.9.7 on Windows and Mac. (In other words you must have that version or higher for it to work!)

##Installing

In order to install the add-in, simply place ExportToPlainTextAddin.dll in your Tomboy plugins folder.

It is enabled by default, and can be turned off in Preferences -> Add-ins.

Your Tomboy plugins folder varies depending on your platform, see http://live.gnome.org/Tomboy/Directories.

##Using

Using is very easy, go to the Tools->Export menu in Search All Notes and select Export To Plain Text Files.

##Compiling

The add-in can be compiled using make, or sudo make install to send it straight to the addin folder on Linux. Open the Makefile to see which compiler commands are used.

##License

The add-in is licensed with the LGPLv3, like Tomboy Notes.
