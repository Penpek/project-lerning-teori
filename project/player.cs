// using System;

// namespace project;

// class player : text {

//     private string? magicPower;
//     public string? MagicPower{
//         get => magicPower;
//         set{
//             if(value == "heal")
//             this.magicPower = value;
//             else
//             System.Console.WriteLine("Tacogo net");
//         }
//     }

//     protected override int Health {get; set;}

//     public player(string name, PersonType type, int age, Dictionary<string, bool>? places, string MP) : base(name, type, age, places) {
//         this.MagicPower = MP;
//     }

//     public player() { }

//         public override void Action()
//     {
//         System.Console.WriteLine("Мы ходим");
//     }

//          public override void GetInfo() {
//             base.GetInfo();
//             System.Console.WriteLine($"Magic Power: {MagicPower}");
//         }
// }
