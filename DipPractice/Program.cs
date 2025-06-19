using DipPractice.part2.exercise2;
using DipPractice.pract1;
using DipPractice.pract2;
using DipPractice.pract3;
using MissionSystemDIP;
using System.Collections.Generic;
using DipPractice.part2.exercise4;
namespace DipPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StartLogger.Run();
            //RunLaying.Run();
            //AlertRun.Run();

            //ControlRoom controlRoom = new ControlRoom();
            //controlRoom.Launch();
            //Rectangle rect = new Rectangle { Width = 5, Height = 10 };
            //Square square = new Square { Side = 6 };

            //Exercise2Run.TestArea(rect);
            //Exercise2Run.TestArea(square);

            //PdfExporter pdfExporter = new PdfExporter();
            //OnlineExporter htmlExporter = new OnlineExporter();

            //ExportDoc.ExportDocument(pdfExporter);

            //htmlExporter.ExportToHTML();

            var accounts = new List<IAccount>
        {
            new BankAccount(1000),
            new DebtAccount(500)

        };
            SumAccounts.SumBalances(accounts);

        }
    }
    

}
