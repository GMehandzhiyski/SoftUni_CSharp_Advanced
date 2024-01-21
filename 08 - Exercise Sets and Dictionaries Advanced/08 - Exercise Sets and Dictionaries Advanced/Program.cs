using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Linq;
namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> trainings = new();

            SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons = new SortedDictionary<string, Dictionary<string, Dictionary<string, int>>>();
            //Name             //Course     // Password   //Score


            //int score = persons.Where(person => person.Key == "Petko").Select(persons.Values.Where(course => course.Keys.Select(courseName => courseName == "C#").Where(password => password));\\
            string name = "Petko";
            string cource = "C#";

            string password = "23456";
            string password1 = "33456";
            string password2 = "1@#$%6";

            int score = 50;
            persons.Add(name, new Dictionary<string, Dictionary<string, int>>());
            persons[name].Add(cource, new Dictionary<string, int>());
            persons[name][cource].Add(password, score);
            persons[name][cource].Add(password1, score);
            persons[name][cource].Add(password2, score);


            var passwordsAndScoreDictonary = persons[name][cource];
            //.Where(c => c.Key == cource).First()
            //.Value;

            foreach (var kvp in passwordsAndScoreDictonary.OrderBy(k => k.Key))
            {
                Console.WriteLine(kvp.Key);
            }




            //SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons
            //Name              //Course       // Password  //Score

            //SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons
            //Това
            string user = persons.Where(person => person.Key == name).Select(p => p.Key).First();


            //SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons
            //Това
            string course = persons.Where(person => person.Key == name)
                           .Select(person => person.Value
                                                   .Where(course => course.Key == cource)
                                                   .Select(course => course.Key).First()).First();

            //SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons
            //Това
            string pass = persons.Where(person => person.Key == name)
                                 .Select(person => person.Value
                                                   .Where(course => course.Key == cource)
                                                   .Select(course => course.Value
                                                                            .Where(currPass => currPass.Key == password)
                                                                            .Select(currPass => currPass.Key).First()).First()).First();

            //SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons
            //Това
            int points = persons.Where(person => person.Key == name)
                                 .Select(person => person.Value
                                                   .Where(course => course.Key == cource)
                                                   .Select(course => course.Value
                                                                            .Where(currPass => currPass.Key == password)
                                                                            .Select(currPass => currPass.Value).First()).First()).First();


            //Начално dictonary (примерно - името не е валидно)
            SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> exampleStartDictonary = new();

            //Взимане на име
            var personName = persons.Keys.Where(key => key == name).First();

            //Вземане курсoвете на човек
            Dictionary<string, Dictionary<string, int>> DictonaryOfCurrentPersonCourses = persons[personName];
            string courseName = DictonaryOfCurrentPersonCourses.Keys.First();

            //Взимане на първата парола
            Dictionary<string, int> dictonaryOfCurrentPasswordsOfCurrentCourse = DictonaryOfCurrentPersonCourses.Values.First();

            string currentPassword = dictonaryOfCurrentPasswordsOfCurrentCourse.Keys.First();

            int currentScore = dictonaryOfCurrentPasswordsOfCurrentCourse.Values.First();

            Console.WriteLine(courseName);





            ////Тук сме взели самият човек                //Tук взимаме курса 
            //Console.WriteLine(points);


            //string arguments = string.Empty;
            //while ((arguments = Console.ReadLine()) != "end of contests")
            //{
            //    string[] token = arguments
            //        .Split(":", StringSplitOptions.RemoveEmptyEntries)
            //        .ToArray();

            //    string contest = token[0];
            //    string password = token[1];

            //    trainings.Add(contest, password);
            //}

            //while ((arguments = Console.ReadLine()) != "end of submissions")
            //{
            //    string[] token = arguments
            //       .Split("=>", StringSplitOptions.RemoveEmptyEntries)
            //       .ToArray();

            //    string name = token[2];
            //    string cource = token[0];
            //    string password = token[1];
            //    int score = int.Parse(token[3]);

            //    bool isCourceCorrect = CheckCource(trainings, cource);
            //    bool isPasswordCorrect = CheckPassword(trainings, password);
            //    //bool isCourceAndUserIsInclude = CkeckCourceAndUser(persons, name, cource);
            //    bool isNameIsInclude = CkeckUser(persons, name);
            //    bool isCourceIsInclude = CkeckCource(persons, password);


            //    if (isCourceCorrect
            //        && isPasswordCorrect)
            //    {
            //        if (false)
            //        {

            //        }
            //        else
            //        {
            //            persons.Add(name, new Dictionary<string, Dictionary<string, int>>());
            //            persons[name].Add(cource, new Dictionary<string, int>());
            //            persons[name][cource].Add(password, score);
            //        }

            //    }
            //    else
            //    {
            //        continue;
            //    }



            //}

            //bool CkeckCource(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string password)
            //{
            //    string matchingEntries = persons
            //             .Where(n => n.Value.Any(c => c.Value.ContainsKey(password)))
            //             .ToString();

            //    return true;
            //}

            //bool CkeckUser(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string name)
            //{
            //    return
            //    persons.ContainsKey(name);
            //}

            //bool CheckPassword(Dictionary<string, string> trainings, string password)
            //{
            //    return
            //        trainings.ContainsValue(password);
            //}
            //bool CkeckCourceAndUser(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> persons, string name, string cource)
            //{
            //    //var currPassword = trainings.Where(p => p.Key == name)
            //    //                       .Select(p => p.Value)
            //    //                       .Where(d => d.ContainsKey(cource))
            //    //                       .Select(d => d[cource]);
            //    //return false;
            //    return true;
            //}

            //bool CheckPassword(SortedDictionary<string, Dictionary<string, Dictionary<string, int>>> trainings, string name, string cource, string password)
            //{
            //    //foreach (var name in persons)
            //    //{
            //    //    foreach (var cource in name.Value)
            //    //    {
            //    //        foreach (var pass in cource.Key)
            //    //        {
            //    //            if (pass == password)///////////deibbbaaaaaa
            //    //            {
            //    //                return true;
            //    //            }
            //    //        }
            //    //    }
            //    //}
            //    var currPassword = trainings.Where(p => p.Key == name)
            //                           .Select(p => p.Value)
            //                           .Where(d => d.ContainsKey(cource))
            //                           .Select(d => d[cource])
            //                           .Where(td => td.ContainsKey(password))
            //                           .Select(td => td[password]);
            //    return false;
            //}

            bool CheckCource(Dictionary<string, string> trainings, string cource)
            {
                return
                     trainings.ContainsKey(cource);
            }
        }
    }
}
