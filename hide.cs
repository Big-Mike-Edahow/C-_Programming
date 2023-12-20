// Hide Project

Console.Title = "Hide";

Man mike = new Man();
Hombre enrique = new Hombre();

mike.speak();
mike.speak("It's a beautiful evening");

enrique.speak("Hola...");
((Man)enrique).speak("Es una tarde hermosa");

Console.ReadKey();

public class Man {
    public void speak() {
        Console.Write("Hello: ");
    }
    public void speak(string message) {
        Console.WriteLine(message + "!\n");
    }
}

public class Hombre : Man {
    public new void speak(string message) {
        base.speak();
        Console.WriteLine(message);
    }
}

