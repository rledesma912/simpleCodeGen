using System;
using System.CodeDom.Compiler;
using System.IO;
using Microsoft.VisualStudio.TextTemplating;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Carga la plantilla T4
            string templateFile = "first.tt";
            Engine engine = new Engine();
            TemplateHost host = new TemplteHost();
            string templateContent = File.ReadAllText(templateFile);

            // Ejecuta la plantilla T4
            string output = engine.ProcessTemplate(templateContent, host);

            // Muestra el resultado en la consola
            Console.WriteLine(output);
        }
    }

    // Clase de alojamiento de plantillas
    public class TemplateHost : ITextTemplatingEngineHost
    {
        public string ResolveAssemblyReference(string assemblyReference)
        {
            return "";
        }

        public Type ResolveDirectiveProcessor(string processorName)
        {
            return null;
        }

        public string ResolveDirectivePath(string directivePath)
        {
            return "";
        }

        public string ResolveIncludeFile(string includeFile)
        {
            return File.ReadAllText(includeFile);
        }

        public bool UseRelativePathForIncludeFiles
        {
            get { return true; }
        }

        public object GetHostOption(string optionName)
        {
            return null;
        }

        public void LogErrors(CompilerErrorCollection errors)
        {
        }

        public AppDomain ProvideTemplatingAppDomain(string content)
        {
            return AppDomain.CurrentDomain;
        }

        public ITextTemplatingSession CreateSession()
        {
            return new TextTemplatingSession();
        }

        public void SetFileExtension(string extension)
        {
        }

        public void SetOutputEncoding(System.Text.Encoding encoding, bool fromOutputDirective)
        {
        }
    }
}
