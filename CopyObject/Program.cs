using Newtonsoft.Json;
using Person;
using System.Text.Json.Serialization;

PersonModel person1 = new PersonModel("Ajay", "Prasadh");
PersonModel person2 = null;
PersonModel person3 = null;

person2 = person1.Clone();
person2.DisplayObject();

string streamOfPerson = JsonConvert.SerializeObject(person1);
person3 = JsonConvert.DeserializeObject<PersonModel>(streamOfPerson);
person3.DisplayObject();

PersonModel person4 = new PersonModel(person1);
person4.DisplayObject();





