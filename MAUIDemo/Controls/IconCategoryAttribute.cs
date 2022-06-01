namespace MAUIDemo.Controls
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
    public class IconCategoryAttribute : Attribute
    {
        public string Category { get; set; }

        public IconCategoryAttribute(string category)
        {
            Category = category;
        }
    }

}
