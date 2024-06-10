///Three ways to declare arrays
//string[] names={"Youssef","Bahaa","Ahmed","Hossam"};

//string[] names=new string[4];

string[] names;
names=new string[4];

names[0]="Youssef";
names[1]="Bahaa";
names[2]="Ahmed";
names[3]="Hossam";

for(int i=0;i<4;i++){
    System.Console.WriteLine($"the name number[{i}] is {names[i]}.");
}