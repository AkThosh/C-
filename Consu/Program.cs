

internal class Program
{
    private static void Main(string[] args)
    {
        var arrUsers = new Users[]
{
    new Users("Tomas", "aka12", 2878),
    new Users("Ferb", "sads", 290)
};

        Start:
        Console.WriteLine("");
        var input = Console.ReadLine();


        bool successfull = false;

        while (!successfull)
        {
            Console.WriteLine("User Login");
            var NameL = Console.ReadLine();
            Console.WriteLine("Password");
            var PassL = Console.ReadLine();


            foreach (Users user in arrUsers)
            {
                if (NameL == user.NameL && PassL == user.PassL)
                {
                    Console.WriteLine("You have successfully logged in !!!");
                        Console.ReadLine();
                        successfull = true;
                        break;
                }
                
            }
                if (!successfull)
                {
                    Console.WriteLine("Your username or password is incorect, try again !!!");
                }
                else if (input == "2")
            {

                Console.WriteLine("Enter your username:");
                var username = Console.ReadLine();

                Console.WriteLine("Enter your password:");
                var password = Console.ReadLine();

                Console.WriteLine("Enter your id:");
                int id = int.Parse(Console.ReadLine());


                Array.Resize(ref arrUsers, arrUsers.Length + 1);
                arrUsers[arrUsers.Length - 1] = new Users(NameL, PassL, id);
                successfull = true;
                goto Start;

            }
            else
            {
                Console.WriteLine("Try again !!!");
                break;


            }

        }
    }
}

public class Users 
{
    public string NameL;
    public string PassL;
    private int id;

    public Users(string NameL, string PassL, int id)
    {
        this.NameL = NameL;
        this.PassL = PassL;
        this.id = id;

    }

}
