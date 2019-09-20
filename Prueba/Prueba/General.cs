using System;
using System.Collections.Generic;

namespace Prueba
{
    public class General
    {
        public General()
        {
        }
    }

    public class Resultado
    {
        public bool isSuccess { get; set; }
        public string message { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public Guid inspectorGuid { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public List<Orders> schedule { get; set; }
    }

    public class Orders
    {
        public string workOrderNumber { get; set; }
        public DateTime scheduleDay { get; set; }
        public string customerId { get; set; }
        public string customerName { get; set; }
        public string location { get; set; }
        public Adress adressInfo { get; set; }
        public string jurisdiction { get; set; }
        public List<Scopes> scopes { get; set; }
        public List<int> Notifications { get; set; }
        public List<int> instructions { get; set; }
        public string status { get; set; }
        public int order { get; set; }            
    }

    public class Adress
    {
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public double longitude { get; set; }
        public double latitude { get; set; }
    }

    public class Scopes
    {
        public string systemType { get; set; }
        public string frecuency { get; set; }
    }

    public class DatesOrders
    {
        public string orderNum { get; set; }
        public DateTime date { get; set; }
        public List<Orders> orders { get; set; }
    }
}
