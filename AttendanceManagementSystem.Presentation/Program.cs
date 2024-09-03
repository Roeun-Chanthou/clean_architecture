using AttendanceManagementSystem.Application;
using AttendanceManagementSystem.Domain.Enitities;
using AttendanceManagementSystem.Infrastructure;
namespace AttendanceManagementSystem.Presentation
{
     static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var AppTimeSheet = new FileTimeSheet();
            AppTimeSheet=TimeSheetDataStorage.LoadTimeSheetFromStorage();
            System.Windows.Forms.Application.Run(new MainForm(AppTimeSheet));

        }
    }
}