
using GenericChallenge;
using ExtensionMethods;
using Person;
using Address;

List<string> a =  new List<string> { "Ajay", "Prasadh", "V" };
List<string> b = new List<string>() { "Abirami", "Selvam", "S" };

List<string> c = GenericMixer.Mix(a, b);

c.Print();

DummyClass1 i = new DummyClass1 { Title = "Aj" };
DummyClass2 j = new DummyClass2 { Title = "asdads" };

var d = GenericMixer.SelectLongerObject(i, j);
Console.WriteLine(d.Title);