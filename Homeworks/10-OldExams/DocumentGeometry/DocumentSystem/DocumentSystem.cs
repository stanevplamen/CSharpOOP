using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystemNS
{
    public class DocumentSystem
    {
        static void Main()
        {
            //This section is compiled in Debug Mode only.
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("input.txt"));
#endif
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
            Console.WriteLine(outputSB);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static List<IDocument> documentsList = new List<IDocument>();
        private static StringBuilder outputSB = new StringBuilder();

        private static string AddDocument(IDocument document, string[] attributes)
        {
            foreach (string attribute in attributes)
            {
                string[] tokens = attribute.Split(new char[] { '=' });
                string propertyName = tokens[0];
                string propertyValue = tokens[1];

                document.LoadProperty(propertyName, propertyValue);
            }

            if (String.IsNullOrWhiteSpace(document.Name))
            {
                return "Document has no name";
            }
            else
            {
                documentsList.Add(document);
                return "Document added: " + document.Name;
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new TextDocument(), attributes));
        }

        private static void AddPdfDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new PDF(), attributes));
        }

        private static void AddWordDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new Word(), attributes));
        }

        private static void AddExcelDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new Excel(), attributes));
        }

        private static void AddAudioDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new Audio(), attributes));
        }

        private static void AddVideoDocument(string[] attributes)
        {
            outputSB.AppendLine(AddDocument(new Video(), attributes));
        }

        private static void ListDocuments()
        {
            if (documentsList.Count > 0)
            {
                foreach (var doc in documentsList)
                {
                    outputSB.AppendLine(doc.ToString());
                }
            }
            else
            {
                outputSB.AppendLine("No documents found");
            }
        }

        private static void EncryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documentsList)
            {
                if (doc.Name == name)
                {
                    if ( doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Encrypt();
                        outputSB.AppendLine("Document encrypted: " + name);
                    }
                    else
                    {
                        outputSB.AppendLine("Document does not support encryption: " + name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                outputSB.AppendLine("Document not found: " + name);
            }
        }

        private static void DecryptDocument(string name)
        {
            bool documentFound = false;
            foreach (var doc in documentsList)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Decrypt();
                        outputSB.AppendLine("Document decrypted: " + name);
                    }
                    else
                    {
                        outputSB.AppendLine("Document does not support decryption: " + name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                outputSB.AppendLine("Document not found: " + name);
            }
        }

        private static void EncryptAllDocuments()
        {
            bool documentFound = false;
            foreach (var doc in documentsList)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    documentFound = true;
                }
            }
            if (documentFound)
            {
                outputSB.AppendLine("All documents encrypted");
            }
            else
            {
                outputSB.AppendLine("No encryptable documents found");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            bool documentFound = false;
            foreach (var doc in documentsList)
            {
                if (doc.Name == name)
                {
                    if (doc is IEditable)
                    {
                        ((IEditable)doc).ChangeContent(content);
                        outputSB.AppendLine("Document content changed: " + doc.Name);
                    }
                    else
                    {
                        outputSB.AppendLine("Document is not editable: " + doc.Name);
                    }
                    documentFound = true;
                }
            }
            if (!documentFound)
            {
                outputSB.AppendLine("Document not found: " + name);
            }
        }
    }
}
