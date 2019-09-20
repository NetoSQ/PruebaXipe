using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Prueba
{
    public partial class PruebaPage : ContentPage
    {

        List<Orders> orderList = new List<Orders>();
        List<Orders> orderList2 = new List<Orders>();
        List<DateTime> dateList = new List<DateTime>();
        List<DatesOrders> dateOrdersList = new List<DatesOrders>();
        string result = "{\"isSuccess\": true,\"message\": null,\"data\": {\"inspectorGuid\": \"d123be0d-6659-49ce-897a-08d70c790fd0\",\"fromDate\": \"2019-08-14T00:00:00\",\"toDate\": \"2019-08-26T00:00:00\",\"schedule\": [{\"workOrderNumber\": \"5171484503\",\"scheduleDay\": \"2019-08-14T16:48:47\",\"customerId\": \"200389\",\"customerName\": \"Metro Fire Equipment Inc.\",\"location\": \"63 S Hamilton Pl Gilbert, AZ 85233-5515 USA\",\"adressInfo\": {\"address\": \"63 S Hamilton Pl\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -111.87528,\"latitude\":33.62134},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"completed\",\"order\": 36},{\"workOrderNumber\": \"5171626304\",\"scheduleDay\": \"2019-08-16T11:44:19\",\"customerId\":\"202681\",\"customerName\": \"Black Fire Protection Inc.\",\"location\": \"1014 SW 19th St Fort Lauderdale, FL 33315 USA\",\"adressInfo\": {\"address\": \"16803 N Tatum Blvd Phoenix\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -111.97612,\"latitude\": 33.63939},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"pending\",\"order\": 94},{\"workOrderNumber\": \"5171529002\",\"scheduleDay\": \"2019-08-17T17:50:47\",\"customerId\": \"204830\",\"customerName\": \"LLC\",\"location\": \"Richmond, TX 77406 USA\",\"adressInfo\": {\"address\": \"15314 N Oracle Rd Tucson\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -110.946977,\"latitude\": 32.180557},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"requested\",\"order\": 18},{\"workOrderNumber\": \"5171627404\",\"scheduleDay\": \"2019-08-18T14:38:00\",\"customerId\": \"201756\",\"customerName\": \"Fire Defense Of Virginia\",\"location\": \"2400 Kerr Dr. Virginia Beach, VA 23454 USA\",\"adressInfo\": {\"address\": \"3636 E. Washington Phoenix\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -112.27481,\"latitude\": 33.71685},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"requested\",\"order\": 42},{\"workOrderNumber\": \"5158746101\",\"scheduleDay\": \"2019-08-20T00:26:06\",\"customerId\": \"204830\",\"customerName\": \"LLC\",\"location\": \"Richmond, TX 77406 USA\",\"adressInfo\": {\"address\": \"15314 N Oracle Rd Tucson\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -110.946977,\"latitude\": 32.180557},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"pending\",\"order\": 90},{\"workOrderNumber\": \"5170735101\",\"scheduleDay\": \"2019-08-24T18:36:12\",\"customerId\": \"202151\",\"customerName\": \"Stumps Fire Protection & Safety Equipment Co.\",\"location\": \"501 E Bigelow Ave Findlay, OH 45840-4250 USA\",\"adressInfo\": {\"address\": \"25650 N Lake Pleasant Pkwy Peoria\",\"city\": \"Phoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -110.95395,\"latitude\": 32.40277},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"pending\",\"order\": 65},{\"workOrderNumber\": \"5171638807\",\"scheduleDay\": \"2019-08-25T19:01:49\",\"customerId\": \"200827\",\"customerName\": \"Marmic Fire & Safety Co., Inc.\",\"location\": \"PO Box 1939 Lowell, AR 72745 USA\",\"adressInfo\": {\"address\": \"14854 N Frank Lloyd Wright Blvd Scottsdale\",\"city\": \"APhoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -112.42577,\"latitude\": 33.43968},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"completed\",\"order\": 21},{\"workOrderNumber\": \"5170703101\",\"scheduleDay\": \"2019-08-25T19:52:54\",\"customerId\": \"200827\",\"customerName\": \"Marmic Fire & Safety Co., Inc.\",\"location\": \"PO Box 1939 Lowell, AR 72745 USA\",\"adressInfo\": {\"address\": \"14854 N Frank Lloyd Wright Blvd Scottsdale\",\"city\": \"APhoenix\",\"zipCode\": \"85209\",\"state\": \"Arizona\",\"country\": \"United State of America\",\"longitude\": -112.42577,\"latitude\": 33.43968},\"jurisdiction\": \"AZ_Phoenix\",\"scopes\": [{\"systemType\": \"Fire Hydrant\",\"frecuency\": \"Year\"}],\"notifications\": [],\"instructions\": [],\"status\": \"pending\",\"order\": 89}]}}";

        public PruebaPage()
        {
            InitializeComponent();
            getOrders();
        }

        public async void getOrders()
        {
            
            
            var Items = JsonConvert.DeserializeObject<Resultado>(
                result,
                new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                }
            );


            var fecha1 = Items.data.fromDate;
            var fecha2 = Items.data.toDate;

            var x = Items.data.schedule;

            for (var day = fecha1; day.Date <= fecha2; day = day.AddDays(1))
            {
                
                foreach (var order in x)
                {
                    if(order.scheduleDay.Date == day.Date)
                    {
                        orderList.Add(order);
                    }
                }
                orderList2 = orderList;

                dateOrdersList.Add(new DatesOrders
                {
                    orderNum = orderList2.Count.ToString(),
                    date = day,
                    orders = orderList2
                }) ;

                orderList.Clear();

            }

            fechasLV.ItemsSource = dateOrdersList;

            //orderList.Add(1);
           // workOrdersLV.ItemsSource = orderList;
            //fechasLV.ItemsSource = dateList;

            fechasLV.ItemSelected += (sender, e) => {

                orderList.Clear();
                workOrdersLV.ItemsSource = null;
                int u = dateOrdersList.IndexOf((DatesOrders)e.SelectedItem);
                DatesOrders y = dateOrdersList[u];
                foreach (var order in x)
                {
                    if (order.scheduleDay.Date == y.date.Date)
                    {
                        orderList.Add(order);
                    }
                }
                lblFechaMain.Text = y.date.Date.ToString("dddd, dd MMMM");
                lblOrders.Text = y.orderNum + " WORK ORDERS";
                workOrdersLV.ItemsSource = orderList;

                e = null;

            };
        }
    }
}
