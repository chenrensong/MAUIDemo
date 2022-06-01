namespace MAUIDemo.Controls
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class IconIdAttribute : Attribute
    {
        public string Id { get; set; }

        public IconIdAttribute(string id)
        {
            Id = id;
        }
    }

}
