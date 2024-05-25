for (int i = 0; i < 10; i++){
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--){
    Console.WriteLine(i);
}

for (int i = 0; i < 10; i++){
    if (i == 7){
        break;
    }
    Console.WriteLine(i);
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--){
    Console.WriteLine(names[i]);
}

string[] names1 = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++){
    if (names1[i] == "David"){
        names1[i] = "Sammy";
    }
}

foreach (var name in names1){
    Console.WriteLine(name);
}