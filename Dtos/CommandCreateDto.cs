namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

        //We remove data which we don't want to expose to the client
        //public string Platform { get; set; }
    }
}