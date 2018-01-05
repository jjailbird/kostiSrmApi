using System;
using System.ComponentModel.DataAnnotations;

// https://docs.microsoft.com/ko-kr/aspnet/core/data/ef-mvc/complex-data-model

namespace kostiSrmApi.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public DateTime ReserveStart { get; set; }
        public DateTime ReserveEnd { get; set; }

        public string DescMessage { get; set; }
        public string DescImagePath { get; set; }

        public bool UseWelcome { get; set; }
        public bool UseDescImage { get; set; }

        public int ResourceItemId { get; set; }


    }
}
