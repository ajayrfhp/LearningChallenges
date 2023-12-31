// See https://aka.ms/new-console-template for more information
using Person;

Console.WriteLine("Hello, World!");
List<PersonModel> people = new List<PersonModel>()
{
    new PersonModel("Ajay", "Prasadh"),
    new PersonModel("Abirami", "Selvam"),
    new PersonModel("Mr", "Beau")
};
foreach (PersonModel person in people)
{
    person.DisplayObject();
}

PersonModel newPerson = new PersonModel();
newPerson.Fill().Print();