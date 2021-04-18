namespace sample.Common.Commands
{
    public class CreateUser : ICommand
    {
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}