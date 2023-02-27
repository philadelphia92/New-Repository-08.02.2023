// 88. Заменить все вхождения подстроки w в строке st на строку v. 

string str = "The class teacher asks students to name an animal that begins with an “E”. One boy says, “Elephant.”"
            +"Then the teacher asks for an animal that begins with a “T”. The same boy says, “Two elephants.”"
            +"The teacher sends the boy out of the class for bad behavior. After that she asks for an animal beginning with “M”."
            +"The boy shouts from the other side of the wall: “Maybe an elephant!”";
System.Console.WriteLine(str);
System.Console.WriteLine();
string s1 = "w";
string s2 = "v";
str = str.Replace(s1,s2);
System.Console.WriteLine(str);