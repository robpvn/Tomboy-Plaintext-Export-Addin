CSOBJECTS = ExportToPlainTextApplicationAddin.cs
CSC = gmcs

all: ${CSOBJECTS}
	$(CSC) ${CSOBJECTS} -debug -out:ExportToPlainTextAddin.dll -target:library -pkg:tomboy-addins -r:Mono.Posix -r:/home/rpvn/vcs/tomboy/bin/Tomboy.exe -resource:ExportToPlainText.addin.xml

install: ${CSOBJECTS}
	$(CSC) ${CSOBJECTS} -out:/usr/lib/tomboy/addins/ExportToPlainTextAddin.dll -target:library -pkg:tomboy-addins -r:Mono.Posix -r:/home/rpvn/vcs/tomboy/bin/Tomboy.exe -resource:ExportToPlainText.addin.xml
