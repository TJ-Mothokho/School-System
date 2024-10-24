using System.ComponentModel.DataAnnotations.Schema;

namespace School_System.Data.Models.Domains
{
    public class Record
    {
        public int RecordID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }

        [ForeignKey("Subject")]
        public int SubjectID { get; set; }

        public double Term1 { get; set; } = 0;
        public double Term2 { get; set; } = 0;
        public double Term3 { get; set; } = 0;
        public double Term4 { get; set; } = 0;
        public double FinalMark
        {
            get
            {
                return (Term1 + Term2 + Term3 + Term4) / 4;
            }
        }

        // Navigation properties
        public Student Student { get; set; }
        public Subject Subject { get; set; }

    }
}
