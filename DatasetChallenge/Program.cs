using DatasetChallenge;
using ExtensionMethods;

CSVParser CSVParser = new CSVParser("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\AdvancedDataset.csv", hasHeader: true, columns:[]);
List<UserModel> users = CSVParser.Read<UserModel>();

users.Print();
users.Add(new UserModel { FirstName = "Mr", LastName="Beau", Age=5, IsAlive=true });
users.Print();
CSVParser.Write(users);