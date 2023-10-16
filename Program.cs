using lab4._2;

class Program
{
    static void Main()
    {
        Network network = new Network();

        Server server1 = new Server("192.168.1.1", 1000, "Windows Server", 50);
        Server server2 = new Server("192.168.1.2", 1500, "Linux", 30);
        Workstation workstation1 = new Workstation("192.168.1.10", 500, "Windows 11", "UserQwerty");
        Workstation workstation2 = new Workstation("192.168.1.11", 600, "Windows 10", "Fraen");
        Router router1 = new Router("192.168.1.100", 200, "Custom Router");
        Router router2 = new Router("192.167.1.000", 100, "Custom Router");

        network.AddComputer(server1);
        network.AddComputer(server2);
        network.AddComputer(workstation1);
        network.AddComputer(workstation2);
        network.AddComputer(router1);
        network.AddComputer(router2);

        network.SimulateNetwork();

        Console.ReadLine();
    }
}