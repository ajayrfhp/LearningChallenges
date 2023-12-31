using DatasetChallenge;
using ExtensionMethods;

CSVReader csvReader = new CSVReader("C:\\Users\\ajviswan\\source\\repos\\LearningChallenges\\AdvancedDataset.csv", hasHeader: true, columns:[]);
List<UserModel> users = csvReader.Read<UserModel>();

users.Print();