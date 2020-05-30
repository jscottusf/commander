namespace Commander.Dtos
{
    public class CommandReadDto
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }

        //We remove data which we don't want to expose to the client
        //public string Platform { get; set; }
    }
}