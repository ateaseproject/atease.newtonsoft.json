namespace AtEase.Newtonsoft.Json.Test
{
    public class Person
    {
        public Person(string name)
        {
            FirstName = name.Substring(0, name.IndexOf(' '));
            LastName = name.Substring(name.IndexOf(' ')+1, name.Length - name.IndexOf(' ')-1);

        }
        public string FirstName { get;}
        public string LastName { get; }

        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }

            return this.FirstName.Equals(item.FirstName) && this.LastName.Equals(item.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName+LastName).GetHashCode();
        }


    }
}