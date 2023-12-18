namespace Assignment_2;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string chosenOption = "";
            string memberNo = "";
            Material material1 = new Material("Fiction Book");
            Material material2 = new Material("Non - Fiction Book");
            Material material3 = new Material("Magazine");
            Material material4 = new Material("Newspaper");
            Material material5 = new Material("Archived Manuscript");
            List<Reservation> bookings = new List<Reservation>();

            //Hardcoded Member booking 1
            Reservation member1 = new Reservation();
            member1.memberNo = "S334567082";
            member1.memberType = "Scholar";
            member1.memberName = "Steve Soares";
            member1.memberEmail = "soaresstevee@gmail.com";
            member1.reservations.Add(material5);
            member1.reservations.Add(material1);
            member1.reservations.Add(material3);
            member1.reservations.Add(material2);
            bookings.Add(member1);

            //Hardcoded Member booking 2
            Reservation member2 = new Reservation();
            member2.memberNo = "B997456702";
            member2.memberType = "Basic";
            member2.memberName = "Jessica Rabbit";
            member2.memberEmail = "rabbitjess@gmail.com";
            member2.reservations.Add(material1);
            member2.reservations.Add(material2);
            member2.reservations.Add(material4);
            member2.reservations.Add(material1);
            bookings.Add(member2);

            //Hardcoded Member booking 3
            Reservation member3 = new Reservation();
            member3.memberNo = "E117853096";
            member3.memberType = "Elite";
            member3.memberName = "James Wisemen";
            member3.memberEmail = "wisemen22@gmail.com";
            member3.reservations.Add(material1);
            member3.reservations.Add(material2);
            member3.reservations.Add(material3);
            member3.reservations.Add(material4);
            bookings.Add(member3);

            //Menu loop
            do 
            { 
                Console.WriteLine("1. Make a Reservation");
                Console.WriteLine("2. List all Reservations");
                Console.WriteLine("3. Cancel a Reservations");
                Console.WriteLine("4. Exit");
                chosenOption = Console.ReadLine();
                //instantiate new memberbooking
                Reservation booking = new Reservation();
                //Modified code to where the membership type is determind based on the first letter of membership number i.e B12345678(Basic), E12345678(Elite)
                if(chosenOption == "1"){
                    Console.WriteLine("Enter Membership ID");
                    memberNo = Console.ReadLine();
                    //Membership number must be 10 digits
                    if(memberNo.Length == 10){
                        //Must start with B, E or S
                        if(memberNo!.StartsWith("B") || memberNo!.StartsWith("E") || memberNo!.StartsWith("S")){
                            //set member number
                            booking.memberNo = memberNo!;
                            //get and set member type from member number
                            booking.memberType = getMemberType(memberNo);
                            //set full name
                            Console.WriteLine("Enter Your Full Name");
                            booking.memberName = Console.ReadLine();
                            //set email
                            Console.WriteLine("Enter Your Email");
                            booking.memberEmail = Console.ReadLine();
                            string? chosenMaterial = "";
                            //check membership type and display available materials
                            if(memberNo!.StartsWith("B")){
                                do {
                                    Console.WriteLine("1. Fiction Book");
                                    Console.WriteLine("2. Non - Fiction Book");
                                    Console.WriteLine("3. Newspaper");
                                    Console.WriteLine("4. Exit");
                                    chosenMaterial = Console.ReadLine();
                                    //Check number of resevations not greater than 4.
                                    if(booking.reservations.Count < 4){
                                        if(chosenMaterial == "1"){
                                        booking.reservations.Add(material1);
                                        }
                                        else if(chosenMaterial == "2"){
                                            booking.reservations.Add(material2);
                                        }
                                        else if(chosenMaterial == "3"){
                                            booking.reservations.Add(material4);
                                        }
                                    }
                                    else {
                                        Console.WriteLine("You have reached the maximum reservation limit.");
                                        break;
                                    }
                                    
                                }while(chosenMaterial !="4");
                                bookings.Add(booking);
                            }
                            //Elite membership
                            else if(memberNo!.StartsWith("E")){
                                //Menu loop
                                do {
                                    Console.WriteLine("1. Fiction Book");
                                    Console.WriteLine("2. Non - Fiction Book");
                                    Console.WriteLine("3. Newspaper");
                                    Console.WriteLine("4. Magazine");
                                    Console.WriteLine("5. Exit");
                                    chosenMaterial = Console.ReadLine();
                                     //Check number of resevations not greater than 4.
                                    if(booking.reservations.Count < 4){
                                        if(chosenMaterial == "1"){
                                        booking.reservations.Add(material1);
                                        }
                                        else if(chosenMaterial == "2"){
                                            booking.reservations.Add(material2);
                                        }
                                        else if(chosenMaterial == "3"){
                                            booking.reservations.Add(material4);
                                        }
                                        else if(chosenMaterial == "4"){
                                            booking.reservations.Add(material3);
                                        }
                                    }
                                    else {
                                        Console.WriteLine("You have already reached the maximum reservation limit.");
                                        break;
                                    }
                                    
                                }while(chosenMaterial !="5");
                                bookings.Add(booking);
                            }
                            //Scholar membership
                            else if(memberNo!.StartsWith("S")){
                                do {
                                    Console.WriteLine("1. Fiction Book");
                                    Console.WriteLine("2. Non - Fiction Book");
                                    Console.WriteLine("3. Newspaper");
                                    Console.WriteLine("4. Magazine");
                                    Console.WriteLine("5. Archived Manuscript");
                                    Console.WriteLine("6. Exit");
                                    chosenMaterial = Console.ReadLine();
                                     //Check number of resevations not greater than 4.
                                    if(booking.reservations.Count < 4){
                                        if(chosenMaterial == "1"){
                                        booking.reservations.Add(material1);
                                        }
                                        else if(chosenMaterial == "2"){
                                            booking.reservations.Add(material2);
                                        }
                                        else if(chosenMaterial == "3"){
                                            booking.reservations.Add(material4);
                                        }
                                        else if(chosenMaterial == "4"){
                                            booking.reservations.Add(material3);
                                        }
                                        else if(chosenMaterial == "5"){
                                            booking.reservations.Add(material5);
                                        }
                                    }
                                    else {
                                        Console.WriteLine("Sorry! You have already reached the maximum reservation limit.");
                                        break;
                                    }
                                    
                                }
                                while(chosenMaterial !="6");
                                bookings.Add(booking);
                            }
                        }  
                    }
                    //Error message for wrong membership number
                    else {
                        Console.WriteLine("Membership Number must be 10 Digits and must start with B, E or S");
                    }
                }  
                //List all reservations
                else if (chosenOption == "2"){
                    listReservations(bookings);
                }
                //Cancel A Reservation
                else if (chosenOption == "3"){
                    string memberID = "";
                    //Get membership id
                    Console.WriteLine("Enter your Membership ID");
                    memberID = Console.ReadLine();

                    //Find corresponding member from list with entered membership ID
                    Reservation member =  bookings.Find(member => member.memberNo == memberID);
                    Console.WriteLine(member.memberName);

                    //if member found, display all reservations of corresponding member
                    if(member != null){
                            Console.WriteLine("Choose Reservation to Cancelle");
                            Console.WriteLine("============================");
                            for (int i = 0; i < member.reservations.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {member.reservations[i].materialType}");
                            }
                            int chosenRes = int.Parse(Console.ReadLine());
                            //Check which option/material chosen to cancel
                            if(chosenRes >= 1 && chosenRes <= member.reservations.Count){
                                member.reservations.RemoveAt(chosenRes-1);
                                Console.WriteLine("Reservation Cancelled");
                            }
                            //display error if member not found.
                            else
                            {
                                Console.WriteLine("Please enter a valid reservation number.");
                            }
                    }
                    else  {
                        Console.WriteLine("Member Not Found!");
                    }
                }

            } while (chosenOption != "4");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    //Get membership type based on memebership number
    public static string getMemberType(string? memberNo){
        //Get the membership number, check first character and return membership type.
        string memberType = "";
        if(memberNo!.StartsWith("B")){
            memberType = "Basic";
        }
        else if(memberNo!.StartsWith("E")){
             memberType = "Elite";
        }
        else if(memberNo!.StartsWith("S")){
             memberType = "Scholar";
        }
        Console.WriteLine(memberType);
        return memberType;
    }

    //List all reservations
    public static void listReservations(List<Reservation> _bookings){
        foreach(var res in _bookings){
           res.PrintReservation();
        }
    }
}
