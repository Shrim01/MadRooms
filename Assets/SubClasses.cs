namespace SubClasses{
    public class LinkedList
    {
        public string Text {get;set;}
        public LinkedList NextElement;
        public Person person;
        public LinkedList(string text, LinkedList nextElement)
        {
            Text = text;
            NextElement = nextElement;
        }

        public LinkedList(string text, LinkedList nextElement, Person person)
        {
            Text = text;
            NextElement = nextElement;
            this.person = person;
        }

    }

    public enum Person
    {
        Man,
        Woman,
        Mermaid
    }
}