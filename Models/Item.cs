namespace Models
{
    public abstract class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public virtual string StringToDisplay()
        {
            return "This is an item: " + Title;
        }
    }
}
