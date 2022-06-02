using Railway.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway
{
    class Data
    {
        private static List<Railroad> RailwayStates { get; set; }
        private static int RailwayIndex { get; set; }
        public static Railroad FillData()
        {
            Data.RailwayStates = new List<Railroad>();

            Train train1 = new Train("Eagle", 250);
            Train train2 = new Train("Aurora", 150);
            Train train3 = new Train("Juno", 118);
            Train train4 = new Train("Electra", 192);

            List<string> days1 = new List<string>() { "Monday", "Wednesday", "Sunday" };
            List<string> days2 = new List<string>() { "Tuesday", "Thursday" };
            List<string> days3 = new List<string>() { "Friday", "Saturday", "Sunday" };
            List<string> days4 = new List<string>() { "Monday" };
            List<string> days5 = new List<string>() { "Monday", "Thursday" };
            List<string> days6 = new List<string>() { "Tuesday", "Friday", "Sunday" };
            List<string> days7 = new List<string>() { "Tuesday", "Wednesday", "Thursday", "Friday" };
            List<string> days8 = new List<string>() { "Saturday", "Sunday" };
            List<string> days9 = new List<string>() { "Wednesday" };
            List<string> days10 = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            DateTime time1 = new DateTime(2022, 6, 6, 8, 20, 0);
            DateTime time2 = new DateTime(2022, 6, 6, 10, 00, 0);
            DateTime time3 = new DateTime(2022, 6, 6, 11, 30, 0);
            DateTime time4 = new DateTime(2022, 6, 6, 12, 15, 0);
            DateTime time5 = new DateTime(2022, 6, 6, 15, 15, 0);
            DateTime time6 = new DateTime(2022, 6, 6, 16, 20, 0);
            DateTime time7 = new DateTime(2022, 6, 6, 17, 45, 0);
            DateTime time8 = new DateTime(2022, 6, 6, 18, 35, 0);
            DateTime time9 = new DateTime(2022, 6, 6, 19, 00, 0);
            DateTime time10 = new DateTime(2022, 6, 6, 19, 50, 0);
            DateTime time11 = new DateTime(2022, 6, 6, 20, 20, 0);
            DateTime time12 = new DateTime(2022, 6, 6, 21, 35, 0);
            DateTime time13 = new DateTime(2022, 6, 6, 22, 5, 0);
            DateTime time14 = new DateTime(2022, 6, 6, 22, 20, 0);

            Station subotica = new Station("Subotica", 19.667587, 46.100376);
            Station subotica1 = new Station("Subotica", 19.667587, 46.100376);
            Station zrenjanin = new Station("Zrenjanin", 20.38194, 45.38361);
            Station zrenjanin1 = new Station("Zrenjanin", 20.38194, 45.38361);
            Station noviSad = new Station("Novi Sad", 19.833549, 45.267136);
            Station noviSad1 = new Station("Novi Sad", 19.833549, 45.267136);
            Station noviSad2 = new Station("Novi Sad", 19.833549, 45.267136);
            Station staraPazova = new Station("Stara Pazova", 19.833549, 45.267136);
            Station staraPazova1 = new Station("Stara Pazova", 19.833549, 45.267136);
            Station beograd = new Station("Beograd Centar", 20.394058, 44.854897);
            Station beograd1 = new Station("Beograd Centar", 20.394058, 44.854897);
            Station beograd2 = new Station("Beograd Centar", 20.394058, 44.854897);
            Station beograd3 = new Station("Beograd Centar", 20.394058, 44.854897);
            Station kragujevac = new Station("Kragujevac", 20.91667, 44.01667);
            Station kragujevac1 = new Station("Kragujevac", 20.91667, 44.01667);
            Station smederevo = new Station("Smederevo", 20.93, 44.66278);
            Station jagodina = new Station("Jagodina", 21.26121, 43.97713);
            Station knjazevac = new Station("Knjaževac", 22.25701, 43.56634);
            Station knjazevac1 = new Station("Knjaževac", 22.25701, 43.56634);
            Station bor = new Station("Bor", 22.09591, 44.07488);
            Station valjevo = new Station("Valjevo", 19.89821, 44.27513);
            Station mladenovac = new Station("Mladenovac", 20.693852, 44.436436);
            Station nis = new Station("Niš", 21.90333, 43.32472);
            Station vranje = new Station("Vranje", 21.90028, 42.55139);
            Station vranje1 = new Station("Vranje", 21.90028, 42.55139);
            Station uzice = new Station("Užice", 19.84878, 43.85861);
            Station sabac = new Station("Šabac", 19.69, 44.74667);
            Station sabac1 = new Station("Šabac", 19.69, 44.74667);


            Path path1 = new Path(subotica, zrenjanin, 45, 230);
            Path path11 = new Path(zrenjanin, noviSad, 30, 170);
            Path path111 = new Path(noviSad, staraPazova, 20, 150);
            Path path1111 = new Path(staraPazova, beograd, 25, 210);
            subotica.PathToPreviousStation = null;
            subotica.PathToNextStation = path1;
            zrenjanin.PathToPreviousStation = path1;
            zrenjanin.PathToNextStation = path11;
            noviSad.PathToPreviousStation = path11;
            noviSad.PathToNextStation = path111;
            staraPazova.PathToPreviousStation = path111;
            staraPazova.PathToNextStation = path1111;
            beograd.PathToPreviousStation = path1111;
            beograd.PathToNextStation = null;


            Path path2 = new Path(beograd1, smederevo, 45, 220);
            Path path22 = new Path(smederevo, jagodina, 30, 190);
            Path path222 = new Path(jagodina, nis, 50, 235);
            Path path2222 = new Path(nis, vranje, 60, 400);
            beograd1.PathToPreviousStation = null;
            beograd1.PathToNextStation = path2;
            smederevo.PathToPreviousStation = path2;
            smederevo.PathToNextStation = path22;
            jagodina.PathToPreviousStation = path22;
            jagodina.PathToNextStation = path222;
            nis.PathToPreviousStation = path222;
            nis.PathToNextStation = path2222;
            vranje.PathToPreviousStation = path2222;
            vranje.PathToNextStation = null;


            Path path3 = new Path(bor, knjazevac, 80, 650);
            bor.PathToPreviousStation = null;
            bor.PathToNextStation = path3;
            knjazevac.PathToPreviousStation = path3;
            knjazevac.PathToNextStation = null;


            Path path4 = new Path(noviSad1, beograd2, 45, 200);
            Path path44 = new Path(beograd2, mladenovac, 50, 280);
            Path path444 = new Path(mladenovac, kragujevac, 60, 300);
            noviSad1.PathToPreviousStation = null;
            noviSad1.PathToNextStation = path4;
            beograd2.PathToPreviousStation = path4;
            beograd2.PathToNextStation = path44;
            mladenovac.PathToPreviousStation = path44;
            mladenovac.PathToNextStation = path444;
            kragujevac.PathToPreviousStation = path444;
            kragujevac.PathToNextStation = null;


            Path path5 = new Path(sabac, valjevo, 65, 450);
            Path path55 = new Path(valjevo, uzice, 60, 330);
            Path path555 = new Path(uzice, staraPazova1, 80, 620);
            sabac.PathToPreviousStation = null;
            sabac.PathToNextStation = path5;
            valjevo.PathToPreviousStation = path5;
            valjevo.PathToNextStation = path55;
            uzice.PathToPreviousStation = path55;
            uzice.PathToNextStation = path555;
            staraPazova1.PathToPreviousStation = path555;
            staraPazova1.PathToNextStation = null;


            Path path6 = new Path(kragujevac1, beograd3, 70, 600);
            Path path66 = new Path(beograd3, noviSad2, 45, 200);
            Path path666 = new Path(noviSad2, zrenjanin1, 30, 200);
            Path path6666 = new Path(zrenjanin1, subotica1, 30, 200);
            kragujevac1.PathToPreviousStation = null;
            kragujevac1.PathToNextStation = path6;
            beograd3.PathToPreviousStation = path6;
            beograd3.PathToNextStation = path66;
            noviSad2.PathToPreviousStation = path66;
            noviSad2.PathToNextStation = path666;
            zrenjanin1.PathToPreviousStation = path666;
            zrenjanin1.PathToNextStation = path6666;
            subotica1.PathToPreviousStation = path6666;
            subotica1.PathToNextStation = null;


            Path path7 = new Path(sabac1, vranje1, 95, 720);
            Path path77 = new Path(vranje1, knjazevac1, 60, 330);
            sabac1.PathToPreviousStation = null;
            sabac1.PathToNextStation = path7;
            vranje1.PathToPreviousStation = path7;
            vranje1.PathToNextStation = path77;
            knjazevac1.PathToPreviousStation = path77;
            knjazevac1.PathToNextStation = null;


            Ticket ticket1 = new Ticket(subotica, beograd, new DateTime(2022, 6, 12), 200);
            Ticket ticket11 = new Ticket(staraPazova, beograd, new DateTime(2022, 6, 12), 35);
            Ticket ticket111 = new Ticket(zrenjanin, noviSad, new DateTime(2022, 6, 15), 6);
            Ticket ticket1111 = new Ticket(subotica, beograd, new DateTime(2022, 6, 15), 10);
            Ticket ticket11111 = new Ticket(beograd, subotica, new DateTime(2022, 6, 12), 22);
            Ticket ticket111111 = new Ticket(noviSad, staraPazova, new DateTime(2022, 6, 12), 7);
            List<Ticket> tickets1 = new List<Ticket>() { ticket1, ticket11, ticket111, ticket1111, ticket11111, ticket111111 };
            List<Ticket> tickets11 = new List<Ticket>() { ticket1111, ticket11111, ticket111111 };

            Ticket ticket2 = new Ticket(beograd1, smederevo, new DateTime(2022, 6, 12), 16);
            Ticket ticket22 = new Ticket(beograd1, vranje, new DateTime(2022, 6, 12), 10);
            Ticket ticket222 = new Ticket(smederevo, jagodina, new DateTime(2022, 6, 12), 2);
            Ticket ticket2222 = new Ticket(nis, vranje, new DateTime(2022, 6, 12), 4);
            List<Ticket> tickets2 = new List<Ticket>() { ticket2, ticket22, ticket222, ticket2222 };
            List<Ticket> tickets22 = new List<Ticket>() { ticket2, ticket22 };
            List<Ticket> tickets222 = new List<Ticket>() { ticket222, ticket2222 };

            Ticket ticket3 = new Ticket(bor, knjazevac, new DateTime(2022, 6, 12), 10);
            Ticket ticket33 = new Ticket(bor, knjazevac, new DateTime(2022, 6, 12), 6);
            Ticket ticket333 = new Ticket(knjazevac, bor, new DateTime(2022, 6, 15), 8);
            Ticket ticket3333 = new Ticket(bor, knjazevac, new DateTime(2022, 6, 15), 12);
            Ticket ticket33333 = new Ticket(knjazevac, bor, new DateTime(2022, 6, 16), 5);
            Ticket ticket333333 = new Ticket(bor, knjazevac, new DateTime(2022, 6, 16), 17);
            List<Ticket> tickets3 = new List<Ticket>() { ticket3, ticket33, ticket333, ticket3333, ticket33333, ticket333333 };
            List<Ticket> tickets33 = new List<Ticket>() { ticket3, ticket33, ticket333 };
            List<Ticket> tickets333 = new List<Ticket>() { ticket3333, ticket33333, ticket333333 };
            List<Ticket> tickets3333 = new List<Ticket>() { ticket33, ticket333, ticket3333, ticket33333 };

            Ticket ticket4 = new Ticket(noviSad1, kragujevac, new DateTime(2022, 6, 12), 5);
            Ticket ticket44 = new Ticket(beograd2, kragujevac, new DateTime(2022, 6, 12), 15);
            Ticket ticket444 = new Ticket(beograd2, kragujevac, new DateTime(2022, 6, 12), 5);
            List<Ticket> tickets4 = new List<Ticket>() { ticket4, ticket44, ticket444 };

            Ticket ticket5 = new Ticket(sabac, staraPazova1, new DateTime(2022, 6, 12), 30);
            Ticket ticket55 = new Ticket(staraPazova1, sabac, new DateTime(2022, 6, 12), 30);
            List<Ticket> tickets5 = new List<Ticket>() { ticket5, ticket55 };
            List<Ticket> tickets55 = new List<Ticket>() { ticket55 };

            Timetable timetable1 = new Timetable(train1, days1, time1, time6, tickets1);
            Timetable timetable11 = new Timetable(train2, days2, time2, time7, tickets11);
            List<Timetable> timetables1 = new List<Timetable>() { timetable1, timetable11 };

            Timetable timetable2 = new Timetable(train2, days3, time3, time9, tickets2);
            Timetable timetable22 = new Timetable(train3, days4, time4, time10, tickets22);
            Timetable timetable222 = new Timetable(train4, days5, time5, time13, tickets222);
            List<Timetable> timetables2 = new List<Timetable>() { timetable2, timetable22, timetable222 };

            Timetable timetable3 = new Timetable(train1, days6, time6, time9, tickets3);
            Timetable timetable33 = new Timetable(train1, days7, time7, time10, tickets33);
            Timetable timetable333 = new Timetable(train4, days8, time8, time11, tickets333);
            Timetable timetable3333 = new Timetable(train4, days9, time9, time14, tickets3333);
            List<Timetable> timetables3 = new List<Timetable>() { timetable3, timetable33, timetable333, timetable3333 };

            Timetable timetable4 = new Timetable(train2, days10, time7, time14, tickets4);
            List<Timetable> timetables4 = new List<Timetable>() { timetable4 };

            Timetable timetable5 = new Timetable(train1, days9, time1, time11, tickets5);
            Timetable timetable55 = new Timetable(train3, days3, time2, time12, tickets5);
            Timetable timetable555 = new Timetable(train3, days2, time3, time13, tickets55);
            List<Timetable> timetables5 = new List<Timetable>() { timetable5, timetable55, timetable555 };

            Timetable timetable6 = new Timetable(train2, days1, time3, time7, new List<Ticket>());
            Timetable timetable66 = new Timetable(train4, days4, time6, time14, new List<Ticket>());
            List<Timetable> timetables6 = new List<Timetable>() { timetable6, timetable66 };

            Timetable timetable7 = new Timetable(train2, days6, time2, time5, new List<Ticket>());
            List<Timetable> timetables7 = new List<Timetable>() { timetable7 };

            Trainline trainline1 = new Trainline(subotica, beograd, timetables1);
            timetable1.Trainline = trainline1;
            timetable11.Trainline = trainline1;

            Trainline trainline2 = new Trainline(beograd1, vranje, timetables2);
            timetable2.Trainline = trainline2;
            timetable22.Trainline = trainline2;
            timetable222.Trainline = trainline2;

            Trainline trainline3 = new Trainline(bor, knjazevac, timetables3);
            timetable3.Trainline = trainline3;
            timetable33.Trainline = trainline3;
            timetable333.Trainline = trainline3;
            timetable3333.Trainline = trainline3;

            Trainline trainline4 = new Trainline(noviSad1, kragujevac, timetables4);
            timetable4.Trainline = trainline4;

            Trainline trainline5 = new Trainline(sabac, staraPazova1, timetables5);
            timetable5.Trainline = trainline5;
            timetable55.Trainline = trainline5;
            timetable555.Trainline = trainline5;

            Trainline trainline6 = new Trainline(kragujevac1, subotica1, timetables6);
            timetable6.Trainline = trainline6;
            timetable66.Trainline = trainline6;

            Trainline trainline7 = new Trainline(sabac1, knjazevac1, timetables7);
            timetable7.Trainline = trainline7;

            List<Trainline> trainlines = new List<Trainline>() { trainline1, trainline2, trainline3, trainline4, trainline5, trainline6, trainline7 };

            Railroad railway = new Railroad(trainlines);

            Data.AddRailway(railway);
            Data.SetRailwayIndex(0);
            return railway;

        }

        private static void AddRailway(Railroad railway)
        {
            Data.RailwayStates.Add(railway);
        }

        private static void SetRailwayIndex(int index)
        {
            Data.RailwayIndex = index;
        }

        public static List<string> GetStationNames()
        {
            List<string> stationNames = new List<string>();
            Railroad railway = Data.RailwayStates[Data.RailwayIndex];
            foreach (Trainline trainline in railway.TrainLines)
            {
                foreach (string stationName in trainline.GetStationNames())
                {
                    if (!stationNames.Contains(stationName))
                    {
                        stationNames.Add(stationName);
                    }
                }
            }
            return stationNames;
        }

        public static List<QuickReservation> GetQuickReservations(string startStation, string endStation, DateTime travelDate, int numOfTickets)
        {
            List<QuickReservation> quickReservations = null;
            Railroad railway = Data.RailwayStates[Data.RailwayIndex];
            foreach (Trainline trainline in railway.TrainLines)
            {
                if (trainline.ContainsStations(startStation, endStation))
                {
                    if (quickReservations == null)
                        quickReservations = new List<QuickReservation>();
                    foreach (Timetable timetable in trainline.Timetables)
                    {
                        if (timetable.ContainsDay(travelDate) && timetable.HaveTicketsAvailable(startStation, endStation, travelDate, numOfTickets))
                        {
                            int price = trainline.CalculatePrice(startStation, endStation);
                            int duration = trainline.CalculateDuration(startStation, endStation);
                            DateTime departure = trainline.CalculateDateAndTime(timetable, travelDate, startStation, endStation);
                            DateTime arrival = departure.AddMinutes(duration);
                            List<string> allStations = trainline.getStationInbetween(startStation, endStation);
                            quickReservations.Add(new QuickReservation(startStation, endStation, allStations, trainline, timetable, departure, arrival, price, duration));
                        }
                    }
                }
            }
            return quickReservations;
        }
    }
}
