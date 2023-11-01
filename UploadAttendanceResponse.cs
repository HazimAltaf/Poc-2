namespace DummyAPIProject
{
    public class UploadAttendanceResponse
    {
        public List<UploadAttendance> Attendances;

        //public bool ErrorInRecords { get; set; }

        //public string ExcelFilePath { get; set; }

        //public string ErrorMessage { get; set; }

    }

    public class UploadAttendance
    {
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }
        public string Branch { get; set; }
        public string CardNo { get; set; }
        public WorkStatus WorkStatus { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }
        public DateTime AttendanceDate { get; set; }

    }

    public enum WorkStatus
    {
        A,
        P,
        NA,
    }
}
