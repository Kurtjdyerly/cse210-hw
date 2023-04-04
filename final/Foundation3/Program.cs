using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("Quantum Mechanics and you", "This lecture by professor Ross E. Forp will underatke to introduce the very implications that quantum mechanics has on everyday life and how they can be utilized to increase quality of life", "Professor Ross E. Forp", 100);
        Reception reception = new Reception("Jack and Jills Wedding Reception", "Food will be served at 5:00 and we require an RSVP with choice of Vegan, Fish, or Steak inculded in the email and if you have a plus one.", "Fell_Down_a_Hill@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Spring mixer","Their will be BBQ games and company at the lake please bring a side.","Sunny with a high of 75F and a low of 45F");

        Address address1 = new Address();
        address1.SetAddress("722 daisy ln");
        address1.SetCity("Pinon hills");
        address1.SetCountry("USA");
        address1.SetState("CA");
        Address address2 = new Address();
        address2.SetAddress("156 W 4th S");
        address2.SetCity("Rexburg");
        address2.SetCountry("USA");
        address2.SetState("CA");
        Address address3 = new Address();
        address3.SetAddress("1234 Rockforth pl");
        address3.SetCity("Fremont");
        address3.SetCountry("CANADA");
        address3.SetState("Calgary");

        lecture.SetAddress(address1);
        reception.SetAddress(address2);
        outdoorGathering.SetAddress(address3);

        lecture.SetDateTime(2023, 2, 28, 10, 30, 00);
        outdoorGathering.SetDateTime(2023, 4, 20, 11, 30, 00);
        reception.SetDateTime(2023, 6, 4, 4, 00, 00);

        lecture.ShortDescription();
        lecture.FullDetails();
        lecture.StandardDetails();

        reception.ShortDescription();
        reception.FullDetails();
        reception.StandardDetails();

        outdoorGathering.ShortDescription();
        outdoorGathering.FullDetails();
        outdoorGathering.StandardDetails();
    }
}