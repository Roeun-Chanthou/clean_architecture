using AttendanceManagementSystem.Application;
using System.Net.WebSockets;
using System.Text.Json;
namespace AttendanceManagementSystem.Infrasturcture
{
    public class TimeSheetDataStorage
    {
        public static void SaveTimeSheetToStorage(FileTimeSheet AttenList)
        {
            var JsonString = JsonSerializer.Serialize<FileTimeSheet>(AttenList);
            File.WriteAllText("timeSheet.json", JsonString);
        }
        public static FileTimeSheet LoadTimeSheetFromStorage()
        {
            using FileStream stream = File.Open("timeSheet.json", FileMode.OpenOrCreate);
            if (stream.Length >0)
            {
                var loadList = JsonSerializer.Deserialize<FileTimeSheet>(stream);
                return loadList!;
            }
            return new FileTimeSheet();
        }
    }
}

