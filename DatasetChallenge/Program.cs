using DatasetChallenge;
using ExtensionMethods;

CSVReader csvReader = new CSVReader("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\AdvancedDataset.csv", hasHeader: true, columns:[]);
List<UserModel> users = csvReader.Read<UserModel>();

users.Print();
users.Add(new UserModel { FirstName = "Mr", LastName="Beau", Age=5, IsAlive=true });
users.Print();
csvReader.Write(users);