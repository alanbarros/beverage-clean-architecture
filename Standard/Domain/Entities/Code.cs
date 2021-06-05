namespace Domain.Entities
{
    public abstract class Code
    {
        public int Delayed { get; set; }
    }

    public class FreshCode : Code 
    {

    }

    public class HotCode : Code 
    {
        
    }

    public class SweetCode : Code 
    {
        
    }
    
    public class DeadCode : Code 
    {
        
    }
}