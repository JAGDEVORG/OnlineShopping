namespace Api.Users.Models
{
    public class ResponseModel
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string Content { get; set; }
    }
}
