using System;

namespace project;

static class users {

    public static int count;

    public static void GetCount() => Console.WriteLine($"Количестко: {count}");

    static users() {
        System.Console.WriteLine("user created");
    }

}
