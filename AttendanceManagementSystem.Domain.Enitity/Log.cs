namespace AttendanceManagementSystem.Domain.Enitities
{
    public class Log
    {
        public Guid Id { get; set; }
        public   DateTime? TimeStamp{get;set;}
        public uint TiimeShit { get;set;}
        public Log() { }
        public Log( DateTime TimeStamp, uint TiimeShit)
        {
            this.Id = Guid.NewGuid();
            this.TimeStamp = TimeStamp;
            this.TiimeShit = TiimeShit;
        }
    }
}
