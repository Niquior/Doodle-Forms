using System.ComponentModel.DataAnnotations;

namespace Doodle_Forms.Migrations
{
    public class Template
    {
        [Key] public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
        public int TopicId { get; set; }

        public bool SingleStringQuestion1State { get; set; }
        public string SingleStringQuestion1 { get; set; }
        public bool SingleStringQuestion2State { get; set; }
        public string SingleStringQuestion2 { get; set; }
        public bool SingleStringQuestion3State { get; set; }
        public string SingleStringQuestion3 { get; set; }
        public bool SingleStringQuestion4State { get; set; }
        public string SingleStringQuestion4 { get; set; }

        public bool MultipleStringsQuestion1State { get; set; }
        public string MultipleStringsQuestion1 { get; set; }
        public bool MultipleStringsQuestion2State { get; set; }
        public string MultipleStringsQuestion2 { get; set; }
        public bool MultipleStringsQuestion3State { get; set; }
        public string MultipleStringsQuestion3 { get; set; }
        public bool MultipleStringsQuestion4State { get; set; }
        public string MultipleStringsQuestion4 { get; set; }
    }
}
