namespace jokenpo_api.Models
{
    public class JokenpoResult
    {
        public string Message { get; set; }
        public JokenpoModel Player { get; set; }
        public JokenpoModel Game { get; set; }
        
        
    }
}