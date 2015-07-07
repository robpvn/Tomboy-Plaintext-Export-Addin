CSOBJECTS = ExportToPlainTextApplicationAddin.cs
CSC = mcs

all: ${CSOBJECTS}
	$(CSC) ${CSOBJECTS} -debug -out:ExportToPlainTextAddin.dll -target:library -pkg:tomboy-addins -r:Mono.Posix -r:/usr/lib/tomboy/Tomboy.exe -resource:ExportToPlainText.addin.xml

install: ${CSOBJECTS}
	$(CSC) ${CSOBJECTS} -out:/usr/lib/tomboy/addins/ExportToPlainTextAddin.dll -target:library -pkg:tomboy-addins -r:Mono.Posix -r:/usr/lib/tomboy/Tomboy.exe -resource:ExportToPlainText.addin.xml
