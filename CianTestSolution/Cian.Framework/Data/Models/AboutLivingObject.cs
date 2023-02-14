﻿using System.Collections.Generic;

namespace Cian.Framework.Data.Models
{
    public class AboutLivingObject
    {
        public string Address { get; set; }
        public string CadastralNumber { get; set; }
        public string RoomsForRentCount { get; set; }
        public string RoomsType { get; set; }
        public string RoomArea { get; set; }
        public string TotalArea { get; set; }
        public string Floor { get; set; }
        public string FloorCount { get; set; }
        public string TotalRoomCountInFlat { get; set; }
        public string Kitchen { get; set; }
        public string LoggiasCount { get; set; }
        public string BalconiesCount { get; set; }
        public string SeparatedWsCount { get; set; }
        public string CombinedWsCount { get; set; }
        public string Repair { get; set; }
        public string Pets { get; set; }
        public string Children { get; set; }
        public List<string> AdvancedOptions { get; set; }
        public string Description { get; set; }
    }

    public class AdvancedOptions
    {
        public static readonly string RoomsFurniture = "Мебель в комнатах";
        public static readonly string KitchenFurniture = "Мебель на кухне";
        public static readonly string WindowsToCourtyard = "Окна во двор";
        public static readonly string WindowsToStreet = "Окна на улицу";
        public static readonly string Balcony = "Балкон";
        public static readonly string Loggia = "Лоджия";
        public static readonly string Fridge = "Холодильник";
        public static readonly string Dishwasher = "Посудомоечная машина";
        public static readonly string WashingMachine = "Стиральная машина";
        public static readonly string TV = "Телевизор";
        public static readonly string Phone = "Телефон";
        public static readonly string Bath = "Ванна";
        public static readonly string Shower = "Душевая кабина";
        public static readonly string AirConditioner = "Кондиционер";
        public static readonly string Internet = "Интернет";
        public static readonly string SeparateWs = "Раздельный санузел";
        public static readonly string CombinedWs = "Совмещённый санузел";
    }
}