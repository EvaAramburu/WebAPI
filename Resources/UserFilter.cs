namespace Resources
{
    public class UserFilter
    { 
        public UserFilter()
        {
            IsActive = true; 
        }
    
        public int Id { get; set; }
        //public string Name { get; set; }

        //public DateTime AddedDate {get; set}
        public bool IsActive { get; set; }

    }
}