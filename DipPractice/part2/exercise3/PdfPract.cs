using System;

public interface IPdfExport
{
    void ExportToPDF();
}

public interface IHtmlExport
{
    void ExportToHTML();
}

public class PdfExporter : IPdfExport
{
    public void ExportToPDF()
    {
        Console.WriteLine("Exporting document to PDF");
    }
}

public class OnlineExporter : IHtmlExport
{
    public void ExportToHTML()
    {
        Console.WriteLine("Exporting document to HTML");
    }
}

public static class ExportDoc
{
    public static void ExportDocument(IPdfExport exporter)
    {
        exporter.ExportToPDF();
    }

   
}
