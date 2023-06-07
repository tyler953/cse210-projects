namespace Learning04
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

        public Assignment(string studentName, string topic)
        {
            this._studentName = studentName;
            this._topic = topic;
        }

        public string GetStudentName()
        {
            return this._studentName;
        }

        public string GetTopic()
        {
            return this._topic;
        }

        public string GetSummary()
        {
            return $"{this._studentName} - {this._topic}";
        }
    }
}