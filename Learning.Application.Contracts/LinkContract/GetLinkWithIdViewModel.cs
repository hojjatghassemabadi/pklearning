namespace Learning.Application.Contracts.LinkContract
{
    public class GetLinkWithIdViewModel
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
    }
}
