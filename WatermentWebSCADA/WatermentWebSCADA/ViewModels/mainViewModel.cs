﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WatermentWebSCADA.Models;
using WatermentWebSCADA.ViewModels;
using System.Data.Entity;

namespace WatermentWebSCADA.ViewModels
{
    public class MainViewModel
    {
       //public FacilityViewModel facilitiess { get; set; }
       public int ID { get; set; }
    

      

    public IEnumerable<facilities> Facilites { get; set; }
    public IEnumerable<alarms> Alarmer { get; set; }
        public IEnumerable<continents> Kontinenter { get; set; }
        public IEnumerable<countries> Countries { get; set; }
        public IEnumerable<equipments> Utstyr { get; set; }
        public IEnumerable<locations> Lokasjoner { get; set; }
        public IEnumerable<maintenance> Vedlikehold { get; set; }
        public IEnumerable<Role> Roller { get; set; }
        public IEnumerable<sessions> Sesjoner { get; set; }
        public IEnumerable<User> Brukere { get; set; }
        public List<countries_with_facilites_view>  countries { get; set; }
        public Client_Conection conection { get; set; }

        public List<equipments> Equipment { get; set; }

        public List<measurements> Verdier { get; set; }
        public List<measurements> Bar { get; set; }
        public List<alarms> AlarmList { get; set; }

  



    }

    public class FacilitesAlarmModel
    {
        public string Name { get; set; }
    }

}

