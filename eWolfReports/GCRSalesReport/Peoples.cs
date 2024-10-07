namespace GCRSalesReport
{
    public class Peoples
        {
            public double Days { get; set; }
            public string Name { get; set; }
            public double Rudds { get; set; }
            public double SetDays { get; set; }
            public double Tickets { get; set; }

            public double Totals
            {
                get
                {
                    double count = 0;
                    count += Days + Rudds + SetDays + Tickets + Trains + WH;
                    return count;
                }
            }

            public double Trains { get; set; }
            public double WH { get; set; }
        }
    
}