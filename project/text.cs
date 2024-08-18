// using System.Collections;

// namespace project;

// enum PersonType {Player, Enemy}

//     abstract class text {

//         //private readonly int score;

//         protected string? name;
//         protected PersonType type;
//         protected int age;
//         protected Dictionary<string, bool>? places = new Dictionary<string, bool>();

//         public int Age
//         {
//             get => age;
//             set{
//                 if (value > 0 && value < 100)
//                 age = value;
//                 else
//                 System.Console.WriteLine("Возраст должен быть больше 0");
//             }
//         }

//         protected abstract int Health { get; set; }

//         public text(string _name, PersonType _type, int _age, Dictionary<string, bool>? _places) {

//             System.Console.WriteLine("User is created");
//             SetData(_name, _type, _age, _places);
//             users.count++;
//         }

//         public text(string name, PersonType type, int age)
//         {
//             System.Console.WriteLine("Person is created");
//             this.name = name;
//             this.type = type;
//             this.Age = age;
//             users.count++;
//         }

//         public text() { }

//         public abstract void Action();

//         public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places = null) {
//             this.name = name;
//             this.type = type;
//             this.Age = age;
//             this.places = places;
//             users.count++;
//         }



//         public string? GetName() => this.name;
//         public string GetPersonType() {
//             switch(this.type) {
//                 case PersonType.Player: return "Player";
//                 case PersonType.Enemy: return "Enemy";
//                 default: return "Takogo net =)";
//             }
//         }

//         public virtual void GetInfo() {
//             System.Console.WriteLine($"Player: {this.name}. Type: {GetPersonType()}. Age: {Age}0");
//             if(places == null || places.Count == 0)
//             return;

//             foreach(var el in places.Keys) {
//                 System.Console.WriteLine(el);
//             }
//         }
//     }
